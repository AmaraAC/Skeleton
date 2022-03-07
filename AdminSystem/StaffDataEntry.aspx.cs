
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
        clsStaff AStaff = new clsStaff();
        AStaff.StaffName = txtStaffName.Text;
        AStaff.EighteenPlus = chkEighteenPlus.Checked;
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AStaff.Role = txtRole.Text;
        AStaff.Gender = txtGender.Text;
        AStaff.JoinDate = Convert.ToDateTime(txtJoinDate.Text);

        Session["AnStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");

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
            CheckBox1.Checked = AnStaff.EighteenPlus;


        }
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}
