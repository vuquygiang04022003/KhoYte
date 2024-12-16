using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHO
{
    internal class XuatHangDAO
    {
        string connectionString = "Data Source=LAPTOP-JKH7G3C3\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
        public XuatHangDAO() { }
        public List<XuatHang> getAllXuatHang()
        {
            List<XuatHang> listXuatHang = new List<XuatHang>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PHIEU_XUAT", sqlConnection);
            using(SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    XuatHang xuatHang = new XuatHang();
                    xuatHang.MAPHIEUXUAT = (string)reader.GetString(0);
                    xuatHang.MAVATTU = (string)reader.GetString(1);
                    xuatHang.MAKH = (string)reader.GetString(2);
                    xuatHang.SOLUONG = (int)reader.GetInt32(3);
                    xuatHang.THANHTIEN = (string)reader.GetString(4);
                    xuatHang.NGAYXUATHANG = (DateTime)reader.GetDateTime(5);
                    xuatHang.MANV = reader.GetValue(6).ToString();
                    listXuatHang.Add(xuatHang);
                }
            }
            return listXuatHang;
        }

        public List<XuatHang> getXuatHang(string keySearch, string keyWhere)
        {
            List<XuatHang> listXuatHang = new List<XuatHang>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PHIEU_XUAT WHERE " + keyWhere + " LIKE '%" + keySearch + "%'", sqlConnection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    XuatHang xuatHang = new XuatHang();
                    xuatHang.MAPHIEUXUAT = (string)reader.GetString(0);
                    xuatHang.MAVATTU = (string)reader.GetString(1);
                    xuatHang.MAKH = (string)reader.GetString(2);
                    xuatHang.SOLUONG = (int)reader.GetInt32(3);
                    xuatHang.THANHTIEN = (string)reader.GetString(4);
                    xuatHang.NGAYXUATHANG = (DateTime)reader.GetDateTime(5);
                    xuatHang.MANV = (string)reader.GetString(6);

                    listXuatHang.Add(xuatHang);
                }
            }
            return listXuatHang;
        }

        public int addOneXuatHang(XuatHang xuathang)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string checkQuery = "SELECT COUNT(*) FROM PHIEU_XUAT WHERE MAPHIEUXUAT = @maPhieuXuat";
            SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);
            checkCommand.Parameters.AddWithValue("@maPhieuXuat", xuathang.MAPHIEUXUAT);

            int duplicateCount = (int)checkCommand.ExecuteScalar();

            if (duplicateCount > 0)
            {
                MessageBox.Show("Mã phiếu xuất đã tồn tại!");
                return 0;
            } 
            else
            {
                string sqlQuery = @"
                     insert into PHIEU_XUAT
                     values (@maPhieuXuat, @maVatTu, @maKhachHang, @soLuong, @thanhTien, @ngayXuat, @maNhanVien)";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@maPhieuXuat", xuathang.MAPHIEUXUAT);
                sqlCommand.Parameters.AddWithValue("@maVatTu", xuathang.MAVATTU);
                sqlCommand.Parameters.AddWithValue("@maKhachHang", xuathang.MAKH);
                sqlCommand.Parameters.AddWithValue("@soLuong", xuathang.SOLUONG);
                sqlCommand.Parameters.AddWithValue("@thanhTien", xuathang.THANHTIEN);
                sqlCommand.Parameters.AddWithValue("@ngayXuat", xuathang.NGAYXUATHANG);
                sqlCommand.Parameters.AddWithValue("@maNhanVien", xuathang.MANV);
                int newRows = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return newRows;
            }

        }

        public int updateOneXuatHang(XuatHang xuathang)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"UPDATE PHIEU_XUAT
                                        SET[MAVATTU] = @maVatTu,
                                           [MAKH] = @maKhachHang,
                                           [SOLUONG] = @soLuong,
                                           [THANHTIEN] = @thanhTien,
                                           [NGAYXUATHANG] = @ngayXuat,
                                           [MANV] = @maNhanVien
                                        WHERE MAPHIEUXUAT = @maPhieuXuat";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@maPhieuXuat", xuathang.MAPHIEUXUAT);
            sqlCommand.Parameters.AddWithValue("@maVatTu", xuathang.MAVATTU);
            sqlCommand.Parameters.AddWithValue("@maKhachHang", xuathang.MAKH);
            sqlCommand.Parameters.AddWithValue("@soLuong", xuathang.SOLUONG);
            sqlCommand.Parameters.AddWithValue("@thanhTien", xuathang.THANHTIEN);
            sqlCommand.Parameters.AddWithValue("@ngayXuat", xuathang.NGAYXUATHANG);
            sqlCommand.Parameters.AddWithValue("@maNhanVien", xuathang.MANV);
            int newRows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return newRows;
        }

        public int deleteOneXuatHang(string MAPHIEUXUAT)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"DELETE FROM PHIEU_XUAT
                                WHERE MAPHIEUXUAT = @maPhieuXuat;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@maPhieuXuat", MAPHIEUXUAT);
            int newRows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return newRows;
        }
    }
}
