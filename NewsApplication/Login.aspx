<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NewsApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous"/>
    <title></title>
</head>
<body>
    <div class="container">
    <form id="form1" runat="server">
        <h1>Login User</h1>
        <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
        <div class="row">
            <asp:Label ID="Label3" runat="server" Text="Email" ></asp:Label>
            <asp:TextBox ID="email" runat="server" placeholder="Enter your email" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="password" runat="server" placeholder="Enter your password" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:Button ID="loginBtn" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="loginBtn_Click" />
        </div>
    </form>
        </div>
</body>
</html>
