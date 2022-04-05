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
            DisplayCustomer();
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection AnOrderBook = new clsCustomerCollection();
        AnOrderBook.ThisCustomer.Find(CustomerID);
        txtCustomerName.Text = AnOrderBook.ThisCustomer.CustomerName;
        txtDateJoined.Text = AnOrderBook.ThisCustomer.DateJoined.ToString();
        txtGender.Text = AnOrderBook.ThisCustomer.Gender.ToString();
      
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