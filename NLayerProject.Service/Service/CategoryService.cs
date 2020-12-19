using System;
using System.Threading.Tasks;
using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;
using NLayerProject.Core.Services;
using NLayerProject.Core.UnitOfWork;

namespace NLayerProject.Service.Service
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IRepository<Category> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await _unitOfWork.Categories.GetWithProductByIdAsync(categoryId);
        }
    }
}
