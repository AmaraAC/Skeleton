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

        public string Valid(string StaffName, string JoinDate, string Role, string Gender)
        {
            String Error = "";
            DateTime DateTemp;
            if (StaffName.Length == 0)
            {
                Error = Error + "The Staff Name may not be blank : ";

            }
            if (StaffName.Length > 50)
            {
                Error = Error + "The Staff Name must be less than 50 chracters : ";

            }
            if(Role.Length == 0)
            {
                Error = Error + "The Role may not be blank : ";

            }
            if (Role.Length > 50)
            {
                Error = Error + "The Role must be less than 50 chracters : ";

            }
            if (Gender.Length == 0)
            {
                Error = Error + "The Role may not be blank : ";

            }
            if (Gender.Length > 50)
            {
                Error = Error + "The Gender must be less than 50 chracters : ";

            }
            try
            {
                DateTemp = Convert.ToDateTime(JoinDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The dae cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            return Error;

        }
    }
}
