namespace SuperHero.Server.Models
{
    public class SuperPower
    {
        public int Id { get; set; }
        public string SuperPoder { get; set; }
        public string Descricao { get; set; }
        public ICollection<Hero> Herois { get; set; }
    }
}
