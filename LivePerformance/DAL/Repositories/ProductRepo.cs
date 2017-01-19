using System.Collections.Generic;
using LivePerformance.DAL.Interfaces;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Repositories
{
    public class ProductRepo
    {
        public IProduct Context { get; private set; }

        public ProductRepo(IProduct context)
        {
            Context = context;
        }
        public Product GetbyId(int id)
        {
           return Context.GetbyId(id);
        }

        public void Add(Product product)
        {
            Context.Add(product);
        }

        public void Update(Product product)
        {
            Context.Update(product);
        }

        public void Delete(Product product)
        {
            Context.Delete(product);
        }

        public List<Product> GetAll()
        {
            return Context.GetAll();
        }
    }
}
