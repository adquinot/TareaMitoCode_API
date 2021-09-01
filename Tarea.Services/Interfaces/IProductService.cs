using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Dto.Request;
using Tarea.Dto.Response;

namespace Tarea.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductDtoResponse> GetCollectionAsync(BaseDtoRequest request);
        Task<ResponseDto<ProductDtoSingleResponse>> GetProductAsync(int id);
        Task<ResponseDto<int>> CreateAsync(ProductDtoRequest request);
        Task<ResponseDto<int>> UpdateAsync(int id, ProductDtoRequest request);
        Task<ResponseDto<int>> DeleteAsync(int id);
    }
}
