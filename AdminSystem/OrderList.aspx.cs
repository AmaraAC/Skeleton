using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayAddresses();
        }
    }

     void DisplayAddresses()
    {
        clsOrderCollection Order = new clsOrderCollection();
        lstOrderList.DataSource = Order.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CustomerName";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if(lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please Select a record to edit from the list";
        }

    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if(lstOrderList.SelectedIndex != - 1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ReportByCustomerName(txtFilter.Text);
        lstOrderList.DataSource = Order.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "CustomerName";
        lstOrderList.DataBind();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ReportByCustomerName("");
        txtFilter.Text = "";
        lstOrderList.DataSource = Order.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "CustomerName";
        lstOrderList.DataBind();
    }
}