using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHO
{
    public partial class frmKhachHang : Form
    {
        BindingSource customerBindingSource = new BindingSource();
        public frmKhachHang()
        {
            InitializeComponent();
            loadDataCustomers();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void loadDataCustomers()
        {
            customerDAO customerDAO = new customerDAO();
            customerBindingSource.DataSource = customerDAO.getAllCustomer();
            dgvCustomer.DataSource = customerBindingSource;
        }

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearchCustomer.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                customerDAO customerDAO = new customerDAO();
                customerBindingSource.DataSource = customerDAO.getCustomersByName(searchText);
                dgvCustomer.DataSource = customerBindingSource;
            }
            else
            {
                loadDataCustomers();
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            customer customer = new customer
            {
                MAKH = txtMakh.Text,
                TENKH = txtMakh.Text,
                DIACHI = txtDiachi.Text,
                SDT = txtSDT.Text,
                EMAIL = txtEmail.Text,
                GHICHU = txtGhichu.Text,
            };
            customerDAO customerDAO = new customerDAO();
            int newRows = customerDAO.addOneCustomer(customer);
            MessageBox.Show("Đã thêm " + newRows + " khách hàng mới!");
            loadDataCustomers();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                string maKH = dgvCustomer.SelectedRows[0].Cells["MAKH"].Value.ToString();
                {
                    customer customer = new customer
                    {
                        MAKH = txtMakh.Text,
                        TENKH = txtTenkh.Text,
                        DIACHI = txtDiachi.Text,
                        SDT = txtSDT.Text,
                        EMAIL = txtEmail.Text,
                        GHICHU = txtGhichu.Text,
                    };
                    customerDAO customerDAO = new customerDAO();
                    int newRows = customerDAO.addOneCustomer(customer);
                    MessageBox.Show("Đã cập nhật " + newRows + " khách hàng!");
                    loadDataCustomers();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng để cập nhật thông tin!");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string maKH = dgvCustomer.SelectedRows[0].Cells["MAKH"].Value.ToString();

                    customerDAO customerDAO = new customerDAO();
                    int deletedRows = customerDAO.deleteCustomer(maKH);
                    MessageBox.Show("Đã xóa " + deletedRows + " khách hàng!");
                    loadDataCustomers();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng để xóa!");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtMakh.Clear();
            txtTenkh.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtGhichu.Clear();
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            // Khởi tạo một đối tượng ExcelPackage
            ExcelPackage excelPackage = new ExcelPackage();

            // Thêm một Sheet mới vào ExcelPackage
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("DataSheet");

            // Thêm dữ liệu từ DataGridView vào Sheet
            for (int i = 0; i < dgvCustomer.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvCustomer.Columns.Count; j++)
                {
                    worksheet.Cells[i + 1, j + 1].Value = dgvCustomer.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Lưu ExcelPackage vào một tập tin Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Lưu file Excel";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.FileInfo file = new System.IO.FileInfo(saveFileDialog.FileName);
                excelPackage.SaveAs(file);
                MessageBox.Show("Đã xuất file Exel thành công!", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentRow.Index;

            txtMakh.Text = dataGridView.Rows[currentRow].Cells[0].Value.ToString();
            txtTenkh.Text = dataGridView.Rows[currentRow].Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView.Rows[currentRow].Cells[2].Value.ToString();
            txtSDT.Text = dataGridView.Rows[currentRow].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView.Rows[currentRow].Cells[4].Value.ToString();
            txtGhichu.Text = dataGridView.Rows[currentRow].Cells[5].Value.ToString();
        }

        
    }
}
