<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnviaDados.aspx.cs" Inherits="Navegacao.EnviaDados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/RecebDados.aspx">Enviar</asp:LinkButton>
        </div>
    </form>
</body>
</html>
