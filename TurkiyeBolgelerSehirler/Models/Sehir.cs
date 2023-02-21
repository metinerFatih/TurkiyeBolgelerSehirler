namespace TurkiyeBolgelerSehirler.Models
{
    public class Sehir
    {
        public int Id { get; set; }
        public string SehirAd { get; set; }
        public int Nufus { get; set; }
        public string? Slug { get; set; }

        public int BolgeId { get; set; }
        public Bolge Bolge { get; set; }
    }
}
