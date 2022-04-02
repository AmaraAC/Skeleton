using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstaceOK()
        {
            clsOrderCollection allOrders = new clsOrderCollection();
            Assert.IsNotNull(allOrders);
        }
        [TestMethod]
        public void OrderlistOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Dispatched = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OrderAddress = "Random Street";
            TestItem.FinalPrice = 17.38;
            TestItem.OrderID = 1;
            TestItem.CustomerName = "Howdy Partner";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Dispatched = true;
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.OrderAddress = "Random Street";
            TestOrder.FinalPrice = 17.38;
            TestOrder.OrderID = 1;
            TestOrder.CustomerName = "Howdy Partner";
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Dispatched = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OrderAddress = "Random Street";
            TestItem.FinalPrice = 17.38;
            TestItem.OrderID = 1;
            TestItem.CustomerName = "Howdy Partner";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }


    }
}
