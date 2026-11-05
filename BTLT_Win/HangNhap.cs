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
    public partial class HangNhap : UserControl
    {
        public HangNhap()
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
            txtMaaSP.Text = "Mã SP"; txtMaaSP.ForeColor = Color.Gray;
            txtTennSP.Clear();
            txtGiaaSP.Clear();
            txtSoLuong.Text = "1"; // Mặc định = 1
            dgvDanhSach.ClearSelection();
            txtMaaSP.Focus();
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
                dgvDanhSach.Columns.Add("SoLuong", "Tồn Kho"); // Hiển thị số lượng

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
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void hàngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HangXuat ucX = new HangXuat();
            ucX.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucX);
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string maSP = txtMaaSP.Text.Trim();
            if (maSP == "Mã SP") maSP = "";

            string tenSP = txtTennSP.Text;
            if (string.IsNullOrWhiteSpace(tenSP))
            {
                MessageBox.Show("Nhập Tên SP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennSP.Focus();
                return;
            }
            tenSP = tenSP.Trim();

            string giaSPtext = txtGiaaSP.Text.Trim();
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

            // === KIỂM TRA SỐ LƯỢNG ===
            string slText = txtSoLuong.Text.Trim();
            if (string.IsNullOrWhiteSpace(slText)) slText = "1";
            if (!int.TryParse(slText, out int soLuongNhap) || soLuongNhap <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            ketnoi();
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                // 1. Thêm hóa đơn nhập — ĐÃ CÓ cột SoLuong
                string maHD = "N" + DateTime.Now.ToString("yyyyMMddHHmmss");
                cmd = new SqlCommand(
                    "INSERT INTO HoaDonNhap(MaHDNhap, NgayNhap, GiaSP, SoLuong, TongTien) " +
                    "VALUES(@MaHD, GETDATE(), @GiaSP, @SoLuong, @TongTien)", cnn, tran);
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.Parameters.AddWithValue("@GiaSP", giaSP);
                cmd.Parameters.AddWithValue("@SoLuong", soLuongNhap);
                cmd.Parameters.AddWithValue("@TongTien", giaSP * soLuongNhap);
                cmd.ExecuteNonQuery();

                // 2. Kiểm tra đã có sản phẩm chưa
                int tonTai = 0;
                if (!string.IsNullOrEmpty(maSP))
                {
                    cmd = new SqlCommand("SELECT COUNT(*) FROM TonKho WHERE STT = @MaSP", cnn, tran);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    tonTai = (int)cmd.ExecuteScalar();
                }

                if (tonTai > 0)
                {
                    // === ĐÃ CÓ → Cộng số lượng ===
                    cmd = new SqlCommand(
                        "UPDATE TonKho SET SoLuongTon = SoLuongTon + @SoLuong, NgayCapNhat = GETDATE() " +
                        "WHERE STT = @MaSP", cnn, tran);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuongNhap);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    // === CHƯA CÓ → Tạo mới ===
                    cmd = new SqlCommand("SELECT ISNULL(MAX(STT), 0) + 1 FROM TonKho", cnn, tran);
                    int sttMoi = (int)cmd.ExecuteScalar();

                    cmd = new SqlCommand(
                        "INSERT INTO TonKho(STT, TenSP, SoLuongTon, GiaBan, NgayCapNhat) " +
                        "VALUES(@STT, @TenSP, @SoLuong, @GiaBan, GETDATE())", cnn, tran);
                    cmd.Parameters.AddWithValue("@STT", sttMoi);
                    cmd.Parameters.AddWithValue("@TenSP", tenSP);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuongNhap);
                    cmd.Parameters.AddWithValue("@GiaBan", giaSP);
                    cmd.ExecuteNonQuery();
                }

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

            MessageBox.Show($"Nhập thành công {soLuongNhap} sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDL();
            LamMoi();
        }

        private void txtXemTatCa_Click(object sender, EventArgs e)
        {
            loadDL();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã in phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

            txtMaaSP.Text = row.Cells[0].Value?.ToString() ?? "";
            txtMaaSP.ForeColor = Color.Black;
            txtTennSP.Text = row.Cells[1].Value?.ToString() ?? "";
            txtTennSP.ForeColor = Color.Black;
            txtGiaaSP.Text = row.Cells[2].Value?.ToString() ?? "";
            txtGiaaSP.ForeColor = Color.Black;
            txtSoLuong.Text = row.Cells[3].Value?.ToString() ?? "";
            txtSoLuong.ForeColor = Color.Black;
        }

        private void HangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaaSP.Text.Trim();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaaSP.Text.Trim();
            if (maSP == "Mã SP" || string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenSP = txtTennSP.Text.Trim();
            string giaSPtext = txtGiaaSP.Text.Trim();

            if (string.IsNullOrEmpty(tenSP))
            {
                MessageBox.Show("Nhập Tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLoaiSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
