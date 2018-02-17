using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class ConsumeTest
    {
        [TestMethod]
        public void CheckIfConsumeReturnsString()
        {
            ChipItem chips = new ChipItem("Doritos", 2.00M);

            string result = chips.Consume();

            Assert.AreEqual("Crunch Crunch, Yum!", result);
        }

        [TestMethod]
        public void CheckIfConsumeReturnsString2()
        {
            CandyItem chips = new CandyItem("Snickers", 4.00M);

            string result = chips.Consume();

            Assert.AreEqual("Munch Munch, Yum!", result);
        }

    }
}
