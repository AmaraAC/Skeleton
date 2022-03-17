using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        string CustomerName = "Fetty Wap";
        string OrderAdress = "11 Trap Queen";
        string DateAdded = DateTime.Now.Date.ToString();



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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);
            Assert.AreEqual(Error, "");

        }
        public void OrderAddressMinLessOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string OrderAddress = "";

            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderAddressNameMin()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string OrderAddress = "g";

            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);        Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderAddressMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string OrderAddress = "gg";

            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);        Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderAddressMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string OrderAddress = "ggggg";

            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);        Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderAddressMax()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string OrderAddress = "gggggg";

            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);        Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderAddressMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string OrderAddress = "";
            OrderAddress.PadRight(51, 'g');
            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);        Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderAddressMid()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string OrderAddress = "ggg";

            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);          

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderAddressExtremeMax()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string OrderAddress = "";
            OrderAddress = OrderAddress.PadRight(500, 'g');

            Error = anOrder.Valid(OrderAddress, CustomerName, DateAdded);          

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string DateAdded = TestDate.ToString();

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);            

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string DateAdded = TestDate.ToString();

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);            

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;


            string DateAdded = TestDate.ToString();

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);           

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string DateAdded = TestDate.ToString();

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);                  
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string DateAdded = TestDate.ToString();

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);              
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string DateAdded = "this is not a date";

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);           

            Assert.AreNotEqual(Error, "");
        }
       [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string CustomerName = "";

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string CustomerName = "g";

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded); 
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string CustomerName = "gg";

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded); 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string CustomerName = "ggggg";

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded); 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string CustomerName = "gggggg";

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded); 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string CustomerName = "";
            CustomerName.PadRight(51, 'g');
            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded); 

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string CustomerName = "ggg";

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'g');

            Error = anOrder.Valid(OrderAdress, CustomerName, DateAdded);

            Assert.AreNotEqual(Error, "");
        }

    }


}

