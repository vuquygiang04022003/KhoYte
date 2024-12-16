using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHO
{
    internal class supplierDAO
    {
        // string kết nối tới database QLK
        string connectionString = "Data Source=LAPTOP-JKH7G3C3\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";

        public supplierDAO()
        {

        }

        public List<supplier> getAllSuppliers()
        {
            List<supplier> listSuppliers = new List<supplier>();

            // Kết nối tới database QLK
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            // Lệnh sql
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM NHA_CUNG_CAP", sqlConnection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    supplier supplier = new supplier();
                    supplier.MANCC = (string)reader.GetString(0);
                    supplier.TENNCC = (string)reader.GetString(1);
                    supplier.DIACHI = (string)reader.GetString(2);
                    supplier.SDT = (string)reader.GetString(3);
                    supplier.EMAIL = (string)reader.GetString(4);
                    supplier.NGAYHOPTAC = (DateTime)reader.GetDateTime(5);

                    listSuppliers.Add(supplier);
                }
            }
            return listSuppliers;
        }

        public int addOneSupplier(supplier supplier)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"INSERT INTO NHA_CUNG_CAP ([MaNCC], [TenNCC], [DIACHI], [SDT], [EMAIL], [NGAYHOPTAC])
            VALUES (@mancc, @tenncc, @diachi, @sdt, @email, @ngayhoptac);";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@mancc", supplier.MANCC);
            sqlCommand.Parameters.AddWithValue("@tenncc", supplier.TENNCC);
            sqlCommand.Parameters.AddWithValue("@sdt", supplier.SDT);
            sqlCommand.Parameters.AddWithValue("@diachi", supplier.DIACHI);
            sqlCommand.Parameters.AddWithValue("@email", supplier.EMAIL);
            sqlCommand.Parameters.AddWithValue("@ngayhoptac", supplier.NGAYHOPTAC);

            return sqlCommand.ExecuteNonQuery();
        }

        public int updateSupplier(supplier supplier)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"UPDATE NHA_CUNG_CAP 
                            SET TENNCC = @tenncc, DIACHI = @diachi, SDT = @sdt, EMAIL = @email
                            WHERE MANCC = @mancc";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@mancc", supplier.MANCC);
            sqlCommand.Parameters.AddWithValue("@tenncc", supplier.TENNCC);
            sqlCommand.Parameters.AddWithValue("@sdt", supplier.SDT);
            sqlCommand.Parameters.AddWithValue("@diachi", supplier.DIACHI);
            sqlCommand.Parameters.AddWithValue("@email", supplier.EMAIL);
            sqlCommand.Parameters.AddWithValue("@ngayhoptac", supplier.NGAYHOPTAC);

            return sqlCommand.ExecuteNonQuery();
        }

        public int deleteSupplier(string maNCC)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"DELETE FROM NHA_CUNG_CAP WHERE [MaNCC] = @mancc";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@mancc", maNCC);
            return sqlCommand.ExecuteNonQuery();
        }

        public List<supplier> getSuppliersByName(string searchName) 
        {
            List<supplier> listSuppliersByName = new List<supplier>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM NHA_CUNG_CAP WHERE TENNCC LIKE @SearchName", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@SearchName", "%" + searchName + "%");

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    supplier supplier = new supplier();
                    supplier.MANCC = reader.GetValue(0).ToString();
                    supplier.TENNCC = reader.GetValue(1).ToString();
                    supplier.DIACHI = reader.GetValue(2).ToString();
                    supplier.SDT = reader.GetValue(3).ToString();
                    supplier.EMAIL = reader.GetValue(4).ToString();
                    supplier.NGAYHOPTAC = reader.GetDateTime(5).ToLocalTime();

                    listSuppliersByName.Add(supplier);
                }
            }
            return listSuppliersByName;
        }
    }
}
