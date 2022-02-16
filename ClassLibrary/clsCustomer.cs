
using System;
namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public DateTime DateJoined { get; set; }

        public bool Over18 { get; set; }

        public string Gender { get; set; }

        public bool MemberSubscription { get; set; }
    }
}