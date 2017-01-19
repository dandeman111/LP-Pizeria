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
    public class BestellingMssql:Connstring , IBestelling
    {
        public Bestelling GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Bestelling bestelling)
        {
            int bestellingId = 0;
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                
                using (var cmd = new SqlCommand("select Max(id)+1 as NextId from Bestelling", con))
                {
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        bestellingId = Convert.ToInt16(reader[0]);
                    }
                }
            }
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var cmd2 = new SqlCommand("insert into Bestelling Values(0,0,0)", con))
                {
                    cmd2.ExecuteNonQuery();
                }
            }
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                foreach (Pizza pizza in bestelling.Pizzas)
                {
                    using (var cmd3 = new SqlCommand("insert into Bestelling_Pizza values(@bestelling, @pizza); ", con))
                    {
                        cmd3.Parameters.AddWithValue("@bestelling", bestellingId);
                        cmd3.Parameters.AddWithValue("@pizza", pizza.Id);
                        cmd3.ExecuteNonQuery();
                    }
                }
            }
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                foreach (Product product in bestelling.Products)
                {
                    using (var cmd3 = new SqlCommand("insert into Bestelling_Product values(@bestelling, @product); ", con))
                    {
                        cmd3.Parameters.AddWithValue("@bestelling", bestellingId);
                        cmd3.Parameters.AddWithValue("@product", product.Id);
                        cmd3.ExecuteNonQuery();
                    }
                }
            }
        }

        public void Update(Bestelling product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Bestelling product)
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
