using System;
using System.ComponentModel.DataAnnotations;

namespace NLayerProject.WEB.DTOs
{
    public class CategoryDto
    {
        public CategoryDto()
        {
        }

        public int Id { get; set; }

        [Required(ErrorMessage ="{0} alanı boş olamaz")]
        public string Name { get; set; }

    }
}
