﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NLayerProject.Core.Models
{

    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDelete { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
