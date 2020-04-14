<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Shivam.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblUser" runat="server" Text="Username :"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPswd" runat="server" Text="Password :"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtPswd" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="LogIn" runat="server" Text="Log In" OnClick="LogIn_Click" />
    </form>
</body>
</html>
