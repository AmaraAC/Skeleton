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

            //Int32 Index = 0;

            //Int32 RecordCount = 0;

            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);

           // RecordCount = DB.Count;

           /// while (Index < RecordCount)
            //{
               // clsCustomer gg = new clsCustomer();

             //   gg.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
             //   gg.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
              //  gg.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
              //  gg.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
              //  gg.MemberSubscription = Convert.ToBoolean(DB.DataTable.Rows[Index]["MemberSubcription"]);
              //  gg.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over18"]);

              //  mCustomerList.Add(gg);

               // Index++;


           // }
        }
        public List<clsCustomer> CustomerList
        {
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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@Gender", mThisCustomer.Gender);
            DB.AddParameter("@MemberSubscription", mThisCustomer.MemberSubscription);
            DB.AddParameter("@Over18", mThisCustomer.Over18);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);

            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@Gender", mThisCustomer.Gender);
            DB.AddParameter("@MemberSubscription", mThisCustomer.MemberSubscription);
            DB.AddParameter("@Over18", mThisCustomer.Over18);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);

            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", CustomerName);
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
             PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            mCustomerList = new List<clsCustomer>();



            while (Index < RecordCount)
            {
                clsCustomer gg = new clsCustomer();

                gg.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                gg.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                gg.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                gg.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                gg.MemberSubscription = Convert.ToBoolean(DB.DataTable.Rows[Index]["MemberSubcription"]);
                gg.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over18"]);

                mCustomerList.Add(gg);

                Index++;


            }
        }
    }
}