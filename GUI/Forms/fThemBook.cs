using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI.Forms
{

    public partial class fThemBook : Form
    {
        AccessData accessData = new AccessData();
        QuanLySach Book;
        public fThemBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        public void Delete()
        {
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNhaXB.Text = "";
            txtTheLoai.Text = "";
            txtTenSach.Focus() ;
        }
        public void getValue()
        {
            string Title = txtTenSach.Text;
            string Author = txtTacGia.Text;
            string Publisher = txtNhaXB.Text;
            DateTime PublicationYear = dtpNamXB.Value;
            string Catagory = txtTheLoai.Text;
            int Quantity = Convert.ToInt32(nudSoLuong.Value);
            Book = new QuanLySach(Title, Author, Publisher, PublicationYear, Catagory, Quantity);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenSach.Text == "" || txtTacGia.Text == "" || txtNhaXB.Text == "" || dtpNamXB.Text == "" || txtTheLoai.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                Delete();

            }
            else
            {
                getValue();
                string sqlInsert = $"Insert into Sach values (N'{Book.Title1}', N'{Book.Author1}', N'{Book.Publisher1}', N'{Book.PublicationYear1}', N'{Book.Catagory1}', N'{Book.Quantity1}')";
                try
                {
                    
                    accessData.Command(sqlInsert);
                    MessageBox.Show("Thêm thành công!");
                    Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void fThemBook_Load(object sender, EventArgs e)
        {

        }
    }
}
