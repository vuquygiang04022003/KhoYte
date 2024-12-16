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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QUANLYKHO
{
    public partial class Formxuathang : Form
    {
        BindingSource xuatHangBindingSource = new BindingSource();
        public Formxuathang()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)

        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridView1, saveFileDialog1.FileName);
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

        private void Formxuathang_Load_1(object sender, EventArgs e)
        {
            cbTKT.SelectedIndex = 0;
            XuatHangDAO xuatHangDAO = new XuatHangDAO();
            xuatHangBindingSource.DataSource = xuatHangDAO.getAllXuatHang();
            dataGridView1.DataSource = xuatHangBindingSource;
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string keyWhere = "MAKH";
            switch (cbTKT.SelectedIndex)
            {
                case 0:
                    keyWhere = "MAKH";
                    break;
                case 1:
                    keyWhere = "MAPHIEUXUAT";
                    break;
                case 2:
                    keyWhere = "MAVATTU";
                    break;
                case 3:
                    keyWhere = "MANV";
                    break;
            }
            if (string.IsNullOrEmpty(txtTK.Text))
            {
                MessageBox.Show("vui lòng điền thông tin !");
            }
            XuatHangDAO xuatHangDAO = new XuatHangDAO();

            xuatHangBindingSource.DataSource = xuatHangDAO.getXuatHang(txtTK.Text, keyWhere);

            dataGridView1.DataSource = xuatHangBindingSource;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMAPX.Text) || string.IsNullOrEmpty(txtMAVT.Text) || string.IsNullOrEmpty(txtMAKH.Text)
                || string.IsNullOrEmpty(txtSL.Text) || string.IsNullOrEmpty(txtTG.Text)
                )
            {
                MessageBox.Show("Hãy điển đầy đủ thông tin sửa");
            }
            else
            {
                XuatHang xuatHang = new XuatHang
                {
                    MAPHIEUXUAT = txtMAPX.Text,
                    MAVATTU = txtMAVT.Text,
                    MAKH = txtMAKH.Text,
                    SOLUONG = int.Parse(txtSL.Text),
                    THANHTIEN = txtTT.Text,
                    NGAYXUATHANG = txtTG.Value,
                    MANV = txtMANV.Text
                };
                XuatHangDAO xuatHangDAO = new XuatHangDAO();
                int newRows = xuatHangDAO.addOneXuatHang(xuatHang);
                MessageBox.Show("Đã thêm " + newRows + " phiếu xuất hàng");
                xuatHangBindingSource.DataSource = xuatHangDAO.getAllXuatHang();
                dataGridView1.DataSource = xuatHangBindingSource;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMAPX.Text) || string.IsNullOrEmpty(txtMAVT.Text) || string.IsNullOrEmpty(txtMAKH.Text)
                || string.IsNullOrEmpty(txtSL.Text) || string.IsNullOrEmpty(txtTG.Text)
                )
            {
                MessageBox.Show("Hãy điển đầy đủ thông tin sửa");
            }
            else
            {
                XuatHang xuatHang = new XuatHang
                {
                    MAPHIEUXUAT = txtMAPX.Text,
                    MAVATTU = txtMAVT.Text,
                    MAKH = txtMAKH.Text,
                    SOLUONG = int.Parse(txtSL.Text),
                    THANHTIEN = txtTT.Text,
                    NGAYXUATHANG = txtTG.Value,
                    MANV = txtMANV.Text
                };
                XuatHangDAO xuatHangDAO = new XuatHangDAO();
                int newRows = xuatHangDAO.updateOneXuatHang(xuatHang);
                MessageBox.Show("Đã sửa " + newRows + " phiếu xuất hàng");
                xuatHangBindingSource.DataSource = xuatHangDAO.getAllXuatHang();
                dataGridView1.DataSource = xuatHangBindingSource;

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string MAPHIEUXUAT = txtMAPX.Text;
                XuatHangDAO xuatHangDAO = new XuatHangDAO();
                int newRows = xuatHangDAO.deleteOneXuatHang(MAPHIEUXUAT);
                MessageBox.Show("Đã xoá " + newRows + " phiếu xuất hàng");
                xuatHangBindingSource.DataSource = xuatHangDAO.getAllXuatHang();
                dataGridView1.DataSource = xuatHangBindingSource;
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentRow.Index;
            txtMAPX.Text = dataGridView.Rows[currentRow].Cells[0].Value.ToString();
            txtMAVT.Text = dataGridView.Rows[currentRow].Cells[1].Value.ToString();
            txtMAKH.Text = dataGridView.Rows[currentRow].Cells[2].Value.ToString();
            txtSL.Text = dataGridView.Rows[currentRow].Cells[3].Value.ToString();
            txtTT.Text = dataGridView.Rows[currentRow].Cells[4].Value.ToString();
            string dateStr = dataGridView.Rows[currentRow].Cells[5].Value.ToString();
            txtMANV.Text = dataGridView.Rows[currentRow].Cells[6].Value.ToString();
            DateTime dateTime = DateTime.Parse(dateStr);
            txtTG.Value = dateTime;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtTK.Text = "";
            txtMAPX.Text = "";
            txtMAVT.Text = "";
            txtMAKH.Text = "";
            txtSL.Text = "";
            txtTT.Text = "";
            txtMANV.Text = "";
            XuatHangDAO xuatHangDAO = new XuatHangDAO();
            xuatHangBindingSource.DataSource = xuatHangDAO.getAllXuatHang();
            dataGridView1.DataSource = xuatHangBindingSource;
        }
    }
}

