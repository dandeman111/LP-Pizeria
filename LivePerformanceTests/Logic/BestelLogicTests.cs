using Microsoft.VisualStudio.TestTools.UnitTesting;
using LivePerformance.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DAL.Models;
using LivePerformance.DAL.Repositories;

namespace LivePerformance.Logic.Tests
{
    [TestClass()]
    public class BestelLogicTests
    {
        [TestMethod()]
        public void GeefItemsTest() //deze test of alle producten netjes op het bestellingslijstje komen.
        {
            BestelLogic bl = new BestelLogic();

            Pizza pizza1 = new Pizza(1, true, false, "Rond", "pizza1", new List<int> {1, 2, 3, 4});
            Pizza pizza2 = new Pizza(1, true, false, "Rond", "pizza2", new List<int> { 1, 2, 3, 4 });
            Pizza pizza3 = new Pizza(1, true, false, "Rond", "pizza3", new List<int> { 1, 2, 3, 4 });
            
            Product product1 = new Product(1,200,"product1",false);
            Product product2 = new Product(1, 200, "product2", false);

            bl.VoegPizzaToe(pizza1);
            bl.VoegPizzaToe(pizza2);
            bl.VoegPizzaToe(pizza3);

            bl.VoegProductToe(product1);
            bl.VoegProductToe(product2);

            Assert.AreEqual(bl.GeefItems()[0].ToString(),"pizza1");
            Assert.AreEqual(bl.GeefItems()[1].ToString(), "pizza2");
            Assert.AreEqual(bl.GeefItems()[2].ToString(), "pizza3");
            Assert.AreEqual(bl.GeefItems()[3].ToString(), "product1");
            Assert.AreEqual(bl.GeefItems()[4].ToString(), "product2");

        }
    }
}