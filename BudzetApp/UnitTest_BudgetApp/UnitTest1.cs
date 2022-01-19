using Microsoft.VisualStudio.TestTools.UnitTesting;
using BudzetApp;

namespace UnitTest_BudgetApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKonverzija()
        {
            int iznos = 500;

            double koefKonv = Form1.konverzije["HRK" + "GBP"];
            double ocekivani = 55.4;

            Assert.AreEqual(ocekivani, iznos * koefKonv,0.2);
        }
    }
}
