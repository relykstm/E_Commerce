using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace E_Commerce.Models
{
    public class ProductWrapper
    {
        public Product Product {get;set;}
        public List<Product> AllProducts {get;set;}
    }
}