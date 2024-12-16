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
    public partial class Formvattu : Form
    {
        BindingSource vatTuBindingSource = new BindingSource();
        public Formvattu()
        {
            InitializeComponent();
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMAVT.Text) || string.IsNullOrEmpty(txtTVT.Text) || string.IsNullOrEmpty(txtMDVT.Text) || string.IsNullOrEmpty(txtMNCC.Text))
            {
                MessageBox.Show("Hãy điển đầy đủ thông tin sửa");
            }
            else
            {
                VatTu vatTu = new VatTu
                {
                    MAVATTU = txtMAVT.Text,
                    TENVATTU = txtTVT.Text,
                    MADVT = txtMDVT.Text,
                    MANCC = txtMNCC.Text,
                    GHICHU = txtGC.Text,

                };
                VatTuDAO xuatHangDAO = new VatTuDAO();
                int newRows = xuatHangDAO.addOneVatTu(vatTu);
                MessageBox.Show("Đã thêm " + newRows + " vật tư");
                vatTuBindingSource.DataSource = xuatHangDAO.getAllVatTu();
                dataGridView1.DataSource = vatTuBindingSource;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMAVT.Text) || string.IsNullOrEmpty(txtTVT.Text) || string.IsNullOrEmpty(txtMDVT.Text) || string.IsNullOrEmpty(txtMNCC.Text))
            {
                MessageBox.Show("Hãy điển đầy đủ thông tin sửa");
            }
            else
            {
                VatTu vatTu = new VatTu
                {
                    MAVATTU = txtMAVT.Text,
                    TENVATTU = txtTVT.Text,
                    MADVT = txtMDVT.Text,
                    MANCC = txtMNCC.Text,
                    GHICHU = txtGC.Text,
                };
                VatTuDAO xuatHangDAO = new VatTuDAO();
                int newRows = xuatHangDAO.updateOneVatTu(vatTu);
                MessageBox.Show("Đã sửa " + newRows + " vật tư");
                vatTuBindingSource.DataSource = xuatHangDAO.getAllVatTu();
                dataGridView1.DataSource = vatTuBindingSource;
            }    
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa vật tự đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string MAVATTU = txtMAVT.Text;
                XuatHangDAO xuatHangDAO = new XuatHangDAO();
                int newRows = xuatHangDAO.deleteOneXuatHang(MAVATTU);
                MessageBox.Show("Đã xoá " + newRows + " vật tư");
                vatTuBindingSource.DataSource = xuatHangDAO.getAllXuatHang();
                dataGridView1.DataSource = vatTuBindingSource;
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            txtTK.Text = "";
            txtMAVT.Text = "";
            txtTVT.Text = "";
            txtMDVT.Text = "";
            txtMNCC.Text = "";
            txtGC.Text = "";
            VatTuDAO xuatHangDAO = new VatTuDAO();
            vatTuBindingSource.DataSource = xuatHangDAO.getAllVatTu();
            dataGridView1.DataSource = vatTuBindingSource;
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string keyWhere = "TENVT";
            switch (cbTKT.SelectedIndex)
            {
                case 0:
                    keyWhere = "TENVT";
                    break;
                case 1:
                    keyWhere = "MAVATTU";
                    break;
                case 2:
                    keyWhere = "MADVT";
                    break;
                case 3:
                    keyWhere = "MANCC";
                    break;
                case 4:
                    keyWhere = "GHICHU";
                    break;
            }
            if (string.IsNullOrEmpty(txtTK.Text))
            {
                MessageBox.Show("vui lòng điền thông tin !");
            }
            VatTuDAO vatTuDAO = new VatTuDAO();

            vatTuBindingSource.DataSource = vatTuDAO.getVatTu(txtTK.Text, keyWhere);

            dataGridView1.DataSource = vatTuBindingSource;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentRow.Index;
            txtMAVT.Text = dataGridView.Rows[currentRow].Cells[0].Value.ToString();
            txtTVT.Text = dataGridView.Rows[currentRow].Cells[1].Value.ToString();
            txtMDVT.Text = dataGridView.Rows[currentRow].Cells[2].Value.ToString();
            txtMNCC.Text = dataGridView.Rows[currentRow].Cells[3].Value.ToString();
            txtGC.Text = dataGridView.Rows[currentRow].Cells[4].Value.ToString();
        }

        private void Formvattu_Load_1(object sender, EventArgs e)
        {
            cbTKT.SelectedIndex = 0;
            VatTuDAO xuatHangDAO = new VatTuDAO();
            vatTuBindingSource.DataSource = xuatHangDAO.getAllVatTu();
            dataGridView1.DataSource = vatTuBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
