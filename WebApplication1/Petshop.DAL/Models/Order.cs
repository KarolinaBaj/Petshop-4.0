using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Petshop.DAL.Models
{
    public class Order
    {
        [Key]
        public int porudzbina_id { get; set; }
        public int korisnik_id { get; set; }
        public DateTime Datumporudzbine { get; set; }
        [Required]
        
        [Column(TypeName = "decimal(10,2)")]
        public decimal ukupnacena { get; set; }

        [Required]
        [StringLength(100)]
        public string status { get; set; }
    }
}
