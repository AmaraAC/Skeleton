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
        //create a new instance of clsAddress
        clsCustomer gg = new clsCustomer();
        //capture the customerid
        gg.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        gg.CustomerName = txtCustomerName.Text;
        gg.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
        gg.Over18 = chk18.Checked;
        gg.Gender = txtGender.Text;
        gg.MemberSubscription = chkMemberSubscription.Checked;
        //store the id in the session object
        Session["An ID"] = gg;
        //navigate to the viewer page
        Response.Redirect("CustViewer.aspx");
    }
}