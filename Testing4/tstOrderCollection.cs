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
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Dispatched = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OrderAddress = "Random Street";
            TestItem.FinalPrice = 17.38;
            TestItem.CustomerName = "Howdy Partner";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Dispatched = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OrderAddress = "Random Street";
            TestItem.FinalPrice = 17.38;
            TestItem.CustomerName = "Howdy Partner";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.Dispatched = false;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OrderAddress = "XXX Street";
            TestItem.FinalPrice = 17.38;
            TestItem.CustomerName = "XXX Partner";
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Dispatched = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OrderAddress = "Random Street";
            TestItem.FinalPrice = 17.38;
            TestItem.CustomerName = "Howdy Partner";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByCustomerNameMethodOk()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            FilteredOrder.ReportByCustomerName("Bando D");
            Assert.AreEqual(0, FilteredOrder.Count);
            
        }
        [TestMethod]
        public void ReportByCustomerNameTestDataFound()
        {
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrder.ReportByCustomerName("Bando D");
            if(FilteredOrder.Count == 2)
            {
                if(FilteredOrder.OrderList[0].OrderID != 4)
                {
                    OK = false;
                }
                if(FilteredOrder.OrderList[1].OrderID != 6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        


    }
}
