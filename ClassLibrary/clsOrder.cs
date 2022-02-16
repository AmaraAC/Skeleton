using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Dispatched { get; set; }
        public DateTime DateAdded { get; set; }
        public int OrderID { get; set; }
        public string OrderAddress { get; set; }
        public string CustumerName { get; set; }
        public double FinalPrice { get; set; }

        public clsOrder()
        {
        }
    }
}