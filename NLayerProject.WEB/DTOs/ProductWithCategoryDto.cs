using System;
using NLayerProject.Core.Models;

namespace NLayerProject.API.DTOs
{
    public class ProductWithCategoryDto:ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
