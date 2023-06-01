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

        private void cSach_Load(object sender, EventArgs e)
        {
            string query = "Select * from Sach";
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
            int i;
            i = dtgSach.CurrentRow.Index;
            f.txtID.Text = dtgSach.Rows[i].Cells[0].Value.ToString();
            f.txtTenSach.Text = dtgSach.Rows[i].Cells[1].Value.ToString();
            f.txtTacGia.Text = dtgSach.Rows[i].Cells[2].Value.ToString();
            f.txtNhaXB.Text = dtgSach.Rows[i].Cells[3].Value.ToString();
            f.dtpNamXB.Text = dtgSach.Rows[i].Cells[4].Value.ToString();
            f.txtTheLoai.Text = dtgSach.Rows[i].Cells[5].Value.ToString();
            f.nudSoLuong.Text = dtgSach.Rows[i].Cells[6].Value.ToString();
            f.ShowDialog();
            cSach_Load (sender, e);
           
        }
        private string id ;
       
        public string Id { get => id; set => id = value; }
       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i;

            i = dtgSach.CurrentRow.Index;
            Id = dtgSach.Rows[i].Cells[0].Value.ToString();
            
          
            string sqlDelete = "Delete from Sach where id =" + Id;
            try
            {
                accessData.Command(sqlDelete);
                MessageBox.Show("Xóa thành công!");
                cSach_Load(sender, e);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error" + ex.Message);
            }
        }
        
    }
}
