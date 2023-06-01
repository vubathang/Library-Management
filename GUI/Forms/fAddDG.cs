using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI.Forms
{
    public partial class fAddDG : Form
    {
        public fAddDG()
        {
            InitializeComponent();
            this.btnEnter.Click += new System.EventHandler(this.Add);
        }
        AccessData accessData = new AccessData();
        DocGia dg = null;
        string id;

        public string Id { get => id; set => id = value; }
        public DocGia Dg { get => dg; set => dg = value; }
        


        #region Func
        public void SwitchForm()
        {
            // Change Text
            this.Text = "Thay đổi thông tin";
            lbTitleInfoReader.Text = "Thông tin độc giả";
            txbUsername.Enabled = false;
            txbPassword.Enabled = false;

            // Change Btn
            btnEnter.Text = "Lưu";
            this.btnEnter.Click -= new System.EventHandler(this.Add);
            this.btnEnter.Click += new System.EventHandler(this.Save);

            // Change Text
            FillText();
        }
        private void FillText()
        {
            if(Dg != null)
            {
                txbUsername.Text = Dg.UserName;
                txbPassword.Text = Dg.PassWord;
                txbFullName.Text = Dg.FullName;
                txbAddress.Text = Dg.Address;
                txbPhone.Text = Dg.Phone;
                dtpkBirth.Value = Dg.Birth;
            }
        }
        private bool CheckText()
        {
            if (txbUsername.Text == "" || txbPassword.Text == "" || txbFullName.Text == "" || txbPhone.Text == "" || txbAddress.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập thông tin đầy đủ thông tin!");
                return false;
            }
            return true;
        }
        private void GetValue()
        {
            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            string fullName = txbFullName.Text;
            string phone = txbPhone.Text;
            DateTime birth = dtpkBirth.Value;
            string address = txbAddress.Text;
            Dg = new DocGia(userName, passWord, fullName, phone, birth, address);
        }
        #endregion
        #region Events
        // Default : btnAdd
        private void Add(object sender, EventArgs e)
        {
            if(CheckText())
            {
                GetValue();
                string query = $"INSERT INTO dbo.NguoiDung VALUES (N'{Dg.UserName}', N'{Dg.PassWord}', N'{Dg.Type}', N'{Dg.FullName}', N'{Dg.Phone}', '{Dg.Birth}', N'{Dg.Address}')";
                try
                {
                    accessData.Command(query);
                    MessageBox.Show("Thêm thành công!");
                    Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }
        private void Save(object sender, EventArgs e)
        {
            GetValue();
            string query = $"UPDATE dbo.NguoiDung " +
                            $"SET userName = N'{Dg.UserName}', " +
                            $"password = N'{Dg.PassWord}', " +
                            $"type = N'{Dg.Type}', " +
                            $"fullName = N'{Dg.FullName}', " +
                            $"phone = N'{Dg.Phone}', " +
                            $"birth = '{Dg.Birth}', " +
                            $"address = N'{Dg.Address}'" +
                            $"WHERE id = N'{this.id}'";
            try
            {
                accessData.Command(query);
                MessageBox.Show("Cập nhật thành công!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

    }
}
