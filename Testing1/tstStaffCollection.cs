using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void InstanceOk()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Assert.IsNotNull(AllStaffs);

        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.EighteenPlus = true;
            TestItem.StaffID = 1;
            TestItem.JoinDate = DateTime.Now.Date;
            TestItem.Gender = "Male";
            TestItem.Role = "User";
            TestItem.StaffName = "Robert Smiths";
            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.StaffList, TestList);

        }
        
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.EighteenPlus = true;
            TestStaff.StaffID = 1;
            TestStaff.JoinDate = DateTime.Now.Date;
            TestStaff.Gender = "Male";
            TestStaff.Role = "User";
            TestStaff.StaffName = "Robert Smiths";
            AllStaffs.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.EighteenPlus = true;
            TestItem.StaffID = 1;
            TestItem.JoinDate = DateTime.Now.Date;
            TestItem.Gender = "Male";
            TestItem.Role = "User";
            TestItem.StaffName = "Robert Smiths";
            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.EighteenPlus = false;
            TestItem.StaffID = 21;
            TestItem.JoinDate = DateTime.Now.Date;
            TestItem.Gender = "FEMALE";
            TestItem.Role = "User";
            TestItem.StaffName = "Ali Baba";
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.EighteenPlus = true;
            TestItem.StaffID = 20;
            TestItem.JoinDate = DateTime.Now.Date;
            TestItem.Gender = "MALE";
            TestItem.Role = "Administrator";
            TestItem.StaffName = "MO Seller";
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffID = PrimaryKey;
            TestItem.EighteenPlus = false;
            TestItem.StaffID = 12;
            TestItem.JoinDate = DateTime.Now.Date;
            TestItem.Gender = "FEMALE";
            TestItem.Role = "User";
            TestItem.StaffName = "Ali Sellers";
            AllStaffs.ThisStaff = TestItem;
            AllStaffs.Update();
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.EighteenPlus = true;
            TestItem.StaffID = 20;
            TestItem.JoinDate = DateTime.Now.Date;
            TestItem.Gender = "MALE";
            TestItem.Role = "Administrator";
            TestItem.StaffName = "MO Seller";
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            AllStaffs.Delete();
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByStaffNameMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            FilteredStaffs.ReportByStaffName("");
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);

        }
        [TestMethod]
        public void ReportByStaffIDNoneFound()
        {
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            FilteredStaffs.ReportByStaffName("xxx xxx");
            Assert.AreEqual(0, FilteredStaffs.Count);
        }
        [TestMethod]
        public void ReportByStaffNameTestDataFound()
        {
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaffs.ReportByStaffName("yyy yyy");
            if (FilteredStaffs.Count == 2)
            {
                if (FilteredStaffs.StaffList[0].StaffID != 13)
                {
                    OK = false;
                }
                if(FilteredStaffs.StaffList[1].StaffID != 15)
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
