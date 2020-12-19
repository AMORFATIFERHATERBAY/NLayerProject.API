using System;
using System.Threading.Tasks;
using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;
using NLayerProject.Core.Services;
using NLayerProject.Core.UnitOfWork;

namespace NLayerProject.Service.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IRepository<Product> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
           return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);


        }
    }
}
