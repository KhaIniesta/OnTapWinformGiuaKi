namespace BaiTapCuaNhom
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbFilMaSV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbFilHo = new System.Windows.Forms.ComboBox();
            this.cbbFilTen = new System.Windows.Forms.ComboBox();
            this.cbbFilGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbbFilMaKhoa = new System.Windows.Forms.ComboBox();
            this.dgvDs = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btnChonAvatar = new System.Windows.Forms.Button();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.tbHoSV = new System.Windows.Forms.TextBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.tbTenSV = new System.Windows.Forms.TextBox();
            this.tbMaKhoa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnNhapThongTin = new System.Windows.Forms.Panel();
            this.tbCoClickChonAvartar = new System.Windows.Forms.TextBox();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.tbButInProg = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pnNhapThongTin.SuspendLayout();
            this.pnFilter.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên SV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã khoa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Avatar";
            // 
            // cbbFilMaSV
            // 
            this.cbbFilMaSV.FormattingEnabled = true;
            this.cbbFilMaSV.Location = new System.Drawing.Point(73, 30);
            this.cbbFilMaSV.Name = "cbbFilMaSV";
            this.cbbFilMaSV.Size = new System.Drawing.Size(89, 24);
            this.cbbFilMaSV.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Filter";
            // 
            // cbbFilHo
            // 
            this.cbbFilHo.FormattingEnabled = true;
            this.cbbFilHo.Location = new System.Drawing.Point(212, 30);
            this.cbbFilHo.Name = "cbbFilHo";
            this.cbbFilHo.Size = new System.Drawing.Size(89, 24);
            this.cbbFilHo.TabIndex = 10;
            // 
            // cbbFilTen
            // 
            this.cbbFilTen.FormattingEnabled = true;
            this.cbbFilTen.Location = new System.Drawing.Point(346, 30);
            this.cbbFilTen.Name = "cbbFilTen";
            this.cbbFilTen.Size = new System.Drawing.Size(89, 24);
            this.cbbFilTen.TabIndex = 11;
            // 
            // cbbFilGioiTinh
            // 
            this.cbbFilGioiTinh.FormattingEnabled = true;
            this.cbbFilGioiTinh.Location = new System.Drawing.Point(601, 30);
            this.cbbFilGioiTinh.Name = "cbbFilGioiTinh";
            this.cbbFilGioiTinh.Size = new System.Drawing.Size(89, 24);
            this.cbbFilGioiTinh.TabIndex = 13;
            // 
            // cbbFilMaKhoa
            // 
            this.cbbFilMaKhoa.FormattingEnabled = true;
            this.cbbFilMaKhoa.Location = new System.Drawing.Point(737, 30);
            this.cbbFilMaKhoa.Name = "cbbFilMaKhoa";
            this.cbbFilMaKhoa.Size = new System.Drawing.Size(89, 24);
            this.cbbFilMaKhoa.TabIndex = 14;
            // 
            // dgvDs
            // 
            this.dgvDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoSV,
            this.TenSV,
            this.NgaySinh,
            this.GioiTinh,
            this.MaKhoa});
            this.dgvDs.Location = new System.Drawing.Point(59, 331);
            this.dgvDs.Name = "dgvDs";
            this.dgvDs.RowHeadersWidth = 51;
            this.dgvDs.RowTemplate.Height = 24;
            this.dgvDs.Size = new System.Drawing.Size(825, 189);
            this.dgvDs.TabIndex = 15;
            this.dgvDs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDs_CellContentClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // HoSV
            // 
            this.HoSV.DataPropertyName = "HoSV";
            this.HoSV.HeaderText = "Họ SV";
            this.HoSV.MinimumWidth = 6;
            this.HoSV.Name = "HoSV";
            this.HoSV.Width = 125;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Tên SV";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(55, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(212, 24);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(342, 24);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLuu.Location = new System.Drawing.Point(463, 24);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(597, 24);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(733, 24);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(105, 84);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(114, 22);
            this.dtpNgaySinh.TabIndex = 18;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAvatar.Location = new System.Drawing.Point(732, 76);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(153, 171);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 19;
            this.pbAvatar.TabStop = false;
            // 
            // btnChonAvatar
            // 
            this.btnChonAvatar.BackColor = System.Drawing.Color.White;
            this.btnChonAvatar.Location = new System.Drawing.Point(105, 130);
            this.btnChonAvatar.Name = "btnChonAvatar";
            this.btnChonAvatar.Size = new System.Drawing.Size(114, 31);
            this.btnChonAvatar.TabIndex = 20;
            this.btnChonAvatar.Text = "Chọn avatar";
            this.btnChonAvatar.UseVisualStyleBackColor = false;
            this.btnChonAvatar.Click += new System.EventHandler(this.btnChonAvatar_Click);
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(105, 17);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(114, 22);
            this.tbMaSV.TabIndex = 21;
            // 
            // tbHoSV
            // 
            this.tbHoSV.Location = new System.Drawing.Point(311, 17);
            this.tbHoSV.Name = "tbHoSV";
            this.tbHoSV.Size = new System.Drawing.Size(100, 22);
            this.tbHoSV.TabIndex = 21;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không rõ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(311, 78);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(100, 24);
            this.cbbGioiTinh.TabIndex = 8;
            // 
            // tbTenSV
            // 
            this.tbTenSV.Location = new System.Drawing.Point(522, 20);
            this.tbTenSV.Name = "tbTenSV";
            this.tbTenSV.Size = new System.Drawing.Size(100, 22);
            this.tbTenSV.TabIndex = 21;
            // 
            // tbMaKhoa
            // 
            this.tbMaKhoa.Location = new System.Drawing.Point(522, 82);
            this.tbMaKhoa.Name = "tbMaKhoa";
            this.tbMaKhoa.Size = new System.Drawing.Size(100, 22);
            this.tbMaKhoa.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Mã SV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Họ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(598, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Giới tính";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(734, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Mã khoa";
            // 
            // pnNhapThongTin
            // 
            this.pnNhapThongTin.Controls.Add(this.tbCoClickChonAvartar);
            this.pnNhapThongTin.Controls.Add(this.cbbGioiTinh);
            this.pnNhapThongTin.Controls.Add(this.label2);
            this.pnNhapThongTin.Controls.Add(this.label3);
            this.pnNhapThongTin.Controls.Add(this.btnChonAvatar);
            this.pnNhapThongTin.Controls.Add(this.label4);
            this.pnNhapThongTin.Controls.Add(this.label8);
            this.pnNhapThongTin.Controls.Add(this.label5);
            this.pnNhapThongTin.Controls.Add(this.label6);
            this.pnNhapThongTin.Controls.Add(this.label7);
            this.pnNhapThongTin.Controls.Add(this.tbMaKhoa);
            this.pnNhapThongTin.Controls.Add(this.dtpNgaySinh);
            this.pnNhapThongTin.Controls.Add(this.tbTenSV);
            this.pnNhapThongTin.Controls.Add(this.tbMaSV);
            this.pnNhapThongTin.Controls.Add(this.tbHoSV);
            this.pnNhapThongTin.Location = new System.Drawing.Point(59, 76);
            this.pnNhapThongTin.Name = "pnNhapThongTin";
            this.pnNhapThongTin.Size = new System.Drawing.Size(666, 171);
            this.pnNhapThongTin.TabIndex = 23;
            // 
            // tbCoClickChonAvartar
            // 
            this.tbCoClickChonAvartar.Location = new System.Drawing.Point(68, 134);
            this.tbCoClickChonAvartar.Name = "tbCoClickChonAvartar";
            this.tbCoClickChonAvartar.Size = new System.Drawing.Size(28, 22);
            this.tbCoClickChonAvartar.TabIndex = 26;
            this.tbCoClickChonAvartar.Visible = false;
            // 
            // pnFilter
            // 
            this.pnFilter.Controls.Add(this.cbbFilMaSV);
            this.pnFilter.Controls.Add(this.label15);
            this.pnFilter.Controls.Add(this.label9);
            this.pnFilter.Controls.Add(this.label14);
            this.pnFilter.Controls.Add(this.cbbFilHo);
            this.pnFilter.Controls.Add(this.cbbFilTen);
            this.pnFilter.Controls.Add(this.label12);
            this.pnFilter.Controls.Add(this.cbbFilGioiTinh);
            this.pnFilter.Controls.Add(this.label11);
            this.pnFilter.Controls.Add(this.cbbFilMaKhoa);
            this.pnFilter.Controls.Add(this.label10);
            this.pnFilter.Location = new System.Drawing.Point(59, 253);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(825, 72);
            this.pnFilter.TabIndex = 24;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.tbButInProg);
            this.pnButton.Controls.Add(this.btnHuy);
            this.pnButton.Controls.Add(this.btnThem);
            this.pnButton.Controls.Add(this.btnSua);
            this.pnButton.Controls.Add(this.btnXoa);
            this.pnButton.Controls.Add(this.btnLuu);
            this.pnButton.Controls.Add(this.btnThoat);
            this.pnButton.Location = new System.Drawing.Point(59, 522);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(825, 63);
            this.pnButton.TabIndex = 25;
            // 
            // tbButInProg
            // 
            this.tbButInProg.Location = new System.Drawing.Point(0, 4);
            this.tbButInProg.Name = "tbButInProg";
            this.tbButInProg.Size = new System.Drawing.Size(22, 22);
            this.tbButInProg.TabIndex = 18;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 597);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnFilter);
            this.Controls.Add(this.pnNhapThongTin);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.dgvDs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pnNhapThongTin.ResumeLayout(false);
            this.pnNhapThongTin.PerformLayout();
            this.pnFilter.ResumeLayout(false);
            this.pnFilter.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbFilMaSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbFilHo;
        private System.Windows.Forms.ComboBox cbbFilTen;
        private System.Windows.Forms.ComboBox cbbFilGioiTinh;
        private System.Windows.Forms.ComboBox cbbFilMaKhoa;
        private System.Windows.Forms.DataGridView dgvDs;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btnChonAvatar;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.TextBox tbHoSV;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox tbTenSV;
        private System.Windows.Forms.TextBox tbMaKhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.Panel pnNhapThongTin;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.TextBox tbButInProg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbCoClickChonAvartar;
    }
}

