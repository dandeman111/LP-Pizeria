using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Interfaces
{
    public interface IProduct
    {
        Product GetbyId(int id);
        void Add(Product product);
        void Update(Product product );
        void Delete(Product product);
        List<Product> GetAll();
    }
}
