using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHO
{
    internal class customerDAO
    {
        string connectionString = "Data Source=LAPTOP-JKH7G3C3\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";

        public customerDAO()
        {

        }

        public List<customer> getAllCustomer()
        {
            List<customer> listCustomers = new List<customer>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM KHACH_HANG", sqlConnection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    customer customer = new customer();
                    customer.MAKH = (string)reader.GetString(0);
                    customer.TENKH = (string)reader.GetString(1);
                    customer.DIACHI = (string)reader.GetString(2);
                    customer.SDT = (string)reader.GetString(3);
                    customer.EMAIL = (string)reader.GetString(4);
                    customer.GHICHU = (string)reader.GetString(5);

                    listCustomers.Add(customer);
                }
            }
            return listCustomers;
        }

        public List<customer> getCustomersByName(string searchName)
        {
            List<customer> listCustomersByName = new List<customer>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM KHACH_HANG WHERE TENKH LIKE @SearchName", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@SearchName", "%" + searchName + "%");

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    customer customer = new customer();
                    customer.MAKH = reader.GetValue(0).ToString();
                    customer.TENKH = reader.GetValue(1).ToString();
                    customer.DIACHI = reader.GetValue(2).ToString();
                    customer.SDT = reader.GetValue(3).ToString();
                    customer.EMAIL = reader.GetValue(4).ToString();
                    customer.GHICHU = reader.GetValue(5).ToString();

                    listCustomersByName.Add(customer);
                }
            }
            return listCustomersByName;
        }

        public int addOneCustomer(customer customer)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"INSERT INTO KHACH_HANG ([MaKH], [TenKH], [DIACHI], [SDT], [EMAIL], [GHICHU])
            VALUES (@makh, @tenkh, @diachi, @sdt, @email, @ghichu);";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@makh", customer.MAKH);
            sqlCommand.Parameters.AddWithValue("@tenkh", customer.TENKH);
            sqlCommand.Parameters.AddWithValue("@sdt", customer.SDT);
            sqlCommand.Parameters.AddWithValue("@diachi", customer.DIACHI);
            sqlCommand.Parameters.AddWithValue("@email", customer.EMAIL);
            sqlCommand.Parameters.AddWithValue("@ghichu", customer.GHICHU);

            return sqlCommand.ExecuteNonQuery();
        }

        public int updateCustomer(customer customer)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"UPDATE KHACH_HANG 
                            SET TENKH = @tenkh, DIACHI = @diachi, SDT = @sdt, EMAIL = @email
                            WHERE MAKH = @makh";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@makh", customer.MAKH);
            sqlCommand.Parameters.AddWithValue("@tenkh", customer.TENKH);
            sqlCommand.Parameters.AddWithValue("@sdt", customer.SDT);
            sqlCommand.Parameters.AddWithValue("@diachi", customer.DIACHI);
            sqlCommand.Parameters.AddWithValue("@email", customer.EMAIL);
            sqlCommand.Parameters.AddWithValue("@ghichu", customer.GHICHU);

            return sqlCommand.ExecuteNonQuery();
        }

        public int deleteCustomer(string maKH)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string sqlQuery = @"DELETE FROM KHACH_HANG WHERE [MaKH] = @makh";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@makh", maKH);
            return sqlCommand.ExecuteNonQuery();
        }
    }


}
