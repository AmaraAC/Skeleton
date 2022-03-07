<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" style="margin-left: 49px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="margin-left: 17px" Text="Find" Width="96px" />
        </div>
        <asp:Label ID="lblOrderAddress" runat="server" Text="Order Address"></asp:Label>
        <asp:TextBox ID="txtOrderAddress" runat="server" style="margin-left: 14px"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 31px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomer" runat="server" Text="Customer Name"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="margin-left: 3px"></asp:TextBox>
        <p>
            <asp:Label ID="lblFinalPrice" runat="server" Text="Final Price"></asp:Label>
            <asp:TextBox ID="txtFinalPrice" runat="server" style="margin-left: 41px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkDispatched" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Dispatched" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="49px" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
