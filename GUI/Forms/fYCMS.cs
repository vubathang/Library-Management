using System;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class fYCMS : Form
    {
        AccessData accessData = new AccessData();

        public fYCMS()
        {
            InitializeComponent();
        }

        private void fYCMS_Load(object sender, EventArgs e)
        {
            string query = "SELECT id as 'Mã yêu cầu', " +
                "idDG as 'Mã độc giả', " +
                "idBook as 'Mã sách', " +
                "requestDate as 'Ngày đặt mượn', " +
                "quantity as 'Số lượng' FROM YeuCauMS " +
                "ORDER BY id ASC";
            dgvYCMS.DataSource = accessData.GetTable(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvYCMS.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn chấp nhận yêu cầu để tạo phiếu mượn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string query = $"EXEC ChapNhanYCMS @idYC = {int.Parse(dgvYCMS.CurrentRow.Cells[0].Value.ToString())}, @idTT = 2";
                        accessData.Command(query);
                        MessageBox.Show("Thêm phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fYCMS_Load(sender, e);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu để tạo phiếu mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn từ chối", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    accessData.Command("DELETE FROM YeuCauMS WHERE id = " + dgvYCMS.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Từ chối yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fYCMS_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
    }
}
