using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongQuanLyDiem.Business;

namespace HeThongQuanLyDiem.Presentation
{
	public partial class frmLopSinhVien : Form
	{
		DuLieu duLieu = new DuLieu();
		XuLyDuLieu xuLyDuLieu = new XuLyDuLieu();
		public frmLopSinhVien()
		{
			InitializeComponent();
			tbMaLop.ReadOnly = true;
		}

		private void frmLopSinhVien_Load(object sender, EventArgs e)
		{
			tbMaLop.ReadOnly = true;
			cbDanhSachLop.DropDownStyle = ComboBoxStyle.DropDownList;
			cbDanhSachLop.DisplayMember = "tenLop";
			cbDanhSachLop.ValueMember = "maLop";
			refreshData();
			tbMaSV.ReadOnly = true;
		}

		private void refreshData()
		{
			cbDanhSachLop.DataSource = xuLyDuLieu.Lop_SelectAll(duLieu);
			tbMaLop.DataBindings.Clear();
			tbMaLop.DataBindings.Add("Text", cbDanhSachLop.DataSource, "maLop");
			tbTenLop.DataBindings.Clear();
			tbTenLop.DataBindings.Add("Text", cbDanhSachLop.DataSource, "tenLop");
		}

		Boolean addLop = false;
		private void btnThemMoiLop_Click(object sender, EventArgs e)
		{
			tbMaLop.ReadOnly = false;
			tbMaLop.Text = "";
			tbTenLop.Text = "";
			tbMaLop.Focus();
			addLop = true;
		}

		private void btnLuuLop_Click(object sender, EventArgs e)
		{
			if (addLop)
			{
				duLieu.maLop = tbMaLop.Text.Trim();
				duLieu.tenLop = tbTenLop.Text.Trim();
				xuLyDuLieu.Lop_Insert(duLieu);
				addLop = false;
				MessageBox.Show("Thêm mới dữ liệu thành công");
			}
			else
			{
				tbMaLop.ReadOnly = true;
				duLieu.maLop = tbMaLop.Text.Trim();
				duLieu.tenLop = tbTenLop.Text.Trim();
				xuLyDuLieu.Lop_Update(duLieu);
				addLop = false;
				MessageBox.Show("Cập nhật dữ liệu thành công");
			}
			frmLopSinhVien_Load(sender, e);
		}

		private void btnXoaLop_Click(object sender, EventArgs e)
		{
			duLieu.maLop = tbMaLop.Text.Trim();
			xuLyDuLieu.Lop_Delete(duLieu);
			MessageBox.Show("Xoá dữ liệu thành công");
			tbMaLop.ReadOnly = true;
			frmLopSinhVien_Load(sender, e);
		}
		public void loadGVSV()
		{
			duLieu.maLop = tbMaLop.Text;
			dgvSinhVienLop.DataSource = xuLyDuLieu.SinhVien_SelectByMaLop(duLieu);
			dgvSinhVienLop.Columns[0].HeaderCell.Value = "Mã SV";
			dgvSinhVienLop.Columns[1].HeaderCell.Value = "Họ tên";
			dgvSinhVienLop.Columns[2].HeaderCell.Value = "Ngày sinh";
			dgvSinhVienLop.Columns[3].HeaderCell.Value = "Giới tính";
			dgvSinhVienLop.Columns[4].HeaderCell.Value = "Nơi sinh";
			dgvSinhVienLop.Columns[5].HeaderCell.Value = "Dân tộc";
			dgvSinhVienLop.Columns[6].Visible = false;
			dgvSinhVienLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			bindingSinhVien(dgvSinhVienLop.DataSource);
		}

		private void bindingSinhVien(object dataSource)
		{
			tbMaSV.DataBindings.Clear();
			tbMaSV.DataBindings.Add("Text", dataSource, "maSV");
			tbHoTen.DataBindings.Clear();
			tbHoTen.DataBindings.Add("Text", dataSource, "hoTen");
			dtpNgaySinh.DataBindings.Clear();
			dtpNgaySinh.DataBindings.Add("Text", dataSource, "ngaySinh");
			tbGioiTinh.DataBindings.Clear();
			tbGioiTinh.DataBindings.Add("Text", dataSource, "gioiTinh");
			tbNoiSinh.DataBindings.Clear();
			tbNoiSinh.DataBindings.Add("Text", dataSource, "noiSinh");
			tbDanToc.DataBindings.Clear();
			tbDanToc.DataBindings.Add("Text", dataSource, "danToc");
		}

		private void tbMaLop_TextChanged(object sender, EventArgs e)
		{
			loadGVSV();
		}
		Boolean addSV = false;
		private void btnThemSV_Click(object sender, EventArgs e)
		{
			tbMaSV.ReadOnly = false;
			tbMaSV.Clear();
			tbHoTen.Clear();
			dtpNgaySinh.Text = "";
			tbGioiTinh.Text = "";
			tbNoiSinh.Clear();
			tbDanToc.Clear();
			tbMaSV.Focus();
			addSV = true;
		}

		private void btnLuuSV_Click(object sender, EventArgs e)
		{
			duLieu.maSV = tbMaSV.Text;
			duLieu.hoTen = tbHoTen.Text;
			duLieu.ngaySinh = dtpNgaySinh.Value;
			duLieu.gioiTinh = Convert.ToInt16(tbGioiTinh.Text);
			duLieu.noiSinh = tbNoiSinh.Text;
			duLieu.danToc = tbDanToc.Text;
			duLieu.maLop = tbMaLop.Text;

			if (addSV)
			{
				xuLyDuLieu.SinhVien_Insert(duLieu);
				addSV = false;
				tbMaSV.ReadOnly = true;
				MessageBox.Show("Thêm sv thành công");
			}
			else
			{
				xuLyDuLieu.SinhVien_Update(duLieu);
				tbMaLop.ReadOnly = true;
				MessageBox.Show("Cập nhật sv thành công");
			}
			loadGVSV();
		}

		private void btnXoaSV_Click(object sender, EventArgs e)
		{
			duLieu.maSV = tbMaSV.Text;
			xuLyDuLieu.SinhVien_Delete(duLieu);
			tbMaLop.ReadOnly = true;
			MessageBox.Show("Xoá sv thành công");
			loadGVSV();
		}

		private void tbTimKiem_TextChanged(object sender, EventArgs e)
		{
			duLieu.maSV = tbTimKiem.Text;
			duLieu.hoTen = tbTimKiem.Text;
			duLieu.noiSinh = tbTimKiem.Text;
			dgvSinhVienLop.DataSource = xuLyDuLieu.SinhVien_Search(duLieu);
		}
	}
}
