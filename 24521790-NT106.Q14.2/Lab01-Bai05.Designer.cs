namespace _24521790_NT106.Q14._2
{
    partial class Lab01_Bai05
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
            components = new System.ComponentModel.Container();
            lbA = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtA = new TextBox();
            txtB = new TextBox();
            lbB = new Label();
            btnTinhToan = new Button();
            btnDelete = new Button();
            btnOut = new Button();
            cboChucNang = new ComboBox();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.Location = new Point(86, 30);
            lbA.Name = "lbA";
            lbA.Size = new Size(59, 20);
            lbA.TabIndex = 0;
            lbA.Text = "Nhập A";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtA
            // 
            txtA.Location = new Point(160, 34);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(569, 30);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 3;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.Location = new Point(479, 37);
            lbB.Name = "lbB";
            lbB.Size = new Size(58, 20);
            lbB.TabIndex = 4;
            lbB.Text = "Nhập B";
            // 
            // btnTinhToan
            // 
            btnTinhToan.Location = new Point(108, 292);
            btnTinhToan.Name = "btnTinhToan";
            btnTinhToan.Size = new Size(141, 29);
            btnTinhToan.TabIndex = 5;
            btnTinhToan.Text = "Tính các giá trị";
            btnTinhToan.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(345, 292);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(600, 292);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(94, 29);
            btnOut.TabIndex = 7;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            // 
            // cboChucNang
            // 
            cboChucNang.FormattingEnabled = true;
            cboChucNang.Location = new Point(270, 158);
            cboChucNang.Name = "cboChucNang";
            cboChucNang.Size = new Size(267, 28);
            cboChucNang.TabIndex = 8;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(232, 375);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(327, 27);
            txtKetQua.TabIndex = 9;
            txtKetQua.TextChanged += textBox1_TextChanged;
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKetQua);
            Controls.Add(cboChucNang);
            Controls.Add(btnOut);
            Controls.Add(btnDelete);
            Controls.Add(btnTinhToan);
            Controls.Add(lbB);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lbA);
            Name = "Lab01_Bai05";
            Text = "Lab01_Bai05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbA;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtA;
        private TextBox txtB;
        private Label lbB;
        private Button btnTinhToan;
        private Button btnDelete;
        private Button btnOut;
        private ComboBox cboChucNang;
        private TextBox txtKetQua;
    }
}