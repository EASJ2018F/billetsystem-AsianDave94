﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            var mc = new MC("1234567", DateTime.Today);

            int Pris = mc.Pris(125);

            Assert.AreEqual(125, Pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var mc = new MC("1234567", DateTime.Today);

            string Køretøj = mc.Type();

            Assert.AreEqual("MC", Køretøj);
        }
    }
}