﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCust
    {
        [TestMethod]
        public void TestMethod1()
        {

            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }
    }
}
