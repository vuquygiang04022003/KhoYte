using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QUANLYKHO
{
    public partial class Formdangnhap : Form
    {
        public Formdangnhap()
        {
            InitializeComponent();
        }
 
        private void tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click_1(object sender, EventArgs e)
        {
            string tenTaiKhoan = tk.Text;
            string matKhau = MK.Text;
            if (tenTaiKhoan == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống");
            }
            else if (matKhau == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
            }
            else
            {
                SqlConnection conn = new SqlConnection(
                "Data Source=LAPTOP-JKH7G3C3\\SQLEXPRESS;Initial Catalog=qlk;Integrated Security=True;Encrypt=False");
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM TAI_KHOAN WHERE TK = '{tenTaiKhoan}' and MK = '{matKhau}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        luuTru.data = tenTaiKhoan;
                        FormHome form2 = new FormHome();
                        this.Hide();
                        form2.Show();
                        // So sánh dữ liệu nhập vào với dữ liệu trong bảng


                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    }
                }
                finally
                {
                }
            }
        }
    }
}