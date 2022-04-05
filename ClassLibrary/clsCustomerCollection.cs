using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            
            clsDataConnection DB = new clsDataConnection();

            Int32 Index = 0;

            Int32 RecordCount = 0;

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
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

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

        public int Add()
        {
            mThisCustomer.CustomerID = 123;

            return mThisCustomer.CustomerID;
        }
    }
}