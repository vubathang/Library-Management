using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI.Forms
{
   
    public partial class fCapNhatBook : Form
    {
        QuanLySach Book;
        AccessData accessData = new AccessData();
        public fCapNhatBook()
        {
            InitializeComponent();
        }

        public void GetValue()
        {
            string ID = txtID.Text;
            string Title = txtTenSach.Text;
            string Author = txtTacGia.Text;
            string Publisher = txtNhaXB.Text;
            DateTime PublicationYear = dtpNamXB.Value;
            string Catagory = txtTheLoai.Text;
            int Quantity = Convert.ToInt32(nudSoLuong.Value);
            Book = new QuanLySach(Title, Author, Publisher, PublicationYear, Catagory, Quantity);
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            if(txtID.Text == "" || txtTenSach.Text == "" || txtTacGia.Text == "" || txtNhaXB.Text == "" || txtTheLoai.Text == "")
            {
               MessageBox.Show("Vui lòng chọn sách!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               this.Close(); 
                
            }
            else
            {
                
                GetValue();
                string sqlUpdate = $"Update Sach set title = N'{Book.Title1}', author = N'{Book.Author1}', publisher = N'{Book.Publisher1}', publicationYear = N'{Book.PublicationYear1}', catagory = N'{Book.Catagory1}', quantity = N'{Book.Quantity1}'" +  $"where id = {txtID.Text}";
                try
                {
                    accessData.Command(sqlUpdate);
                    MessageBox.Show("Lưu thành công!");
                    Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult reults = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reults == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
