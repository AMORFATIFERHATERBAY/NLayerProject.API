using System;
using AutoMapper;
using NLayerProject.API.DTOs;
using NLayerProject.Core.Models;

namespace NLayerProject.API.Mapping
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
