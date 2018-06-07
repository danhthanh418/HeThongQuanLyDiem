namespace HeThongQuanLyDiem.Presentation
{
	partial class frmLopSinhVien
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
			this.components = new System.ComponentModel.Container();
			this.panLopSinhVien = new System.Windows.Forms.Panel();
			this.dgvSinhVienLop = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbTimKiem = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.btnXoaSV = new System.Windows.Forms.Button();
			this.btnXoaLop = new System.Windows.Forms.Button();
			this.btnLuuSV = new System.Windows.Forms.Button();
			this.btnLuuLop = new System.Windows.Forms.Button();
			this.btnThemSV = new System.Windows.Forms.Button();
			this.btnThemMoiLop = new System.Windows.Forms.Button();
			this.tbDanToc = new System.Windows.Forms.TextBox();
			this.tbNoiSinh = new System.Windows.Forms.TextBox();
			this.tbHoTen = new System.Windows.Forms.TextBox();
			this.tbTenLop = new System.Windows.Forms.TextBox();
			this.tbMaSV = new System.Windows.Forms.TextBox();
			this.tbMaLop = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbDanhSachLop = new System.Windows.Forms.ComboBox();
			this.dbQuanLyDiemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dbQuanLyDiemDataSet = new HeThongQuanLyDiem.dbQuanLyDiemDataSet();
			this.tbGioiTinh = new System.Windows.Forms.TextBox();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.panLopSinhVien.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienLop)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbQuanLyDiemDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbQuanLyDiemDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// panLopSinhVien
			// 
			this.panLopSinhVien.Controls.Add(this.dgvSinhVienLop);
			this.panLopSinhVien.Controls.Add(this.groupBox1);
			this.panLopSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panLopSinhVien.Location = new System.Drawing.Point(0, 0);
			this.panLopSinhVien.Name = "panLopSinhVien";
			this.panLopSinhVien.Size = new System.Drawing.Size(1005, 656);
			this.panLopSinhVien.TabIndex = 0;
			// 
			// dgvSinhVienLop
			// 
			this.dgvSinhVienLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSinhVienLop.Location = new System.Drawing.Point(4, 209);
			this.dgvSinhVienLop.Name = "dgvSinhVienLop";
			this.dgvSinhVienLop.Size = new System.Drawing.Size(998, 444);
			this.dgvSinhVienLop.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExportExcel);
			this.groupBox1.Controls.Add(this.tbGioiTinh);
			this.groupBox1.Controls.Add(this.tbTimKiem);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.dtpNgaySinh);
			this.groupBox1.Controls.Add(this.btnXoaSV);
			this.groupBox1.Controls.Add(this.btnXoaLop);
			this.groupBox1.Controls.Add(this.btnLuuSV);
			this.groupBox1.Controls.Add(this.btnLuuLop);
			this.groupBox1.Controls.Add(this.btnThemSV);
			this.groupBox1.Controls.Add(this.btnThemMoiLop);
			this.groupBox1.Controls.Add(this.tbDanToc);
			this.groupBox1.Controls.Add(this.tbNoiSinh);
			this.groupBox1.Controls.Add(this.tbHoTen);
			this.groupBox1.Controls.Add(this.tbTenLop);
			this.groupBox1.Controls.Add(this.tbMaSV);
			this.groupBox1.Controls.Add(this.tbMaLop);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbDanhSachLop);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1005, 202);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cập nhật thông tin lớp học, sinh viên";
			// 
			// tbTimKiem
			// 
			this.tbTimKiem.Location = new System.Drawing.Point(525, 147);
			this.tbTimKiem.Name = "tbTimKiem";
			this.tbTimKiem.Size = new System.Drawing.Size(234, 20);
			this.tbTimKiem.TabIndex = 34;
			this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(425, 149);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 13);
			this.label10.TabIndex = 33;
			this.label10.Text = "Tìm kiếm sinh viên";
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.Location = new System.Drawing.Point(404, 99);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(109, 20);
			this.dtpNgaySinh.TabIndex = 31;
			// 
			// btnXoaSV
			// 
			this.btnXoaSV.Location = new System.Drawing.Point(327, 144);
			this.btnXoaSV.Name = "btnXoaSV";
			this.btnXoaSV.Size = new System.Drawing.Size(83, 23);
			this.btnXoaSV.TabIndex = 28;
			this.btnXoaSV.Text = "Xoá";
			this.btnXoaSV.UseVisualStyleBackColor = true;
			this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
			// 
			// btnXoaLop
			// 
			this.btnXoaLop.Location = new System.Drawing.Point(819, 42);
			this.btnXoaLop.Name = "btnXoaLop";
			this.btnXoaLop.Size = new System.Drawing.Size(83, 23);
			this.btnXoaLop.TabIndex = 28;
			this.btnXoaLop.Text = "Xoá";
			this.btnXoaLop.UseVisualStyleBackColor = true;
			this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
			// 
			// btnLuuSV
			// 
			this.btnLuuSV.Location = new System.Drawing.Point(228, 144);
			this.btnLuuSV.Name = "btnLuuSV";
			this.btnLuuSV.Size = new System.Drawing.Size(93, 23);
			this.btnLuuSV.TabIndex = 29;
			this.btnLuuSV.Text = "Lưu lại";
			this.btnLuuSV.UseVisualStyleBackColor = true;
			this.btnLuuSV.Click += new System.EventHandler(this.btnLuuSV_Click);
			// 
			// btnLuuLop
			// 
			this.btnLuuLop.Location = new System.Drawing.Point(720, 42);
			this.btnLuuLop.Name = "btnLuuLop";
			this.btnLuuLop.Size = new System.Drawing.Size(93, 23);
			this.btnLuuLop.TabIndex = 29;
			this.btnLuuLop.Text = "Lưu lại";
			this.btnLuuLop.UseVisualStyleBackColor = true;
			this.btnLuuLop.Click += new System.EventHandler(this.btnLuuLop_Click);
			// 
			// btnThemSV
			// 
			this.btnThemSV.Location = new System.Drawing.Point(136, 144);
			this.btnThemSV.Name = "btnThemSV";
			this.btnThemSV.Size = new System.Drawing.Size(86, 23);
			this.btnThemSV.TabIndex = 30;
			this.btnThemSV.Text = "Thêm mới";
			this.btnThemSV.UseVisualStyleBackColor = true;
			this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
			// 
			// btnThemMoiLop
			// 
			this.btnThemMoiLop.Location = new System.Drawing.Point(628, 42);
			this.btnThemMoiLop.Name = "btnThemMoiLop";
			this.btnThemMoiLop.Size = new System.Drawing.Size(86, 23);
			this.btnThemMoiLop.TabIndex = 30;
			this.btnThemMoiLop.Text = "Thêm mới";
			this.btnThemMoiLop.UseVisualStyleBackColor = true;
			this.btnThemMoiLop.Click += new System.EventHandler(this.btnThemMoiLop_Click);
			// 
			// tbDanToc
			// 
			this.tbDanToc.Location = new System.Drawing.Point(759, 99);
			this.tbDanToc.Name = "tbDanToc";
			this.tbDanToc.Size = new System.Drawing.Size(119, 20);
			this.tbDanToc.TabIndex = 26;
			// 
			// tbNoiSinh
			// 
			this.tbNoiSinh.Location = new System.Drawing.Point(623, 99);
			this.tbNoiSinh.Name = "tbNoiSinh";
			this.tbNoiSinh.Size = new System.Drawing.Size(119, 20);
			this.tbNoiSinh.TabIndex = 26;
			// 
			// tbHoTen
			// 
			this.tbHoTen.Location = new System.Drawing.Point(198, 99);
			this.tbHoTen.Name = "tbHoTen";
			this.tbHoTen.Size = new System.Drawing.Size(190, 20);
			this.tbHoTen.TabIndex = 26;
			// 
			// tbTenLop
			// 
			this.tbTenLop.Location = new System.Drawing.Point(379, 45);
			this.tbTenLop.Name = "tbTenLop";
			this.tbTenLop.Size = new System.Drawing.Size(219, 20);
			this.tbTenLop.TabIndex = 26;
			// 
			// tbMaSV
			// 
			this.tbMaSV.Location = new System.Drawing.Point(47, 99);
			this.tbMaSV.Name = "tbMaSV";
			this.tbMaSV.Size = new System.Drawing.Size(133, 20);
			this.tbMaSV.TabIndex = 27;
			// 
			// tbMaLop
			// 
			this.tbMaLop.Location = new System.Drawing.Point(228, 45);
			this.tbMaLop.Name = "tbMaLop";
			this.tbMaLop.Size = new System.Drawing.Size(133, 20);
			this.tbMaLop.TabIndex = 27;
			this.tbMaLop.TextChanged += new System.EventHandler(this.tbMaLop_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(527, 83);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 23;
			this.label7.Text = "Giới tính";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(401, 83);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 23;
			this.label6.Text = "Ngày sinh";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(756, 83);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Dân tộc";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(620, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 23;
			this.label8.Text = "Nơi sinh";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(195, 83);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "Họ tên";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "Mã sinh viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(376, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 23;
			this.label3.Text = "Tên lớp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(225, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "Mã lớp";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "Danh sách lớp";
			// 
			// cbDanhSachLop
			// 
			this.cbDanhSachLop.FormattingEnabled = true;
			this.cbDanhSachLop.Location = new System.Drawing.Point(47, 45);
			this.cbDanhSachLop.Name = "cbDanhSachLop";
			this.cbDanhSachLop.Size = new System.Drawing.Size(175, 21);
			this.cbDanhSachLop.TabIndex = 22;
			// 
			// dbQuanLyDiemDataSetBindingSource
			// 
			this.dbQuanLyDiemDataSetBindingSource.DataSource = this.dbQuanLyDiemDataSet;
			this.dbQuanLyDiemDataSetBindingSource.Position = 0;
			// 
			// dbQuanLyDiemDataSet
			// 
			this.dbQuanLyDiemDataSet.DataSetName = "dbQuanLyDiemDataSet";
			this.dbQuanLyDiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tbGioiTinh
			// 
			this.tbGioiTinh.Location = new System.Drawing.Point(530, 98);
			this.tbGioiTinh.Name = "tbGioiTinh";
			this.tbGioiTinh.Size = new System.Drawing.Size(68, 20);
			this.tbGioiTinh.TabIndex = 35;
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Location = new System.Drawing.Point(775, 143);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(75, 23);
			this.btnExportExcel.TabIndex = 36;
			this.btnExportExcel.Text = "Export Excel";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			// 
			// frmLopSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 656);
			this.Controls.Add(this.panLopSinhVien);
			this.Name = "frmLopSinhVien";
			this.Text = "frmLopSinhVien";
			this.Load += new System.EventHandler(this.frmLopSinhVien_Load);
			this.panLopSinhVien.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienLop)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbQuanLyDiemDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbQuanLyDiemDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panLopSinhVien;
		private System.Windows.Forms.BindingSource dbQuanLyDiemDataSetBindingSource;
		private dbQuanLyDiemDataSet dbQuanLyDiemDataSet;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbTimKiem;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.Button btnXoaSV;
		private System.Windows.Forms.Button btnXoaLop;
		private System.Windows.Forms.Button btnLuuSV;
		private System.Windows.Forms.Button btnLuuLop;
		private System.Windows.Forms.Button btnThemSV;
		private System.Windows.Forms.Button btnThemMoiLop;
		private System.Windows.Forms.TextBox tbDanToc;
		private System.Windows.Forms.TextBox tbNoiSinh;
		private System.Windows.Forms.TextBox tbHoTen;
		private System.Windows.Forms.TextBox tbTenLop;
		private System.Windows.Forms.TextBox tbMaSV;
		private System.Windows.Forms.TextBox tbMaLop;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbDanhSachLop;
		private System.Windows.Forms.DataGridView dgvSinhVienLop;
		private System.Windows.Forms.TextBox tbGioiTinh;
		private System.Windows.Forms.Button btnExportExcel;
	}
}