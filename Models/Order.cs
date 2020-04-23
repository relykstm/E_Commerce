using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace E_Commerce.Models
{
    public class Order
    {
        [Key]
        public int OrderId {get; set;}
        [Required]
        public int OrderQuantity {get;set;}
        public int CustomerId {get;set;}
        public Customer Customer {get;set;}
        public int ProductId {get;set;}
        public Product Product {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } =  DateTime.Now;

    }
}