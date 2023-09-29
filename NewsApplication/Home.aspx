<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NewsApplication.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
</head>
<body>
    <nav class="navbar navbar-light bg-light">
        <div class="container-fluid">
            <a class="navbar-brand">News App</a>
            
            <form id="form1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Add News" CssClass="btn btn-outline-success" OnClick="Button1_Click"  />
            </form>
        </div>
    </nav>
    <div class="container">
        <div class="row">

            <asp:Repeater ID="NewsRepeater" runat="server">
                <ItemTemplate>
                    <div class="col-4">
                        <div class="card" style="width: 18rem;">
                            <asp:Image  runat="server" CssClass="card-img-top" ImageUrl='<%# Eval("Imageurl") %>' />
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("News_title") %></h5>
                                <p class="card-text"><%# Eval("News_subtitle") %></p>
                                <a href="/Fullnews.aspx?id=<%# Eval("News_id") %>" class="btn btn-primary">See Full News</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</body>
</html>
