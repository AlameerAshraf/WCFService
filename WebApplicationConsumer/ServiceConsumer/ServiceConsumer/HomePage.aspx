<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ServiceConsumer.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Height="234px" Width="470px"></asp:TextBox>
    
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="put" />
        <asp:Button ID="Button3" runat="server" Text="Dele" OnClick="Button3_Click" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="post" />
        <br />
    
    </div>
    </form>
</body>
</html>
