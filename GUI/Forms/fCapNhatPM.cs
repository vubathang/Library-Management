using System;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class fCapNhatPM : Form
    {
        AccessData accessData = new AccessData();

        private int id;
        private string nameBook;
        private string nameReader;
        private string borrowDate;
        private int amount;
        private string statusPM;
        private int deposit;

        public fCapNhatPM(int id, string nameBook, string nameReader, string borrowDate, int amount, string statusPM, int deposit)
        {
            InitializeComponent();
            this.id = id;
            this.nameBook = nameBook;
            this.nameReader = nameReader;
            this.borrowDate = borrowDate;
            this.amount = amount;
            this.statusPM = statusPM;
            this.deposit = deposit;
        }

        private void fCapNhatPM_Load(object sender, EventArgs e)
        {
            txtBook.Text = nameBook;
            txtReader.Text = nameReader; 
            dtpBorrow.Text = borrowDate.ToString();
            txtAmount.Text = amount.ToString();
            cbTTPM.Text = statusPM;
            txtDeposit.Text = deposit.ToString();
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime borrowDate = dtpBorrow.Value;
            string cbTTPM = this.cbTTPM.Text;
            int deposit = int.Parse(txtDeposit.Text);
            string query = $"UPDATE PhieuMuon SET borrowDate='{borrowDate}', statusPM=N'{cbTTPM}', deposit={deposit} WHERE id={id}";
            accessData.Command(query);
            MessageBox.Show("Cập nhật phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
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
