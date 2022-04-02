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

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Navigate to the viwer page
        clsOrder AnOrder = new clsOrder();
        String DateAdded = txtDateAdded.Text;
        String OrderAddress = txtOrderAddress.Text;
        String CustomerName = txtCustomerName.Text;
        string Error = "";
        Error = AnOrder.Valid(OrderAddress, CustomerName, DateAdded);
        if (Error == "")
        {
            AnOrder.OrderAddress = OrderAddress;
            AnOrder.CustomerName = CustomerName;
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsOrder anOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = anOrder.Find(OrderID);
        if (Found == true)
        {
            txtCustomerName.Text = anOrder.CustomerName;
            txtDateAdded.Text = anOrder.DateAdded.ToString();
            txtFinalPrice.Text = anOrder.FinalPrice.ToString();
            txtOrderAddress.Text = anOrder.OrderAddress;
            chkDispatched.Checked = anOrder.Dispatched;

        }
    }
}
