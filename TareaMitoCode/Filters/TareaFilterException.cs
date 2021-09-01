using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaMitoCode.Filters
{
    public class TareaFilterException : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is TareaException)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
