namespace SuperHero.Server.Models
{
    public class Hero
    {
        private int Id { get; set; }
        public string Nome { get; set; }

        public string NomeHeroi { get; set; }

        public DateTime DataNascimento { get; set; }

        public double Altura { get; set; }
        public double Peso { get; set; }
    }
}
