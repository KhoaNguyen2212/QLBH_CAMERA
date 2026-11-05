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

    public partial class QLSP1 : Form
    {
        public QLSP1()
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
            if (cnn.State == ConnectionState.Closed) cnn.Open();
        }

        void dongkn()
        {
            if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
        }

        private void LamMoi()
        {
            txtSTT.Text = "Số thứ tự"; txtSTT.ForeColor = Color.Gray;
            txtTenSP.Text = "Tên sản phẩm"; txtTenSP.ForeColor = Color.Gray;
            txtSL.Text = "Số lượng"; txtSL.ForeColor = Color.Gray;
            txtDonGia.Text = "Đơn giá"; txtDonGia.ForeColor = Color.Gray;
            txtThanhTien.Clear();
            dgvSanPham.ClearSelection();
            txtTenSP.Focus();
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) e.Handled = true;
        }

        private void TinhThanhTien()
        {
            if (int.TryParse(txtSL.Text.Trim(), out int sl) &&
                decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia))
                txtThanhTien.Text = (sl * donGia).ToString("N2");
            else txtThanhTien.Clear();
        }

        void loadDL()
        {
            try
            {
                ketnoi();
                dgvSanPham.Rows.Clear(); dgvSanPham.Columns.Clear();
                dgvSanPham.Columns.Add("STT", "STT");
                dgvSanPham.Columns.Add("TenSP", "Tên sản phẩm");
                dgvSanPham.Columns.Add("SL", "Số lượng");
                dgvSanPham.Columns.Add("DonGia", "Đơn giá");
                dgvSanPham.Columns.Add("ThanhTien", "Thành tiền");

                string sql = "SELECT * FROM SanPham ORDER BY STT";
                cmd = new SqlCommand(sql, cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgvSanPham.Rows.Add(dr["STT"], dr["TenSP"], dr["SL"], dr["DonGia"], dr["ThanhTien"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dr != null && !dr.IsClosed) dr.Close();
                dongkn();
            }
        }

        private void QLSP1_Load(object sender, EventArgs e)
        {
            LamMoi();
            txtSTT.Enter += (s, ea) => { if (txtSTT.Text == "Số thứ tự") { txtSTT.Text = ""; txtSTT.ForeColor = Color.Black; } };
            txtSTT.Leave += (s, ea) => { if (string.IsNullOrWhiteSpace(txtSTT.Text)) { txtSTT.Text = "Số thứ tự"; txtSTT.ForeColor = Color.Gray; } };
            txtTenSP.Enter += (s, ea) => { if (txtTenSP.Text == "Tên sản phẩm") { txtTenSP.Text = ""; txtTenSP.ForeColor = Color.Black; } };
            txtTenSP.Leave += (s, ea) => { if (string.IsNullOrWhiteSpace(txtTenSP.Text)) { txtTenSP.Text = "Tên sản phẩm"; txtTenSP.ForeColor = Color.Gray; } };
            txtSL.Enter += (s, ea) => { if (txtSL.Text == "Số lượng") { txtSL.Text = ""; txtSL.ForeColor = Color.Black; } };
            txtSL.Leave += (s, ea) => { if (string.IsNullOrWhiteSpace(txtSL.Text)) { txtSL.Text = "Số lượng"; txtSL.ForeColor = Color.Gray; } };
            txtDonGia.Enter += (s, ea) => { if (txtDonGia.Text == "Đơn giá") { txtDonGia.Text = ""; txtDonGia.ForeColor = Color.Black; } };
            txtDonGia.Leave += (s, ea) => { if (string.IsNullOrWhiteSpace(txtDonGia.Text)) { txtDonGia.Text = "Đơn giá"; txtDonGia.ForeColor = Color.Gray; } };
            txtSL.TextChanged += (s, ea) => TinhThanhTien();
            txtDonGia.TextChanged += (s, ea) => TinhThanhTien();
            loadDL();

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
            txtSTT.Text = row.Cells[0].Value?.ToString() ?? ""; txtSTT.ForeColor = Color.Black;
            txtTenSP.Text = row.Cells[1].Value?.ToString() ?? ""; txtTenSP.ForeColor = Color.Black;
            txtSL.Text = row.Cells[2].Value?.ToString() ?? ""; txtSL.ForeColor = Color.Black;
            txtDonGia.Text = row.Cells[3].Value?.ToString() ?? ""; txtDonGia.ForeColor = Color.Black;
            txtThanhTien.Text = row.Cells[4].Value?.ToString() ?? ""; txtThanhTien.ForeColor = Color.Black;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sttText = txtSTT.Text.Trim();
            if (sttText == "Số thứ tự") sttText = "";
            string tenSP = txtTenSP.Text.Trim();
            if (tenSP == "Tên sản phẩm") tenSP = "";
            string slText = txtSL.Text.Trim();
            if (slText == "Số lượng") slText = "";
            string donGiaText = txtDonGia.Text.Trim();
            if (donGiaText == "Đơn giá") donGiaText = "";

            if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(slText))
            {
                MessageBox.Show("Nhập Tên sản phẩm và Số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(slText, out int sl) || sl < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(donGiaText, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal thanhTien = sl * donGia;

            ketnoi();
            if (!string.IsNullOrEmpty(sttText))
            {
                if (!int.TryParse(sttText, out int stt) || stt <= 0)
                {
                    MessageBox.Show("STT phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dongkn(); return;
                }
                cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE STT = " + stt, cnn);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("STT " + stt + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dongkn(); return;
                }
                cmd = new SqlCommand("SET IDENTITY_INSERT SanPham ON", cnn); cmd.ExecuteNonQuery();
                cmd = new SqlCommand("INSERT INTO SanPham (STT,TenSP,SL,DonGia,ThanhTien) VALUES(" + stt + ",N'" + tenSP + "'," + sl + "," + donGia + "," + thanhTien + ")", cnn); cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SET IDENTITY_INSERT SanPham OFF", cnn); cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO SanPham (TenSP,SL,DonGia,ThanhTien) VALUES(N'" + tenSP + "'," + sl + "," + donGia + "," + thanhTien + ")", cnn);
                cmd.ExecuteNonQuery();
            }
            dongkn();
            loadDL(); LamMoi();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSTT.Text.Trim(), out int stt))
            {
                MessageBox.Show("Chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSL.Text.Trim(), out int sl) || sl < 0) return;
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0) return;
            decimal thanhTien = sl * donGia;

            ketnoi();
            cmd = new SqlCommand("UPDATE SanPham SET TenSP=N'" + txtTenSP.Text.Trim() + "',SL=" + sl + ",DonGia=" + donGia + ",ThanhTien=" + thanhTien + " WHERE STT=" + stt, cnn);
            cmd.ExecuteNonQuery();
            dongkn();
            loadDL(); LamMoi();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSTT.Text.Trim(), out int stt))
            {
                MessageBox.Show("Chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ketnoi();
                cmd = new SqlCommand("DELETE FROM SanPham WHERE STT=" + stt, cnn);
                cmd.ExecuteNonQuery();
                dongkn();
                loadDL(); LamMoi();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
