using System;
using System.ComponentModel.DataAnnotations;

namespace NLayerProject.API.DTOs
{
    public class CategoryDto
    {
        public CategoryDto()
        {
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
