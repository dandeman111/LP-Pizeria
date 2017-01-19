using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
