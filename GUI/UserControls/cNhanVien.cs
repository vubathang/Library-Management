using DAL;
using DTO;
using GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class cNhanVien : UserControl
    {
        public cNhanVien()
        {
            InitializeComponent();
        }
        AccessData accessData = new AccessData();
        NhanVien nv = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new fAddNV();
            form.ShowDialog();
            cNhanVien_Load(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(nv != null)
            {
                fEditNV form = new fEditNV();
                form.Nv = nv;

                
                form.ShowDialog();
                cNhanVien_Load(sender, e);
            }else
            {
                MessageBox.Show("Yêu cầu chọn nhân viên");
            }
            
        }

        private void cNhanVien_Load(object sender, EventArgs e)
        {
            string query = "SELECT " +
                "id as ID," +
                "userName as 'Tên đăng nhập'," +
                "password as 'Mật khẩu'," +
                "fullName as 'Họ tên'," +
                "address as 'Địa chỉ'," +
                "birth as 'Ngày sinh'," +
                "phone as 'SDT'," +
                "type as 'Chức vụ' " +
                "FROM NguoiDung WHERE type = N'1' or type = N'2'";
            dgvNV.DataSource = accessData.GetTable(query);
            dgvNV.Columns["ID"].Width = 50;
            dgvNV.Columns["Ngày Sinh"].Width = 100;
            dgvNV.Columns["SDT"].Width = 120;
            txbSum.Text = Convert.ToString(dgvNV.Rows.Count-1);
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.RowIndex < dgvNV.Rows.Count - 1) 
            {
                int id = Convert.ToInt32(dgvNV.SelectedRows[0].Cells["ID"].Value);
                string userName = dgvNV.SelectedRows[0].Cells["Tên đăng nhập"].Value.ToString();
                string password = dgvNV.SelectedRows[0].Cells["Mật khẩu"].Value.ToString();
                string fullName = dgvNV.SelectedRows[0].Cells["Họ tên"].Value.ToString();
                string address = dgvNV.SelectedRows[0].Cells["Địa chỉ"].Value.ToString();
                DateTime birth = Convert.ToDateTime(dgvNV.SelectedRows[0].Cells["Ngày sinh"].Value);
                string phone = dgvNV.SelectedRows[0].Cells["SDT"].Value.ToString();
                string type= dgvNV.SelectedRows[0].Cells["Chức vụ"].Value.ToString();
                nv = new NhanVien(id, userName, password, type, fullName, phone, birth, address);

            }
            else
            {
                nv = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nv != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = $"delete from NguoiDung where id = {nv.Id}";
                    accessData.Command(query) ;
                    MessageBox.Show("Xóa thành công");
                    cNhanVien_Load(sender,e);
                }
            }
        }
    }
}
