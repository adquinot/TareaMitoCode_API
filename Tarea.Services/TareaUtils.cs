using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Services
{
    public class TareaUtils
    {
        public static int GetTotalPages(int total, int rows)
        {
            var totalPages = total / rows;
            if (total % rows > 0)
                totalPages++;

            return totalPages;
        }
    }
}
