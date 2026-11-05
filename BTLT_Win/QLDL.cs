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

    public partial class QLDL : Form
    {
        string chuoikn = @"Data Source=DESKTOP-VEDD4V5\SQLEXPRESS;Initial Catalog=QLBH_CAMERA;Integrated Security=True";

        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

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
            txtMaDL.Clear();
            txtMaDL.Text = "Mã đại lý";
            txtMaDL.ForeColor = Color.Gray;

            txtTenDL.Clear();
            txtTenDL.Text = "Tên đại lý";
            txtTenDL.ForeColor = Color.Gray;

            txtDiaChi.Clear();
            txtDiaChi.Text = "Địa chỉ";
            txtDiaChi.ForeColor = Color.Gray;

            txtSDT.Clear();
            txtSDT.Text = "Số điện thoại";
            txtSDT.ForeColor = Color.Gray;

            txtEmail.Clear();
            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Gray;

            txtNguoiDaiDien.Clear();
            txtNguoiDaiDien.Text = "Người đại diện";
            txtNguoiDaiDien.ForeColor = Color.Gray;

            dgvDaiLy.ClearSelection();
            txtMaDL.Focus();
        }

        void loadDL()
        {
            try
            {
                ketnoi();
                dgvDaiLy.Rows.Clear();
                dgvDaiLy.Columns.Clear();

                dgvDaiLy.Columns.Add("MaDL", "Mã DL");
                dgvDaiLy.Columns.Add("TenDL", "Tên Đại Lý");
                dgvDaiLy.Columns.Add("DiaChi", "Địa Chỉ");
                dgvDaiLy.Columns.Add("SDT", "SĐT");
                dgvDaiLy.Columns.Add("Email", "Email");
                dgvDaiLy.Columns.Add("NguoiDaiDien", "Người Đại Diện");

                string sql = "SELECT * FROM DaiLy";
                cmd = new SqlCommand(sql, cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvDaiLy.Rows.Add(
                        dr["MaDL"],
                        dr["TenDL"],
                        dr["DiaChi"],
                        dr["SDT"],
                        dr["Email"],
                        dr["NguoiDaiDien"]
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
        public QLDL()
        {
            InitializeComponent();
        }

        private void QLDL_Load(object sender, EventArgs e)
        {
            txtMaDL.Text = "Mã đại lý";
            txtMaDL.ForeColor = Color.Gray;

            txtTenDL.Text = "Tên đại lý";
            txtTenDL.ForeColor = Color.Gray;

            txtDiaChi.Text = "Địa chỉ";
            txtDiaChi.ForeColor = Color.Gray;

            txtSDT.Text = "Số điện thoại";
            txtSDT.ForeColor = Color.Gray;

            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Gray;

            txtNguoiDaiDien.Text = "Người đại diện";
            txtNguoiDaiDien.ForeColor = Color.Gray;
            loadDL();
        }
        private void txtMaDL_Enter(object sender, EventArgs e)
        {
            if (txtMaDL.Text == "Mã đại lý")
            {
                txtMaDL.Text = "";
                txtMaDL.ForeColor = Color.Black;
            }
        }
        private void txtMaDL_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDL.Text))
            {
                txtMaDL.Text = "Mã đại lý";
                txtMaDL.ForeColor = Color.Gray;
            }
        }
        private void txtMaDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenDL_Enter(object sender, EventArgs e)
        {
            if (txtTenDL.Text == "Tên đại lý")
            {
                txtTenDL.Text = "";
                txtTenDL.ForeColor = Color.Black;
            }
        }
        private void txtTenDL_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDL.Text))
            {
                txtTenDL.Text = "Tên đại lý";
                txtTenDL.ForeColor = Color.Gray;
            }
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Địa chỉ")
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

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Số điện thoại")
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
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
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

        private void txtNguoiDaiDien_Enter(object sender, EventArgs e)
        {
            if (txtNguoiDaiDien.Text == "Người đại diện")
            {
                txtNguoiDaiDien.Text = "";
                txtNguoiDaiDien.ForeColor = Color.Black;
            }
        }
        private void txtNguoiDaiDien_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNguoiDaiDien.Text))
            {
                txtNguoiDaiDien.Text = "Người đại diện";
                txtNguoiDaiDien.ForeColor = Color.Gray;
            }
        }

        private void dgvDaiLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDaiLy.Rows[e.RowIndex];
            txtMaDL.Text = row.Cells[0].Value?.ToString() ?? "";
            txtTenDL.Text = row.Cells[1].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells[2].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells[3].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells[4].Value?.ToString() ?? "";
            txtNguoiDaiDien.Text = row.Cells[5].Value?.ToString() ?? "";

            txtMaDL.ForeColor = Color.Black;
            txtTenDL.ForeColor = Color.Black;
            txtDiaChi.ForeColor = Color.Black;
            txtSDT.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtNguoiDaiDien.ForeColor = Color.Black;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maDL = txtMaDL.Text.Trim();
            string tenDL = txtTenDL.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string nguoiDD = txtNguoiDaiDien.Text.Trim();

            if (maDL == "Mã đại lý") maDL = "";
            if (tenDL == "Tên đại lý") tenDL = "";
            if (diaChi == "Địa chỉ") diaChi = "";
            if (sdt == "Số điện thoại") sdt = "";
            if (email == "Email") email = "";
            if (nguoiDD == "Người đại diện") nguoiDD = "";

            if (string.IsNullOrEmpty(maDL) || string.IsNullOrEmpty(tenDL))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên đại lý!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi();
            string sqlKt = "SELECT COUNT(*) FROM DaiLy WHERE MaDL = N'" + maDL + "'";
            cmd = new SqlCommand(sqlKt, cnn);
            int dem = (int)cmd.ExecuteScalar();
            dongkn();

            if (dem > 0)
            {
                MessageBox.Show("Mã đại lý đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi();
            string sql = "INSERT INTO DaiLy (MaDL, TenDL, DiaChi, SDT, Email, NguoiDaiDien) " +
                "VALUES(N'" + maDL + "', N'" + tenDL + "', N'" + diaChi + "', N'" + sdt + "', N'" + email + "', N'" + nguoiDD + "')";
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongkn();

            loadDL();
            LamMoi();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDL = txtMaDL.Text.Trim();
            if (maDL == "Mã đại lý") maDL = "";

            if (string.IsNullOrEmpty(maDL))
            {
                MessageBox.Show("Vui lòng chọn đại lý cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenDL = txtTenDL.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string nguoiDD = txtNguoiDaiDien.Text.Trim();

            if (tenDL == "Tên đại lý") tenDL = "";
            if (diaChi == "Địa chỉ") diaChi = "";
            if (sdt == "Số điện thoại") sdt = "";
            if (email == "Email") email = "";
            if (nguoiDD == "Người đại diện") nguoiDD = "";

            if (string.IsNullOrEmpty(tenDL))
            {
                MessageBox.Show("Vui lòng nhập Tên đại lý!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi();
            string sql = "UPDATE DaiLy SET TenDL = N'" + tenDL +
                         "', DiaChi = N'" + diaChi +
                         "', SDT = N'" + sdt +
                         "', Email = N'" + email +
                         "', NguoiDaiDien = N'" + nguoiDD +
                         "' WHERE MaDL = N'" + maDL + "'";
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongkn();

            loadDL();
            LamMoi();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDL = txtMaDL.Text.Trim();
            if (maDL == "Mã đại lý") maDL = "";

            if (string.IsNullOrEmpty(maDL))
            {
                MessageBox.Show("Vui lòng chọn đại lý cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult chon = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (chon == DialogResult.Yes)
            {
                thucthisql("DELETE FROM DaiLy WHERE MaDL = N'" + maDL + "'");
                loadDL();
                LamMoi();
                MessageBox.Show("Xóa thành công!");
            }
            }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
