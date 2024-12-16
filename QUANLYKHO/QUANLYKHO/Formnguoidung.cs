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
using System.Xml.Linq;

namespace QUANLYKHO
{
    public partial class Formnguoidung : Form
    {
        public Formnguoidung()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Formnguoidung_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
            "Data Source=LAPTOP-JKH7G3C3\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False");
            try
            {
                conn.Open();
                string query = $"SELECT * FROM TT_Nhan_Vien WHERE MaNV = '{luuTru.data}'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    textBox1.Text = reader["MaNV"].ToString();
                    textBox2.Text = reader["TENNV"].ToString();
                    textBox3.Text = reader["GT"].ToString();
                    textBox4.Text = reader["NgaySinh"].ToString();
                    textBox5.Text = reader["DIACHI"].ToString();
                    textBox6.Text = reader["SDT"].ToString();
                    textBox7.Text = reader["GMAIL"].ToString();
                }
                else
                {
                    MessageBox.Show("Có lỗi gì đó");
                }
            }
            finally
            {
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
