using System;
using System.Threading.Tasks;
using NLayerProject.Core.Repositories;
using NLayerProject.Core.UnitOfWork;
using NLayerProject.Data.Repositories;

namespace NLayerProject.Data.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_appDbContext);
       
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_appDbContext);

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsycn()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
