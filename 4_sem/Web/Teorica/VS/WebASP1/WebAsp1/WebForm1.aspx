<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAsp1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="lblNome" runat="server" Text="nome" Font-Size="XX-Large"></asp:Label>
            </p>
            <asp:TextBox ID="TextBox1" runat="server" Font-Size="X-Large"></asp:TextBox>
            <br />
            <asp:Button ID="btnMessage" runat="server" Text="Button" Font-Size="X-Large" OnClick="btnMessage_Click" />
            <p>
                <asp:Label ID="lblMessage" runat="server" Text="Label" Font-Bold="True" Font-Names="Arial" Font-Size="XX-Large" ForeColor="#CC0000"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
