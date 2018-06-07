using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongQuanLyDiem.DataAccess;

namespace HeThongQuanLyDiem.Business
{
	class XuLyDuLieu
	{
		XuLy xuLy = new XuLy();
		//Dư liệu là 1 object trong csdl
		DuLieu duLieu = new DuLieu();

		public DataTable SinhVien_SelectAll(DuLieu duLieu)
		{
			return xuLy.table_Select("SELECT * FROM SinhVien");
		}

		public DataTable SinhVien_SelectByMaLop(DuLieu duLieu)
		{
			return xuLy.table_Select("SELECT * FROM SinhVien WHERE maLop='" + duLieu.maLop + "'"); 
		}

		public void SinhVien_Delete(DuLieu duLieu)
		{
			xuLy.table_Command("DELETE FROM SinhVien WHERE maSV='"+ duLieu.maSV +"'");
		}

		public void SinhVien_Insert(DuLieu duLieu)
		{
			xuLy.table_Command("INSERT INTO SinhVien VALUES('" + duLieu.maSV + "',N'" 
																+ duLieu.hoTen + "','" 
																+ duLieu.ngaySinh + "'," 
																+ duLieu.gioiTinh + ",N'" 
																+ duLieu.noiSinh + "',N'"
																+ duLieu.danToc + "','"
																+ duLieu.maLop + "')");
		}

		public DataTable SinhVien_Search(DuLieu duLieu)
		{
			return xuLy.table_Select("SELECT * FROM SinhVien WHERE maSV LIKE '%" + duLieu.maSV + "%' OR hoTen LIKE N'%"+duLieu.hoTen+"%' OR noiSinh LIKE N'%"+duLieu.noiSinh+"%'" );
		}
		public void SinhVien_Update(DuLieu duLieu)
		{
			xuLy.table_Command("UPDATE SinhVien " +
								"SET hoTen=N'" + duLieu.hoTen + "',ngaySinh='"
											+ duLieu.ngaySinh + "',gioiTinh="
											+ duLieu.gioiTinh + ",noiSinh=N'"
											+ duLieu.noiSinh + "',dantoc=N'"
											+ duLieu.danToc + "',maLop='"
											+ duLieu.maLop + "' " +
								"WHERE maSV='"+duLieu.maSV+"'");
		}


		public DataTable Lop_SelectAll(DuLieu duLieu)
		{
			return xuLy.table_Select("SELECT * FROM Lop");
		}
		public void Lop_Delete(DuLieu duLieu)
		{
			xuLy.table_Command("DELETE FROM Lop WHERE maLop='" + duLieu.maLop + "'");
		}

		public void Lop_Insert(DuLieu duLieu)
		{
			xuLy.table_Command("INSERT INTO Lop VALUES('" + duLieu.maLop + "',N'"+ duLieu.tenLop + "')");
		}
		public void Lop_Update(DuLieu duLieu)
		{
			xuLy.table_Command("UPDATE Lop " +
								"SET tenLop=N'" + duLieu.tenLop + "'"+	
								"WHERE maLop='" + duLieu.maLop + "'");
		}
	}
}
