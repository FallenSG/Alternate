using Alternate.Models;

namespace Alternate.Data
{
    public class SeedData
    {
        public static void Initialize(Product_Context context) {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (context.Units.Any() || context.Unit_Conversions.Any() || context.Taxes.Any())
            {
                return;
            }

            string[] Units_List = new string[] { 
                "Kgs", "Gms", "Pcs", "Unit", "Bag", "Bundle", "Case", "Dozen", "Jar", "Ladi", "Patta"
            };

            Unit[] Units = new Unit[Units_List.Length];

            for (int i = 0; i < Units_List.Length; i++)
            {
                Units[i] = new Unit { Name = Units_List[i], Alias="", PrintName = Units_List[i] };
            }
            context.Units.AddRange(Units);
            context.SaveChanges();
        }
    }
}
