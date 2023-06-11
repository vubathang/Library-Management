using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.Forms
{
    public partial class fEditProfile : Form
    {
        public fEditProfile(int id, fHomeManagement f)
        {
            InitializeComponent();
            Id = id;
            this.F = f;
        }
        int id;
        fHomeManagement f;
        AccessData accessData = new AccessData();

        public int Id { get => id; set => id = value; }
        public fHomeManagement F { get => f; set => f = value; }

        private bool Check()
        {
            string username = txbUserName.Text;
            string password = txbPassword.Text;
            string fullName = txbFullName.Text;
            string address = txbAddress.Text;
            string phone = txbPhone.Text;
            DateTime birth = dtpkBirth.Value;
            return (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(fullName) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(phone) && birth != DateTime.MinValue);
        }
        private void loadData()
        {
            string query = $"SELECT * FROM NguoiDung WHERE id = {Id}";
            DataTable dt =  accessData.GetTable(query);
            if (dt.Rows.Count > 0 )
            {
                txbUserName.Text = dt.Rows[0]["userName"].ToString();
                txbFullName.Text = dt.Rows[0]["fullName"].ToString();
                txbPassword.Text = dt.Rows[0]["passWord"].ToString();
                txbPhone.Text = dt.Rows[0]["phone"].ToString();
                dtpkBirth.Value = Convert.ToDateTime(dt.Rows[0]["birth"]);
                txbAddress.Text = dt.Rows[0]["address"].ToString();
            }
        }
        private void ClearFields()
        {
            txbUserName.Text = "";
            txbFullName.Text = "";
            txbPassword.Text = "";
            txbPhone.Text = "";
            dtpkBirth.Value = DateTime.Now;
            txbAddress.Text = "";
        }

        private void fEditProfile_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(Check())
            {
                try
                {
                    string fullName = txbFullName.Text;
                    string passWord = txbPassword.Text;
                    string address = txbAddress.Text;
                    string phone = txbPhone.Text;
                    DateTime birth = dtpkBirth.Value;
                    string query = $"UPDATE NguoiDung SET fullName = N'{fullName}', passWord = '{passWord}', address = N'{address}', phone = '{phone}', birth = '{birth}' WHERE id = {Id}";
                    accessData.Command(query);
                    MessageBox.Show("Cập nhật thành công!");
                    loadData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = $"DELETE FROM NguoiDung WHERE id = {Id}";
                    accessData.Command(query);
                    MessageBox.Show("Xóa thành công!");
                    this.Close();
                    F.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
    }
}
