using LivePerformance.DAL.Contexten.Mssql;
using LivePerformance.DAL.Models;
using LivePerformance.DAL.Repositories;

namespace LivePerformance.Logic
{
    public class Beheerlogic
    {
        
        private ProductRepo ProductRepo;
        private IngredientRepo ingredientRepo;

        public Beheerlogic()
        {
            ProductRepo = new ProductRepo(new ProductMssql());
            ingredientRepo = new IngredientRepo(new IngredientMssql());
        }

        public void ProductToevoegen(string naam,double prijs, bool alcohol)
        {
            ProductRepo.Add(new Product(prijs,naam,alcohol));
        }

        public void ingredientToevoegen(string naam, double prijs, bool halal, bool veganistisch)
        {
            ingredientRepo.Add(new Ingredient(naam,halal,veganistisch,prijs));
        }
    }
}
