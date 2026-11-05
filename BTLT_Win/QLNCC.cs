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
    public partial class QLNCC : Form
    {
        public QLNCC()
        {
            InitializeComponent();
        }
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

        private void LamMoi()
        {
            txtMaNCC.Text = "Mã NCC";
            txtMaNCC.ForeColor = Color.Gray;

            txtTenNCC.Text = "Tên nhà cung cấp";
            txtTenNCC.ForeColor = Color.Gray;

            txtSDT.Text = "Số điện thoại";
            txtSDT.ForeColor = Color.Gray;

            txtCty.Text = "Tên công ty";
            txtCty.ForeColor = Color.Gray;

            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Gray;

            txtSP.Text = "Sản phẩm cung cấp";
            txtSP.ForeColor = Color.Gray;

            dgvNCC.ClearSelection();
            txtMaNCC.Focus();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        void loadDL()
        {
            try
            {
                ketnoi();
                dgvNCC.Rows.Clear();
                dgvNCC.Columns.Clear();

                dgvNCC.Columns.Add("MaNCC", "Mã NCC");
                dgvNCC.Columns.Add("TenNCC", "Tên nhà cung cấp");
                dgvNCC.Columns.Add("SDT", "SĐT");
                dgvNCC.Columns.Add("TenCongTy", "Tên công ty");
                dgvNCC.Columns.Add("Email", "Email");
                dgvNCC.Columns.Add("SanPhamCungCap", "Sản phẩm cung cấp");

                string sql = "SELECT * FROM NhaCungCap";
                cmd = new SqlCommand(sql, cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvNCC.Rows.Add(
                        dr["MaNCC"],
                        dr["TenNCC"],
                        dr["SDT"],
                        dr["TenCongTy"],
                        dr["Email"],
                        dr["SanPhamCungCap"]
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
        private void QLNCC_Load(object sender, EventArgs e)
        {
            LamMoi();
            txtMaNCC.Enter += (s, ea) =>
            {
                if (txtMaNCC.Text == "Mã NCC") { txtMaNCC.Text = ""; txtMaNCC.ForeColor = Color.Black; }
            };
            txtMaNCC.Leave += (s, ea) =>
            {
                if (string.IsNullOrWhiteSpace(txtMaNCC.Text)) { txtMaNCC.Text = "Mã NCC"; txtMaNCC.ForeColor = Color.Gray; }
            };
            txtMaNCC.KeyPress += (s, ea) =>
            {
                if (!char.IsControl(ea.KeyChar) && !char.IsDigit(ea.KeyChar)) ea.Handled = true;
            };

            txtTenNCC.Enter += (s, ea) =>
            {
                if (txtTenNCC.Text == "Tên nhà cung cấp") { txtTenNCC.Text = ""; txtTenNCC.ForeColor = Color.Black; }
            };
            txtTenNCC.Leave += (s, ea) =>
            {
                if (string.IsNullOrWhiteSpace(txtTenNCC.Text)) { txtTenNCC.Text = "Tên nhà cung cấp"; txtTenNCC.ForeColor = Color.Gray; }
            };

            txtSDT.Enter += (s, ea) =>
            {
                if (txtSDT.Text == "Số điện thoại") { txtSDT.Text = ""; txtSDT.ForeColor = Color.Black; }
            };
            txtSDT.Leave += (s, ea) =>
            {
                if (string.IsNullOrWhiteSpace(txtSDT.Text)) { txtSDT.Text = "Số điện thoại"; txtSDT.ForeColor = Color.Gray; }
            };
            txtSDT.KeyPress += txtSDT_KeyPress;

            txtCty.Enter += (s, ea) =>
            {
                if (txtCty.Text == "Tên công ty") { txtCty.Text = ""; txtCty.ForeColor = Color.Black; }
            };
            txtCty.Leave += (s, ea) =>
            {
                if (string.IsNullOrWhiteSpace(txtCty.Text)) { txtCty.Text = "Tên công ty"; txtCty.ForeColor = Color.Gray; }
            };

            txtEmail.Enter += (s, ea) =>
            {
                if (txtEmail.Text == "Email") { txtEmail.Text = ""; txtEmail.ForeColor = Color.Black; }
            };
            txtEmail.Leave += (s, ea) =>
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text)) { txtEmail.Text = "Email"; txtEmail.ForeColor = Color.Gray; }
            };

            txtSP.Enter += (s, ea) =>
            {
                if (txtSP.Text == "Sản phẩm cung cấp") { txtSP.Text = ""; txtSP.ForeColor = Color.Black; }
            };
            txtSP.Leave += (s, ea) =>
            {
                if (string.IsNullOrWhiteSpace(txtSP.Text)) { txtSP.Text = "Sản phẩm cung cấp"; txtSP.ForeColor = Color.Gray; }
            };

            loadDL();
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvNCC.Rows[e.RowIndex];

            txtMaNCC.Text = row.Cells[0].Value?.ToString() ?? "";
            txtMaNCC.ForeColor = Color.Black;
            txtTenNCC.Text = row.Cells[1].Value?.ToString() ?? "";
            txtTenNCC.ForeColor = Color.Black;
            txtSDT.Text = row.Cells[2].Value?.ToString() ?? "";
            txtSDT.ForeColor = Color.Black;
            txtCty.Text = row.Cells[3].Value?.ToString() ?? "";
            txtCty.ForeColor = Color.Black;
            txtEmail.Text = row.Cells[4].Value?.ToString() ?? "";
            txtEmail.ForeColor = Color.Black;
            txtSP.Text = row.Cells[5].Value?.ToString() ?? "";
            txtSP.ForeColor = Color.Black;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text.Trim();
            if (maNCC == "Mã NCC") maNCC = "";

            string tenNCC = txtTenNCC.Text.Trim();
            if (tenNCC == "Tên nhà cung cấp") tenNCC = "";

            string sdt = txtSDT.Text.Trim();
            if (sdt == "Số điện thoại") sdt = "";

            string cty = txtCty.Text.Trim();
            if (cty == "Tên công ty") cty = "";

            string email = txtEmail.Text.Trim();
            if (email == "Email") email = "";

            string sp = txtSP.Text.Trim();
            if (sp == "Sản phẩm cung cấp") sp = "";

            if (string.IsNullOrEmpty(maNCC) || string.IsNullOrEmpty(tenNCC))
            {
                MessageBox.Show("Vui lòng nhập Mã NCC và Tên nhà cung cấp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi();
            string sqlKt = "SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = N'" + maNCC + "'";
            cmd = new SqlCommand(sqlKt, cnn);
            int dem = (int)cmd.ExecuteScalar();
            dongkn();

            if (dem > 0)
            {
                MessageBox.Show("Mã NCC đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi();
            string sql = "INSERT INTO NhaCungCap (MaNCC, TenNCC, SDT, TenCongTy, Email, SanPhamCungCap) " +
                         "VALUES(N'" + maNCC + "', N'" + tenNCC + "', N'" + sdt + "', N'" + cty + "', N'" + email + "', N'" + sp + "')";
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongkn();

            loadDL();
            LamMoi();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text.Trim();
            if (string.IsNullOrEmpty(maNCC) || maNCC == "Mã NCC")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenNCC = txtTenNCC.Text.Trim();
            if (string.IsNullOrEmpty(tenNCC) || tenNCC == "Tên nhà cung cấp")
            {
                MessageBox.Show("Vui lòng nhập Tên nhà cung cấp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sdt = txtSDT.Text.Trim();
            if (sdt == "Số điện thoại") sdt = "";

            string cty = txtCty.Text.Trim();
            if (cty == "Tên công ty") cty = "";

            string email = txtEmail.Text.Trim();
            if (email == "Email") email = "";

            string sp = txtSP.Text.Trim();
            if (sp == "Sản phẩm cung cấp") sp = "";

            ketnoi();
            string sql = "UPDATE NhaCungCap SET TenNCC=N'" + tenNCC +
                         "', SDT=N'" + sdt +
                         "', TenCongTy=N'" + cty +
                         "', Email=N'" + email +
                         "', SanPhamCungCap=N'" + sp +
                         "' WHERE MaNCC=N'" + maNCC + "'";
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongkn();

            loadDL();
            LamMoi();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text.Trim();
            if (string.IsNullOrEmpty(maNCC) || maNCC == "Mã NCC")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult chon = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                ketnoi();
                string sql = "DELETE FROM NhaCungCap WHERE MaNCC=N'" + maNCC + "'";
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                dongkn();

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
