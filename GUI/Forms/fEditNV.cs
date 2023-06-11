using DAL;
using DTO;
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
    public partial class fEditNV : Form
    {
        public fEditNV()
        {
            InitializeComponent();
        }
        NhanVien nv = null;
        AccessData accessdata = new AccessData();
        public NhanVien Nv { get => nv; set => nv = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void fEditNV_Load(object sender, EventArgs e)
        {
            txbuserName.Text = nv.UserName;
            txbpassword.Text = nv.Password;
            txbtype.Text = nv.Type;
            txbfullName.Text = nv.FullName;
            txbphone.Text = nv.Phone;
            dtpDate.Value = nv.Birth;
            txbaddress.Text = nv.Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"update NguoiDung set " +
                $"userName = N'{txbuserName.Text}', " +
                $"passWord = N'{txbpassword.Text}', " +
                $"type = N'{txbtype.Text}', " +
                $"fullName = N'{txbfullName.Text}', " +
                $"phone = N'{txbphone.Text}', " +
                $"birth = '{dtpDate.Value}', " +
                $"address = N'{txbaddress.Text}' " +
                $"where id = {nv.Id}";
                accessdata.Command(query);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
