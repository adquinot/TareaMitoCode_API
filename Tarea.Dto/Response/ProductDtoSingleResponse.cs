using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Dto.Response
{
    public class ProductDtoSingleResponse
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        public decimal ProductPrice { get; set; }


        public bool ProductEnabled { get; set; }
    }
}
