using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();

        CustomerBook.ThisCustomer.Find(CustomerID);

        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        txtDateJoined.Text = CustomerBook.ThisCustomer.DateJoined.ToString();
        txtGender.Text = CustomerBook.ThisCustomer.Gender;
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        chk18.Checked = CustomerBook.ThisCustomer.Over18;
        chkMemberSubscription.Checked = CustomerBook.ThisCustomer.MemberSubscription;

      
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer gg = new clsCustomer();
        //capture the fields
        string CustomerName= txtCustomerName.Text;
        string DateJoined =txtDateJoined.Text;
        string Gender = txtGender.Text;

        string Error = "";

        Error = gg.Valid(CustomerName,DateJoined,Gender);
        if(Error == "")
        {

            gg.CustomerID = CustomerID;
            gg.CustomerName = CustomerName;
                gg.DateJoined = Convert.ToDateTime(DateJoined);
                gg.Gender = Gender;
            gg.Over18 = chk18.Checked;
            gg.MemberSubscription = chkMemberSubscription.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = gg;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);

                CustomerList.ThisCustomer = gg;

                CustomerList.Update();
            }

            Response.Redirect("CustList.aspx");
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