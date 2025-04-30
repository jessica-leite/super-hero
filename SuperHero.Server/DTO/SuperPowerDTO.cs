using System.ComponentModel.DataAnnotations;

namespace SuperHero.Server.DTO
{
    public class SuperPowerDTO
    {
        public int Id { get; set; }

        [Required]
        public string SuperPoder { get; set; }

        [Required]
        public string Descricao { get; set; }

    }
}