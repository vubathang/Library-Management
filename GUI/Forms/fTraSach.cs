using System;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class fTraSach : Form
    {
        AccessData accessData = new AccessData();

        private int id;
        private string nameBook;
        private string nameReader;
        private string borrowDate;
        private string returnDate;
        private int amount;
        private string statusBook;
        private string statusPM;
        private int refund;

        public fTraSach(int id, string nameBook, string nameReader, string borrowDate, string returnDate, int amount, string statusBook, string statusPM, int refund)
        {
            InitializeComponent();
            this.id = id;
            this.nameBook = nameBook;
            this.nameReader = nameReader;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            this.amount = amount;
            this.statusBook = statusBook;
            this.statusPM = statusPM;
            this.refund = refund;
        }

        private void txtRefund_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void fTraSach_Load(object sender, EventArgs e)
        {
            txtReader.Text = nameReader;
            txtBook.Text = nameBook;
            dtpBorrow.Text = borrowDate.ToString();
            dtpReturn.Text = returnDate.ToString();
            txtAmount.Text = amount.ToString();
            cbTTS.Text = statusBook;
            cbTTPM.Text = statusPM;
            txtRefund.Text = refund.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime returnDate = dtpReturn.Value;
                string cbTTS = this.cbTTS.Text;
                string cbTTPM = this.cbTTPM.Text;
                int refund = int.Parse(txtRefund.Text);
                string query = $"UPDATE PhieuMuon SET returnDate='{returnDate}', statusBook=N'{cbTTS}', statusPM=N'{cbTTPM}', refund={refund} WHERE id={id}";
                accessData.Command(query);
                MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
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
