<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ITP_2017110206002.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.3/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div id="body">
            <div class="container">
                <div class="col-lg-12 col-sm-12 col-md-12">
                    <div class="form-group">
                        <label for="formGroupExampleInput">Student Number</label>
                        <asp:TextBox ID="txtOgrenciNo" CssClass="form-control input-group-sm" placeholder="Öğrenci No" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-12 col-sm-12 col-md-12">
                    <div class="form-group">
                        <label for="formGroupExampleInput2">Studen Name</label>

                        <asp:TextBox class="form-control" ID="txtAdiSoyadi" placeholder="Another input" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-12 col-sm-12 col-md-12">
                    <div class="form-group">
                        <asp:Button ID="BtnSave" class="btn btn-primary" runat="server" Text="Kaydet" OnClick="BtnSave_Click" />
                    </div>
                </div>

            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="table-responsive">
                            <asp:GridView ID="GridStudents" AutoGenerateColumns="false" UseAccessibleHeader="true" CssClass="table table-bordered table-condensed" runat="server">
                                <Columns>
                                    <asp:BoundField DataField="StudenNumber" HeaderText="StudenNumber" />
                                </Columns>
                                <Columns>
                                   <asp:BoundField DataField="StudenNameSurName" HeaderText="StudenNameSurName" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
    </form>
</body>
</html>
