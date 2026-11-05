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
    public partial class QLNV : Form
    {
        string chuoikn = @"Data Source=DESKTOP-VEDD4V5\SQLEXPRESS;Initial Catalog=QLBH_CAMERA;Integrated Security=True";

        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        void thucthisql(string sql)
        {
            ketnoi();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongkn();
        }

        void ketnoi()
        {
            cnn = new SqlConnection(chuoikn);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
        }

        void dongkn()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        private void LamMoi()
        {
            txtID.Text = "Mã nhân viên";
            txtID.ForeColor = Color.Gray;
            txtHoTen.Text = "Họ và tên";
            txtHoTen.ForeColor = Color.Gray;
            txtSDT.Text = "Số điện thoại";
            txtSDT.ForeColor = Color.Gray;
            txtNamSinh.Text = "Năm sinh";
            txtNamSinh.ForeColor = Color.Gray;
            DgvNhanVien.ClearSelection();
            txtID.Focus();
        }
        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "Mã nhân viên")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "Mã nhân viên";
                txtID.ForeColor = Color.Gray;
            }
        }
        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "Họ và tên")
            {
                txtHoTen.Text = "";
                txtHoTen.ForeColor = Color.Black;
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                txtHoTen.Text = "Họ và tên";
                txtHoTen.ForeColor = Color.Gray;
            }
        }


        void loadDL()
        {
            try
            {
                ketnoi();
                DgvNhanVien.Rows.Clear();

                string sql = "SELECT * FROM QLNV";
                cmd = new SqlCommand(sql, cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                 
                    DgvNhanVien.Rows.Add(
                        dr[0],
                        dr[1],  
                        dr[2],  
                        dr[3],  
                        dr[4], 
                        dr[5], 
                        dr[6] 
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                dongkn();
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        void Loadcbb()
        {
            ketnoi();
            cbbGioiTinh.Items.Clear();
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.SelectedIndex = -1;

            cbbCaLam.Items.Clear();
            cbbCaLam.Items.Add("Sáng");
            cbbCaLam.Items.Add("Tối");
            cbbCaLam.SelectedIndex = -1;

            dongkn();
        }
        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = DgvNhanVien.Rows[e.RowIndex];

            txtID.Text = row.Cells[0].Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells[1].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells[2].Value?.ToString() ?? "";

            string sNgayBD = row.Cells[3].Value?.ToString()?.Trim() ?? "";
            DateTime dtNgay;
            if (DateTime.TryParse(sNgayBD, out dtNgay))
                dtpNgayBatDau.Value = dtNgay;
            else
                dtpNgayBatDau.Value = DateTime.Now; 

            txtNamSinh.Text = row.Cells[4].Value?.ToString() ?? "";

            cbbGioiTinh.Text = row.Cells[5].Value?.ToString() ?? "";
            cbbCaLam.Text = row.Cells[6].Value?.ToString() ?? "";
        }
        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() == "Số điện thoại")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }
        private void txtNamSinh_Enter(object sender, EventArgs e)
        {
            if (txtNamSinh.Text.Trim() == "Năm sinh")
            {
                txtNamSinh.Text = "";
                txtNamSinh.ForeColor = Color.Black;
            }
        }

        private void txtNamSinh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamSinh.Text))
            {
                txtNamSinh.Text = "Năm sinh";
                txtNamSinh.ForeColor = Color.Gray;
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
        public QLNV()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (id == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                string sql = "DELETE FROM QLNV WHERE id = '" + id + "'";
                thucthisql(sql);
                loadDL();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            txtID.Text = "Mã nhân viên";
            txtID.ForeColor = Color.Gray;

            txtHoTen.Text = "Họ và tên";
            txtHoTen.ForeColor = Color.Gray;

            txtSDT.Text = "Số điện thoại";
            txtSDT.ForeColor = Color.Gray;

            txtNamSinh.Text = "Năm sinh";
            txtNamSinh.ForeColor = Color.Gray;

            // Gắn sự kiện Enter/Leave
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;

            txtHoTen.Enter += txtHoTen_Enter;
            txtHoTen.Leave += txtHoTen_Leave;

            txtSDT.Enter += txtSDT_Enter;
            txtSDT.Leave += txtSDT_Leave;
            txtSDT.KeyPress += txtSDT_KeyPress;

            txtNamSinh.Enter += txtNamSinh_Enter;
            txtNamSinh.Leave += txtNamSinh_Leave;
            txtNamSinh.KeyPress += txtNamSinh_KeyPress;

            txtID.KeyPress += txtID_KeyPress;

            Loadcbb();
            loadDL();
        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            if (id == "Mã nhân viên") id = "";

            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "Họ và tên") hoTen = "";

            string sdt = txtSDT.Text.Trim();
            if (sdt == "Số điện thoại") sdt = "";

            string namSinh = txtNamSinh.Text.Trim();
            if (namSinh == "Năm sinh") namSinh = "";

            string ngayBatDau = dtpNgayBatDau.Value.ToString("yyyy/MM/dd");


            ketnoi();
            string sqlKiemTra = "SELECT COUNT(*) FROM QLNV WHERE id = '" + id + "'";
            cmd = new SqlCommand(sqlKiemTra, cnn);
            int i = (int)cmd.ExecuteScalar();
            dongkn();

            if (i > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gioiTinh = cbbGioiTinh.Text;
            string caLam = cbbCaLam.Text;

            ketnoi();
            string sql = "INSERT INTO QLNV (id, HoTen, Sdt, NgayBD, NamSinh, GioiTinh, CaLam) " +
                "VALUES('" + id + "', N'" + hoTen + "', '" + sdt + "', '" + ngayBatDau + "', '" + namSinh + "', N'" + gioiTinh + "', N'" + caLam + "')";
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongkn();

            loadDL();
            MessageBox.Show("Thêm thành công");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }


            if (id == "Mã nhân viên") id = "";
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "Họ và tên") hoTen = "";

            string sdt = txtSDT.Text.Trim();
            if (sdt == "Số điện thoại") sdt = "";

            string namSinh = txtNamSinh.Text.Trim();
            if (namSinh == "Năm sinh") namSinh = "";

            string ngayBatDau = dtpNgayBatDau.Value.ToString("yyyy/MM/dd");
            string gioiTinh = cbbGioiTinh.Text;
            string caLam = cbbCaLam.Text;

            ketnoi();
            string sqlKiemTra = "SELECT COUNT(*) FROM QLNV WHERE id = '" + id + "'";
            cmd = new SqlCommand(sqlKiemTra, cnn);
            int i = (int)cmd.ExecuteScalar();
            dongkn();

            if (i == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại, không thể sửa");
                return;
            }

            ketnoi();
            string sql = "UPDATE QLNV SET HoTen = N'" + hoTen + "', Sdt = '" + sdt + "', NgayBD = '" + ngayBatDau + "', " +
             "NamSinh = '" + namSinh + "', GioiTinh = N'" + gioiTinh + "', CaLam = N'" + caLam + "' WHERE id = '" + id + "'";
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongkn();

            loadDL();
            MessageBox.Show("Sửa thành công");
        }
        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void cbbCaLam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = DgvNhanVien.Rows[e.RowIndex];

            txtID.Text = row.Cells[0].Value?.ToString() ?? "";
            txtID.ForeColor = Color.Black;

            txtHoTen.Text = row.Cells[1].Value?.ToString() ?? "";
            txtHoTen.ForeColor = Color.Black;

            txtSDT.Text = row.Cells[2].Value?.ToString() ?? "";
            txtSDT.ForeColor = Color.Black;

            string sNgayBD = row.Cells[3].Value?.ToString()?.Trim() ?? "";
            DateTime dtNgay;
            if (DateTime.TryParse(sNgayBD, out dtNgay))
                dtpNgayBatDau.Value = dtNgay;
            else
                dtpNgayBatDau.Value = DateTime.Now;

            txtNamSinh.Text = row.Cells[4].Value?.ToString() ?? "";
            txtNamSinh.ForeColor = Color.Black;

            cbbGioiTinh.Text = row.Cells[5].Value?.ToString()?.Trim() ?? "";
            cbbCaLam.Text = row.Cells[6].Value?.ToString()?.Trim() ?? "";
        }

        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
