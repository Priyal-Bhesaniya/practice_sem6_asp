<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addition.aspx.cs" Inherits="practice_sem6_asp.net.Addition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server" Text="Num1"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Num 2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Addition" />
        </p>
    </form>
</body>
</html>
