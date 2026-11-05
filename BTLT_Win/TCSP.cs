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
    public partial class TCSP : Form
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

        void loadDL()
        {
            try
            {
                ketnoi();
                DgvSP.Rows.Clear();

                string sql = "SELECT * FROM SanPham";
                cmd = new SqlCommand(sql, cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DgvSP.Rows.Add(
                        dr[0],
                        dr[1],
                        dr[2],
                        dr[3],
                        dr[4]
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
        public TCSP()
        {

            InitializeComponent();
        }

        private void TCSP_Load(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;

            txtTimKiem.Enter += txtTimKiem_Enter;
            txtTimKiem.Leave += txtTimKiem_Leave;
            loadDL();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
            DgvSP.ClearSelection();
            loadDL();
            txtTimKiem.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text.Trim();

            // Nếu chưa nhập gì → load toàn bộ
            if (tukhoa == "" || tukhoa == "Tìm kiếm...")
            {
                loadDL();
                return;
            }

            try
            {
                ketnoi();
                DgvSP.Rows.Clear();

                string sql = "SELECT * FROM SanPham WHERE " +
                             "TenSP LIKE N'%" + tukhoa + "%' OR " +
                             "STT LIKE '%" + tukhoa + "%'";

                cmd = new SqlCommand(sql, cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DgvSP.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
                }

                if (DgvSP.RowCount == 0)
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dr != null && !dr.IsClosed) dr.Close();
                dongkn();
            }
        }
    }

}