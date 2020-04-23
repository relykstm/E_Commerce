using System;
using Microsoft.AspNetCore.Mvc;
using E_Commerce.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        
        [HttpGet("")]
        
        public ViewResult Index()
        {

            return View();
        }
        [HttpPost("register")]
        public IActionResult RegisterUser(RegisterUser regFromForm)
        {

            if(ModelState.IsValid)
            {
                PasswordHasher<RegisterUser> Hasher = new PasswordHasher<RegisterUser>();
                regFromForm.Password = Hasher.HashPassword(regFromForm, regFromForm.Password);

                if(dbContext.Users.Any(u => u.Email == regFromForm.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                else{
                    dbContext.Add(regFromForm);
                    dbContext.SaveChanges();
                    HttpContext.Session.SetObjectAsJson("LoggedInUser", regFromForm);
                    return RedirectToAction("Main");
                }
            }

            return View("Index");

        }
        [HttpPost("login")]
        public IActionResult LoginUser(LoginUser LoginFromForm)
        {
           if(ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == LoginFromForm.LoginEmail);
                // If no user exists with provided email
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "Invalid Email or Password");
                    return View("Index");
                }
                
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();
                
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(LoginFromForm, userInDb.Password, LoginFromForm.LoginPassword);
                
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email or Password");
                    return View("Index");
                } 
                else
                {
                    HttpContext.Session.SetObjectAsJson("LoggedInUser", userInDb);
                    return RedirectToAction("Main");
                }
                
            }

            return View("Index");
        }


        [HttpGet("logout")]

        public ViewResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpGet("main")]

        public IActionResult Main()
        {
            RegisterUser fromLogin = HttpContext.Session.GetObjectFromJson<RegisterUser>("LoggedInUser");
            if(fromLogin == null)
            {
                return RedirectToAction("Index");
            }
            MainWrapper MainWrapper = new MainWrapper();
            MainWrapper.RegisterUser = fromLogin;
            
            MainWrapper.ThreeCustomers = dbContext.Customers
                .Take(3)
                .ToList();
            MainWrapper.ThreeOrders = dbContext.Orders
                .Include(o=>o.Product)
                .Include(o=>o.Customer)
                .Take(3)
                .ToList();
            MainWrapper.ThreeProducts = dbContext.Products
                .Take(5)
                .ToList();

            return View("Main", MainWrapper);
        }
        [HttpGet("products")]

        public IActionResult Products()
        {
            RegisterUser fromLogin = HttpContext.Session.GetObjectFromJson<RegisterUser>("LoggedInUser");
            if(fromLogin == null)
            {
                return RedirectToAction("Index");
            }

            ProductWrapper ProductWrapper = new ProductWrapper();
            ProductWrapper.AllProducts = dbContext.Products.ToList();
            return View("Products", ProductWrapper);
        }
        [HttpGet("orders")]

        public IActionResult Orders()
        {
            RegisterUser fromLogin = HttpContext.Session.GetObjectFromJson<RegisterUser>("LoggedInUser");
            if(fromLogin == null)
            {
                return RedirectToAction("Index");
            }
            OrderWrapper OrderWrapper = new OrderWrapper();
            OrderWrapper.AllCustomers = dbContext.Customers.ToList();
            OrderWrapper.AllProducts = dbContext.Products.ToList();
            OrderWrapper.AllOrders = dbContext.Orders
                .Include(o => o.Product)
                .Include(o => o.Customer)
                .ToList();

            return View("Orders", OrderWrapper);
        }
        [HttpPost("addorder")]
        public IActionResult AddOrder(OrderWrapper fromForm){
            if(ModelState.IsValid)
            {
                Product Product = dbContext.Products
                    .FirstOrDefault(p => p.ProductId ==fromForm.Order.ProductId);
                Product.QuantityInStore = (Product.QuantityInStore - fromForm.Order.OrderQuantity);
                dbContext.Update(Product);
                dbContext.Entry(Product).Property("CreatedAt").IsModified = false;
                dbContext.SaveChanges();
                dbContext.Add(fromForm.Order);
                dbContext.SaveChanges();
                return RedirectToAction("Orders");
            }
            else 
            {
                OrderWrapper OrderWrapper = new OrderWrapper();
                OrderWrapper.AllCustomers = dbContext.Customers.ToList();
                OrderWrapper.AllProducts = dbContext.Products.ToList();
                OrderWrapper.AllOrders = dbContext.Orders
                    .Include(o => o.Product)
                    .Include(o => o.Customer)
                    .ToList();

                return View("Orders", OrderWrapper);
            }
        }


        [HttpGet("customers")]
        public IActionResult Customers()
        {
            RegisterUser fromLogin = HttpContext.Session.GetObjectFromJson<RegisterUser>("LoggedInUser");
            if(fromLogin == null)
            {
                return RedirectToAction("Index");
            }

            CustomerWrapper CustomerWrapper = new CustomerWrapper();
            CustomerWrapper.AllCustomers = dbContext.Customers.ToList();

            return View("Customers", CustomerWrapper);
        }
        [HttpPost("addcustomer")]
        public IActionResult AddCustomer(CustomerWrapper fromForm){
            if(ModelState.IsValid)
            {
                dbContext.Add(fromForm.Customer);
                dbContext.SaveChanges();
                return RedirectToAction("Customers");
            }
            else 
            {
                CustomerWrapper CustomerWrapper = new CustomerWrapper();
                CustomerWrapper.AllCustomers = dbContext.Customers.ToList();
                return View("Customers", CustomerWrapper);
            }
        }

        [HttpPost("addproduct")]
        public IActionResult AddProduct(ProductWrapper fromForm){
            if(ModelState.IsValid)
            {
                dbContext.Add(fromForm.Product);
                dbContext.SaveChanges();
                return RedirectToAction("Products");
            }
            else 
            {
                ProductWrapper ProductWrapper = new ProductWrapper();
                ProductWrapper.AllProducts = dbContext.Products.ToList();
                return View("Products", ProductWrapper);
            }
        }
    }
    public static class SessionExtensions
    {
        // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This helper function simply serializes theobject to JSON and stores it as a string in session
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        
        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upon retrieval the object is deserialized based on the type we specified
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}