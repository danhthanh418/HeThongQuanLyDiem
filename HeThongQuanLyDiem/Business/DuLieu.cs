using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyDiem.Business
{
	class DuLieu
	{
		//SinhVien
		public String maSV { get; set; }
		public String hoTen { get; set; }
		public DateTime ngaySinh { get; set; }
		public int gioiTinh { get; set; }
		public String noiSinh { get; set; }
		public String danToc { get; set; }
		public String maLop { get; set; }
		//Lop
		public String tenLop { get; set; }
		public String maMon { get; set; }
		public float diemLan1 { get; set; }
		public float diemLan2 { get; set; }

		//MonHP
		public String tenMon { get; set; }
		public int soTinChi { get; set; }
		public String maHK { get; set; }
		//HocKy
		public String tenHK { get; set; }

		//DangNhap
		public String username { get; set; }
		public String password { get; set; }

		//thongtin
		public String donViChuQuan { get; set; }
		public String tenTruong { get; set; }
		public String khoaHoc { get; set; }
		public String nganhHoc { get; set; }
		public String chuyenNganh { get; set; }
	}
}
