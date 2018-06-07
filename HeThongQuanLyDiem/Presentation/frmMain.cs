using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongQuanLyDiem.Presentation;

namespace HeThongQuanLyDiem
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void mnThongTinLopSinVien_Click(object sender, EventArgs e)
		{
			frmLopSinhVien frmLopSinhVien = new frmLopSinhVien();
			frmLopSinhVien.ShowDialog();
			frmLopSinhVien.StartPosition = FormStartPosition.CenterScreen;
		}
	}
}
