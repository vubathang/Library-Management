using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL;
namespace GUI.Forms
{
    public partial class fAdd : Form
    {
        private int userId = 1;
        private string connectionString = @"Data Source=DESKTOP-319AI5G\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        AccessData accessData = new AccessData();
        public fAdd()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            string Name = txbName.Text;
            string PassWord = txbPassword.Text;
            string Address = txbAddress.Text;
            string Phone = txbPhone.Text;
            DateTime Brith = dtBirth.Value;
            return (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(PassWord) && !string.IsNullOrEmpty(Address) && !string.IsNullOrEmpty(Phone) && Brith != DateTime.MinValue);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    string fullName = txbName.Text;
                    string passWord = txbPassword.Text;
                    string address = txbAddress.Text;
                    string phone = txbPhone.Text;
                    DateTime birth = dtBirth.Value;

                    string query = $"UPDATE NguoiDung SET fullName = N'{fullName}', passWord = '{passWord}', address = N'{address}', phone = '{phone}', birth = '{birth}' WHERE id = 6";
                    accessData.Command(query);

                    MessageBox.Show("Cập nhật thành công!");
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi Thông tin người dùng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void fAdd_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int userId = 6;
                string query = "SELECT * FROM NguoiDung WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", userId);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    txbName.Text = dt.Rows[0]["fullName"].ToString();
                    txbPassword.Text = dt.Rows[0]["passWord"].ToString();
                    txbPhone.Text = dt.Rows[0]["phone"].ToString();
                    dtBirth.Value = Convert.ToDateTime(dt.Rows[0]["birth"]);
                    txbAddress.Text = dt.Rows[0]["address"].ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM NguoiDung WHERE id = 6";
                    accessData.Command(query);
                    MessageBox.Show("Xóa thành công!");
                    ClearFields();
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void ClearFields()
        {
            txbName.Text = "";
            txbPassword.Text = "";
            txbPhone.Text = "";
            dtBirth.Value = DateTime.Now;
            txbAddress.Text = "";
        }
    }
}
