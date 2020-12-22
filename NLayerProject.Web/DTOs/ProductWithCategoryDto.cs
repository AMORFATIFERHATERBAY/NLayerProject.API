using System;
using NLayerProject.Core.Models;

namespace NLayerProject.WEB.DTOs
{
    public class ProductWithCategoryDto:ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
