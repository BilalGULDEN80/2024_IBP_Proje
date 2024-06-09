using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP_2017110206002
{
    public partial class AdminPage : System.Web.UI.Page
    {
        Operations _Ops; Kullanici kullanici;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] != "Admin")
                Response.Redirect("UserLogin.aspx");
            UyeListesi();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            UyeKaydet();
        }
        void UyeKaydet()
        {
            if (_Ops == null)
                _Ops = new Operations();
            kullanici = new Kullanici();
            kullanici.Username = txtKullaniciAdi.Text;
            kullanici.Password = txtSifre.Text;
            if (RdKullanici.Checked)
                kullanici.Role = 1;
            else if (RdYonetici.Checked)
                kullanici.Role = 2;
            _Ops.UserAdds(kullanici);
            UyeListesi();

        }
        void UyeListesi()
        {

            if (_Ops == null)
                _Ops = new Operations();
            if (_Ops.dtUserList().Rows.Count > 0)
            {
                GridStudents.DataSource = _Ops.dtUserList();
                GridStudents.DataBind();
            }
             


        }
    }
}