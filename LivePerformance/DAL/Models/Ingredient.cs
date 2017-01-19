using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance.DAL.Models
{
    public class Ingredient
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public bool Halal { get; private set; }
        public bool Veganistisch { get; private set; }

        public Ingredient(int id, string naam, bool halal, bool veganistisch)
        {
            Id = id;
            Naam = naam;
            Halal = halal;
            Veganistisch = veganistisch;
        }
    }
}
