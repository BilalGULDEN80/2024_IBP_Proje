using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP_2017110206002
{
    public partial class Default : System.Web.UI.Page
    {
        Operations _Ops; Students _ogrenci;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] == null)
                Response.Redirect("UserLogin.aspx");

        }
        void OgrenciListesi()
        {
            if (_Ops == null)
                _Ops = new Operations();
            GridStudents.DataSource = _Ops.dtStudentList();
            GridStudents.DataBind();
           
        }
        void OgrenciKaydet()
        {
            _ogrenci = new Students();
            if (_Ops == null)
                _Ops = new Operations();
            _ogrenci.StudenNameSurName = txtAdiSoyadi.Text;
            _ogrenci.StudenNumber = txtOgrenciNo.Text;
            _Ops.OgrenciKayit(_ogrenci);
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            OgrenciKaydet(); OgrenciListesi();
        }
    }
}