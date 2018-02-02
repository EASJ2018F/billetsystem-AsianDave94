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
            var bil = new Bil();

            int Pris = bil.Pris();

            Assert.AreEqual(240, Pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var bil = new Bil();

            string Køretøj = bil.Type();

            Assert.AreEqual("Bil", Køretøj);
        }
    }
}