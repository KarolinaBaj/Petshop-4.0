using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Petshop.DAL.Models
{
    public class Category
    {
        [Key]
        public int Kategorija_id { get; set; }

        [Required]
        [StringLength(100)]
        public string nazivkategorije { get; set; }
    }
}
