using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        clsOrder mThisOrder = new clsOrder();
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
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@FinalPrice", mThisOrder.FinalPrice);
            DB.AddParameter("@Dispatched", mThisOrder.Dispatched);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);

            DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@FinalPrice", mThisOrder.FinalPrice);
            DB.AddParameter("@Dispatched", mThisOrder.Dispatched);
            DB.Execute("sproc_tblOrder_Update");

        }
    }
}