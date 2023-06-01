using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class QuanLyThongTinNguoiDung
    {
        private string Name;
        private string Password;
        private string Address;
        private string Phone;
        private DateTime Brith;

        public QuanLyThongTinNguoiDung()
        {

        }

        public QuanLyThongTinNguoiDung( string name, string password, string address, string phone, DateTime brith)
        {
            Name = name;
            Password = password;
            this.Address = address;
            Phone = phone;
            Brith = brith;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Psssword1 { get => Password; set => Password = value; }
        public string Address1 { get =>  Address; set => Address = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public DateTime Brith1 { get => Brith; set => Brith = value; }  
    }
}
