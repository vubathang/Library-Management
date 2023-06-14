using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        AccessData accessData = new AccessData();
        string password;
        int id;
        string type;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string password = txbPassword.Text;
            if(Login(userName, password))
            {
                if (type == "3")
                {

                    fHomeLibrary form = new fHomeLibrary();
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    fHomeManagement form = new fHomeManagement(id);
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
        private void DeleteFiels()
        {
            txbUserName.Text = "";
            txbPassword.Text = "";
        }
        private bool Login(string userName, string password)
        {
            DataTable dt = accessData.GetTable($"SELECT * FROM NguoiDung WHERE userName = N'{userName}'");

            if (dt.Rows.Count > 0)
            {
                type = dt.Rows[0]["type"].ToString();
                password = dt.Rows[0]["password"].ToString();
                id = Convert.ToInt32(dt.Rows[0]["id"]);

                if (txbPassword.Text == password)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
