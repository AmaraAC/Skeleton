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
        clsCustomer gg = new clsCustomer();
        gg = (clsCustomer)Session["An ID"];
        Response.Write(gg.CustomerID);
        Response.Write(gg.CustomerName);
        Response.Write(gg.DateJoined);
        Response.Write(gg.Over18);
        Response.Write(gg.Gender);
        Response.Write(gg.MemberSubscription);
    }
}