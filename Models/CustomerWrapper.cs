using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace E_Commerce.Models
{
    public class CustomerWrapper
    {
        public Customer Customer {get;set;}
        public List<Customer> AllCustomers {get;set;}
    }
}