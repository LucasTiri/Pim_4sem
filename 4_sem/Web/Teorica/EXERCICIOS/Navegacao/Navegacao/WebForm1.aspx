<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Navegacao.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>HOME</h1>
            
            <h3>Exemplo de hyperlink</h3>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm2.aspx">HyperLink</asp:HyperLink>
            <asp:LinkButton ID="LinkButton1" runat="server">Contato</asp:LinkButton>
        </div>
    </form>
</body>
</html>
