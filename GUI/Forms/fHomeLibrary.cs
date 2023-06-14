﻿using DAL;
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class fHomeLibrary : Form
    {
        public fHomeLibrary()
        {
            InitializeComponent();
        }
        AccessData accessdata = new AccessData();
        DataTable dt = new DataTable();
        private void RenderBook(string query)
        {
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.ResumeLayout();
            flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1);
            // Đường dẫn tới tài nguyên hình ảnh

            dt = accessdata.GetTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                int id = Convert.ToInt32(dr["id"].ToString());
                this.flowLayoutPanel1.Controls.Add(new BookItem(id));
            }


            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        //private void fTest_Load(object sender, EventArgs e)
        //{
        //    RenderBook();
        //}

        private void fHomeLibrary_Load(object sender, EventArgs e)
        {
            RenderBook("SELECT id From Sach");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            { 
                if (textBox1.Text.Trim() != "")
                {
                    RenderBook($"SELECT * FROM Sach WHERE title LIKE N'%{textBox1.Text}%'");
                }
                else
                {
                    RenderBook("SELECT id From Sach");
                }
            }
        }
    }
}
