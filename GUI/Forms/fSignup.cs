using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class fSignup : Form
    {
        private AccessData accessData;

        public fSignup()
        {
            InitializeComponent();
            accessData = new AccessData();
            this.panel1.BackColor = Color.FromArgb(128, 255, 255, 255);
        }

        private bool IsvalidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Text;
            string cfpassword = txtcfPassword.Text;

            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(cfpassword) )
            {
                MessageBox.Show("Vui lòng điền đày đủ thông tin!");
                return;
            }

            if(!IsvalidEmail(email))
            {
                MessageBox.Show("email không đúng định dạng!");
                return;
            }

            int phoneNumber;
            if (!int.TryParse(phone, out phoneNumber))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng!");
                return;
            }

            if (password != cfpassword)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!");
                return;
            }

            try
            {
                string query = $"insert into fDangKy ([Họ và tên], [Email], [Số điện thoại], [Mật khẩu], [Xác nhận mật khẩu]) values (N'{name}', '{email}', '{phone}', '{password}', '{cfpassword}')";
                accessData.Command(query);
                MessageBox.Show("Đăng ký thành công!");

                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại: " + ex.Message);
            }
        }

        private void btnDangKy_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
