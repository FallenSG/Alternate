using Microsoft.EntityFrameworkCore;
using System;

namespace Alternate.Models
{
    public class Product_Context : DbContext
    {
        public DbSet<Unit> Units {  get; set; }
        public DbSet<Unit_Conversion> Unit_Conversions { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Parent_Product> Parent_Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=Alternate.db");
    }
}
