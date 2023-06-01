using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia
    {
        private string userName;
        private string passWord;
        private string type;
        private string fullName;
        private string phone;
        private DateTime birth;
        private string address; 
        public DocGia(string userName, string passWord, string fullName, string phone, DateTime birth, string address, string type = "3")
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.Type = type;
            this.FullName = fullName;
            this.Phone = phone;
            this.Birth = birth;
            this.Address = address;
        }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Type { get => type; set => type = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Address { get => address; set => address = value; }
    }
}
