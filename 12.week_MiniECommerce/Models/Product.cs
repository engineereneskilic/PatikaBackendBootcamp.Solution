﻿using System.ComponentModel.DataAnnotations.Schema;

namespace _12.week_MiniECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        
        public int CategoryID { get; set; }
        [ForeignKey(nameof(CategoryID))]
        public Category Category { get; set; }


        public int StockQuantity { get; set; }
    }
}
