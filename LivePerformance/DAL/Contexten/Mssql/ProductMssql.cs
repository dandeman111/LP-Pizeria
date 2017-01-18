using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DAL.Interfaces;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Contexten.Mssql
{
    class ProductMssql:Connstring , IProduct
    {
        public Product GetbyId(int id)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("Select * from Product where id = 1", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    Product p;
                    p = null;
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        p = new Product(
                            Convert.ToInt16(reader["Id"]),
                            Convert.ToDouble(reader["Prijs"]),
                            Convert.ToString(reader["Naam"]),
                            Convert.ToBoolean(reader["alcohol"]));
                    }
                    return p;
                }
            }
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> p = new List<Product>();
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var command = new SqlCommand("Select * from Product", con))
                {
                    var reader =command.ExecuteReader();
                    while (reader.Read())
                    {
                        p.Add(new Product(
                            Convert.ToInt16(reader["Id"]),
                            Convert.ToDouble(reader["Prijs"]),
                            Convert.ToString(reader["Naam"]),
                            Convert.ToBoolean(reader["alcohol"])));
                    }
                }
            }
            return p;
        }
    }
}
