using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITP_2017110206002
{
    public class Users
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public int Active { get; set; }
    }
}