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
    }
}
