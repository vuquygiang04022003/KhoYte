namespace QUANLYKHO
{
    partial class frmNhaCungCap
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
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearchName = new Button();
            txtSearchName = new TextBox();
            dgvSupplier = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMancc = new TextBox();
            txtTenncc = new TextBox();
            txtSDT = new TextBox();
            txtDiachi = new TextBox();
            txtEmail = new TextBox();
            txtNHT = new TextBox();
            btnClear = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "NHÀ CUNG CẤP";
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
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click_1;
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
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(174, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 28);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnSearchName
            // 
            btnSearchName.Anchor = AnchorStyles.Top;
            btnSearchName.BackColor = Color.Green;
            btnSearchName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchName.ForeColor = Color.White;
            btnSearchName.Location = new Point(703, 42);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(101, 27);
            btnSearchName.TabIndex = 4;
            btnSearchName.Text = "Tìm kiếm";
            btnSearchName.UseVisualStyleBackColor = false;
            btnSearchName.Click += btnSearchName_Click_1;
            // 
            // txtSearchName
            // 
            txtSearchName.Anchor = AnchorStyles.Top;
            txtSearchName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchName.Location = new Point(490, 42);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(207, 26);
            txtSearchName.TabIndex = 5;
            txtSearchName.KeyPress += txtSearchName_KeyPress_1;
            // 
            // dgvSupplier
            // 
            dgvSupplier.Anchor = AnchorStyles.Top;
            dgvSupplier.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(367, 79);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvSupplier.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvSupplier.RowTemplate.Height = 25;
            dgvSupplier.Size = new Size(437, 330);
            dgvSupplier.TabIndex = 6;
            dgvSupplier.CellClick += dgvSupplier_CellClick_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 82);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 8;
            label2.Text = "Mã nhà cung cấp";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 119);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 9;
            label3.Text = "Tên nhà cung cấp";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 158);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 10;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 198);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 11;
            label5.Text = "SĐT";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 235);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 272);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 13;
            label7.Text = "Ngày hợp tác";
            // 
            // txtMancc
            // 
            txtMancc.Anchor = AnchorStyles.Top;
            txtMancc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMancc.Location = new Point(130, 78);
            txtMancc.Name = "txtMancc";
            txtMancc.Size = new Size(214, 21);
            txtMancc.TabIndex = 14;
            // 
            // txtTenncc
            // 
            txtTenncc.Anchor = AnchorStyles.Top;
            txtTenncc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenncc.Location = new Point(130, 115);
            txtTenncc.Name = "txtTenncc";
            txtTenncc.Size = new Size(214, 21);
            txtTenncc.TabIndex = 15;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top;
            txtSDT.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSDT.Location = new Point(130, 194);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(214, 21);
            txtSDT.TabIndex = 17;
            // 
            // txtDiachi
            // 
            txtDiachi.Anchor = AnchorStyles.Top;
            txtDiachi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiachi.Location = new Point(130, 154);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(214, 21);
            txtDiachi.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(130, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 21);
            txtEmail.TabIndex = 18;
            // 
            // txtNHT
            // 
            txtNHT.Anchor = AnchorStyles.Top;
            txtNHT.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNHT.Location = new Point(130, 268);
            txtNHT.Name = "txtNHT";
            txtNHT.Size = new Size(214, 21);
            txtNHT.TabIndex = 19;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top;
            btnClear.BackColor = Color.Green;
            btnClear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(256, 415);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 28);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top;
            btnExport.BackColor = Color.Green;
            btnExport.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(703, 415);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(101, 28);
            btnExport.TabIndex = 21;
            btnExport.Text = "Xuất file excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click_1;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(816, 450);
            Controls.Add(btnExport);
            Controls.Add(btnClear);
            Controls.Add(txtNHT);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtDiachi);
            Controls.Add(txtTenncc);
            Controls.Add(txtMancc);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvSupplier);
            Controls.Add(txtSearchName);
            Controls.Add(btnSearchName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label1);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NHÀ CUNG CẤP";
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearchName;
        private TextBox txtSearchName;
        private DataGridView dgvSupplier;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMancc;
        private TextBox txtTenncc;
        private TextBox txtSDT;
        private TextBox txtDiachi;
        private TextBox txtEmail;
        private TextBox txtNHT;
        private Button btnClear;
        private Button btnExport;
    }
}