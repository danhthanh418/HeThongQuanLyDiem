namespace HeThongQuanLyDiem
{
	partial class frmMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xửLýDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnThongTinLopSinVien = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.xửLýDữLiệuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(708, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.hệThốngToolStripMenuItem.Text = "Hệ thống";
			// 
			// xửLýDữLiệuToolStripMenuItem
			// 
			this.xửLýDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongTinLopSinVien});
			this.xửLýDữLiệuToolStripMenuItem.Name = "xửLýDữLiệuToolStripMenuItem";
			this.xửLýDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.xửLýDữLiệuToolStripMenuItem.Text = "Xử lý dữ liệu";
			// 
			// mnThongTinLopSinVien
			// 
			this.mnThongTinLopSinVien.Name = "mnThongTinLopSinVien";
			this.mnThongTinLopSinVien.Size = new System.Drawing.Size(199, 22);
			this.mnThongTinLopSinVien.Text = "Thông tin lớp, sinh viên";
			this.mnThongTinLopSinVien.Click += new System.EventHandler(this.mnThongTinLopSinVien_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 519);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "Hệ Thống Quản lý Điểm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xửLýDữLiệuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnThongTinLopSinVien;
	}
}

