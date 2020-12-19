using System;
using System.ComponentModel.DataAnnotations;

namespace NLayerProject.API.DTOs
{
    public class PersonsDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]  // {0} <= Name
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]  // {0} <= Surname
        public string Surname { get; set; }
    }
}
