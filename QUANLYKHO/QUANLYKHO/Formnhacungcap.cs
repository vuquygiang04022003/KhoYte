using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace QUANLYKHO
{
    public partial class frmNhaCungCap : Form
    {
        BindingSource supplierBindingSource = new BindingSource();
        public frmNhaCungCap()
        {
            InitializeComponent();
            loadDataSuppliers();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void loadDataSuppliers()
        {
            supplierDAO supplierDAO = new supplierDAO();
            supplierBindingSource.DataSource = supplierDAO.getAllSuppliers();
            dgvSupplier.DataSource = supplierBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnSearchName_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvSupplier_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentRow.Index;

            txtMancc.Text = dataGridView.Rows[currentRow].Cells[0].Value.ToString();
            txtTenncc.Text = dataGridView.Rows[currentRow].Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView.Rows[currentRow].Cells[2].Value.ToString();
            txtSDT.Text = dataGridView.Rows[currentRow].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView.Rows[currentRow].Cells[4].Value.ToString();
            txtNHT.Text = dataGridView.Rows[currentRow].Cells[5].Value.ToString();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtNHT.Text, out DateTime ngayHopTac))
            {
                supplier supplier = new supplier
                {
                    MANCC = txtMancc.Text,
                    TENNCC = txtTenncc.Text,
                    DIACHI = txtDiachi.Text,
                    SDT = txtSDT.Text,
                    EMAIL = txtEmail.Text,
                    NGAYHOPTAC = ngayHopTac
                };
                supplierDAO supplierDAO = new supplierDAO();
                int newRows = supplierDAO.addOneSupplier(supplier);

                MessageBox.Show("Đã thêm " + newRows + " nhà cung cấp mới!");
                loadDataSuppliers();
            }
            else
            {

                MessageBox.Show("Định dạng ngày đã nhập không hợp lệ! Nhập lại theo mẫu yyyy/mm/dd");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {

                string maNCC = dgvSupplier.SelectedRows[0].Cells["MANCC"].Value.ToString();


                if (DateTime.TryParse(txtNHT.Text, out DateTime ngayHopTac))
                {
                    supplier supplier = new supplier
                    {
                        MANCC = txtMancc.Text,
                        TENNCC = txtTenncc.Text,
                        DIACHI = txtDiachi.Text,
                        SDT = txtSDT.Text,
                        EMAIL = txtEmail.Text,
                        NGAYHOPTAC = ngayHopTac
                    };
                    supplierDAO supplierDAO = new supplierDAO();
                    int updatedRows = supplierDAO.updateSupplier(supplier);

                    MessageBox.Show("Đã cập nhật " + updatedRows + " nhà cung cấp!");
                    loadDataSuppliers();
                }
                else
                {

                    MessageBox.Show("Định dạng ngày đã nhập không hợp lệ! Nhập lại theo mẫu yyyy/mm/dd");
                }
            }
            else
            {

                MessageBox.Show("Hãy chọn nhà cung cấp để cập nhật thông tin!");

            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    string maNCC = dgvSupplier.SelectedRows[0].Cells["MANCC"].Value.ToString();

                    supplierDAO supplierDAO = new supplierDAO();
                    int deletedRows = supplierDAO.deleteSupplier(maNCC);

                    MessageBox.Show("Đã xóa " + deletedRows + " nhà cung cấp!");
                    loadDataSuppliers();
                }
            }
            else
            {

                MessageBox.Show("Hãy chọn nhà cung cấp để xóa!");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtMancc.Clear();
            txtTenncc.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtNHT.Clear();
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            // Khởi tạo một đối tượng ExcelPackage
            ExcelPackage excelPackage = new ExcelPackage();

            // Thêm một Sheet mới vào ExcelPackage
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("DataSheet");

            // Thêm dữ liệu từ DataGridView vào Sheet
            for (int i = 0; i < dgvSupplier.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvSupplier.Columns.Count; j++)
                {
                    worksheet.Cells[i + 1, j + 1].Value = dgvSupplier.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Lưu ExcelPackage vào một tập tin Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.FileInfo file = new System.IO.FileInfo(saveFileDialog.FileName);
                excelPackage.SaveAs(file);
                MessageBox.Show("Excel file has been exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearchName_Click(sender, e);
                e.Handled = true;
            }
        }

        private void btnSearchName_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearchName.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                supplierDAO supplierDAO = new supplierDAO();
                supplierBindingSource.DataSource = supplierDAO.getSuppliersByName(searchText);
                dgvSupplier.DataSource = supplierBindingSource;
            }
            else
            {
                loadDataSuppliers();
            }
        }
    }
}
