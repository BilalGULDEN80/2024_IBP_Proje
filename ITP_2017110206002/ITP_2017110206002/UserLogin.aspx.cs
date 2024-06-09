using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP_2017110206002
{
    public partial class UserLogin : System.Web.UI.Page
    {
        Operations _o; Kullanici _k; int _xSonuc;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        void Login()
        {
            _k = new Kullanici();
            _k.Username = txtUserName.Text;
            _k.Password = txtpassword.Text;
            _o = new Operations();
            _xSonuc = _o.LoginControl(_k);
            if(_xSonuc<0)
            {
                lblHata.Visible = true;
            }
            else if(_xSonuc==1)
            {
                Session["Kullanici"] = "Kullanici";
                Response.Redirect("Default.aspx");
            }
            else if(_xSonuc==2)
            {
                Session["Kullanici"] = "Admin";
                Response.Redirect("AdminPage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Length>0 && txtpassword.Text.Length>0)
            {
                Login();
            }
        }
    }
}