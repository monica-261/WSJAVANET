<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cliente.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Resultado" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="ParX" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:TextBox ID="ParY" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Mult" runat="server" Text="Multiplicar" OnClick="Mult_Click" style="height: 26px" />
        <asp:Button ID="Suma" runat="server" Text="Sumar" />
    
    </div>
    </form>
</body>
</html>
