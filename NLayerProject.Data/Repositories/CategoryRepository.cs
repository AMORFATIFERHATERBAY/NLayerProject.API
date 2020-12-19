using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;

namespace NLayerProject.Data.Repositories
{
    public class CategoryRepository:Repository<Category>, ICategoryRepository
    {
        private AppDbContext appDbContext { get => _appDbContext as AppDbContext; }

        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await _appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync
                (x => x.Id == categoryId);
            }
        }
}
