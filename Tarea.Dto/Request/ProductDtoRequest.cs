using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Dto.Request
{
    public class ProductDtoRequest
    {
        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        public decimal ProductPrice { get; set; }

        public bool ProductEnabled { get; set; }
    }
}
