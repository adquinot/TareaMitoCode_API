using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.DataAccess.Repositories;
using Tarea.Services.Implementations;
using Tarea.Services.Interfaces;

namespace Tarea.Services
{
    public static class InjectionDependency
    {
        public static IServiceCollection AddInjection(this IServiceCollection services)
        {
            // Transient => Por request

            // Scoped => En el mismo request si tengo mas de un objeto del mismo tipo, entonces se utiliza una sola instancia.

            // Singleton => Se utiliza la misma instancia para todos los request.

            // STATELESS = SIN ESTADO.

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductService, ProductService>();

            return services.AddTransient<ICategoryRepository, CategoryRepository>()
                           .AddTransient<ICategoryService, CategoryService>();


        }
    }
}
