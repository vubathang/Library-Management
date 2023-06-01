using DAL;
using System;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class fThemPM : Form
    {
        AccessData accessData = new AccessData();

        public fThemPM()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtReader.Text == "" || txtBook.Text == "" || nudAmount.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string reader = txtReader.Text;
                    string book = txtBook.Text;
                    DateTime borrowDate = dtpBorrow.Value;
                    int amount = int.Parse(nudAmount.Value.ToString());
                    string query = $"EXEC LapPM @fullName=N'{reader}',@title=N'{book}',@amount={amount},@borrowDate='{borrowDate}'";
                    accessData.Command(query);
                    MessageBox.Show("Thêm phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
