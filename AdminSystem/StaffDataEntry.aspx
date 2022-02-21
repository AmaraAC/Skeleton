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
        </p>
        <asp:Label ID="StaffName" runat="server" Text="Staff Name  " width="102px"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="JoinDate" runat="server" Text="Date  " width="102px"></asp:Label>
            <asp:TextBox ID="txtJoinDate" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Role" runat="server" Text="Role  " width="102px"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server" Height="16px"></asp:TextBox>
        <p>
            <asp:Label ID="Gender" runat="server" Text="Gender  " width="102px"></asp:Label>
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="EighteenPlus" runat="server" Text="Age  " width="102px"></asp:Label>
            <asp:CheckBox ID="chkEighteenPlus" runat="server" Text="18+" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
