namespace QUANLYKHO
{
    partial class Formvattu
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cbTKT = new ComboBox();
            txtTK = new TextBox();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            txtMAVT = new TextBox();
            label5 = new Label();
            txtGC = new TextBox();
            txtMNCC = new TextBox();
            label4 = new Label();
            label7 = new Label();
            txtMDVT = new TextBox();
            label3 = new Label();
            txtTVT = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbTKT
            // 
            cbTKT.Anchor = AnchorStyles.Top;
            cbTKT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTKT.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbTKT.FormattingEnabled = true;
            cbTKT.Items.AddRange(new object[] { "Tên vật tư", "Mã vật tư", "Mã đơn vị tính", "Nhà cung cấp", "Ghi chú" });
            cbTKT.Location = new Point(653, 44);
            cbTKT.Margin = new Padding(3, 4, 3, 4);
            cbTKT.Name = "cbTKT";
            cbTKT.Size = new Size(135, 28);
            cbTKT.TabIndex = 29;
            // 
            // txtTK
            // 
            txtTK.Anchor = AnchorStyles.Top;
            txtTK.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTK.Location = new Point(572, 14);
            txtTK.Margin = new Padding(3, 4, 3, 4);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(216, 24);
            txtTK.TabIndex = 28;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.BackColor = Color.Green;
            btnSua.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(472, 72);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 40);
            btnSua.TabIndex = 26;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top;
            btnTimKiem.BackColor = Color.Green;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(572, 44);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 40);
            btnTimKiem.TabIndex = 24;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Top;
            btnCapNhat.BackColor = Color.Green;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(686, 130);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(102, 40);
            btnCapNhat.TabIndex = 23;
            btnCapNhat.Text = "Đặt lại";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click_1;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.BackColor = Color.Green;
            btnThem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(472, 18);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 40);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.BackColor = Color.LightCoral;
            btnXoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(472, 122);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 40);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 192);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(548, 235);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtMAVT
            // 
            txtMAVT.Anchor = AnchorStyles.Top;
            txtMAVT.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMAVT.Location = new Point(104, 14);
            txtMAVT.Margin = new Padding(3, 4, 3, 4);
            txtMAVT.Name = "txtMAVT";
            txtMAVT.Size = new Size(100, 24);
            txtMAVT.TabIndex = 18;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(224, 14);
            label5.Name = "label5";
            label5.Size = new Size(118, 18);
            label5.TabIndex = 12;
            label5.Text = "Tên Sản Phẩm";
            // 
            // txtGC
            // 
            txtGC.Anchor = AnchorStyles.Top;
            txtGC.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGC.Location = new Point(104, 138);
            txtGC.Margin = new Padding(3, 4, 3, 4);
            txtGC.Name = "txtGC";
            txtGC.Size = new Size(325, 24);
            txtGC.TabIndex = 17;
            // 
            // txtMNCC
            // 
            txtMNCC.Anchor = AnchorStyles.Top;
            txtMNCC.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMNCC.Location = new Point(366, 77);
            txtMNCC.Margin = new Padding(3, 4, 3, 4);
            txtMNCC.Name = "txtMNCC";
            txtMNCC.Size = new Size(100, 24);
            txtMNCC.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 80);
            label4.Name = "label4";
            label4.Size = new Size(113, 18);
            label4.TabIndex = 11;
            label4.Text = "Mã đơn vị tính";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 137);
            label7.Name = "label7";
            label7.Size = new Size(66, 18);
            label7.TabIndex = 10;
            label7.Text = "Ghi chú";
            // 
            // txtMDVT
            // 
            txtMDVT.Anchor = AnchorStyles.Top;
            txtMDVT.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMDVT.Location = new Point(104, 77);
            txtMDVT.Margin = new Padding(3, 4, 3, 4);
            txtMDVT.Name = "txtMDVT";
            txtMDVT.Size = new Size(100, 24);
            txtMDVT.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(224, 80);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 9;
            label3.Text = "Mã nhà cung cấp";
            // 
            // txtTVT
            // 
            txtTVT.Anchor = AnchorStyles.Top;
            txtTVT.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTVT.Location = new Point(366, 18);
            txtTVT.Margin = new Padding(3, 4, 3, 4);
            txtTVT.Name = "txtTVT";
            txtTVT.Size = new Size(100, 24);
            txtTVT.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 18);
            label2.Name = "label2";
            label2.Size = new Size(113, 18);
            label2.TabIndex = 8;
            label2.Text = "Mã Sản Phẩm";
            // 
            // Formvattu
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 445);
            Controls.Add(cbTKT);
            Controls.Add(txtTK);
            Controls.Add(btnSua);
            Controls.Add(btnTimKiem);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(dataGridView1);
            Controls.Add(txtMAVT);
            Controls.Add(label5);
            Controls.Add(txtGC);
            Controls.Add(txtMNCC);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtMDVT);
            Controls.Add(label3);
            Controls.Add(txtTVT);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Formvattu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formvt";
            Load += Formvattu_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTKT;
        private TextBox txtTK;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnCapNhat;
        private Button btnThem;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private TextBox txtMAVT;
        private Label label5;
        private TextBox txtGC;
        private TextBox txtMNCC;
        private Label label4;
        private Label label7;
        private TextBox txtMDVT;
        private Label label3;
        private TextBox txtTVT;
        private Label label2;
    }
}