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
    public partial class cDocGia : UserControl
    {
        public cDocGia()
        {
            InitializeComponent();
        }
        
        AccessData accessData = new AccessData();
        DocGia dg = null;
        string id = null;
        private void btnAddDG_Click(object sender, EventArgs e)
        {
            fAddDG f = new fAddDG();
            f.ShowDialog();
            cDocGia_Load(sender, e);
        }

        private void btnEditDG_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                fAddDG f = new fAddDG();
                f.Id = id;
                f.Dg = dg;
                f.SwitchForm();
                f.ShowDialog();
                cDocGia_Load(sender, e);
            } 
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả!");
            }
        }
        private void btnDeleteDG_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM NguoiDung WHERE id = '{id}'";
                    accessData.Command(query);
                    cDocGia_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu chọn độc giả!");
            }
        }
        public void cDocGia_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT " +
                    "id as ID," +
                    "userName as 'Tên đăng nhập'," +
                    "password as 'Mật khẩu'," +
                    "fullName as 'Họ tên'," +
                    "address as 'Địa chỉ'," +
                    "birth as 'Ngày sinh'," +
                    "phone as 'SDT' " +
                    "FROM NguoiDung WHERE type = N'3'";
                dtgvDG.DataSource = accessData.GetTable(query);
                dtgvDG.Columns["ID"].Width = 50;
                dtgvDG.Columns["Ngày sinh"].Width = 100;
                dtgvDG.Columns["SDT"].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            txbAmount.Text = Convert.ToString(dtgvDG.Rows.Count - 1);

        }

        private void dtgvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvDG.Rows.Count - 1)
            {
                id = dtgvDG.SelectedRows[0].Cells[0].Value.ToString();
                string userName = dtgvDG.SelectedRows[0].Cells["Tên đăng nhập"].Value.ToString();
                string password = dtgvDG.SelectedRows[0].Cells["Mật khẩu"].Value.ToString();
                string fullName = dtgvDG.SelectedRows[0].Cells["Họ tên"].Value.ToString();
                string address = dtgvDG.SelectedRows[0].Cells["Địa chỉ"].Value.ToString();
                DateTime birth = Convert.ToDateTime(dtgvDG.SelectedRows[0].Cells["Ngày sinh"].Value);
                string phone = dtgvDG.SelectedRows[0].Cells["SDT"].Value.ToString();
                dg = new DocGia(userName, password, fullName, phone, birth, address);
            }
            else
            {
                dg = null;
            }
        }
    }
}
