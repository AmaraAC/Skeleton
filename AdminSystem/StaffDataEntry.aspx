<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblStaff" runat="server" Text="StaffID Number  "></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text=" Find" />
        </p>
        <asp:Label ID="lblStaffName" runat="server" Text="Staff Name  " width="102px"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblJoinDate" runat="server" Text="Date  " width="102px"></asp:Label>
            <asp:TextBox ID="txtJoinDate" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblRole" runat="server" Text="Role  " width="102px"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server" Height="16px"></asp:TextBox>
        <p>
            <asp:Label ID="lblGender" runat="server" Text="Gender  " width="102px"></asp:Label>
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="chkEighteenPlus" runat="server" Text="Age  " width="102px"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="18+" OnCheckedChanged="CheckBox1_CheckedChanged" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
