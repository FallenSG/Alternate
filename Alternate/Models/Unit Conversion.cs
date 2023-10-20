using System.ComponentModel.DataAnnotations;

namespace Alternate.Models
{
    public class Unit_Conversion
    {
        public int Unit_ConversionId { get; set; }

        [Required]
        public Unit? MainUnit { get; set; }

        [Required]
        public Unit? SubUnit { get; set; }

        [Required]
        public decimal ConFact { get; set; }
    }
}
