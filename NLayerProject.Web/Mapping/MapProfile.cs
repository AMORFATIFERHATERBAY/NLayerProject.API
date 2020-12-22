using AutoMapper;
using NLayerProject.Core.Models;
using NLayerProject.WEB.DTOs;

namespace NLayerProject.WEB.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Category, CategoryWithProductDto>();
            CreateMap<CategoryWithProductDto, Category>();

            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductDto>();

            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<ProductWithCategoryDto, Product>();


            CreateMap<PersonsDto, Person>();
            CreateMap<Person, PersonsDto>();


        }
    }
}
