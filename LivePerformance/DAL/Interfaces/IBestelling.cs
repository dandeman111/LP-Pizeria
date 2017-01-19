using System.Collections.Generic;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Interfaces
{
    public interface IBestelling
    {
        Bestelling GetbyId(int id);
        void Add(Bestelling bestelling);
        void Update(Bestelling bestelling);
        void Delete(Bestelling bestelling);
        List<Bestelling> GetAll();
    }
}
