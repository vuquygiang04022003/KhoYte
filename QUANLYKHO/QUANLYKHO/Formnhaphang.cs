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

namespace QUANLYKHO
{
    public partial class Formnhaphang : Form
    {
        public Formnhaphang()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = "Data Source=LAPTOP-JKH7G3C3\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string query = "SELECT PHIEU_NHAP.MAPHIEUNHAP,PHIEU_NHAP.MAVATTU,VATTU.TENVT,PHIEU_NHAP.MANCC,PHIEU_NHAP.SOLUONG,PHIEU_NHAP.THANHTIEN,PHIEU_NHAP.NGAYNHAPHANG FROM PHIEU_NHAP INNER JOIN VATTU ON PHIEU_NHAP.MAVATTU=VATTU.MAVATTU ";

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
                        dataGridViewnk.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewnk_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentCell.RowIndex;
            textmnh.Text = dataGridView.Rows[currentRow].Cells[0].Value.ToString();
            textmvt.Text = dataGridView.Rows[currentRow].Cells[1].Value.ToString();
            textncc.Text = dataGridView.Rows[currentRow].Cells[3].Value.ToString();
            textsoluong.Text = dataGridView.Rows[currentRow].Cells[4].Value.ToString();
            texttien.Text = dataGridView.Rows[currentRow].Cells[5].Value.ToString();
            string dateStr = dataGridView.Rows[currentRow].Cells[6].Value.ToString();
            DateTime dateTime = DateTime.Parse(dateStr);
            dateTimenh.Value = dateTime;

        }

        private void btn_clearnk_Click(object sender, EventArgs e)
        {
            textmnh.Text = "";
            textmvt.Text = "";
            textncc.Text = "";
            textsoluong.Text = "";
            texttien.Text = "";
            dateTimenh.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string deleteQuery = "DELETE FROM PHIEU_NHAP WHERE MAPHIEUNHAP = @MAPHIEUNHAP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@MAPHIEUNHAP", textmnh.Text);

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

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textmnh.Text) || string.IsNullOrEmpty(textmvt.Text) || string.IsNullOrEmpty(textncc.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
            else
            {
                string connectionString = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
                string insertQuery = "INSERT INTO PHIEU_NHAP (MAPHIEUNHAP,MAVATTU,MANCC,SOLUONG,THANHTIEN,NGAYNHAPHANG) VALUES (@MAPHIEUNHAP,@MAVATTU,@MANCC,@SOLUONG,@THANHTIEN,@NGAYNHAPHANG)";
                string checkDuplicateQuery = "SELECT COUNT(*) FROM PHIEU_NHAP WHERE MAPHIEUNHAP = @MAPHIEUNHAP";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand checkDuplicateCommand = new SqlCommand(checkDuplicateQuery, connection))
                    {
                        checkDuplicateCommand.Parameters.AddWithValue("@MAPHIEUNHAP", textmnh.Text);

                        try
                        {
                            connection.Open();
                            int duplicateCount = (int)checkDuplicateCommand.ExecuteScalar();

                            if (duplicateCount > 0)
                            {
                                MessageBox.Show("MAPHIEUNHAP đã tồn tại!");
                            }
                            else
                            {
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@MAPHIEUNHAP", textmnh.Text);
                                    insertCommand.Parameters.AddWithValue("@MAVATTU", textmvt.Text);
                                    insertCommand.Parameters.AddWithValue("@MANCC", textncc.Text);
                                    insertCommand.Parameters.AddWithValue("@SOLUONG", textsoluong.Text);
                                    insertCommand.Parameters.AddWithValue("@THANHTIEN", texttien.Text);
                                    insertCommand.Parameters.AddWithValue("@NGAYNHAPHANG",dateTimenh.Value);
                                  
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
            string updateQuery = "UPDATE PHIEU_NHAP SET MAVATTU=@MAVATTU,MANCC=@MANCC,SOLUONG=@SOLUONG,THANHTIEN=@THANHTIEN,NGAYNHAPHANG=@NGAYNHAPHANG  WHERE MAPHIEUNHAP = @MAPHIEUNHAP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@MAPHIEUNHAP", textmnh.Text);
                    command.Parameters.AddWithValue("@MAVATTU", textmvt.Text);
                    command.Parameters.AddWithValue("@MANCC", textncc.Text);
                    command.Parameters.AddWithValue("@SOLUONG", textsoluong.Text);
                    command.Parameters.AddWithValue("@THANHTIEN", texttien.Text);
                    command.Parameters.AddWithValue("@NGAYNHAPHANG", dateTimenh.Value);

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

        private void IN_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridViewnk, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = DateTime.Now.ToString("dd MMMM yyyy - HH|mm|ss");

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void Formnhaphang_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewnk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void texttien_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void textncc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textmvt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textmnh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
