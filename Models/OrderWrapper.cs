using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace E_Commerce.Models
{
    public class OrderWrapper
    {
        public Order Order {get;set;}
        public List<Order> AllOrders {get;set;}
        public List<Customer> AllCustomers {get;set;}

        public List<Product> AllProducts {get;set;}
    }
}