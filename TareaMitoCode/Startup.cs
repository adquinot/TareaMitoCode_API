using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea.DataAccess;
using Tarea.Entities;
using Tarea.Services;
using TareaMitoCode.Filters;

namespace TareaMitoCode
{
    public class Startup
    {
        public Startup(IWebHostEnvironment environment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath) // Use la carpeta donde se ejecuta el API
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: false, reloadOnChange: true);

            builder.AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        private readonly string _corsConfiguration = "_corsConfiguration";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
            });

            services.Configure<AppSettings>(Configuration)
        .AddCors(options =>
            options.AddPolicy(_corsConfiguration,
                builder =>
                {
                    builder.WithOrigins("*", "http://localhost", "https://localhost");
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                }
            ))
        .AddMvcCore()
        .AddApiExplorer();

            services.AddInjection();


            services.AddDbContext<TareaDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
                //options.LogTo(Console.WriteLine, LogLevel.Information);
            });

            services.AddControllers(options =>
            {
                //options.Filters.Add<FiltroRecurso>();
                options.Filters.Add<TareaFilterException>();
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TareaMitoCode", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TareaMitoCode v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(_corsConfiguration);

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
