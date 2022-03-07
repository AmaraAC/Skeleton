using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestFinalPriceFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = anOrder.Find(OrderID);
            if (anOrder.FinalPrice != 20.25)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = anOrder.Find(OrderID);
            if (anOrder.DateAdded != Convert.ToDateTime("15/02/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDispatchedFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = anOrder.Find(OrderID);
            if (anOrder.Dispatched != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestOrderIDFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = anOrder.Find(OrderID);
            if (anOrder.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestOrderAddressFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = anOrder.Find(OrderID);
            if (anOrder.OrderAddress != "Trap Queen")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestCustomerNameFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = anOrder.Find(OrderID);
            if (anOrder.CustumerName != "Baba Tunde")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder anOrder = new clsOrder();
            Assert.IsNotNull(anOrder);

        }
        [TestMethod]
        public void DispatchedpropertOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Dispatched = TestData;
            Assert.AreEqual(AnOrder.Dispatched, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateAdded = TestData;
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 3;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void OrderAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "17 Trap Road";
            AnOrder.OrderAddress = TestData;
            Assert.AreEqual(AnOrder.OrderAddress, TestData);
        }
        [TestMethod]
        public void CustumerNamePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "Fetty Wap";
            AnOrder.CustumerName = TestData;
            Assert.AreEqual(AnOrder.CustumerName, TestData);
        }
        [TestMethod]
        public void FinalPricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Double TestData = 20.25;
            AnOrder.FinalPrice = TestData;
            Assert.AreEqual(AnOrder.FinalPrice, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 3;
            Found = AnOrder.Find(OrderID);
            Assert.IsTrue(Found);
        }
    }
}
