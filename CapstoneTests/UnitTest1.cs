using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InvStocking()
        {
            VendingMachineFileReader vfr = new VendingMachineFileReader("vendingmachine.csv");
            var inventory = vfr.GetInventory();
            VendingMachine vm = new VendingMachine(inventory);
            Assert.AreEqual(16, inventory.Count);

            
        }
        [TestMethod]
        public void MyTestMethod()
        {
            VendingMachineFileReader vfr = new VendingMachineFileReader("vendingmachine.csv");
            var inventory = vfr.GetInventory();
            VendingMachine vm = new VendingMachine();
            Assert.AreEqual(16, inventory.Count);
        }
    }
}
