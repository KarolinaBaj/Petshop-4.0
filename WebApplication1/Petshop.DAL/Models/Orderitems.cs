using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Petshop.DAL.Models
{
    public class Orderitems
    {
        [Key]
        public int stavkaporudzbine_id { get; set; }    
        public int porudzbina_id { get; set; }
        public int Proizvod_id { get; set; }    
        public int kolicina { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal cena { get; set; }

    }
}
