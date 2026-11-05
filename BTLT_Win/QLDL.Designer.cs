namespace BTLT_Win
{
    partial class QLDL
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDL = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenDL = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DonGia = new System.Windows.Forms.Label();
            this.SL = new System.Windows.Forms.Label();
            this.TenSP = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDaiLy = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaiLy)).BeginInit();
            this.SuspendLayout();

            // 
            // label1 (Tiêu đề chính)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229))))); // Tím Indigo
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 45);
            this.label1.TabIndex = 57;
            this.label1.Text = "QUẢN LÝ ĐẠI LÝ";

            // 
            // STT (Mã Đại Lý)
            // 
            this.STT.AutoSize = true;
            this.STT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.STT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.STT.Location = new System.Drawing.Point(35, 90);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(76, 20);
            this.STT.TabIndex = 48;
            this.STT.Text = "Mã đại lý"; // Đổi text hiển thị cho rõ nghĩa
            // 
            // txtMaDL
            // 
            this.txtMaDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtMaDL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtMaDL.Location = new System.Drawing.Point(39, 115);
            this.txtMaDL.Name = "txtMaDL";
            this.txtMaDL.Size = new System.Drawing.Size(280, 29);
            this.txtMaDL.TabIndex = 56;
            this.txtMaDL.Enter += new System.EventHandler(this.txtMaDL_Enter);
            this.txtMaDL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDL_KeyPress);
            this.txtMaDL.Leave += new System.EventHandler(this.txtMaDL_Leave);

            // 
            // TenSP (Tên Đại Lý)
            // 
            this.TenSP.AutoSize = true;
            this.TenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.TenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.TenSP.Location = new System.Drawing.Point(35, 160);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(78, 20);
            this.TenSP.TabIndex = 49;
            this.TenSP.Text = "Tên đại lý";
            // 
            // txtTenDL
            // 
            this.txtTenDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtTenDL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtTenDL.Location = new System.Drawing.Point(39, 185);
            this.txtTenDL.Name = "txtTenDL";
            this.txtTenDL.Size = new System.Drawing.Size(280, 29);
            this.txtTenDL.TabIndex = 54;
            this.txtTenDL.Enter += new System.EventHandler(this.txtTenDL_Enter);
            this.txtTenDL.Leave += new System.EventHandler(this.txtTenDL_Leave);

            // 
            // SL (Địa Chỉ)
            // 
            this.SL.AutoSize = true;
            this.SL.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.SL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.SL.Location = new System.Drawing.Point(35, 230);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(56, 20);
            this.SL.TabIndex = 50;
            this.SL.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtDiaChi.Location = new System.Drawing.Point(39, 255);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(280, 29);
            this.txtDiaChi.TabIndex = 58;
            this.txtDiaChi.Enter += new System.EventHandler(this.txtDiaChi_Enter);
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);

            // 
            // DonGia (SĐT)
            // 
            this.DonGia.AutoSize = true;
            this.DonGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.DonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.DonGia.Location = new System.Drawing.Point(35, 300);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(99, 20);
            this.DonGia.TabIndex = 51;
            this.DonGia.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSDT.Location = new System.Drawing.Point(39, 325);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(280, 29);
            this.txtSDT.TabIndex = 53;
            this.txtSDT.Enter += new System.EventHandler(this.txtSDT_Enter);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);

            // 
            // label10 (Email)
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label10.Location = new System.Drawing.Point(35, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtEmail.Location = new System.Drawing.Point(39, 395);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 29);
            this.txtEmail.TabIndex = 55;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);

            // 
            // label2 (Người đại diện)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(35, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Người đại diện";
            // 
            // txtNguoiDaiDien
            // 
            this.txtNguoiDaiDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtNguoiDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNguoiDaiDien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNguoiDaiDien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtNguoiDaiDien.Location = new System.Drawing.Point(39, 465);
            this.txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            this.txtNguoiDaiDien.Size = new System.Drawing.Size(280, 29);
            this.txtNguoiDaiDien.TabIndex = 72;
            this.txtNguoiDaiDien.Enter += new System.EventHandler(this.txtNguoiDaiDien_Enter);
            this.txtNguoiDaiDien.Leave += new System.EventHandler(this.txtNguoiDaiDien_Leave);

            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(39, 530);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 45);
            this.btnThem.TabIndex = 67;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(189, 530);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 45);
            this.btnSua.TabIndex = 68;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72))))); // Đỏ
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(39, 590);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 45);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.White;
            this.btnMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnMoi.Location = new System.Drawing.Point(189, 590);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(130, 45);
            this.btnMoi.TabIndex = 70;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);

            // 
            // groupBox2 (Bảng Dữ Liệu)
            // 
            this.groupBox2.Controls.Add(this.dgvDaiLy);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.groupBox2.Location = new System.Drawing.Point(360, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 555);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Đại Lý";

            // 
            // dgvDaiLy
            // 
            this.dgvDaiLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDaiLy.BackgroundColor = System.Drawing.Color.White;
            this.dgvDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDaiLy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            // Tùy chỉnh màu Header của DataGridView
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.dgvDaiLy.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvDaiLy.EnableHeadersVisualStyles = false;

            this.dgvDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column1});

            // Tùy chỉnh màu các dòng (Rows)
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255))))); // Tím rất nhạt khi chọn
            rowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.dgvDaiLy.RowsDefaultCellStyle = rowStyle;

            this.dgvDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDaiLy.Location = new System.Drawing.Point(3, 27);
            this.dgvDaiLy.Name = "dgvDaiLy";
            this.dgvDaiLy.ReadOnly = true;
            this.dgvDaiLy.RowHeadersVisible = false; // Ẩn cột mũi tên bên trái cùng cho gọn
            this.dgvDaiLy.RowTemplate.Height = 35; // Tăng chiều cao dòng cho dễ nhìn
            this.dgvDaiLy.Size = new System.Drawing.Size(794, 525);
            this.dgvDaiLy.TabIndex = 0;
            this.dgvDaiLy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaiLy_CellContentClick);

            // 
            // Các Cột Dữ Liệu
            // 
            this.Column6.HeaderText = "Mã ĐL";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;

            this.Column4.HeaderText = "Tên đại lý";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;

            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;

            this.Column3.HeaderText = "SDT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;

            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;

            this.Column1.HeaderText = "Người đại diện";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;

            // 
            // QLDL Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 680); // Căn chỉnh lại form vuông vắn
            this.Controls.Add(this.txtNguoiDaiDien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaDL);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenDL);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.SL);
            this.Controls.Add(this.TenSP);
            this.Controls.Add(this.STT);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QLDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đại Lý";
            this.Load += new System.EventHandler(this.QLDL_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaiLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDL;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenDL;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DonGia;
        private System.Windows.Forms.Label SL;
        private System.Windows.Forms.Label TenSP;
        private System.Windows.Forms.Label STT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDaiLy;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtNguoiDaiDien;
        private System.Windows.Forms.Label label2;
    }
}