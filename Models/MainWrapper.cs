using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace E_Commerce.Models
{
    public class MainWrapper
    {
        public RegisterUser RegisterUser {get;set;}
        public List<Customer> ThreeCustomers {get;set;}
        public List<Order> ThreeOrders{get;set;}
        public List<Product> ThreeProducts {get;set;}
    }
}