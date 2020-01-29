<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblusername" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click"></asp:Button>
            <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
