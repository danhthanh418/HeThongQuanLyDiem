using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace HeThongQuanLyDiem.DataAccess
{
	class XuLy
	{
		//Tạo chuỗi kết nối
		SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["StringConn"]);
		//Kết nối đổ dữ liệu vào data table
		SqlDataAdapter adapter;
		//Xử lý dữ liệu IUD;
		SqlCommand cmd;

		public DataTable table_Select(String sql)
		{
			adapter = new SqlDataAdapter(sql, conn);
			//Tạo mới table
			var table = new DataTable();
			//Đỗ dữ lêiuj vào
			adapter.Fill(table);
			//Trả về data table
			return table;
		}

		public void table_Command(String sql)
		{
			conn.Open();
			//Khỏi tạo biến command với 2 parameter sql,conn

			cmd = new SqlCommand(sql, conn);
			//Thực thi câu lệnh	
			cmd.ExecuteNonQuery();
		
			cmd.Dispose();
			//Đóng kết nối
			conn.Close();
		}
	}
}
