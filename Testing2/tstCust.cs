using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCust
    {
        [TestMethod]
        public void InstanceOk()
        {

            clsCustomer acustomer = new clsCustomer();

            Assert.IsNotNull(acustomer);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer acustomer = new clsCustomer();

            int gt = 9;

                acustomer.CustomerID = gt;

            Assert.AreEqual(acustomer.CustomerID, gt);
        }
        [TestMethod]
        public void CustomerNamePropertyOk()
        {
            clsCustomer acustomer = new clsCustomer();

            String gt = "luke";

            acustomer.CustomerName = gt;

            Assert.AreEqual(acustomer.CustomerName, gt);
        }
        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            clsCustomer acustomer = new clsCustomer();

            DateTime gt = DateTime.Now.Date; 

                acustomer.DateJoined = gt ;

            Assert.AreEqual(acustomer.DateJoined, gt);
        }
        [TestMethod]
        public void Over18PropertyOK()
        {
            clsCustomer acustomer = new clsCustomer();

            Boolean gt = true;

               acustomer.Over18 = gt;

            Assert.AreEqual(acustomer.Over18, gt);
        }
        [TestMethod]
        public void GenderPropertyOk()
        {
            clsCustomer acustomer = new clsCustomer();

            String gt = "Female";

            acustomer.Gender = gt;

            Assert.AreEqual(acustomer.Gender, gt);
        }
        [TestMethod]
        public void MemberSubscriptionPropertyOk()
        {
            clsCustomer acustomer = new clsCustomer();

            Boolean gt = true;

            acustomer.MemberSubscription = gt;

            Assert.AreEqual(acustomer.MemberSubscription, gt);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer acustomer = new clsCustomer();

            Boolean Found = false;

            Int32 CustomerID = 1;

            Found = acustomer.Find(CustomerID);

            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = gg.Find(CustomerID);

            if (gg.CustomerID != 3)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = gg.Find(CustomerID);

            if (gg.CustomerName != "Jack")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateJoinedFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = gg.Find(CustomerID);

            if (gg.DateJoined != Convert.ToDateTime("4/2/2022"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOver18Found()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = gg.Find(CustomerID);

            if (gg.Over18 != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestGenderFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = gg.Find(CustomerID);

            if (gg.Gender != "Female")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestMemberSubscriptionFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = gg.Find(CustomerID);

            if (gg.MemberSubscription != true )
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
