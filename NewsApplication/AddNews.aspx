<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="NewsApplication.AddNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
    <title></title>
</head>
<body>
   <div class="container  align-items-center align-content-center">
    <form id="form1" runat="server" class="form-control justify-content-center align-items-center">
        <h1>Add News</h1>
        <div class="row justify-content-center align-content-center align-items-md-center">
            <asp:Label ID="Label1" runat="server" Text="News Title" ></asp:Label>
            <asp:TextBox ID="title" runat="server" placeholder="Title" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Subtitle"></asp:Label>
            <asp:TextBox ID="Subtitle" runat="server" placeholder="Subtitle" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="Content" runat="server" placeholder="Enter your Content" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="ImageUrl"></asp:Label>
            <asp:TextBox ID="Imageurl" runat="server" placeholder="Enter Image Url"  CssClass="form-control"></asp:TextBox>
            <asp:Button ID="Add" runat="server" Text="Add"  OnClick="Add_Click" />
        </div>
    </form>
        </div>
</body>
</html>
