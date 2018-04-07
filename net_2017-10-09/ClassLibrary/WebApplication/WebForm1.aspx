<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="A"></asp:Label>
            <asp:TextBox ID="TextBoxAx" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBoxAy" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="B"></asp:Label>
            <asp:TextBox ID="TextBoxBx" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBoxBy" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="C"></asp:Label>
            <asp:TextBox ID="TextBoxCx" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBoxCy" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            Perimetr&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelP" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            Aera&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelS" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
