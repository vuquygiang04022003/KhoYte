using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHO
{
    internal class VatTuDAO
    {
        string connectionString = "Data Source=LAPTOP-JKH7G3C3\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
        public VatTuDAO() { }
        public List<VatTu> getAllVatTu()
        {
            List<VatTu> listVatTu = new List<VatTu>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM VATTU", sqlConnection);
            using(SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    VatTu vatTu = new VatTu();
                    vatTu.MAVATTU = (string)reader.GetString(0);
                    vatTu.TENVATTU = (string)reader.GetString(1);
                    vatTu.MADVT = (string)reader.GetString(2);
                    vatTu.MANCC = (string)reader.GetString(3);
                    vatTu.GHICHU = reader.GetValue(4).ToString();
                    listVatTu.Add(vatTu);
                }
            }
            return listVatTu;
        }

        public List<VatTu> getVatTu(string keySearch, string keyWhere)
        {
            List<VatTu> listVatTu = new List<VatTu>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM VATTU WHERE " + keyWhere + " LIKE '%" + keySearch + "%'", sqlConnection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    VatTu vatTu = new VatTu();
                    vatTu.MAVATTU = (string)reader.GetString(0);
                    vatTu.TENVATTU = (string)reader.GetString(1);
                    vatTu.MADVT = (string)reader.GetString(2);
                    vatTu.MANCC = (string)reader.GetString(3);
                    vatTu.GHICHU = reader.GetValue(4).ToString();
                    listVatTu.Add(vatTu);
                }
            }
            return listVatTu;
        }

        public int addOneVatTu(VatTu vattu)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string checkQuery = "SELECT COUNT(*) FROM VATTU WHERE MAVATTU = @maVatTu";
            SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);
            checkCommand.Parameters.AddWithValue("@maVatTu", vattu.MAVATTU);

            int duplicateCount = (int)checkCommand.ExecuteScalar();

            if (duplicateCount > 0)
            {
                MessageBox.Show("Mã vật tư đã tồn tại!");
                return 0;
            }
            else
            {
                string sqlQuery = @"
                 insert into VATTU
                 values (@maVatTu, @tenVatTu, @maDonViTinh, @maNhaCungCap, @ghiChu)";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@maVatTu", vattu.MAVATTU);
                sqlCommand.Parameters.AddWithValue("@tenVatTu", vattu.TENVATTU);
                sqlCommand.Parameters.AddWithValue("@maDonViTinh", vattu.MADVT);
                sqlCommand.Parameters.AddWithValue("@maNhaCungCap", vattu.MANCC);
           
                sqlCommand.Parameters.AddWithValue("@ghiChu", vattu.GHICHU);
                int newRows = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
                return newRows;
            }
        }

        public int updateOneVatTu(VatTu vattu)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"UPDATE VATTU
                                        SET[TENVT] = @tenVatTu,
                                           [MADVT] = @maDonViTinh,
                                           [MANCC] = @maNhaCungCap,
                                           [GHICHU] = @ghiChu
                                        WHERE MAVATTU = @maVatTu";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@maVatTu", vattu.MAVATTU);
            sqlCommand.Parameters.AddWithValue("@tenVatTu", vattu.TENVATTU);
            sqlCommand.Parameters.AddWithValue("@maDonViTinh", vattu.MADVT);
            sqlCommand.Parameters.AddWithValue("@maNhaCungCap", vattu.MANCC);
            sqlCommand.Parameters.AddWithValue("@ghiChu", vattu.GHICHU);
            int newRows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return newRows;
        }

        public int deleteOneVatTu(string MAVATTU)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"DELETE FROM VATTU
                                WHERE MAVATTU = @maVatTu;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@maVatTu", MAVATTU);
            int newRows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return newRows;
        }
    }
}
