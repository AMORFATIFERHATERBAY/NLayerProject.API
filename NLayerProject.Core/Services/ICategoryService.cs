using System;
using System.Threading.Tasks;
using NLayerProject.Core.Models;

namespace NLayerProject.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);

        // Category ile alakalı metodlar işlemleri burda tanımlayabiliriz. 
    }
}
