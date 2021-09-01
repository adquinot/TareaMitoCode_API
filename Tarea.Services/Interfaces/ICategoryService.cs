using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Dto.Request;
using Tarea.Dto.Response;

namespace Tarea.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDtoResponse> GetCollectionAsync(BaseDtoRequest request);

        Task<ResponseDto<CategoryDtoSingleResponse>> GetAsync(int id);

        Task<ResponseDto<int>> CreateAsync(CategoryDtoRequest request);

        Task<ResponseDto<int>> UpdateAsync(int id, CategoryDtoRequest request);

        Task<ResponseDto<int>> DeleteAsync(int id);
    }
}
