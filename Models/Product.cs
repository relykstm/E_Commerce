using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace E_Commerce.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get; set;}

        [Required]
        public string ProductName {get;set;}

        [Required]
        public string Image {get;set;}

        [Required]
        public string Description {get;set;}

        [Required]

        public int QuantityInStore {get;set;}

        List<Order> Orders {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } =  DateTime.Now;

    }
}