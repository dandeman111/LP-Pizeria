using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LivePerformance.DAL.Interfaces;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Contexten.Mssql
{
    class PizzaMssql:Connstring,IPizza
    {
        public Pizza GetbyId(int id)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("Select  * from pizza join Pizza_ingredient on Pizza.Id = Pizza_ingredient.Pizza_id join Ingredient on Ingredient.Id = Pizza_ingredient.Ingredient_id where Pizza.Id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    Pizza i;
                    i = null;
                    var reader = cmd.ExecuteReader();
                    List<int> li = new List<int>();

                    int Id = 0;
                    bool halal = false;
                    bool vegan = false;
                    string vorm = null;
                    string naam = null;
                    
                    while (reader.Read())
                    {
                        Id = Convert.ToInt16(reader[0]);
                        halal = Convert.ToBoolean(reader["Halal"]);
                        vegan = Convert.ToBoolean(reader["Veganistisch"]);
                        vorm = Convert.ToString(reader["Vorm"]);
                        naam = Convert.ToString(reader["Naam"]);
                        li.Add(Convert.ToInt16(reader[9]));
                    }
                    i= new Pizza(Id,halal,vegan,vorm,naam,li);
                    return i;
                }
            }
        }

        public void Add(Pizza product)
        {
            throw new NotImplementedException();
        }

        public void Update(Pizza product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pizza product)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetAll()
        {
          List<int> x = new List<int>();
        List<Pizza> p = new List<Pizza>();
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("Select  * from pizza", con))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        x.Add(Convert.ToInt16(reader["Id"]));
                    }
                }
            }
            foreach (int pizzaId in x)
            {
                p.Add(GetbyId(pizzaId));
            }
            return p;
        }
    }
    }

