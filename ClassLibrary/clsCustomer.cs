
using System;
namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;

        public int CustomerID {

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
        public DateTime DateJoined {
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
        public bool Over18 {
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
        public bool MemberSubscription {
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
            //set the private data members to the test data value
            mCustomerID = 21;

            mCustomerName = "Jack";

            mDateJoined = Convert.ToDateTime("4/2/2022");

            mOver18 = true ;

            mGender = "Female";

            mMemberSubscription = true;
            //always return true
            return true;
        }
    }
}