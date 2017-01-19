using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DAL.Interfaces;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Repositories
{
    public class PizzaRepo
    {
        public IPizza Context { get; private set; }

        public PizzaRepo(IPizza context)
        {
            Context = context;
        }

        public Pizza GetbyId(int id)
        {
            return Context.GetbyId(id);
        }

        public void Add(Pizza product)
        {
            Context.Add(product);
        }

        public void Update(Pizza product)
        {
            Context.Update(product);
        }

        public void Delete(Pizza product)
        {
            Context.Delete(product);
        }

        public List<Pizza> GetAll()
        {
            return Context.GetAll();
        }
    }
}
