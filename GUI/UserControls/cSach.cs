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
using System.Data.SqlClient;
using DTO;
using DAL;
namespace GUI.UserControls
{
  
    public partial class cSach : UserControl
    {
        AccessData accessData = new AccessData();

        public cSach()
        {
            InitializeComponent();
        }
        int indexCurrent;
        private void cSach_Load(object sender, EventArgs e)
        {
            string query = "Select id as N'Id'" +
                ",title as N'Tiêu đề'," +
                "author as N'Tác giả'," +
                "publisher as N'Nhà xuất bản'," +
                "publicationYear as N'Năm xuất bản'," +
                "catagory as N'Thể loại'," +
                "quantity as N'Số lượng'" +
                "from Sach";
            dtgSach.DataSource = accessData.GetTable(query);

            int totalBooks = dtgSach.Rows.Count - 1; //Trả về số dòng trong bảng
            txbTongSo.Text = totalBooks.ToString();
        }
        


        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemBook f = new fThemBook();
            f.ShowDialog();
            cSach_Load (sender, e);
        }
       

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            fCapNhatBook f = new fCapNhatBook();
            if (indexCurrent >= 0 && indexCurrent < dtgSach.Rows.Count - 1)
            {
                f.txtID.Text = dtgSach.Rows[indexCurrent].Cells[0].Value.ToString();
                f.txtTenSach.Text = dtgSach.Rows[indexCurrent].Cells[1].Value.ToString();
                f.txtTacGia.Text = dtgSach.Rows[indexCurrent].Cells[2].Value.ToString();
                f.txtNhaXB.Text = dtgSach.Rows[indexCurrent].Cells[3].Value.ToString();
                f.dtpNamXB.Text = dtgSach.Rows[indexCurrent].Cells[4].Value.ToString();
                f.txtTheLoai.Text = dtgSach.Rows[indexCurrent].Cells[5].Value.ToString();
                f.nudSoLuong.Text = dtgSach.Rows[indexCurrent].Cells[6].Value.ToString();
                f.ShowDialog();
                cSach_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Yêu cầu chọn sách!");
            }
            
           
        }
        private string id ;
       
        public string Id { get => id; set => id = value; }
       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            
            if ( indexCurrent >= 0 && indexCurrent < dtgSach.Rows.Count - 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Id = dtgSach.Rows[indexCurrent].Cells[0].Value.ToString();
                    string sqlDelete = "Delete from Sach where id =" + Id;
                    try
                    {
                        accessData.Command(sqlDelete);
                        MessageBox.Show("Xóa thành công!");
                        cSach_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Error" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu chọn sách!");
            }
        }

        private void dtgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexCurrent = dtgSach.CurrentRow.Index;
        }
    }
}
