using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHero.Server.Models
{
    public class SuperPower
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string SuperPoder { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Descricao { get; set; }

        public ICollection<Hero> Herois { get; set; }
    }
}
