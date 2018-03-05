﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soap.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetNameSoapTest()
        {
            Service1 s1 = new Service1();

            var expectedResult = s1.GetNameSoap();



            Assert.AreEqual(expectedResult, "Gordon");
        }
    }
}