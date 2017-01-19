using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Interfaces
{
    public interface IIngredient
    {
        Ingredient GetbyId(int id);
        void Add(Ingredient product);
        void Update(Ingredient product);
        void Delete(Ingredient product);
        List<Ingredient> GetAll();
    }
}
