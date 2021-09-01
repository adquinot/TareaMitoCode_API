using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Dto.Request
{
    public class BaseDtoRequest
    {
        public string Filter { get; set; }
        public int Page { get; set; }
        public int Rows { get; set; }

        public BaseDtoRequest(string filter, int page, int rows)
        {
            Filter = filter;
            Page = page;
            Rows = rows;
        }
    }
}
