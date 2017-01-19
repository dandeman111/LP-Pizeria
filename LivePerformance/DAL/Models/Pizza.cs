using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DAL.Contexten.Mssql;
using LivePerformance.DAL.Repositories;
using LivePerformance.Enumurations;

namespace LivePerformance.DAL.Models
{
    public class Pizza
    {
        public int Id { get; private set; }
        public double Prijs { get; private set; }
        public bool Halal { get; private set; }
        public bool Veganistisch { get; private set; }
        public int BaktijdInMin { get; private set; }
        public string Vorm { get; private set; }
        public string Naam { get; private set; }
        public List<Ingredient> Ingredienten { get; private set; }

        public Pizza(int id, bool halal, bool veganistisch,  string vorm, string naam, List<int> ingredienten)
        {
            IngredientRepo ir = new IngredientRepo(new IngredientMssql());
            Ingredienten = new List<Ingredient>();
            Id = id;
            Halal = halal;
            Veganistisch = veganistisch;
            Vorm = vorm;
            Naam = naam;
            foreach (int ingredient in ingredienten)
            {
                Ingredienten.Add(ir.GetbyId(ingredient));
            }
        }
    }
}
