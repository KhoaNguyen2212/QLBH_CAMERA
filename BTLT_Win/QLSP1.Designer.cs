namespace BTLT_Win
{
    partial class QLSP1
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
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DonGia = new System.Windows.Forms.Label();
            this.SL = new System.Windows.Forms.Label();
            this.TenSP = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.Label();

            // Đổi GroupBox thành Panel để loại bỏ viền thô
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDanhSach = new System.Windows.Forms.Label();

            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();

            // 
            // label1 (Tiêu đề chính)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229))))); // Tím Indigo
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 41);
            this.label1.TabIndex = 61;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";

            // 
            // STT (Nhãn STT / Mã SP)
            // 
            this.STT.AutoSize = true;
            this.STT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.STT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.STT.Location = new System.Drawing.Point(40, 85);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(31, 19);
            this.STT.TabIndex = 52;
            this.STT.Text = "STT";

            // 
            // txtSTT
            // 
            this.txtSTT.BackColor = System.Drawing.Color.White;
            this.txtSTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSTT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSTT.Location = new System.Drawing.Point(44, 110);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(260, 27);
            this.txtSTT.TabIndex = 60;

            // 
            // TenSP (Nhãn Tên SP)
            // 
            this.TenSP.AutoSize = true;
            this.TenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.TenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.TenSP.Location = new System.Drawing.Point(40, 155);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(95, 19);
            this.TenSP.TabIndex = 53;
            this.TenSP.Text = "Tên sản phẩm";

            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.White;
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtTenSP.Location = new System.Drawing.Point(44, 180);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(260, 27);
            this.txtTenSP.TabIndex = 58;

            // 
            // SL (Nhãn Số Lượng)
            // 
            this.SL.AutoSize = true;
            this.SL.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.SL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.SL.Location = new System.Drawing.Point(40, 225);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(66, 19);
            this.SL.TabIndex = 54;
            this.SL.Text = "Số lượng";

            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.White;
            this.txtSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSL.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSL.Location = new System.Drawing.Point(44, 250);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(260, 27);
            this.txtSL.TabIndex = 62;

            // 
            // DonGia (Nhãn Đơn Giá)
            // 
            this.DonGia.AutoSize = true;
            this.DonGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.DonGia.Location = new System.Drawing.Point(40, 295);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(59, 19);
            this.DonGia.TabIndex = 55;
            this.DonGia.Text = "Đơn giá";

            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtDonGia.Location = new System.Drawing.Point(44, 320);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(260, 27);
            this.txtDonGia.TabIndex = 57;

            // 
            // label10 (Nhãn Thành Tiền)
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label10.Location = new System.Drawing.Point(40, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Thành tiền";

            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtThanhTien.Location = new System.Drawing.Point(44, 390);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(260, 27);
            this.txtThanhTien.TabIndex = 59;

            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241))))); // Tím nhạt
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(44, 460);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 63;
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
            this.btnSua.Location = new System.Drawing.Point(184, 460);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94))))); // Đỏ nhạt (Rose)
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(44, 515);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 65;
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
            this.btnMoi.Location = new System.Drawing.Point(184, 515);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(120, 40);
            this.btnMoi.TabIndex = 66;
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
            this.lblDanhSach.Size = new System.Drawing.Size(183, 25);
            this.lblDanhSach.TabIndex = 73;
            this.lblDanhSach.Text = "Danh sách sản phẩm";

            // 
            // groupBox2 (Panel thay cho GroupBox)
            // 
            this.groupBox2.Controls.Add(this.dgvSanPham);
            this.groupBox2.Location = new System.Drawing.Point(380, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 440);
            this.groupBox2.TabIndex = 51;

            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252))))); // Slate 50
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));

            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvSanPham.EnableHeadersVisualStyles = false;

            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5});

            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            rowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.dgvSanPham.RowsDefaultCellStyle = rowStyle;

            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowTemplate.Height = 35;
            this.dgvSanPham.Size = new System.Drawing.Size(750, 440);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);

            // Các Cột Dữ Liệu
            this.Column6.HeaderText = "STT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;

            this.Column4.HeaderText = "Tên SP";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;

            this.Column2.HeaderText = "SL";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;

            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;

            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;

            // 
            // QLSP1 Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 600);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.SL);
            this.Controls.Add(this.TenSP);
            this.Controls.Add(this.STT);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QLSP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.QLSP1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DonGia;
        private System.Windows.Forms.Label SL;
        private System.Windows.Forms.Label TenSP;
        private System.Windows.Forms.Label STT;
        // Đổi sang kiểu Panel
        private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}