namespace SuperHero.Server.Models
{
    public class Hero
    {
        public int Id { get; private set; }
        public string Nome { get; set; }

        public string NomeHeroi { get; set; }

        public DateTime DataNascimento { get; set; }

        public double Altura { get; set; }
        public double Peso { get; set; }
    }
}
