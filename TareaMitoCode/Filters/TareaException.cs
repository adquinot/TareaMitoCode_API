using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaMitoCode.Filters
{
    public class TareaException : Exception
    {
        public TareaException(string message)
           : base(message)
        {

        }
    }
}
