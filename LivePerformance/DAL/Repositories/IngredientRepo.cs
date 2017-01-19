using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DAL.Interfaces;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Repositories
{
    class IngredientRepo
    {
        public IIngredient Context { get; private set; }

        public IngredientRepo(IIngredient context)
        {
            Context = context;
        }

        public Ingredient GetbyId(int id)
        {
            return Context.GetbyId(id);
        }

        public void Add(Ingredient product)
        {
            Context.Add(product);
        }

        public void Update(Ingredient product)
        {
            Context.Update(product);
        }

        public void Delete(Ingredient product)
        {
            Context.Delete(product);
        }

        public List<Ingredient> GetAll()
        {
            return Context.GetAll();
        }
    }
}
