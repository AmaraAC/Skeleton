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
        public string Valid(string OrderAdress, string CustomerName, string DateAdded)
        {
            String Error = "";
            DateTime DateTemp;
            if (OrderAdress.Length == 0)
            {
                Error = Error + "The Order Address may not be empty :";
            }
            if (OrderAdress.Length > 50)
            {
                Error = Error + "The order Address must be less than 50 characters";
            }
            if (CustomerName.Length == 0)
            {
                Error = Error + "The Customer Name must may not be empty :";
            }
            if (CustomerName.Length > 50)
            {
                Error = Error + "The Customer Name must be less than 50 characters";
            }
            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Date cannt be in the past";
                }
                if (DateTemp > DateTime.Now.Date)
                {

                    Error = Error + "The Date cannot be in the future :";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date ;";
            }
            return Error;

        }

    }
}


