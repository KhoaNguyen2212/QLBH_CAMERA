namespace BTLT_Win
{
    partial class QLNV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbCaLam = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();

            // Đổi GroupBox thành Panel để loại bỏ viền kẻ
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.lblDanhSach = new System.Windows.Forms.Label();

            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            this.SuspendLayout();

            // 
            // label1 (Tiêu đề chính)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229))))); // Tím Indigo
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";

            // 
            // label2 (ID)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";

            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtID.Location = new System.Drawing.Point(39, 105);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 27);
            this.txtID.TabIndex = 14;
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);

            // 
            // label9 (Họ tên)
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label9.Location = new System.Drawing.Point(175, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Họ và tên";
            this.label9.Click += new System.EventHandler(this.label9_Click);

            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtHoTen.Location = new System.Drawing.Point(179, 105);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(190, 27);
            this.txtHoTen.TabIndex = 16;
            this.txtHoTen.Enter += new System.EventHandler(this.txtHoTen_Enter);
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave);

            // 
            // label5 (SĐT)
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(35, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";

            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSDT.Location = new System.Drawing.Point(39, 165);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(330, 27);
            this.txtSDT.TabIndex = 17;

            // 
            // label11 (Năm sinh)
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label11.Location = new System.Drawing.Point(35, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Năm sinh";
            this.label11.Click += new System.EventHandler(this.label11_Click);

            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BackColor = System.Drawing.Color.White;
            this.txtNamSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamSinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNamSinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtNamSinh.Location = new System.Drawing.Point(39, 225);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(155, 27);
            this.txtNamSinh.TabIndex = 31;

            // 
            // label10 (Giới tính)
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label10.Location = new System.Drawing.Point(210, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Giới tính";

            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.BackColor = System.Drawing.Color.White;
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(214, 225);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(155, 28);
            this.cbbGioiTinh.TabIndex = 30;
            this.cbbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cbbGioiTinh.Text = "Nam";
            this.cbbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbbGioiTinh_SelectedIndexChanged);

            // 
            // label6 (Ngày Bắt đầu)
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(35, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Bắt đầu";

            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CalendarFont = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(39, 285);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(330, 27);
            this.dtpNgayBatDau.TabIndex = 24;
            this.dtpNgayBatDau.Value = new System.DateTime(2026, 10, 1, 15, 30, 45, 0);

            // 
            // label8 (Ca làm)
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(35, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ca làm";

            // 
            // cbbCaLam
            // 
            this.cbbCaLam.BackColor = System.Drawing.Color.White;
            this.cbbCaLam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCaLam.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbCaLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbbCaLam.FormattingEnabled = true;
            this.cbbCaLam.Location = new System.Drawing.Point(39, 345);
            this.cbbCaLam.Name = "cbbCaLam";
            this.cbbCaLam.Size = new System.Drawing.Size(330, 28);
            this.cbbCaLam.TabIndex = 13;
            this.cbbCaLam.Items.AddRange(new object[] { "Sáng", "Chiều", "Tối" });
            this.cbbCaLam.Text = "Sáng";
            this.cbbCaLam.SelectedIndexChanged += new System.EventHandler(this.cbbCaLam_SelectedIndexChanged);

            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241))))); // Tím nhạt
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(39, 410);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(155, 40);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(214, 410);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(155, 40);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94))))); // Đỏ nhạt
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(39, 470);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 40);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.button3_Click);

            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.White;
            this.btnMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnMoi.Location = new System.Drawing.Point(214, 470);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(155, 40);
            this.btnMoi.TabIndex = 28;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnInPhieu_Click);

            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblDanhSach.Location = new System.Drawing.Point(405, 55);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(193, 25);
            this.lblDanhSach.TabIndex = 74;
            this.lblDanhSach.Text = "Danh sách nhân viên";

            // 
            // groupBox2 (Panel thay cho GroupBox)
            // 
            this.groupBox2.Controls.Add(this.DgvNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(410, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 420);
            this.groupBox2.TabIndex = 29;

            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252))))); // Slate 50
            this.DgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));

            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.DgvNhanVien.ColumnHeadersDefaultCellStyle = headerStyle;
            this.DgvNhanVien.EnableHeadersVisualStyles = false;

            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});

            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            rowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.DgvNhanVien.RowsDefaultCellStyle = rowStyle;

            this.DgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.ReadOnly = true;
            this.DgvNhanVien.RowHeadersVisible = false;
            this.DgvNhanVien.RowTemplate.Height = 35;
            this.DgvNhanVien.Size = new System.Drawing.Size(780, 420);
            this.DgvNhanVien.TabIndex = 0;
            this.DgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNhanVien_CellClick);
            this.DgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNhanVien_CellContentClick);

            // Các Cột Dữ Liệu
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;

            this.Column6.HeaderText = "Họ tên";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;

            this.Column2.HeaderText = "SĐT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;

            this.Column3.HeaderText = "Ngày bắt đầu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;

            this.Column4.HeaderText = "Năm sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;

            this.Column5.HeaderText = "Giới tính";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;

            this.Column7.HeaderText = "Ca làm";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;

            // 
            // QLNV Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 560); // Căn chỉnh tỷ lệ cho gọn
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbbCaLam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên"; // Đổi title form cho phù hợp
            this.Load += new System.EventHandler(this.QLNV_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbCaLam;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;

        // Đã đổi kiểu từ GroupBox sang Panel
        private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.Label lblDanhSach;

        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox txtNamSinh;
    }
}