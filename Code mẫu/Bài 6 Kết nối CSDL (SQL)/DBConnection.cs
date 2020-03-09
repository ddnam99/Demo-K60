using System.Data;
using System.Data.SqlClient;

namespace Bài_6_Kết_nối_CSDL__SQL_
{
    class DBConnection
    {
        /// <summary>
        /// Chuỗi kết nối tới SQLSever và DataBase.
        /// </summary>
        private static string StrConnect = @"Data Source=DESKTOP-9620ED2\DOUBLED;Initial Catalog=Demo;Integrated Security=True;";
        private static SqlConnection Conn = null;
        private static SqlCommand Cmd = null;

        /// <summary>
        /// Lấy toàn bộ dữ liệu DienThoai trong DataBase.
        /// </summary>
        public static DataTable LayToanBoDuLieuDuLieu()
        {
            DataTable DT = new DataTable();

            DataAdapter("select MaSP as [Mã SP], TenSP as [Tên SP], XuatSu as [Xuất sứ], DonGia as [Đơn giá], SoLuong as [Số lượng], ThanhTien as [Thành tiền] from DienThoai").Fill(DT);

            return DT;
        }

        /// <summary>
        /// Insert dữ liệu DT vào DataBase.
        /// </summary>
        public static void InsertDuLieu(DienThoai DT)
        {
            string sql = "insert into DienThoai values('" + DT.GSMaSP + "', N'" + DT.GSTenSP + "', N'" + DT.GSXuatSu + "'," + DT.GSDonGia + "," + DT.GSSoLuong + "," + DT.ThanhTien() + ")";

            Command(sql);
        }

        /// <summary>
        /// Sửa dữ liệu của MaSP cũ bằng dữ liệu của DT.
        /// </summary>
        public static void UpdateDuLieu(string MaSPCu, DienThoai DT)
        {
            string sql = "update DienThoai " +
                         "set MaSP = '" + DT.GSMaSP + "', TenSP = N'" + DT.GSTenSP + "', XuatSu = N'" + DT.GSXuatSu + "', DonGia = " + DT.GSDonGia + ", SoLuong = " + DT.GSSoLuong + ", ThanhTien = " + DT.ThanhTien() + " " +
                         "where MaSP = '" + MaSPCu + "'";

            Command(sql);
        }

        /// <summary>
        /// Xóa dữ liệu MaSP trong DataBase
        /// </summary>
        public static void DeleteDuLieuBangMaSP(string MaSP)
        {
            string sql = "delete DienThoai where MaSP = '" + MaSP + "'";

            Command(sql);
        }

        private static SqlDataAdapter DataAdapter(string Sql)
        {
            Connect();

            SqlDataAdapter SDA = new SqlDataAdapter(Sql, Conn);

            DisConnect();

            return SDA;
        }

        private static void Command(string Sql)
        {
            Connect();

            Cmd.CommandText = Sql;

            Cmd.ExecuteNonQuery();

            DisConnect();
        }

        private static void Connect()
        {
            Conn = new SqlConnection(StrConnect);
            Conn.Open();

            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
        }

        private static void DisConnect()
        {
            Conn.Close();
        }
    }
}