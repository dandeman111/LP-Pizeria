namespace LivePerformance.DAL.Models
{
    public class Ingredient
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public bool Halal { get; private set; }
        public bool Veganistisch { get; private set; }
        public double Prijs { get; private set; }

        public Ingredient(int id, string naam, bool halal, bool veganistisch,double prijs)
        {
            Id = id;
            Naam = naam;
            Halal = halal;
            Veganistisch = veganistisch;
            Prijs = prijs;
        }
        public Ingredient(string naam, bool halal, bool veganistisch, double prijs)
        {
            Naam = naam;
            Halal = halal;
            Veganistisch = veganistisch;
            Prijs = prijs;
        }
    }
}
