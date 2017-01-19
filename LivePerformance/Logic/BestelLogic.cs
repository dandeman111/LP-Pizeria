using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LivePerformance.DAL.Contexten.Mssql;
using LivePerformance.DAL.Models;
using LivePerformance.DAL.Repositories;

namespace LivePerformance.Logic
{
    public class BestelLogic
    {
        private PizzaRepo PizzaRepo;
        private ProductRepo ProductRepo;
        private BestellingRepo BestellingRepo;
        private Bestelling Bestelling;

        public BestelLogic()
        {
            PizzaRepo = new PizzaRepo(new PizzaMssql());
            ProductRepo = new ProductRepo(new ProductMssql());
            Bestelling = new Bestelling();
            BestellingRepo = new BestellingRepo(new BestellingMssql());

        }

        public List<Pizza> AllePizzas()
        {
            return PizzaRepo.GetAll();
        }
        public List<Product> AlleProducts()
        {
            return ProductRepo.GetAll();
        }

        public void VoegPizzaToe(Pizza pizza)
        {
            if(pizza !=null) { Bestelling.Pizzas.Add(pizza);}
            Bestelling.UpdatePrijs();
        }

        public void VoegProductToe(Product product)
        {
            if(product != null) { Bestelling.Products.Add(product);}
            Bestelling.UpdatePrijs();
        }

        public List<string> GeefItems()
        {
            List<string> ls=new List<string>();
            foreach (Pizza p in Bestelling.Pizzas)
            {
                if (p != null)
                {
                    ls.Add(p.Naam);
                }
                 
            }
            
            foreach (Product p in Bestelling.Products)
            {
                if (p != null)
                {
                    ls.Add(p.Naam);
                }
                
            }
            return ls;
        }

        public bool plaatsBestelling()
        {
            if (Bestelling.Pizzas.Count > 0 || Bestelling.Products.Count > 0)
            {
                BestellingRepo.Add(Bestelling);
                return true;
            }
            else
            {
                MessageBox.Show("je kan geen lege bestelling plaatsen");
                return false;
            }
            
        }

        public double geefPrijs()
        {
            Bestelling.UpdatePrijs();
            return Bestelling.Prijs / 100;
        }

        public void ExporteerBon()
        {
            using (StreamWriter writer =
           new StreamWriter("bon.txt"))
            {
                writer.Write("Pizzeria La Crosta Insapore");
                writer.WriteLine("Klantbon voor klant");
                foreach (Pizza pizza in Bestelling.Pizzas)
                {
                    writer.WriteLine(pizza.Naam + ": " + pizza.Prijs/100);
                }
                foreach (Product product in Bestelling.Products)
                {
                    writer.WriteLine(product.Naam + ": "+product.Prijs/100);
                }
                writer.WriteLine("Te betalen bedrag: "+ Bestelling.Prijs/100);
            }
        }

    }
}
