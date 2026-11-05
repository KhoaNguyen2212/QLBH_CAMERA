namespace BTLT_Win
{
    partial class QLSP1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(788, 562);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(166, 51);
            this.btnMoi.TabIndex = 66;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(552, 562);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(166, 51);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(297, 562);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(166, 51);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(36, 562);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(166, 51);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(179, 277);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(250, 22);
            this.txtSL.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(410, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 61;
            this.label1.Text = "Bảng quản lý Sản phẩm";
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(179, 102);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(250, 22);
            this.txtSTT.TabIndex = 60;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(179, 447);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(250, 22);
            this.txtThanhTien.TabIndex = 59;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(179, 190);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(250, 22);
            this.txtTenSP.TabIndex = 58;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(179, 360);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(250, 22);
            this.txtDonGia.TabIndex = 57;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 56;
            this.label10.Text = "Thành Tiền";
            // 
            // DonGia
            // 
            this.DonGia.AutoSize = true;
            this.DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.Location = new System.Drawing.Point(22, 357);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(90, 25);
            this.DonGia.TabIndex = 55;
            this.DonGia.Text = "Đơn Giá";
            // 
            // SL
            // 
            this.SL.AutoSize = true;
            this.SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL.Location = new System.Drawing.Point(22, 273);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(39, 25);
            this.SL.TabIndex = 54;
            this.SL.Text = "SL";
            // 
            // TenSP
            // 
            this.TenSP.AutoSize = true;
            this.TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.TenSP.Location = new System.Drawing.Point(20, 190);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(90, 26);
            this.TenSP.TabIndex = 53;
            this.TenSP.Text = "Tên SP";
            // 
            // STT
            // 
            this.STT.AutoSize = true;
            this.STT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.STT.Location = new System.Drawing.Point(20, 102);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(54, 26);
            this.STT.TabIndex = 52;
            this.STT.Text = "STT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSanPham);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(469, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 444);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 26);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(729, 415);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "STT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên SP";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SL";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // QLSP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 625);
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
            this.Name = "QLSP1";
            this.Text = "QLSP1";
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}