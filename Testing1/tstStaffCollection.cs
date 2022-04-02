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
        
        

    }
}
