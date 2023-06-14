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
using GUI.UserControls;

namespace GUI
{
    public partial class fTest : Form
    {
        public fTest()
        {
            InitializeComponent();
        }
        AccessData a = new AccessData();
        private void RenderBook()
        {
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            // Đường dẫn tới tài nguyên hình ảnh
            List<BookItem> list = new List<BookItem>();

            DataTable dt = a.GetTable("SELECT id From Sach");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                list.Add(new BookItem(Convert.ToInt32(dr["id"].ToString())));
            }           

            for(int i = 0; i < list.Count; i++)
            {
                this.flowLayoutPanel1.Controls.Add(list[i]);
                //list[i].Size = new System.Drawing.Size(400, 400);
            }

            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private void fTest_Load(object sender, EventArgs e)
        {
            RenderBook();
        }
    }
}
