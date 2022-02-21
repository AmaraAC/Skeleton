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
        AStaff.StaffId = Convert.ToInt32(txtStaffID.Text);
        AStaff.Role = txtRole.Text;
        AStaff.Gender = txtGender.Text;
        AStaff.JoinDate = Convert.ToDateTime(txtJoinDate.Text);

        Session["AnStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");

    }
}