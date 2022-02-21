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
        AnOrder.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AnOrder.Dispatched = chkDispatched.Checked;
        AnOrder.OrderAddress = txtOrderAddress.Text;
        AnOrder.FinalPrice = Convert.ToDouble(txtFinalPrice.Text);
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
        AnOrder.CustumerName = txtCustomerName.Text;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}