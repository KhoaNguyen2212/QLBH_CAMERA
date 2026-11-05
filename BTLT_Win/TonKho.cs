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
    public partial class TonKho : Form
    {
        public TonKho()
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
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
        }

        void dongkn()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();
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
                dgvDanhSach.Columns.Add("SoLuongTon", "Số lượng");
                dgvDanhSach.Columns.Add("GiaBan", "Giá bán");
                dgvDanhSach.Columns.Add("ThanhTien", "Thành tiền");

                string sql = "SELECT STT AS MaSP, TenSP, SoLuongTon, GiaBan, (SoLuongTon * GiaBan) AS ThanhTien FROM TonKho ORDER BY STT";
                cmd = new SqlCommand(sql, cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvDanhSach.Rows.Add(
                        dr["MaSP"],
                        dr["TenSP"],
                        dr["SoLuongTon"],
                        dr["GiaBan"],
                        dr["ThanhTien"]
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

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HangNhap ucN = new HangNhap();
            ucN.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucN);
        }

        private void hàngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HangXuat ucX = new HangXuat();
            ucX.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucX);
        }

        private void TonKho_Load(object sender, EventArgs e)
        {

        }

        private void dgvHDX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDL();
            MessageBox.Show("Đã cập nhật dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
