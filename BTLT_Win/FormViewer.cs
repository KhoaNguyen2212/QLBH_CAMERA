using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace BTLT_Win
{
    public partial class FormViewer : Form
    {
        // Khai báo đối tượng Viewer bằng code để hiển thị báo cáo
        private CrystalReportViewer myViewer;

        // Lưu trữ tài liệu báo cáo để gọi sự kiện in
        private ReportDocument cryReport;

        // Chuỗi kết nối SQL Server tới CSDL quản lý cửa hàng camera của bạn
        string strCon = @"Data Source=.\MSSQLSERVER01;Initial Catalog=QuanLyCuaHangCamera;Integrated Security=True";

        private string currentMaHD = "";

        public FormViewer()
        {
            InitializeComponent();

            // 1. TẠO GIAO DIỆN VIEWER BẰNG CODE
            myViewer = new CrystalReportViewer();
            myViewer.Dock = DockStyle.Fill;
            // Đưa Viewer xuống dưới nút In để nút In luôn nổi lên trên cùng
            this.Controls.Add(myViewer);
            myViewer.BringToFront();
            btnPrint.BringToFront();
        }

        // Hàm nhận mã hóa đơn từ form bên ngoài truyền vào để hiển thị
        public void LoadHoaDon(string maHD)
        {
            currentMaHD = maHD;
        }

        private void FormViewer_Load(object sender, EventArgs e)
        {
            try
            {
                // 2. LẤY DỮ LIỆU TỪ SQL SERVER THEO HÓA ĐƠN
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    string query = @"SELECT hd.MaHD, hd.NgayTao, kh.TenKH, sp.TenSP, cthd.SoLuong, cthd.DonGia, cthd.ThanhTien 
                                     FROM HoaDon hd 
                                     LEFT JOIN KhachHang kh ON hd.MaKH = kh.MaKH 
                                     INNER JOIN ChiTietHoaDon cthd ON hd.MaHD = cthd.MaHD 
                                     INNER JOIN SanPham sp ON cthd.MaSP = sp.MaSP 
                                     WHERE hd.MaHD = @MaHD";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Nếu chưa truyền mã, lấy mặc định hóa đơn đầu tiên để test
                        if (string.IsNullOrEmpty(currentMaHD)) currentMaHD = "HD01";
                        cmd.Parameters.AddWithValue("@MaHD", currentMaHD);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // 3. TẢI GIAO DIỆN BÁO CÁO (.rpt)
                            cryReport = new ReportDocument();
                            string reportPath = Application.StartupPath + @"\CrystalReportHoaDon.rpt";
                            cryReport.Load(reportPath);

                            // 4. TRUYỀN DỮ LIỆU VÀ HIỂN THỊ
                            cryReport.SetDataSource(dt);
                            myViewer.ReportSource = cryReport;
                            myViewer.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SỰ KIỆN KHI BẤM NÚT "IN HÓA ĐƠN"
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cryReport != null)
                {
                    // Gọi hộp thoại Print của Crystal Reports để chọn máy in và thực hiện in
                    cryReport.PrintOptions.NoPrinter = false;
                    cryReport.PrintToPrinter(1, true, 1, 1);
                    MessageBox.Show("Đã gửi lệnh in hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chưa có dữ liệu báo cáo để in!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in hóa đơn: " + ex.Message, "Lỗi in ấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}