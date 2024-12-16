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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            hienthivt();
            hienthislnk();
            hienthislxk();
            tonkho();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hienthivt();
            hienthislnk();
            hienthislxk();
            tonkho();
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label.Text = "Home";
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Formdangnhap form1 = new Formdangnhap();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formnhaphang());
            label.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formxuathang());
            label.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formvattu());
            label.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaCungCap());
            label.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formdonvido());
            label.Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
            label.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formnguoidung());
            label.Text = button8.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void hienthivt()
        {
            string connectionString = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string countQuery = "SELECT COUNT(*) FROM VATTU";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(countQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        labelvattu.Text = count.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void hienthislnk()
        {
            string connectionString = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string sumQuery = "SELECT SUM(SOLUONG) FROM PHIEU_NHAP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sumQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        labelnhapkho.Text = count.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void hienthislxk()
        {
            string connectionString = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string sumQuery = "SELECT SUM(SOLUONG) FROM PHIEU_XUAT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sumQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        labelxuatkho.Text = count.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void tonkho()
        {

            int soLuongNhapKho = 0;
            int soLuongXuatKho = 0;

            // Tính số lượng nhập kho
            string connectionStringNhap = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string sumQueryNhap = "SELECT SUM(SOLUONG) FROM PHIEU_NHAP";

            using (SqlConnection connectionNhap = new SqlConnection(connectionStringNhap))
            {
                using (SqlCommand commandNhap = new SqlCommand(sumQueryNhap, connectionNhap))
                {
                    try
                    {
                        connectionNhap.Open();
                        soLuongNhapKho = (int)(commandNhap.ExecuteScalar() ?? 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tính số lượng nhập kho: " + ex.Message);
                    }
                }
            }

            // Tính số lượng xuất kho
            string connectionStringXuat = "Data Source=PHANTUOI\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False";
            string sumQueryXuat = "SELECT SUM(SOLUONG) FROM PHIEU_XUAT";

            using (SqlConnection connectionXuat = new SqlConnection(connectionStringXuat))
            {
                using (SqlCommand commandXuat = new SqlCommand(sumQueryXuat, connectionXuat))
                {
                    try
                    {
                        connectionXuat.Open();
                        soLuongXuatKho = (int)(commandXuat.ExecuteScalar() ?? 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tính số lượng xuất kho: " + ex.Message);
                    }
                }
            }

            // Tính số lượng tồn kho
            int soLuongTonKho = soLuongNhapKho - soLuongXuatKho;

            // Hiển thị kết quả trên Label
            labeltonkho.Text = soLuongTonKho.ToString();

        }

        private void labelnhapkho_Click(object sender, EventArgs e)
        {

        }
    }
}
