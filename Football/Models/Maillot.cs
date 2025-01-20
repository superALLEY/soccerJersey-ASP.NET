namespace Football.Models
{
    public class Maillot
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Couleur { get; set; }
        public string Taille { get; set; }
        public decimal Prix { get; set; }

        // Le pays participant
        public string Pays { get; set; }
    }
}
