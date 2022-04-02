using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();

        public clsOrderCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            Int32 Index = 0;
            Int32 RecordCount = 0;
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.OrderAddress = Convert.ToString(DB.DataTable.Rows[Index]["OrderAddress"]);
                AnOrder.FinalPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["FinalPrice"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                mOrderList.Add(AnOrder);
                Index++;

            }
        }

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count {
            get
            {
                return mOrderList.Count;
            }
            set
            {
            }
        }
        public clsOrder ThisOrder { get; set; }

    


    }
}