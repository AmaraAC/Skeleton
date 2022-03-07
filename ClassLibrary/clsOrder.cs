using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private DateTime mDateTime;
        private Double mFinalPrice;
        private Int32 mOrderID;
        private Boolean mDispatched;
        private String mOrderAddress;
        private String mCustomerName;
        public bool Dispatched
        {
            get
            {
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateTime;
            }
            set
            {
                mDateTime = value;
            }
        }

        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        public string OrderAddress
        {
            get
            {
                return mOrderAddress;
            }
            set
            {
                mOrderAddress = value;
            }
        }
        public string CustumerName
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
        public Double FinalPrice
        {
            get
            {
                return mFinalPrice;
            }


            set
            {
                mFinalPrice = value;

            }
        }

        public clsOrder()
        {
        }

        public bool Find(Int32 OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterbyOrderID");
            if (DB.Count == 1)
            {
                mDateTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mFinalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["FinalPrice"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                mOrderAddress = Convert.ToString(DB.DataTable.Rows[0]["OrderAddress"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}


