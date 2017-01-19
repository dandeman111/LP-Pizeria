using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DAL.Interfaces;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Repositories
{
    public class BestellingRepo
    {
        public IBestelling Context { get; private set; }

        public BestellingRepo(IBestelling context)
        {
            Context = context;
        }

        public Bestelling GetbyId(int id)
        {
            return Context.GetbyId(id);
        }

        public void Add(Bestelling bestelling)
        {
            Context.Add(bestelling);
        }

        public void Update(Bestelling bestelling)
        {
            Context.Update(bestelling);
        }

        public void Delete(Bestelling bestelling)
        {
            Context.Delete(bestelling);
        }

        public List<Bestelling> GetAll()
        {
            return Context.GetAll();
        }
    }
}
