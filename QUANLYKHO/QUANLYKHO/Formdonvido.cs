using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QUANLYKHO
{
    public partial class Formdonvido : Form
    {
        public Formdonvido()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = "Data Source=LAPTOP-JKH7G3C3\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string query = "SELECT * FROM DON_VI_TINH ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị dữ liệu trong DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void xem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textmadvd.Text) || string.IsNullOrEmpty(texttendvd.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
            else
            {
                string connectionString = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
                string insertQuery = "INSERT INTO DON_VI_TINH (MADVT,TENDV) VALUES (@MADVT, @TENDV)";
                string checkDuplicateQuery = "SELECT COUNT(*) FROM DON_VI_TINH WHERE MADVT = @MADVT";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand checkDuplicateCommand = new SqlCommand(checkDuplicateQuery, connection))
                    {
                        checkDuplicateCommand.Parameters.AddWithValue("@MADVT", textmadvd.Text);

                        try
                        {
                            connection.Open();
                            int duplicateCount = (int)checkDuplicateCommand.ExecuteScalar();

                            if (duplicateCount > 0)
                            {
                                MessageBox.Show("MADVT đã tồn tại!");
                            }
                            else
                            {
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@MADVT", textmadvd.Text);
                                    insertCommand.Parameters.AddWithValue("@TENDV", texttendvd.Text);

                                    int result = insertCommand.ExecuteNonQuery();

                                    if (result > 0)
                                    {
                                        MessageBox.Show("Thêm thông tin thành công!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm thông tin không thành công!");
                                    }
                                }
                            }

                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string updateQuery = "UPDATE DON_VI_TINH SET TENDV = @TENDV WHERE MADVT = @MADVT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@MADVT", textmadvd.Text);
                    command.Parameters.AddWithValue("@TENDV", texttendvd.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin không thành công!");
                        }

                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string deleteQuery = "DELETE FROM DON_VI_TINH WHERE MADVT = @MADVT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@MADVT", textmadvd.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa thông tin thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thông tin không thành công!");
                        }

                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentCell.RowIndex;
            textmadvd.Text = dataGridView.Rows[currentRow].Cells[0].Value.ToString();
            texttendvd.Text = dataGridView.Rows[currentRow].Cells[1].Value.ToString();
        }
    }
}