using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCust
    {
        //good test data
        //create some test data to pass the method

        string CustomerName = "Jake";
        string DateJoined = DateTime.Now.Date.ToString();
        string Gender = "Male";
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

            if (gg.CustomerID != 1)
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

            if (gg.CustomerName != "Jake")
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

            if (gg.DateJoined != Convert.ToDateTime("07/05/2018"))
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

            if (gg.Gender != "Male")
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerName = "";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerName = "g";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void CustomerNameMinPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerName = "gg";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void CustomerNameMaxLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerName = "ggggg";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void CustomerNameMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerName = "gggggg";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void CustomerNameMaxPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            String CustomerName = "";
             CustomerName = CustomerName.PadRight(51, 'g');

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
            public void CustomerNameMid()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerName = "ggg";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void CustomerNameExtremeMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'g');

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string DateJoined = TestDate.ToString();

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
             public void DateJoinedMinLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string DateJoined = TestDate.ToString();

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
             public void DateJoinedMin()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;


            string DateJoined = TestDate.ToString();

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
             public void DateJoinedMinPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string DateJoined = TestDate.ToString();

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
             public void DateJoinedExtremeMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string DateJoined = TestDate.ToString();

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
             public void DateJoinedInvalidData()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";



            string DateJoined = "this is not a date";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMin()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string  Gender = "g";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void GenderMinPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "gg";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void GenderMaxLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "ggggg";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void GenderMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "gggggg";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void GenderMaxPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "ggggggg";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
            public void GenderMid()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "ggg";

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
            public void GenderExtremeMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "";
            Gender = Gender.PadRight(500, 'g');

            Error = gg.Valid(CustomerName, DateJoined, Gender);

            Assert.AreNotEqual(Error, "");
        }
    }

}
