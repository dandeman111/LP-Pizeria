﻿using System.Collections.Generic;

namespace LivePerformance.DAL.Models
{
    public class Bestelling
    {
        public int Id { get; private set; }
        public double Prijs { get; private set; }
        public double Btw { get; private set; }
        public bool Afhalen { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Product> Products { get; private set; }

        public Bestelling(int id, double price, double btw, bool afhalen, List<Pizza> pizzas, List<Product> products)
        {
            Id = id;
            Prijs = price;
            Btw = btw;
            Afhalen = afhalen;
            Pizzas = pizzas;
            Products = products;
        }

        public Bestelling()
        {
            Pizzas = new List<Pizza>();
            Products = new List<Product>();

        }

        public void UpdatePrijs()
        {
            
                Prijs = 0;
                foreach (Pizza pizza in Pizzas)
                {
                    Prijs = Prijs + pizza.Prijs;
                }
                foreach (Product product in Products)
                {
                    Prijs = Prijs + product.Prijs;
                }
           
            
        }

        

    }
}
