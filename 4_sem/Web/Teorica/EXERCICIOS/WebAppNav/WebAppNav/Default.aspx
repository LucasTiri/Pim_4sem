<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppNav.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Pagina Principal</h1>
            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" />
            
        </div>
        <div>
            <h1>Link Button</h1>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Cadastro</asp:LinkButton>
        </div>
    </form>
</body>
</html>
