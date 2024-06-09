<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="ITP_2017110206002.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>2017110206002-BİLAL GÜLDEN</title>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.3/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <style>
        html, body {
            height: 100%;
            margin: 0;
            display: flex;
            justify-content: center;
            align-items: center;
        }
        .container {
            width: 100%;
            max-width: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">

            <div class="form-group">
                <label for="exampleInputEmail1">Username(StudentNumber)</label>                
                <asp:TextBox ID="txtUserName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Password(Şifre)</label>              
                <asp:TextBox ID="txtpassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
            </div>           
             <div class="form-group">
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Giriş Yap" OnClick="Button1_Click" />
            </div> 
             <div class="form-group">
                 <asp:Label ID="lblHata" runat="server" Text="Kullanıcı Adı veya Şifre Hatalı" Visible="false"></asp:Label>
            </div> 

        </div>
    </form>
</body>
</html>
