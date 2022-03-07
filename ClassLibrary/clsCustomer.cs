
using System;
namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;

        public int CustomerID
        {

            get
            {

                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }

        }
        private string mCustomerName;
        public string CustomerName
        {

            get
            {
                return mCustomerName;

            }
            set
            {
                mCustomerName = value;
            }
        }

        private DateTime mDateJoined;
        public DateTime DateJoined
        {
            get
            {
                return mDateJoined;
            }
            set
            {
                mDateJoined = value;
            }
        }
        private bool mOver18;
        public bool Over18
        {
            get
            {
                return mOver18;
            }
            set
            {
                mOver18 = value;

            }
        }
        private string mGender;
        public string Gender
        {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }
        }
        private bool mMemberSubscription;
        public bool MemberSubscription
        {
            get
            {
                return mMemberSubscription;
            }
            set
            {
                mMemberSubscription = value;
            }
        }

        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", CustomerID);

            DB.Execute("sproc_tblCustomer_FilterbyCustomerID");

            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mMemberSubscription = Convert.ToBoolean(DB.DataTable.Rows[0]["MemberSubscription"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}