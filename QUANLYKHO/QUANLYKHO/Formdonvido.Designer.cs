namespace QUANLYKHO
{
    partial class Formdonvido
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textmadvd = new TextBox();
            label2 = new Label();
            texttendvd = new TextBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(155, 30);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(246, 312);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(448, 30);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Mã đơn vị do :";
            label1.Click += label1_Click;
            // 
            // textmadvd
            // 
            textmadvd.Anchor = AnchorStyles.Top;
            textmadvd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textmadvd.Location = new Point(559, 30);
            textmadvd.Margin = new Padding(3, 2, 3, 2);
            textmadvd.Name = "textmadvd";
            textmadvd.Size = new Size(117, 21);
            textmadvd.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(445, 69);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Tên đơn vị đo :";
            // 
            // texttendvd
            // 
            texttendvd.Anchor = AnchorStyles.Top;
            texttendvd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            texttendvd.Location = new Point(559, 69);
            texttendvd.Margin = new Padding(3, 2, 3, 2);
            texttendvd.Name = "texttendvd";
            texttendvd.Size = new Size(117, 21);
            texttendvd.TabIndex = 6;
            // 
            // btn_them
            // 
            btn_them.Anchor = AnchorStyles.Top;
            btn_them.BackColor = Color.Green;
            btn_them.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_them.ForeColor = Color.White;
            btn_them.Location = new Point(513, 149);
            btn_them.Margin = new Padding(3, 2, 3, 2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(104, 33);
            btn_them.TabIndex = 7;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Anchor = AnchorStyles.Top;
            btn_sua.BackColor = Color.Green;
            btn_sua.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sua.ForeColor = Color.White;
            btn_sua.Location = new Point(513, 208);
            btn_sua.Margin = new Padding(3, 2, 3, 2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(104, 33);
            btn_sua.TabIndex = 8;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Anchor = AnchorStyles.Top;
            btn_xoa.BackColor = Color.LightCoral;
            btn_xoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoa.ForeColor = Color.White;
            btn_xoa.Location = new Point(513, 267);
            btn_xoa.Margin = new Padding(3, 2, 3, 2);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(104, 33);
            btn_xoa.TabIndex = 9;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // Formdonvido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(826, 406);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(texttendvd);
            Controls.Add(label2);
            Controls.Add(textmadvd);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Formdonvido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formdvd";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textmadvd;
        private Label label2;
        private TextBox texttendvd;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
    }
}