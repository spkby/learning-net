<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="HandlerCaptcha.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Handler2.ashx?img=1"/>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Handler2.ashx?img=2"/>
            <asp:Image ID="Image3" runat="server" ImageUrl="~/Handler2.ashx?img=3"/>
        </div>
    </form>
</body>
</html>
