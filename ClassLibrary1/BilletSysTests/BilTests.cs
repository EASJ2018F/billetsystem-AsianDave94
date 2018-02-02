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
            var bil = new Bil("1234567");

            int Pris = bil.Pris();

            Assert.AreEqual(240, Pris);
        }
        public void PrisTestMedBrobizz()
        {
            var bil = new Bil("1234567");

            int Pris = bil.Pris();

            Assert.AreEqual(240, Pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var bil = new Bil("1234567");

            string Køretøj = bil.Type();

            Assert.AreEqual("Bil", Køretøj);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
            "Nummerplade er for lang")]
        public void NummerpladeForLangExceptionTest()
        {
            Bil skoda = new Bil("12345678");
            
        }
    }
}