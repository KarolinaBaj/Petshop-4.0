using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Petshop.DAL.Models
{
    public class Product
    {
        [Key]
        public int Proizvod_id { get; set; }

        [Required]
        [StringLength(100)]
        public string naziv { get; set; }
        [Required]
        [Column(TypeName="decimal(10,2)")]
        public decimal cena { get; set; }
        [Required]
        public int kolicinanastanju { get; set; }
        [StringLength(500)]
        public string opis { get; set; }
        public int kategorija_id { get; set; }
    }
}
