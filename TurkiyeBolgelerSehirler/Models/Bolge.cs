namespace TurkiyeBolgelerSehirler.Models
{
    public class Bolge
    {
        public int Id { get; set; }
        public string BolgeAd { get; set; }
        public string? Slug { get; set; }
        public List<Sehir> Sehirler { get; set; }
    }
}
