using System.ComponentModel.DataAnnotations;

namespace SuperHero.Server.DTO
{
    public class HeroDTO
    {
        public int Id { get; private set; }

        [Required]
        public required string Nome { get; set; }

        [Required]
        public required string NomeHeroi { get; set; }

        [Required]
        public required DateTime DataNascimento { get; set; }

        [Required]
        public required double Altura { get; set; }

        [Required]
        public required double Peso { get; set; }
        public ICollection<SuperPowerDTO> SuperPoderes { get; set; }
    }
}
