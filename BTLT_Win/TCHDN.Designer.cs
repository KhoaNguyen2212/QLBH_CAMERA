namespace BTLT_Win
{
    partial class TCHDN
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
            this.txtXemTatCa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayDen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayTu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.Panel(); // Đổi từ GroupBox sang Panel để xóa viền thô
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvHDX = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDX)).BeginInit();
            this.SuspendLayout();

            // 
            // label1 (Tiêu đề chính)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229))))); // Tím Indigo
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "TRA CỨU HÓA ĐƠN NHẬP";

            // 
            // groupBox1 (Panel Tìm Kiếm)
            // 
            this.groupBox1.Controls.Add(this.txtXemTatCa);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNgayDen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNgayTu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Location = new System.Drawing.Point(35, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 160);
            this.groupBox1.TabIndex = 23;

            // 
            // label2 (Mã HĐ)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã HĐ";

            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.White;
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtMaHD.Location = new System.Drawing.Point(110, 18);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(230, 27);
            this.txtMaHD.TabIndex = 18;

            // 
            // label3 (Mã KH)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(380, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã KH";

            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.White;
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtMaKH.Location = new System.Drawing.Point(460, 18);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(250, 27);
            this.txtMaKH.TabIndex = 20;

            // 
            // label4 (Ngày Từ)
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(20, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày Từ";

            // 
            // txtNgayTu
            // 
            this.txtNgayTu.BackColor = System.Drawing.Color.White;
            this.txtNgayTu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayTu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNgayTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtNgayTu.Location = new System.Drawing.Point(110, 66);
            this.txtNgayTu.Name = "txtNgayTu";
            this.txtNgayTu.Size = new System.Drawing.Size(230, 27);
            this.txtNgayTu.TabIndex = 22;

            // 
            // label5 (đến)
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(380, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "đến";

            // 
            // txtNgayDen
            // 
            this.txtNgayDen.BackColor = System.Drawing.Color.White;
            this.txtNgayDen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayDen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNgayDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtNgayDen.Location = new System.Drawing.Point(460, 66);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(250, 27);
            this.txtNgayDen.TabIndex = 24;

            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241))))); // Tím nhạt
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(110, 110);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 38);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;

            // 
            // txtXemTatCa
            // 
            this.txtXemTatCa.BackColor = System.Drawing.Color.White;
            this.txtXemTatCa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtXemTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtXemTatCa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtXemTatCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtXemTatCa.Location = new System.Drawing.Point(245, 110);
            this.txtXemTatCa.Name = "txtXemTatCa";
            this.txtXemTatCa.Size = new System.Drawing.Size(120, 38);
            this.txtXemTatCa.TabIndex = 25;
            this.txtXemTatCa.Text = "Xem tất cả";
            this.txtXemTatCa.UseVisualStyleBackColor = false;

            // 
            // dgvHDX
            // 
            this.dgvHDX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252))))); // Slate 50
            this.dgvHDX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHDX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHDX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));

            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.dgvHDX.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvHDX.EnableHeadersVisualStyles = false;

            this.dgvHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});

            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            rowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.dgvHDX.RowsDefaultCellStyle = rowStyle;

            this.dgvHDX.Location = new System.Drawing.Point(35, 255);
            this.dgvHDX.Name = "dgvHDX";
            this.dgvHDX.ReadOnly = true;
            this.dgvHDX.RowHeadersVisible = false;
            this.dgvHDX.RowTemplate.Height = 35;
            this.dgvHDX.Size = new System.Drawing.Size(740, 200);
            this.dgvHDX.TabIndex = 21;
            this.dgvHDX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDX_CellContentClick);

            // 
            // Các Cột Dữ Liệu
            // 
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;

            this.Column2.HeaderText = "Ngày Nhập";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;

            this.Column3.HeaderText = "Mã KH";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;

            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;

            // 
            // button1 (Xem chi tiết)
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.button1.Location = new System.Drawing.Point(35, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Xem chi tiết";
            this.button1.UseVisualStyleBackColor = false;

            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94))))); // Đỏ nhạt (Rose)
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(645, 470);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 40);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;

            // 
            // TCHDN Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 540);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvHDX);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TCHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Hóa Đơn Nhập";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button txtXemTatCa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayDen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgayTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMaHD;
        // Đổi sang kiểu Panel để xóa viền GroupBox cũ
        private System.Windows.Forms.Panel groupBox1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvHDX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}