﻿using System;
namespace NLayerProject.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string InnerBrcod { get; set; }
        public bool IsDelete { get; set; }

        public virtual Category Category { get; set; }
    }
}
