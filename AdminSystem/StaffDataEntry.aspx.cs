
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            if (StaffID != -1)
            {
                DisplayStaff();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        String StaffID = txtStaffID.Text;
        String StaffName = txtStaffName.Text;
        String JoinDate = txtJoinDate.Text;
        String Role = txtRole.Text;
        String Gender = txtGender.Text;
        Boolean chkEighteenPlus = EighteenPlus.Checked;
        String Error = "";
        Error = AnStaff.Valid(StaffName, JoinDate,Role, Gender);
        if (Error == "")
        {
            AnStaff.StaffID = Convert.ToInt32(StaffID);
            AnStaff.StaffName = StaffName;
            AnStaff.JoinDate = Convert.ToDateTime(JoinDate);
            AnStaff.Role = Role;
            AnStaff.Gender = Gender;
            AnStaff.EighteenPlus = chkEighteenPlus;

            clsStaffCollection StaffList = new clsStaffCollection();
            if ((Convert.ToInt32(StaffID) == -1))
            {
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(Convert.ToInt32(StaffID));
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
            }
            
            Response.Redirect("StaffList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = AnStaff.Find(StaffID);
        if (Found == true)
        {
            txtStaffID.Text = AnStaff.StaffID.ToString();
            txtStaffName.Text = AnStaff.StaffName;
            txtGender.Text = AnStaff.Gender;
            txtJoinDate.Text = AnStaff.JoinDate.ToString();
            txtRole.Text = AnStaff.Role;
            EighteenPlus.Checked = AnStaff.EighteenPlus;


        }
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(StaffID);
        txtStaffID.Text = StaffBook.ThisStaff.StaffID.ToString();
        txtStaffName.Text = StaffBook.ThisStaff.StaffName;
        txtJoinDate.Text = StaffBook.ThisStaff.JoinDate.ToString();
        txtRole.Text = StaffBook.ThisStaff.Role;
        txtGender.Text = StaffBook.ThisStaff.Gender;
        EighteenPlus.Checked = StaffBook.ThisStaff.EighteenPlus;
    }
}
