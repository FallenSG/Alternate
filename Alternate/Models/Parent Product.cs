using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Alternate.Models
{
    public class Parent_Product
    {
        public int Parent_ProductId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        public string? Alias { get; set; }

        [Required]
        [MaxLength(100)]
        public string? PrintName { get; set; }

        [Required]
        public Unit? Unit { get; set; }
        public bool? IsVisible { get; set; }
        public int Tax { get; set; }

        public int SP { get; set; }
        public int CP { get; set; }
        public int MRP { get; set; }

        //public ICollection<int>? PriceList { get; set; }
    }
}
