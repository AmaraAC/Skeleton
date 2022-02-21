<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer Identification  "></asp:Label>
            &nbsp;<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="144px"></asp:Label>
        &nbsp;<asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateJoined" runat="server" Text="Date Joined   " width="144px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDateJoined" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblGender" runat="server" Text="Gender    " width="144px"></asp:Label>
&nbsp;<asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chk18" runat="server" Text="Over 18" width="144px" />
        </p>
        <p>
            <asp:CheckBox ID="chkMemberSubscription" runat="server" Text="Are you a Subscibed Member?" width="144px" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
