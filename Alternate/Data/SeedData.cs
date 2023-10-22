using Alternate.Models;

namespace Alternate.Data
{
    public class SeedData
    {
        public static void Initialize(Product_Context context) {
            context.Database.EnsureCreated();

            if (context.Units.Any() && context.Unit_Conversions.Any() && context.Taxes.Any())
            {
                return;
            }

            var Units = new Unit[]
            {
                new Unit { Name = "Kgs" },
                new Unit { Name = "Gms"},
                new Unit { Name = "Pcs" },
                new Unit { Name = "Unit" },
                new Unit { Name = "Bag" },
                new Unit { Name = "Bundle" },
                new Unit { Name = "Case" },
                new Unit { Name = "Dozen" },
                new Unit { Name = "Jar" },
                new Unit { Name = "Ladi" },
                new Unit { Name = "Patta" }
            };

            context.Units.AddRange(Units);
            context.SaveChanges();
        }
    }
}
