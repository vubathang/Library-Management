using System;
using System.Windows.Forms;
using DAL;
using GUI.Forms;

namespace GUI.UserControls
{
    public partial class cMuonTra : UserControl
    {
        AccessData accessData = new AccessData();

        public cMuonTra()
        {
            InitializeComponent();
        }

        private void cMuonTra_Load(object sender, EventArgs e)
        {
            string queryPM = "SELECT " +
                "PM.id as 'ID', " +
                "ND.fullName as 'Tên độc giả', " +
                "S.title as 'Tên sách', " +
                "PM.borrowDate as 'Ngày mượn', " +
                "PM.amount as 'Số lượng', " +
                "PM.deposit as 'Tiền cọc', " +
                "PM.statusBook as 'Trạng thái sách', " +
                "PM.statusPM as 'Trạng thái phiếu mượn' " +
                "FROM PhieuMuon PM " +
                "INNER JOIN NguoiDung ND ON PM.idDG = ND.id " +
                "INNER JOIN ChiTietPM CTPM ON PM.id = CTPM.idPM " +
                "INNER JOIN Sach S ON CTPM.idBook = S.id " +
                "WHERE PM.statusPM LIKE N'Chưa thanh toán' " +
                "ORDER BY PM.id ASC";
            string queryPT = "SELECT " +
                "PM.id as 'ID', " +
                "ND.fullName as 'Tên độc giả', " +
                "S.title as 'Tên sách', " +
                "PM.borrowDate as 'Ngày mượn', " +
                "PM.returnDate as 'Ngày trả', " +
                "PM.amount as 'Số lượng', " +
                "PM.deposit as 'Tiền cọc', " +
                "PM.refund as 'Tiền hoàn', " +
                "PM.statusBook as 'Trạng thái sách', " +
                "PM.statusPM as 'Trạng thái phiếu trả' " +
                "FROM PhieuMuon PM " +
                "INNER JOIN NguoiDung ND ON PM.idDG = ND.id " +
                "INNER JOIN ChiTietPM CTPM ON PM.id = CTPM.idPM " +
                "INNER JOIN Sach S ON CTPM.idBook = S.id " +
                "WHERE PM.statusPM LIKE N'Đã%' OR PM.statusPM LIKE N'Hoàn thành' " +
                "ORDER BY PM.id ASC";
            dgvPM.DataSource = accessData.GetTable(queryPM);
            dgvPT.DataSource = accessData.GetTable(queryPT);

            txtTotalPM.Text = (int.Parse(dgvPM.Rows.Count.ToString()) - 1).ToString();
            txtTotalPT.Text = (int.Parse(dgvPT.Rows.Count.ToString()) - 1).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemPM f = new fThemPM();
            f.ShowDialog();
            cMuonTra_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPM.SelectedRows.Count > 0)
            {
                int id= int.Parse(dgvPM.SelectedRows[0].Cells["ID"].Value.ToString());
                string nameBook = dgvPM.SelectedRows[0].Cells["Tên sách"].Value.ToString();
                string nameReader = dgvPM.SelectedRows[0].Cells["Tên độc giả"].Value.ToString();
                string borrowDate = dgvPM.SelectedRows[0].Cells["Ngày mượn"].Value.ToString();
                int amount = int.Parse(dgvPM.SelectedRows[0].Cells["Số lượng"].Value.ToString());
                string statusPM = dgvPM.SelectedRows[0].Cells["Trạng thái phiếu mượn"].Value.ToString();
                int deposit = int.Parse(dgvPM.SelectedRows[0].Cells["Tiền cọc"].Value.ToString());
                
                fCapNhatPM f = new fCapNhatPM(id, nameBook, nameReader, borrowDate, amount, statusPM, deposit);
                f.ShowDialog();
                cMuonTra_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnYCMS_Click(object sender, EventArgs e)
        {
            fYCMS f = new fYCMS();
            f.ShowDialog();
            cMuonTra_Load(sender, e);
        }

        private void btnTS_Click(object sender, EventArgs e)
        {
            if (dgvPT.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvPT.SelectedRows[0].Cells["ID"].Value.ToString());
                string nameBook = dgvPT.SelectedRows[0].Cells["Tên sách"].Value.ToString();
                string nameReader = dgvPT.SelectedRows[0].Cells["Tên độc giả"].Value.ToString();
                string borrowDate = dgvPT.SelectedRows[0].Cells["Ngày mượn"].Value.ToString();
                string returnDate = dgvPT.SelectedRows[0].Cells["Ngày trả"].Value.ToString();
                int amount = int.Parse(dgvPT.SelectedRows[0].Cells["Số lượng"].Value.ToString());
                string statusBook = dgvPT.SelectedRows[0].Cells["Trạng thái sách"].Value.ToString();
                string statusPM = dgvPT.SelectedRows[0].Cells["Trạng thái phiếu trả"].Value.ToString();
                int refund = int.Parse(dgvPT.SelectedRows[0].Cells["Tiền hoàn"].Value.ToString());

                fTraSach f2 = new fTraSach(id, nameBook, nameReader, borrowDate, returnDate, amount, statusBook, statusPM, refund);
                f2.ShowDialog();
                cMuonTra_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvPT.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa phiếu trả này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int idPM = int.Parse(dgvPT.SelectedRows[0].Cells["ID"].Value.ToString());
                        string query = $"EXEC XoaPT @idPM = {idPM}";
                        accessData.Command(query);
                        cMuonTra_Load(sender, e);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu trả để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
