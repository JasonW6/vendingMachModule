using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class ChangeTest
    {
        [TestMethod]
        public void GivesCorrectChange()
        {
            Change moreChange = new Change(1.55M);
            string result = moreChange.Total;
            Assert.AreEqual("1 nickels 0 Dimes 6 Quarters", result);

        }
        [TestMethod]
        public void CorrectChange()
        {
            Change moreChange = new Change(.90M);
            string result = moreChange.Total;
            Assert.AreEqual("1 nickels 1 Dimes 3 Quarters", result);
        }
    }
}
