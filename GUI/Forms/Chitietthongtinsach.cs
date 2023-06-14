using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class Chitietthongtinsach : Form
    {
        public Chitietthongtinsach(int id)
        {
            InitializeComponent();
            Id = id;
        }
        int id;
        AccessData accessData = new AccessData();

        public int Id { get => id; set => id = value; }

        private void Chitietthongtinsach_Load(object sender, EventArgs e)
        {
            string query = $"Select * from Sach where id = {Id}";
            DataTable dt = accessData.GetTable(query);
            if(dt.Rows.Count > 0 ) {
                txtMaSach.Text = dt.Rows[0]["id"].ToString();
                txtTenSach.Text = dt.Rows[0]["title"].ToString();
                txtTacGia.Text = dt.Rows[0]["author"].ToString();
                txtNhaXB.Text  = dt.Rows[0]["publisher"].ToString() ;
                txtNamXB.Text = dt.Rows[0]["publicationYear"].ToString();
                txtTheLoai.Text = dt.Rows[0]["catagory"].ToString();
                txtSoLuong.Text = dt.Rows[0]["quantity"].ToString();
            }
        }
    }
}
