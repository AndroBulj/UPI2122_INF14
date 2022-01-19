using Microsoft.VisualStudio.TestTools.UnitTesting;
using BudzetApp;
using System.Collections.Generic;

namespace UnitTest_BudgetApp
{
    [TestClass]
    public class UnitTest1
    {
        Form1 forma = new Form1();

        [TestMethod]
        public void TestKonverzija()
        {
            int iznos = 500;

            double koefKonv = Form1.konverzije["HRK" + "GBP"];
            double ocekivani = 55.4;

            Assert.AreEqual(ocekivani, iznos * koefKonv,0.2);
        }

        [TestMethod]
        public void TestUkupno()
        {
            List<Form1.Transakcija> transakcije = new List<Form1.Transakcija>();

            Form1.kategorijePrihoda.Add("Test", 0);
            Form1.kategorijeRashoda.Add("Test", 0);

            Form1.Transakcija nova1 = new Form1.Transakcija("Prihod", "Test1", 200, "HRK", "Test");
            transakcije.Add(nova1);
            Form1.Transakcija nova2 = new Form1.Transakcija("Rashod", "Test2", 600, "HRK", "Test");
            transakcije.Add(nova2);
            Form1.Transakcija nova3 = new Form1.Transakcija("Prihod", "Test3", 100, "HRK", "Test");
            transakcije.Add(nova3);

            foreach(Form1.Transakcija tran in transakcije)
            {
                forma.RacunajTotal(tran);
            }
            double ocekivan = -300;

            Assert.AreEqual(ocekivan, forma.Total);
        }
    }
}
