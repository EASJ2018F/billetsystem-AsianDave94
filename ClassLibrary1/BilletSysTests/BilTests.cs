using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            var bil = new Bil("1234567", DateTime.Today);

            int Pris = bil.Pris(240);

            Assert.AreEqual(240, Pris);
        }
        

        [TestMethod()]
        public void KøretøjTest()
        {
            var bil = new Bil("1234567", DateTime.Today);

            string Køretøj = bil.Type();

            Assert.AreEqual("Bil", Køretøj);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
            "Nummerplade er for lang")]
        public void NummerpladeForLangExceptionTest()
        {
            Bil skoda = new Bil("12345678", DateTime.Today);
            
        }
        [TestMethod()]
        public void PrisMedBrobizzTest()
        {
            Bil b1 = new Bil("1234567", DateTime.Today);

            b1.Brobizz = true;
            int pris = b1.Pris(240);

            Assert.AreEqual(230, pris);
        }
        [TestMethod()]
        public void PrisMedBrobizzOgWeekendTest()
        {
            DateTime Dato = new DateTime(2018,02,03);
            Bil b1 = new Bil("1234567", Dato);
            
            int pris = b1.Pris(240);

            Assert.AreEqual(190, pris);
        }
        [TestMethod()]
        public void PrisUdenBrobizzOgWeekendTest()
        {
            DateTime Dato = new DateTime(2018, 02, 03);
            Bil b1 = new Bil("1234567", Dato);

            b1.Brobizz = false;
            int pris = b1.Pris(240);

            Assert.AreEqual(200, pris);
        }
    }
}