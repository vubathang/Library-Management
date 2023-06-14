using GUI.Forms;
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
        public fHomeManagement(int id)
        {
            InitializeComponent();
            this.Id = id;
        }
        int id;
        private UserControl currentUserControl;

        public int Id { get => id; set => id = value; }

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
            OpenUserControl(new cMuonTra(Id));
            lbTitle.Text = "QUẢN LÝ MƯỢN TRẢ";
        }

        private void Home_Click(object sender, EventArgs e)
        {
            currentUserControl?.Dispose();
            currentUserControl=null;
            lbTitle.Text = "HOME";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fEditProfile f = new fEditProfile(Id);
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
