using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Alternate.Models
{
    public class Product_Context : DbContext
    {
        public DbSet<Unit> Units {  get; set; }
        public DbSet<Unit_Conversion> Unit_Conversions { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Parent_Product> Parent_Products { get; set; }

        /*public string DbPath { get; }

        public Product_Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Alternate.db");
            Console.Write(DbPath);
        }*/

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=Alternate.db");
    }
}
