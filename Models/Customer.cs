using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace E_Commerce.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId {get; set;}

        [Required]
        public string Name {get;set;}

        List<Order> Orders {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } =  DateTime.Now;

    }
}