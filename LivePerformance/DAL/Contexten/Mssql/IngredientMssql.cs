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
    class IngredientMssql:Connstring,IIngredient
    {
        public Ingredient GetbyId(int id)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("Select * from ingredient where id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    Ingredient i;
                    i = null;
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        i = new Ingredient(
                            Convert.ToInt16(reader["Id"]),
                            Convert.ToString(reader["Naam"]),
                            Convert.ToBoolean(reader["Halal"]),
                            Convert.ToBoolean(reader["Veganistisch"]));
                    }
                    return i;
                }
            }
        }

        public void Add(Ingredient product)
        {
            throw new NotImplementedException();
        }

        public void Update(Ingredient product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Ingredient product)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetAll()
        {
            List<Ingredient> p = new List<Ingredient>();
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var command = new SqlCommand("Select * from Ingredient", con))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        p.Add(new Ingredient(
                            Convert.ToInt16(reader["Id"]),
                            Convert.ToString(reader["Naam"]),
                            Convert.ToBoolean(reader["Halal"]),
                            Convert.ToBoolean(reader["Veganistisch"])));
                    }
                }
            }
            return p;
        }
    }
}
