using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
      

        public clsCustomerCollection()
        {
            //clsDataConnection DB = new clsDataConnection();
            clsCustomer gg = new clsCustomer();


            gg.CustomerID = 1;
            gg.CustomerName = "Jake";
            gg.DateJoined = DateTime.Now.Date;
            gg.Gender = "Male";
            gg.MemberSubscription = true;
            gg.Over18 = true;

            mCustomerList.Add(gg);

            gg = new clsCustomer();

            gg.CustomerID = 2;
            gg.CustomerName = "Joe";
            gg.DateJoined = DateTime.Now.Date;
            gg.Gender = "Female";
            gg.MemberSubscription = true;
            gg.Over18 = true;

            mCustomerList.Add(gg);


        }
        public List<clsCustomer> CustomerList {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            } 
        }
        public clsCustomer ThisCustomer { get; set; }
        public int Count 
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
    }
}