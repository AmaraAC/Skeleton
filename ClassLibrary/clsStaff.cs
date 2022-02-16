using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        public clsStaff()
        {
        }

        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public DateTime JoinDate { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
        public bool EighteenPlus { get; set; }
    }
}