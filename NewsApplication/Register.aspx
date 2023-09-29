<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="NewsApplication.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
    <title></title>
</head>
<body>
    <div class="container">
    <form id="form1" runat="server">
        <h1>Register User</h1>
        <div class="row">
            <asp:Label ID="Label1" runat="server" Text="FirstName" ></asp:Label>
            <asp:TextBox ID="firstname" runat="server" placeholder="Enter your firstname" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
            <asp:TextBox ID="lastname" runat="server" placeholder="Enter your lastname" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="email" runat="server" placeholder="Enter your email" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="password" runat="server" placeholder="Enter your password" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:Button ID="regBtn" runat="server" Text="Register" OnClick="regBtn_Click" CssClass="btn btn-primary" />
        </div>
    </form>
        </div>
</body>
</html>
