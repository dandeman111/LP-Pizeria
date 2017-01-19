using System.Collections.Generic;
using LivePerformance.DAL.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LivePerformance.Logic.Tests
{
    [TestClass]
    public class BestelLogicTests
    {
        [TestMethod]
        public void GeefItemsTest() //deze test of alle producten netjes op het bestellingslijstje komen.
        {
            BestelLogic bl = new BestelLogic();

            Pizza pizza1 = new Pizza(1, true, false, "Rond", "pizza1", new List<int> {1, 2, 3, 4});
            Pizza pizza2 = new Pizza(1, true, false, "Rond", "pizza2", new List<int> { 1, 2, 3, 4 });//ik had geen tijd meer voor een memory context dus dan zo maar
            Pizza pizza3 = new Pizza(1, true, false, "Rond", "pizza3", new List<int> { 1, 2, 3, 4 });
            
            Product product1 = new Product(1,200,"product1",false);
            Product product2 = new Product(1, 200, "product2", false);

            bl.VoegPizzaToe(pizza1);
            bl.VoegPizzaToe(pizza2);
            bl.VoegPizzaToe(pizza3);

            bl.VoegProductToe(product1);
            bl.VoegProductToe(product2);

            Assert.AreEqual(bl.GeefItems()[0],"pizza1");
            Assert.AreEqual(bl.GeefItems()[1], "pizza2");
            Assert.AreEqual(bl.GeefItems()[2], "pizza3");
            Assert.AreEqual(bl.GeefItems()[3], "product1");
            Assert.AreEqual(bl.GeefItems()[4], "product2");

        }
    }
}