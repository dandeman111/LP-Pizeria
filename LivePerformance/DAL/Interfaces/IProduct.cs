using System.Collections.Generic;
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
