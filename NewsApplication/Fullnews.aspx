<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fullnews.aspx.cs" Inherits="NewsApplication.Fullnews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
</head>
<body>
    <nav class="navbar navbar-light bg-light">
        <div class="container-fluid">
            <a class="navbar-brand" href="Home.aspx">News App</a>
            
            <form id="form1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Add News" CssClass="btn btn-outline-success"/>
            </form>
        </div>
    </nav>
    <div class="container">
        <div class="row justify-content-center">
            
            <div class="col-4">
                <asp:Image ID="Image1" runat="server" />
            </div>
            <div class="col-8">
                <h4><small>RECENT POSTS</small></h4>
                <hr />
                <h2>
                <asp:Label ID="LabelTitle" runat="server" Text=""></asp:Label>
                </h2>
                <h5><span class="glyphicon glyphicon-time"></span>Post by <asp:Label ID="user" runat="server" Text="Label"></asp:Label></h5>
                <h5> <span class="label label-primary">
                    <asp:Label ID="LabelSubtitle" runat="server" Text="Label"></asp:Label>

                     </span></h5>
                <br />
                    <p> <asp:Label ID="LabelContent" runat="server" Text="Label"></asp:Label></p>
                <br />
                <br />
                <a class="btn btn-primary" href="Home.aspx">Go Back</a>
            </div>
        </div>
    </div>
</body>
</html>
