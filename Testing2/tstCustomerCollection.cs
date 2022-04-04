using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;


namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection gg = new clsCustomerCollection();

            Assert.IsNotNull(gg);
        }

        [TestMethod]
        public void CustomerListOK()
        {

            clsCustomerCollection gg = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerID = 1;
            TestItem.CustomerName= "Jake";
            TestItem.DateJoined= DateTime.Now.Date;
            TestItem.Gender="Male";
            TestItem.MemberSubscription= true;
            TestItem.Over18= true;

            TestList.Add(TestItem);
            gg.CustomerList = TestList;
            Assert.AreEqual(gg.CustomerList,TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsCustomerCollection gg = new clsCustomerCollection();

            Int32 SomeCount = 2;

            gg.Count = SomeCount;

            Assert.AreEqual(gg.Count, SomeCount);

        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection gg = new clsCustomerCollection();

            clsCustomer testg = new clsCustomer();

            testg.CustomerID = 1;
            testg.CustomerName = "Jake";
            testg.DateJoined = DateTime.Now.Date;
            testg.Gender = "Male";
            testg.MemberSubscription = true;
            testg.Over18 = true;

            gg.ThisCustomer = testg;

            Assert.AreEqual(gg.ThisCustomer, testg);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            clsCustomerCollection gg = new clsCustomerCollection();

            List<clsCustomer> testg = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();


            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jake";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Gender = "Male";
            TestItem.MemberSubscription = true;
            TestItem.Over18 = true;

            testg.Add(TestItem);

            gg.CustomerList = testg;

            Assert.AreEqual(gg.Count, testg.Count);

        }
    }
}
