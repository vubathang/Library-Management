using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        int id;
        string userName;
        string password;
        string type;
        string fullName;
        string phone;
        DateTime birth;
        string address;
        public NhanVien() { }
        public NhanVien(int id, string userName, string password, string type, string fullName, string phone, DateTime birth, string address)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.Type = type;
            this.FullName = fullName;
            this.Phone = phone;
            this.Birth = birth;
            this.Address = address;
        }

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Address { get => address; set => address = value; }
    }
    
}
