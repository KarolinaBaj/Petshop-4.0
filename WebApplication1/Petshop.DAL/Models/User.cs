using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Petshop.DAL.Models
{
    [Table("korisnik")]
    public class User
    {
        [Key]
        [Column("Korsnik_id")]
        public int Korsnik_id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("ime")]
        public string ime { get; set; }
        [Required]
        [StringLength(100)]
        [Column("prezime")]
        public string prezime { get; set; }
        
        [Required]
        [Column("lozinka")]
        [StringLength(255)]
        public string lozinka { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress]
        [Column("email")]
        public string email { get; set; }
        [Required]
        [StringLength(100)]
        [Column("adresa")]
        public string adresa { get; set; }
        [Required]
        [Column("br_telefona")]
        public int br_telefona { get; set; }

        
    }
}
