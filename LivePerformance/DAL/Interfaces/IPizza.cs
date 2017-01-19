using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Interfaces
{
     public interface IPizza
    {
        Pizza GetbyId(int id);
        void Add(Pizza product);
        void Update(Pizza product);
        void Delete(Pizza product);
        List<Pizza> GetAll();
    }
}
