using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }


        private Int32 mStaffID;
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }


        private string mStaffName;
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }

        private DateTime mJoinDate;
        public DateTime JoinDate
        {
            get
            {
                return mJoinDate;
            }
            set
            {
                mJoinDate = value;
            }

        }


        private string mRole;
        public string Role
        {
            get
            {
                return mRole;
            }
            set
            {
                mRole = value;
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


        private Boolean mEighteenPlus;
        public bool EighteenPlus
        {
            get
            {
                return mEighteenPlus;
            }
            set
            {
                mEighteenPlus = value;
            }
        }




        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mJoinDate = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinDate"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mEighteenPlus = Convert.ToBoolean(DB.DataTable.Rows[0]["EighteenPlus"]);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
