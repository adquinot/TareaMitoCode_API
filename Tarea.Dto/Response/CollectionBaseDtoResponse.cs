using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Dto.Response
{
    public class CollectionBaseDtoResponse<TDtoClass>
   where TDtoClass : class
    {
        public ICollection<TDtoClass> Collection { get; set; }
        public int TotalPages { get; set; }
    }
}
