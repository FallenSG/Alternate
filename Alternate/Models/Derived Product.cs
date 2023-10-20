using System.ComponentModel.DataAnnotations;

namespace Alternate.Models
{
    public class Derived_Product : Parent_Product
    {
        public int DPId { get; set; }

        public ICollection<string>? Expr { get; set; }
    }
}
