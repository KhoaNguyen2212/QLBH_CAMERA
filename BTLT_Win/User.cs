using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLT_Win
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        //khai bao chuoi kn
        string chuoikn = @"Data Source=DESKTOP-VEDD4V5\SQLEXPRESS;Initial Catalog=QLBH_CAMERA;Integrated Security=True";
        //khai bao cacs doi tuong cuar ADO
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
        void loadDL()
        {
            try
            {
                // Mở kết nối
                ketnoi();

                // Xóa dữ liệu cũ trên DataGridView để tránh bị cộng dồn/nhân đôi dòng khi gọi lại hàm
                DgvUser.Rows.Clear();

                // Lấy dữ liệu từ bảng Users trong SQL
                string sql = "SELECT * FROM Users";
                cmd = new SqlCommand(sql, cnn);

                // Thực thi câu truy vấn
                dr = cmd.ExecuteReader();

                // Đọc dữ liệu trả về từ dr, đổ từng dòng vào dgvUser theo đúng các cột bạn đã tạo sẵn
                while (dr.Read())
                {
                    // dr[0]: Username, dr[1]: Password, dr[2]: Permission
                    DgvUser.Rows.Add(dr[0], dr[1], dr[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo đóng SqlDataReader và kết nối an toàn
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                dongkn();
            }
        }

        void Loadcbb()
        {
            ketnoi();
            da = new SqlDataAdapter("Select * from Users", cnn);
            dt = new DataTable();
            da.Fill(dt); // điền dữ liệu từ data adapter vào DataTable
            //ChoLoaiSP.DataSource = dt; // gán DataTable làm nguồn dữ liệu cho ComboBox
            //ChoLoaiSP.DisplayMember = "Permission"; // cột hiển thị
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            loadDL();
            Loadcbb();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex; // Lấy đúng dòng vừa nhấn

                txtUsername.Text = DgvUser.Rows[i].Cells[0].Value.ToString();
                txtPass.Text = DgvUser.Rows[i].Cells[1].Value.ToString();
                cbbPermission.Text = DgvUser.Rows[i].Cells[2].Value.ToString();
            }
        }
        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Khai báo biến lấy dữ liệu từ form
            string user = txtUsername.Text;
            string pass = txtPass.Text;
            string phanQuyen = cbbPermission.SelectedItem?.ToString() ?? ""; //gán bằng chuỗi rỗng "" thay vì để trống/null (gán 0 vào ngay)


            // Kiểm tra trùng Username
            string sqlKiemTra = "SELECT COUNT(*) FROM Users WHERE Username = '" + user + "'";
            cmd = new SqlCommand(sqlKiemTra, cnn);
            int i = (int)cmd.ExecuteScalar();

            if (i == 1)
            {
                MessageBox.Show("Username đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Thêm mới
                string sql = "INSERT INTO Users (Username, Password, Permission) VALUES('" + user + "', '" + pass + "', '" + phanQuyen + "')";
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();

                dongkn(); //đóng kết nối an toàn
                loadDL(); //cập nhật danh sách ngay
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ giao diện
            String user = txtUsername.Text;
            String pass = txtPass.Text;
            String phanQuyen = cbbPermission.SelectedItem.ToString();

            // 2. Mở kết nối CSDL
            ketnoi();

            // 3. Kiểm tra tài khoản có tồn tại không
            // Câu lệnh SQL đếm số lượng bản ghi có Username trùng với chữ người dùng nhập
            String sqlKiemTra = "Select count(*) From Users Where Username = '" + user + "'";
            cmd = new SqlCommand(sqlKiemTra, cnn);
            int i = (int)cmd.ExecuteScalar(); // ExecuteScalar dùng khi chỉ muốn lấy ra 1 giá trị duy nhất (ở đây là số đếm)

            // 4. Xử lý logic
            if (i == 0) // Không tìm thấy
            {
                MessageBox.Show("Username không tồn tại, không thể sửa");
                dongkn(); // Đóng kết nối
            }
            else // Đã tìm thấy
            {
                // Tạo câu lệnh cập nhật dữ liệu
                String sql = "Update Users Set Password = '" + pass + "', Permission = '" + phanQuyen + "' Where Username = '" + user + "'";
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery(); // ExecuteNonQuery dùng cho các lệnh Insert, Update, Delete (không trả về bảng dữ liệu)

                dongkn(); // Đóng kết nối
                loadDL(); // Load lại DataGridView
                MessageBox.Show("Sửa thành công");
            }
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtUsername.Text;

            // Kiểm tra nếu ô trống
            if (ma == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                // ĐÚNG: Bảng Users, cột Username
                string sql = "Delete From Users Where Username = '" + ma + "'";
                thucthisql(sql);
                loadDL();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void cbbPermission_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
