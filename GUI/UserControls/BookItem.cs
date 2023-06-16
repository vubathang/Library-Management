using DAL;
using DTO;
using GUI.Forms;
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

namespace GUI.UserControls
{
    public partial class BookItem : UserControl
    {
        AccessData accessdata = new AccessData();
        int ID;

        public BookItem(int id)
        {
            InitializeComponent();
            ID = id;
            //this.pictureBox1.Image = global::GUI.Properties.Resources.rounded_in_photoretrica__1_;
            DataTable book = accessdata.GetTable($"SELECT * FROM Sach WHERE id = {id}");
            DataRow dr = book.Rows[0];
            this.label1.Text = dr["title"].ToString();
            this.label2.Text = dr["author"].ToString();
        }


        private void BookItem_Click(object sender, EventArgs e)
        {
            Chitietthongtinsach form = new Chitietthongtinsach(ID);
            form.Show();
        }
    }
}
