using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Entities;
using Tarea.Entities.Complex;

namespace Tarea.DataAccess.Repositories
{
    public interface IProductRepository
    {
        Task<(ICollection<ProductInfo> collection, int total)> GetCollectionAsync(string filter, int page, int rows);
        Task<Product> GetItemAsync(int id);
        Task<int> CreateAsync(Product entity);
        Task UpdateAsync(Product entity);
        Task DeleteAsync(int id);
    }
}
