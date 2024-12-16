namespace QUANLYKHO
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvCustomer = new DataGridView();
            txtSearchCustomer = new TextBox();
            btnSearchCustomer = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnExport = new Button();
            btnClear = new Button();
            txtGhichu = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiachi = new TextBox();
            txtTenkh = new TextBox();
            txtMakh = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 1;
            label1.Text = "KHÁCH HÀNG";
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top;
            dgvCustomer.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(367, 79);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomer.RowTemplate.Height = 25;
            dgvCustomer.Size = new Size(437, 330);
            dgvCustomer.TabIndex = 12;
            dgvCustomer.CellClick += dgvCustomer_CellClick_1;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Anchor = AnchorStyles.Top;
            txtSearchCustomer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchCustomer.Location = new Point(463, 45);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(207, 26);
            txtSearchCustomer.TabIndex = 11;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Anchor = AnchorStyles.Top;
            btnSearchCustomer.BackColor = Color.Green;
            btnSearchCustomer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchCustomer.ForeColor = Color.White;
            btnSearchCustomer.Location = new Point(676, 45);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(128, 28);
            btnSearchCustomer.TabIndex = 10;
            btnSearchCustomer.Text = "Tìm kiếm";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            btnSearchCustomer.Click += btnSearchCustomer_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(174, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 28);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.BackColor = Color.Green;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(93, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 28);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Top;
            btnInsert.BackColor = Color.Green;
            btnInsert.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(12, 415);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 28);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top;
            btnExport.BackColor = Color.Green;
            btnExport.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(700, 415);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(104, 28);
            btnExport.TabIndex = 22;
            btnExport.Text = "Xuất file excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click_1;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top;
            btnClear.BackColor = Color.Green;
            btnClear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(255, 415);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 28);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // txtGhichu
            // 
            txtGhichu.Anchor = AnchorStyles.Top;
            txtGhichu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGhichu.Location = new Point(116, 273);
            txtGhichu.Multiline = true;
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(214, 124);
            txtGhichu.TabIndex = 35;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(116, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 21);
            txtEmail.TabIndex = 34;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top;
            txtSDT.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSDT.Location = new Point(116, 199);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(214, 21);
            txtSDT.TabIndex = 33;
            // 
            // txtDiachi
            // 
            txtDiachi.Anchor = AnchorStyles.Top;
            txtDiachi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiachi.Location = new Point(116, 159);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(214, 21);
            txtDiachi.TabIndex = 32;
            // 
            // txtTenkh
            // 
            txtTenkh.Anchor = AnchorStyles.Top;
            txtTenkh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenkh.Location = new Point(116, 120);
            txtTenkh.Name = "txtTenkh";
            txtTenkh.Size = new Size(214, 21);
            txtTenkh.TabIndex = 31;
            // 
            // txtMakh
            // 
            txtMakh.Anchor = AnchorStyles.Top;
            txtMakh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMakh.Location = new Point(116, 83);
            txtMakh.Name = "txtMakh";
            txtMakh.Size = new Size(214, 21);
            txtMakh.TabIndex = 30;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(13, 276);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 29;
            label7.Text = "Ghi chú";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 236);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 28;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 199);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 27;
            label5.Text = "SĐT";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 159);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 26;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 120);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 25;
            label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 24;
            label2.Text = "Mã khách hàng";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(816, 450);
            Controls.Add(txtGhichu);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtDiachi);
            Controls.Add(txtTenkh);
            Controls.Add(txtMakh);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnExport);
            Controls.Add(dgvCustomer);
            Controls.Add(txtSearchCustomer);
            Controls.Add(btnSearchCustomer);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label1);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KHÁCH HÀNG";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCustomer;
        private TextBox txtSearchCustomer;
        private Button btnSearchCustomer;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnExport;
        private Button btnClear;
        private TextBox txtGhichu;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtDiachi;
        private TextBox txtTenkh;
        private TextBox txtMakh;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}