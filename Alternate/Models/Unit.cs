using System.ComponentModel.DataAnnotations;

namespace Alternate.Models
{
    public class Unit
    {
        public int UnitId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
    }
}
