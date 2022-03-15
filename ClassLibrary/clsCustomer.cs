
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
                mMemberSubscription = Convert.ToBoolean(DB.DataTable.Rows[0]["MemberSubcription"]);
                return true;
            }
            else
            {

                return false;
            }
        }
        public string Valid(string CustomerName, string DateJoined, string Gender)
        {

            String Error = "";

            DateTime DateTemp;

            //if CustomerName is blank
             if(CustomerName.Length==0)
            {
                Error = Error + "Your Customer Name may not be blank";
            }
             if(CustomerName.Length>6)
            {
                Error = Error + "Your Customer Name may not be blank";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateJoined);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";

                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";

            }
            if (Gender.Length == 0)
            {
                //record the error
                Error = Error + "The street may not be blank : ";
            }
            //if the gender is too long
            if (Gender.Length > 6)
            {
                //record the error
                Error = Error + "The street must be less than 50 characters : ";
            }


            return Error;
        }
    }
}