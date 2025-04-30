using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHero.Server.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [Column(TypeName = "nvarchar(120)")]
        public required string Nome { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(120)")]
        public required string NomeHeroi { get; set; }
        [Required]
        [Column(TypeName = "datetime2(7)")]
        public required DateTime DataNascimento { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public required double Altura { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public required double Peso { get; set; }
        public ICollection<SuperPower> SuperPoderes { get; set; }
    }
}
