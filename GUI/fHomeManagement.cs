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

namespace GUI
{
    public partial class fHomeManagement : Form
    {
        public fHomeManagement()
        {
            InitializeComponent();
        }
        private UserControl currentUserControl;
        private void OpenUserControl(UserControl userControl)
        {
            if (currentUserControl != null)
            {
                currentUserControl.Dispose();
            }
            currentUserControl = userControl;
            userControl.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(currentUserControl);
            pnlBody.Tag = userControl;
            userControl.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenUserControl(new cNhanVien());
            lbTitle.Text = "QUẢN LÝ NHÂN VIÊN";
        }

        private void btnQLDG_Click(object sender, EventArgs e)
        {
            OpenUserControl(new cDocGia());
            lbTitle.Text = "QUẢN LÝ ĐỘC GIẢ";
        }

        private void btnQLS_Click(object sender, EventArgs e)
        {
            OpenUserControl(new cSach());
            lbTitle.Text = "QUẢN LÝ SÁCH";
        }

        private void btnQLMT_Click(object sender, EventArgs e)
        {
            OpenUserControl(new cMuonTra());
            lbTitle.Text = "QUẢN LÝ MƯỢN TRẢ";
        }

        private void Home_Click(object sender, EventArgs e)
        {
            currentUserControl?.Dispose();
            currentUserControl=null;
            lbTitle.Text = "HOME";
        }
    }
}
