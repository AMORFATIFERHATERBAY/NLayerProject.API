using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;

namespace NLayerProject.Data.Repositories
{
    public class ProductRepository:Repository<Product>, IProductRepository
    {
        private AppDbContext appDbContext { get => _appDbContext as AppDbContext; }

        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
        

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync
                (x => x.Id == productId);
            //return await _appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync
            //    (x => x.Id == productId);
        }
    }
}
