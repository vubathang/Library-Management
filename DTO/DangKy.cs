using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DangKy
    {
        private string userName;
        private string email;
        private string phone;
        private string password;
        private string cfpassword;

        public DangKy(string userName, string email, string phone, string password, string cfpassword)
        {
            this.UserName = userName;
            this.Email = email;
            this.Phone = phone;
            this.Password = password;
            this.cfPassword = cfpassword;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value;}
        public string Phone { get => phone; set => phone = value;}
        public string Password { get => password; set => password = value;}
        public string cfPassword { get => cfpassword; set => cfpassword = value;}
    }
}
