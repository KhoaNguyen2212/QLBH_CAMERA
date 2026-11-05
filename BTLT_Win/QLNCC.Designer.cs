namespace BTLT_Win
{
    partial class QLNCC
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
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtCty = new System.Windows.Forms.TextBox(); // Bị ngược thứ tự ở trên, tôi đã đổi lại
            this.DonGia = new System.Windows.Forms.Label();
            this.SL = new System.Windows.Forms.Label();
            this.TenSP = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.Label();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDanhSach = new System.Windows.Forms.Label();
            // Đã đổi kiểu từ GroupBox sang Panel
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();

            // 
            // label1 (Tiêu đề chính)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 41);
            this.label1.TabIndex = 83;
            this.label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";

            // 
            // STT (Nhãn Mã NCC)
            // 
            this.STT.AutoSize = true;
            this.STT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.STT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.STT.Location = new System.Drawing.Point(40, 85);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(117, 19);
            this.STT.TabIndex = 74;
            this.STT.Text = "Mã nhà cung cấp";

            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BackColor = System.Drawing.Color.White;
            this.txtMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNCC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtMaNCC.Location = new System.Drawing.Point(44, 110);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(260, 27);
            this.txtMaNCC.TabIndex = 82;

            // 
            // TenSP (Nhãn Tên NCC)
            // 
            this.TenSP.AutoSize = true;
            this.TenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.TenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.TenSP.Location = new System.Drawing.Point(40, 145);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(119, 19);
            this.TenSP.TabIndex = 75;
            this.TenSP.Text = "Tên nhà cung cấp";

            // 
            // txtTenNCC
            // 
            this.txtTenNCC.BackColor = System.Drawing.Color.White;
            this.txtTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNCC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtTenNCC.Location = new System.Drawing.Point(44, 170);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(260, 27);
            this.txtTenNCC.TabIndex = 80;

            // 
            // SL (Nhãn SĐT)
            // 
            this.SL.AutoSize = true;
            this.SL.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.SL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.SL.Location = new System.Drawing.Point(40, 205);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(93, 19);
            this.SL.TabIndex = 76;
            this.SL.Text = "Số điện thoại";

            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSDT.Location = new System.Drawing.Point(44, 230);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(260, 27);
            this.txtSDT.TabIndex = 84;

            // 
            // DonGia (Nhãn Tên công ty)
            // 
            this.DonGia.AutoSize = true;
            this.DonGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.DonGia.Location = new System.Drawing.Point(40, 265);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(83, 19);
            this.DonGia.TabIndex = 77;
            this.DonGia.Text = "Tên công ty";

            // 
            // txtCty
            // 
            this.txtCty.BackColor = System.Drawing.Color.White;
            this.txtCty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtCty.Location = new System.Drawing.Point(44, 290);
            this.txtCty.Name = "txtCty";
            this.txtCty.Size = new System.Drawing.Size(260, 27);
            this.txtCty.TabIndex = 79;

            // 
            // label10 (Nhãn Email)
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label10.Location = new System.Drawing.Point(40, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 78;
            this.label10.Text = "Email";

            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtEmail.Location = new System.Drawing.Point(44, 350);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 27);
            this.txtEmail.TabIndex = 81;

            // 
            // label2 (Nhãn Sản phẩm)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(40, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 89;
            this.label2.Text = "Sản phẩm cung cấp";

            // 
            // txtSP
            // 
            this.txtSP.BackColor = System.Drawing.Color.White;
            this.txtSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSP.Location = new System.Drawing.Point(44, 410);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(260, 27);
            this.txtSP.TabIndex = 90;

            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(44, 470);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 85;
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
            this.btnSua.Location = new System.Drawing.Point(184, 470);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 86;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(44, 525);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 87;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.White;
            this.btnMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnMoi.Location = new System.Drawing.Point(184, 525);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(120, 40);
            this.btnMoi.TabIndex = 88;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);

            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblDanhSach.Location = new System.Drawing.Point(375, 80);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(217, 25);
            this.lblDanhSach.TabIndex = 91;
            this.lblDanhSach.Text = "Danh sách nhà cung cấp";

            // 
            // groupBox2 (Panel Bảng Dữ Liệu)
            // 
            this.groupBox2.Controls.Add(this.dgvNCC);
            this.groupBox2.Location = new System.Drawing.Point(380, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 455);
            this.groupBox2.TabIndex = 73;

            // 
            // dgvNCC
            // 
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));

            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.dgvNCC.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvNCC.EnableHeadersVisualStyles = false;

            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column1});

            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            rowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.dgvNCC.RowsDefaultCellStyle = rowStyle;

            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNCC.Location = new System.Drawing.Point(0, 0);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.ReadOnly = true;
            this.dgvNCC.RowHeadersVisible = false;
            this.dgvNCC.RowTemplate.Height = 35;
            this.dgvNCC.Size = new System.Drawing.Size(760, 455);
            this.dgvNCC.TabIndex = 0;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick);

            // Các Cột Dữ Liệu
            this.Column6.HeaderText = "Mã NCC";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;

            this.Column4.HeaderText = "Tên NCC";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;

            this.Column2.HeaderText = "SĐT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;

            this.Column3.HeaderText = "Tên công ty";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;

            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;

            this.Column1.HeaderText = "Sản phẩm cấp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;

            // 
            // QLNCC Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 600);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtCty);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.SL);
            this.Controls.Add(this.TenSP);
            this.Controls.Add(this.STT);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QLNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.QLNCC_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtCty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DonGia;
        private System.Windows.Forms.Label SL;
        private System.Windows.Forms.Label TenSP;
        private System.Windows.Forms.Label STT;
        // Đổi sang kiểu Panel
        private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}