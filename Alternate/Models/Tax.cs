using System.ComponentModel.DataAnnotations;

namespace Alternate.Models
{
    public class Tax
    {
        public int TaxId { get; set; }

        [Required]
        public int TaxRate { get; set; }
    }
}
