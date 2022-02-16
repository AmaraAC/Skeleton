using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);



        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 3;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see the twp values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }
        [TestMethod]
        public void JoinDatePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.JoinDate = TestData;
            Assert.AreEqual(AnStaff.JoinDate, TestData);
        }
        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = " ADE ";
            //assign the data to the property
            AnStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffName, TestData);
        }
        [TestMethod]
        public void RolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "User";
            //assign the data to the property
            AnStaff.Role = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Role, TestData);
        }
        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Male";
            //assign the data to the property
            AnStaff.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Gender, TestData);
        }
        [TestMethod]
        public void EighteenPlusPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.EighteenPlus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.EighteenPlus, TestData);
        }





    }
}
