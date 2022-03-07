using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff)Session["AnStaff"];
        Response.Write(AStaff.StaffName);
        Response.Write(AStaff.Gender);
        Response.Write(AStaff.JoinDate);
        Response.Write(AStaff.StaffID);
        Response.Write(AStaff.StaffName);
        Response.Write(AStaff.Role);



    }
}