<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ITP_2017110206002.AdminPage" MasterPageFile="~/Site1.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Üye Kayıt Formu</h1>
    <div class="col-lg-12 col-md-12">
        <div class="card info-card sales-card">
            <div class="container">
                <div class="col-lg-12 col-sm-12 col-md-12">
                    <div class="form-group">
                        <label for="formGroupExampleInput">Kullanıcı Adı</label>
                        <asp:TextBox ID="txtKullaniciAdi" CssClass="form-control input-group-sm" placeholder="Kullanici Adı" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-12 col-sm-12 col-md-12">
                    <div class="form-group">
                        <label for="formGroupExampleInput2">Şifre</label>

                        <asp:TextBox class="form-control" ID="txtSifre" placeholder="Şifre" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="col-lg-12 col-sm-12 col-md-12">
                    <div class="form-group"> Yetki Türü
                      <asp:RadioButton ID="RdYonetici" GroupName="role" Text="yönetici" runat="server" />
                        <asp:RadioButton ID="RdKullanici" GroupName="role" Text="kullanici" runat="server" />
                    </div>
                </div>

                <div class="col-lg-12 col-sm-12 col-md-12">
                    <div class="form-group">
                        <asp:Button ID="BtnSave" class="btn btn-primary" runat="server" Text="Kaydet" OnClick="BtnSave_Click" />
                    </div>
                </div>

            </div>
        </div>
    </div>
    <div class="col-lg-12 col-md-12">
        <div class="card info-card sales-card">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="table-responsive">
                            <asp:GridView ID="GridStudents" AutoGenerateColumns="false" UseAccessibleHeader="true" CssClass="table table-bordered table-condensed" runat="server">
                                <Columns>
                                    <asp:BoundField DataField="UserName" HeaderText="StudenNumber" />
                                </Columns>
                                <Columns>
                                    <asp:BoundField DataField="Password" HeaderText="StudenNameSurName" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
