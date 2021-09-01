using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Entities;

namespace Tarea.DataAccess
{
    public class TareaDbContext:DbContext
    {

         public TareaDbContext(DbContextOptions<TareaDbContext> options)
        : base(options)
            {
            }

            public TareaDbContext()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.UnitPrice)
                .HasPrecision(8, 2);
        }
    }
}
