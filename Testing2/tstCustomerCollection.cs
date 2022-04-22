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
            TestItem.CustomerName = "Jake";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Gender = "Male";
            TestItem.MemberSubscription = true;
            TestItem.Over18 = true;

            TestList.Add(TestItem);
            gg.CustomerList = TestList;
            Assert.AreEqual(gg.CustomerList, TestList);
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

        [TestMethod]

        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jake";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Gender = "Male";
            TestItem.MemberSubscription = true;
            TestItem.Over18 = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Over18 = true;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.CustomerName = "Jane Janet";
            TestItem.MemberSubscription = false;
            TestItem.Gender = "Female";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();

            TestItem.Over18 = false;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.CustomerName = "Janet Jane";
            TestItem.MemberSubscription = true;
            TestItem.Gender = "Male";

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 1;
            TestItem.Over18 = true;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.CustomerName = "Jane Janet";
            TestItem.MemberSubscription = false;
            TestItem.Gender = "Female";

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomerCollection FilteredNames = new clsCustomerCollection();

            FilteredNames.ReportByCustomerName("");

            Assert.AreEqual(AllCustomers.Count, FilteredNames.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameTestDataFound()
        {
            clsCustomerCollection FilteredNames = new clsCustomerCollection();

            Boolean ok = true;

            FilteredNames.ReportByCustomerName("Sparrow Finch");

            if (FilteredNames.Count == 2)
            {

                if (FilteredNames.CustomerList[0].CustomerID != 12)
                {
                    ok = false;
                }
                if (FilteredNames.CustomerList[1].CustomerID != 18)
                {
                    ok = false;
                }
            }
            else
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
    }
}