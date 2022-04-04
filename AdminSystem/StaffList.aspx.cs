﻿using System;
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
            DisplayStaffs();
        }
    }
    void DisplayStaffs()
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        lstStaffList.DataSource = Staffs.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";

        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != 1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";

        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByStaffName(txtFilter.Text);
        lstStaffList.DataSource = Staffs.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();


    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByStaffName("");
        txtFilter.Text = "";
        lstStaffList.DataSource = Staffs.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }
}