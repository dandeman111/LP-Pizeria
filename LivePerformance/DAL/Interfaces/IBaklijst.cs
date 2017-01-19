using System.Collections.Generic;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Interfaces
{
    public interface IBaklijst
    {
        Baklijst GetbyId(int id);
        void Add(Baklijst product);
        void Update(Baklijst product);
        void Delete(Baklijst product);
        List<Baklijst> GetAll();
    }
}
