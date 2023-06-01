using System;
using DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Controls;

namespace GUI.Forms
{
    public partial class fAddNV : Form
    {
        public fAddNV()
        {
            InitializeComponent();
        }

        AccessData accessData = new AccessData();   
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO NguoiDung VALUES (N'{txbuserName.Text}', N'{txbpassword.Text}', N'{txbtype.Text}', N'{txbfullName.Text}', N'{txbphone.Text}', '{dtpDate.Text}', N'{txbaddress.Text}')";
            accessData.Command(query);
            MessageBox.Show("Thêm thành công");
            Close();
        }
    }
}
