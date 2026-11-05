using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLT_Win
{
    public partial class QLKH : Form
    {
        string chuoikn = @"Data Source=DESKTOP-VEDD4V5\SQLEXPRESS;Initial Catalog=QLBH_CAMERA;Integrated Security=True";

        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        void ketnoi()
        {
            cnn = new SqlConnection(chuoikn);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
        }

        void dongkn()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        void thucthisql(string sql)
        {
            ketnoi();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongkn();
        }

        private void LamMoi()
        {
            txtMaKH.Text = "Mã khách hàng";
            txtMaKH.ForeColor = Color.Gray;

            txtTenKH.Text = "Tên khách hàng";
            txtTenKH.ForeColor = Color.Gray;

            txtSDT.Text = "Số điện thoại";
            txtSDT.ForeColor = Color.Gray;

            txtDiaChi.Text = "Địa chỉ";
            txtDiaChi.ForeColor = Color.Gray;

            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Gray;

            dgvKhachHang.ClearSelection();
            txtMaKH.Focus();
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void loadDL()
        {
            try
            {
                ketnoi();
                dgvKhachHang.Rows.Clear();
                dgvKhachHang.Columns.Clear();

                dgvKhachHang.Columns.Add("MaKH", "Mã KH");
                dgvKhachHang.Columns.Add("TenKH", "Họ Tên");
                dgvKhachHang.Columns.Add("SDT", "SĐT");
                dgvKhachHang.Columns.Add("DiaChi", "Địa Chỉ");
                dgvKhachHang.Columns.Add("Email", "Email");

                string sql = "SELECT * FROM KhachHang";
                cmd = new SqlCommand(sql, cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvKhachHang.Rows.Add(
                        dr["MaKH"],
                        dr["TenKH"],
                        dr["SDT"],
                        dr["DiaChi"],
                        dr["Email"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dr != null && !dr.IsClosed) dr.Close();
                dongkn();
            }
        }
        public QLKH()
        {
            InitializeComponent();
        }

        private void TenSP_Click(object sender, EventArgs e)
        {

        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = "Mã khách hàng";
            txtMaKH.ForeColor = Color.Gray;

            txtTenKH.Text = "Tên khách hàng";
            txtTenKH.ForeColor = Color.Gray;

            txtSDT.Text = "Số điện thoại";
            txtSDT.ForeColor = Color.Gray;

            txtDiaChi.Text = "Địa chỉ";
            txtDiaChi.ForeColor = Color.Gray;

            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Gray;

            // Gắn sự kiện Enter/Leave
            txtMaKH.Enter += txtMaKH_Enter;
            txtMaKH.Leave += txtMaKH_Leave;

            txtTenKH.Enter += txtTenKH_Enter;
            txtTenKH.Leave += txtTenKH_Leave;

            txtSDT.Enter += txtSDT_Enter;
            txtSDT.Leave += txtSDT_Leave;
            txtSDT.KeyPress += txtSDT_KeyPress;

            txtDiaChi.Enter += txtDiaChi_Enter;
            txtDiaChi.Leave += txtDiaChi_Leave;

            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;

            loadDL();
        }
        private void txtMaKH_Enter(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "Mã khách hàng")
            {
                txtMaKH.Text = "";
                txtMaKH.ForeColor = Color.Black;
            }
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                txtMaKH.Text = "Mã khách hàng";
                txtMaKH.ForeColor = Color.Gray;
            }
        }
        private void txtTenKH_Enter(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Trim() == "Tên khách hàng")
            {
                txtTenKH.Text = "";
                txtTenKH.ForeColor = Color.Black;
            }
        }
        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() == "Số điện thoại")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                txtSDT.Text = "Số điện thoại";
                txtSDT.ForeColor = Color.Gray;
            }
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Trim() == "Địa chỉ")
            {
                txtDiaChi.Text = "";
                txtDiaChi.ForeColor = Color.Black;
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                txtDiaChi.Text = "Địa chỉ";
                txtDiaChi.ForeColor = Color.Gray;
            }
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                txtTenKH.Text = "Tên khách hàng";
                txtTenKH.ForeColor = Color.Gray;
            }
        }
        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
            {
            string maKH = txtMaKH.Text.Trim();
            if (maKH == "Mã khách hàng") maKH = "";
            string tenKH = txtTenKH.Text.Trim();
            if (tenKH == "Tên khách hàng") tenKH = "";
            string sdt = txtSDT.Text.Trim();
            if (sdt == "Số điện thoại") sdt = "";
            string diaChi = txtDiaChi.Text.Trim();
            if (diaChi == "Địa chỉ") diaChi = "";
            string email = txtEmail.Text.Trim();
            if (email == "Email") email = "";
            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH))
                {
                    MessageBox.Show("Vui lòng nhập Mã KH và Họ Tên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng mã
                ketnoi();
                string sqlKt = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = N'" + maKH + "'";
                cmd = new SqlCommand(sqlKt, cnn);
                int dem = (int)cmd.ExecuteScalar();
                dongkn();

                if (dem > 0)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm mới
                ketnoi();
                string sql = "INSERT INTO KhachHang (MaKH, TenKH, SDT, DiaChi, Email) " +
                    "VALUES(N'" + maKH + "', N'" + tenKH + "', N'" + sdt + "', N'" + diaChi + "', N'" + email + "')";
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                dongkn();

                loadDL();
                LamMoi();
                MessageBox.Show("Thêm thành công!");
            }
        private void btnSua_Click(object sender, EventArgs e)
            {
                string maKH = txtMaKH.Text.Trim();
                if (string.IsNullOrEmpty(maKH))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenKH = txtTenKH.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(tenKH))
                {
                    MessageBox.Show("Vui lòng nhập Họ Tên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ketnoi();
                string sql = "UPDATE KhachHang SET TenKH = N'" + tenKH +
                             "', SDT = N'" + sdt +
                             "', DiaChi = N'" + diaChi +
                             "', Email = N'" + email +
                             "' WHERE MaKH = N'" + maKH + "'";
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                dongkn();

                loadDL();
                LamMoi();
                MessageBox.Show("Sửa thành công!");
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult chon = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (chon == DialogResult.Yes)
            {
                thucthisql("DELETE FROM KhachHang WHERE MaKH = N'" + maKH + "'");
                loadDL();
                LamMoi();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells[0].Value?.ToString() ?? "";
            txtMaKH.ForeColor = Color.Black;
            txtTenKH.Text = row.Cells[1].Value?.ToString() ?? "";
            txtTenKH.ForeColor = Color.Black;
            txtSDT.Text = row.Cells[2].Value?.ToString() ?? "";
            txtSDT.ForeColor = Color.Black;
            txtDiaChi.Text = row.Cells[3].Value?.ToString() ?? "";
            txtDiaChi.ForeColor = Color.Black;
            txtEmail.Text = row.Cells[4].Value?.ToString() ?? "";
            txtEmail.ForeColor = Color.Black;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
                string rowFilter = string.Format("{0} like '{1}'", "TenKH", "%" + txtTimKiem.Text + "%");
                (dgvKhachHang.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                loadDL();
            }
        }
    }
}
