using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ITP_2017110206002
{
    public class Operations
    {
        DataTable dt;
        veritabani _vt;
        string _xSql;
        public int LoginControl(Kullanici _k)
        {
            if (_vt == null)
                _vt = new veritabani();
            dt = _vt.DtGetir("select * from Users where Username='"+_k.Username+"' and Password='"+_k.Password+"'");
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["Role"]);
            }
            else
                return -1;
            
        }
        public bool UserAdds(Kullanici _u)
        {
            _xSql = "INSERT INTO users(Username,Password,Role) values('"+_u.Username+"','"+_u.Password+"',"+_u.Role+");";
            return _vt.CRUD(_xSql);
        }
        public DataTable dtStudentList()
        {
            if (_vt == null)
                _vt = new veritabani();
            return _vt.DtGetir("select * from students");

        }
        public DataTable dtUserList()
        {
            if (_vt == null)
                _vt = new veritabani();
            return _vt.DtGetir("select * from users");

        }
        public bool OgrenciKayit(Students _s)
        {
            _xSql = "INSERT INTO students(StudenNumber,StudenNameSurName) values ('"+_s.StudenNumber+"','"+_s.StudenNameSurName+"');";
            if (_vt == null)
                _vt = new veritabani();
            return _vt.CRUD(_xSql);
            
        }
    }
}