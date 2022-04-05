using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
      

        public clsCustomerCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsCustomer gg = new clsCustomer();

                gg.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                gg.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                gg.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                gg.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                gg.MemberSubscription = Convert.ToBoolean(DB.DataTable.Rows[Index]["MemberSubscription"]);
                gg.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over18"]);

                mCustomerList.Add(gg);

                Index++;


                //gg.CustomerID = 1;
                //gg.CustomerName = "Jake";
                //gg.DateJoined = DateTime.Now.Date;
                //gg.Gender = "Male";
                //gg.MemberSubscription = true;
                //gg.Over18 = true;
                //mCustomerList.Add(gg);
                //.............
                //gg = new clsCustomer();

                //gg.CustomerID = 2;
                //gg.CustomerName = "Joe";
                //gg.DateJoined = DateTime.Now.Date;
                //gg.Gender = "Female";
                //gg.MemberSubscription = true;
                //gg.Over18 = true;
                //mCustomerList.Add(gg);
            }
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