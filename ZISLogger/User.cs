using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZISLogger
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public User(object[] user)
        {
            Login = user[1].ToString();
            Password = user[2].ToString();
            Status = user[3].ToString();
        }
    }
}
