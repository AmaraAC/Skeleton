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
        //capture the fields
        string CustomerName= txtCustomerName.Text;
        string DateJoined =txtDateJoined.Text;
        string Gender = txtGender.Text;

        string Error = "";

        Error = gg.Valid(CustomerName,DateJoined,Gender);
        if(Error == "")
        {
            gg.CustomerName = CustomerName;
                gg.DateJoined = Convert.ToDateTime(DateJoined);
                gg.Gender = Gender;
            //store the id in the session object
            Session["An ID"] = gg;

            //navigate to the viewer page
            Response.Redirect("CustViewer.aspx");
        }
      else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer gg = new clsCustomer();

        Int32 CustomerID;

        Boolean Found = false;

        CustomerID = Convert.ToInt32(txtCustomerID.Text);

        Found = gg.Find(CustomerID);

        if (Found == true)
        {
            
            txtCustomerName.Text = gg.CustomerName;
            txtDateJoined.Text = gg.DateJoined.ToString();
            txtGender.Text = gg.Gender;
            chk18.Checked=gg.Over18;
            chkMemberSubscription.Checked = gg.MemberSubscription;
        

        }

    }
}