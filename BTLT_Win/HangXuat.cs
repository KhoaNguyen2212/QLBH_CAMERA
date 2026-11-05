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
    public partial class HangXuat : UserControl
    {
        public HangXuat()
        {
            InitializeComponent();
            loadDL();
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
            txtMaSP.Text = "Mã SP"; txtMaSP.ForeColor = Color.Gray;
            txtTenSP.Clear();
            txtGiaSP.Clear();
            txtSoLuong.Text = "1"; // Mặc định xuất 1
            dgvDanhSach.ClearSelection();
            txtMaSP.Focus();
        }

        void loadDL()
        {
            try
            {
                ketnoi();
                dgvDanhSach.Rows.Clear();
                dgvDanhSach.Columns.Clear();

                dgvDanhSach.Columns.Add("MaSP", "Mã SP");
                dgvDanhSach.Columns.Add("TenSP", "Tên SP");
                dgvDanhSach.Columns.Add("GiaSP", "Giá SP");
                dgvDanhSach.Columns.Add("SoLuong", "Tồn Kho");

                string sql = "SELECT STT AS MaSP, TenSP, GiaBan AS GiaSP, SoLuongTon AS SoLuong FROM TonKho ORDER BY STT";
                cmd = new SqlCommand(sql, cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvDanhSach.Rows.Add(
                        dr["MaSP"],
                        dr["TenSP"],
                        dr["GiaSP"],
                        dr["SoLuong"]
                    );
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
        

        private void hàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HangNhap ucN = new HangNhap();
            ucN.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucN);
        }
        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TonKho frmKho = new TonKho();
            frmKho.TopLevel = false;
            frmKho.FormBorderStyle = FormBorderStyle.None;
            frmKho.Dock = DockStyle.Fill;

            this.Controls.Clear();
            this.Controls.Add(frmKho);

            frmKho.Show();
        }

        private void HangXuat_Load(object sender, EventArgs e)
        {

        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            if (maSP == "Mã SP") maSP = "";

            string tenSP = txtTenSP.Text;
            if (string.IsNullOrWhiteSpace(tenSP))
            {
                MessageBox.Show("Nhập Tên SP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            tenSP = tenSP.Trim();

            string giaSPtext = txtGiaSP.Text.Trim();
            if (string.IsNullOrWhiteSpace(giaSPtext))
            {
                MessageBox.Show("Nhập Giá SP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(giaSPtext, out decimal giaSP) || giaSP < 0)
            {
                MessageBox.Show("Giá SP không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // === KIỂM TRA SỐ LƯỢNG XUẤT ===
            string slText = txtSoLuong.Text.Trim();
            if (string.IsNullOrWhiteSpace(slText)) slText = "1";
            if (!int.TryParse(slText, out int soLuongXuat) || soLuongXuat <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            string maHD = "X" + DateTime.Now.ToString("yyyyMMddHHmmss");

            ketnoi();
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                // 1. Kiểm tra tồn kho đủ không
                cmd = new SqlCommand("SELECT SoLuongTon FROM TonKho WHERE STT = @MaSP", cnn, tran);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                object slObj = cmd.ExecuteScalar();

                if (slObj == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tran.Rollback();
                    dongkn();
                    return;
                }

                int soLuongTon = (int)slObj;
                if (soLuongTon < soLuongXuat)
                {
                    MessageBox.Show($"Chỉ có {soLuongTon} sản phẩm trong kho! Không đủ xuất {soLuongXuat}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tran.Rollback();
                    dongkn();
                    return;
                }

                // 2. Thêm hóa đơn xuất — khớp cột thực tế của bạn
                cmd = new SqlCommand(
                    "INSERT INTO HoaDonXuat(MaHDXuat, NgayXuat, GiaSP, SoLuong, TongTien) " +
                    "VALUES(@MaHD, GETDATE(), @GiaSP, @SoLuong, @TongTien)", cnn, tran);
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.Parameters.AddWithValue("@GiaSP", giaSP);
                cmd.Parameters.AddWithValue("@SoLuong", soLuongXuat);
                cmd.Parameters.AddWithValue("@TongTien", giaSP * soLuongXuat);
                cmd.ExecuteNonQuery();

                // 3. Giảm số lượng trong kho
                cmd = new SqlCommand(
                    "UPDATE TonKho SET SoLuongTon = SoLuongTon - @SoLuong, NgayCapNhat = GETDATE() " +
                    "WHERE STT = @MaSP", cnn, tran);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@SoLuong", soLuongXuat);
                cmd.ExecuteNonQuery();

                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dongkn();
                return;
            }
            dongkn();

            MessageBox.Show($"Xuất thành công {soLuongXuat} sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDL();
            LamMoi();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            if (maSP == "Mã SP" || string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Xóa sản phẩm này khỏi kho?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ketnoi();
                cmd = new SqlCommand("DELETE FROM TonKho WHERE STT = @MaSP", cnn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.ExecuteNonQuery();
                dongkn();

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDL();
                LamMoi();
            }
        }
        

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã in phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtXemTatCa_Click(object sender, EventArgs e)
        {
            loadDL();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

            txtMaSP.Text = row.Cells[0].Value?.ToString() ?? "";
            txtMaSP.ForeColor = Color.Black;
            txtTenSP.Text = row.Cells[1].Value?.ToString() ?? "";
            txtTenSP.ForeColor = Color.Black;
            txtGiaSP.Text = row.Cells[2].Value?.ToString() ?? "";
            txtGiaSP.ForeColor = Color.Black;
            txtSoLuong.Text = "1";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            if (maSP == "Mã SP" || string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenSP = txtTenSP.Text;
            if (string.IsNullOrWhiteSpace(tenSP))
            {
                MessageBox.Show("Nhập Tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tenSP = tenSP.Trim();

            string giaSPtext = txtGiaSP.Text.Trim();
            if (!decimal.TryParse(giaSPtext, out decimal giaSP) || giaSP < 0)
            {
                MessageBox.Show("Giá SP không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi();
            try
            {
                cmd = new SqlCommand(@"UPDATE TonKho 
                               SET TenSP = @TenSP, GiaBan = @GiaBan, NgayCapNhat = GETDATE() 
                               WHERE STT = @MaSP", cnn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@TenSP", tenSP);
                cmd.Parameters.AddWithValue("@GiaBan", giaSP);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dongkn();
            }

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDL();
            LamMoi();
        }
    }
}
