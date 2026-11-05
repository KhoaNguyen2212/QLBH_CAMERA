namespace BTLT_Win
{
    partial class QLNV
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng quản lý nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(117, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(95, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Bắt đầu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(686, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ca làm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(686, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Họ tên";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(686, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Giới tính";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(686, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Năm sinh";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbbCaLam
            // 
            this.cbbCaLam.FormattingEnabled = true;
            this.cbbCaLam.Location = new System.Drawing.Point(837, 94);
            this.cbbCaLam.Name = "cbbCaLam";
            this.cbbCaLam.Size = new System.Drawing.Size(250, 24);
            this.cbbCaLam.TabIndex = 13;
            this.cbbCaLam.Text = "Sáng";
            this.cbbCaLam.SelectedIndexChanged += new System.EventHandler(this.cbbCaLam_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(185, 102);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(215, 22);
            this.txtID.TabIndex = 14;
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(837, 143);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 22);
            this.txtHoTen.TabIndex = 16;
            this.txtHoTen.Enter += new System.EventHandler(this.txtHoTen_Enter);
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(185, 167);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(215, 22);
            this.txtSDT.TabIndex = 17;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(185, 230);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(215, 22);
            this.dtpNgayBatDau.TabIndex = 24;
            this.dtpNgayBatDau.Value = new System.DateTime(2026, 10, 1, 15, 30, 45, 0);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Location = new System.Drawing.Point(52, 394);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 57);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(378, 394);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(147, 57);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(715, 394);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(147, 57);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(1018, 394);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(147, 57);
            this.btnMoi.TabIndex = 28;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvNhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-6, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1237, 313);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.DgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvNhanVien.Location = new System.Drawing.Point(3, 26);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.ReadOnly = true;
            this.DgvNhanVien.RowHeadersWidth = 51;
            this.DgvNhanVien.RowTemplate.Height = 24;
            this.DgvNhanVien.Size = new System.Drawing.Size(1231, 284);
            this.DgvNhanVien.TabIndex = 0;
            this.DgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNhanVien_CellClick);
            this.DgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNhanVien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Họ tên";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SĐT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày bắt đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Năm sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giới tính";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ca làm";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.Location = new System.Drawing.Point(837, 185);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(250, 24);
            this.cbbGioiTinh.TabIndex = 30;
            this.cbbGioiTinh.Text = "Nam";
            this.cbbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbbGioiTinh_SelectedIndexChanged);
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(837, 236);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(250, 22);
            this.txtNamSinh.TabIndex = 31;
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 787);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLNV";
            this.Text = "TracuuNV";
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
        private System.Windows.Forms.GroupBox groupBox2;
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