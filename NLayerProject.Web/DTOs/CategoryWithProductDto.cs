using System;
using System.Collections.Generic;

namespace NLayerProject.WEB.DTOs
{
    public class CategoryWithProductDto:CategoryDto
    {
        public ICollection<ProductDto> Products { get; set; }

    }
}
