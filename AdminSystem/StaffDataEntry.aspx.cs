
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        String StaffName = txtStaffName.Text;
        String StaffID = txtStaffID.Text;
        String Role = txtRole.Text;
        String EighteenPlus = chkEighteenPlus.Text;
        String Gender = txtGender.Text;
        String JoinDate = txtJoinDate.Text;
        String Error = "";
        Error = AnStaff.Valid(StaffName, JoinDate,Role, Gender);
        if (Error == "")
        {
            AnStaff.Role = Role;
            AnStaff.Gender = Gender;
            AnStaff.StaffName = StaffName;
            AnStaff.JoinDate = Convert.ToDateTime(JoinDate);
            AnStaff.StaffID = Convert.ToInt32(StaffID);
            AnStaff.EighteenPlus = Convert.ToBoolean(EighteenPlus);

            Session["AnStaff"] = AnStaff;
            Response.Write("StaffViewer.aspx");

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
}
