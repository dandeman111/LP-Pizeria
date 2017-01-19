using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public Double Prijs { get; private set; }
        public string Naam { get; private set; }
        public bool Alcohol { get; private set; }

        public Product(int id, double prijs, string naam, bool alcohol)
        {
            Id = id;
            Prijs = prijs;
            Naam = naam;
            Alcohol = alcohol;
        }

        public override string ToString()
        {
            return Naam;
        }
        public Product( double prijs, string naam, bool alcohol)
        {
            Prijs = prijs;
            Naam = naam;
            Alcohol = alcohol;
        }
    }
}
