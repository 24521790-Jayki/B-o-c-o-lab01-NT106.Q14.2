namespace _24521790_NT106.Q14._2
{
    partial class Lab01_Bai08
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
            label1 = new Label();
            btnThemMon = new Button();
            txtNhapMonAn = new TextBox();
            lbDanhSachMonAn = new ListBox();
            btnTimMon = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 31);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập món ăn";
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(343, 119);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(94, 29);
            btnThemMon.TabIndex = 1;
            btnThemMon.Text = "Thêm";
            btnThemMon.UseVisualStyleBackColor = true;
            // 
            // txtNhapMonAn
            // 
            txtNhapMonAn.Location = new Point(188, 31);
            txtNhapMonAn.Name = "txtNhapMonAn";
            txtNhapMonAn.Size = new Size(125, 27);
            txtNhapMonAn.TabIndex = 2;
           
            // 
            // lbDanhSachMonAn
            // 
            lbDanhSachMonAn.FormattingEnabled = true;
            lbDanhSachMonAn.Location = new Point(549, 57);
            lbDanhSachMonAn.Name = "lbDanhSachMonAn";
            lbDanhSachMonAn.Size = new Size(208, 204);
            lbDanhSachMonAn.TabIndex = 4;
            // 
            // btnTimMon
            // 
            btnTimMon.Location = new Point(113, 302);
            btnTimMon.Name = "btnTimMon";
            btnTimMon.Size = new Size(94, 29);
            btnTimMon.TabIndex = 5;
            btnTimMon.Text = "Tìm món";
            btnTimMon.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(325, 302);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(595, 302);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTimMon);
            Controls.Add(lbDanhSachMonAn);
            Controls.Add(txtNhapMonAn);
            Controls.Add(btnThemMon);
            Controls.Add(label1);
            Name = "Lab01_Bai08";
            Text = "Lab01_Bai08";
            Load += Lab01_Bai08_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnThemMon;
        private TextBox txtNhapMonAn;
        private ListBox lbDanhSachMonAn;
        private Button btnTimMon;
        private Button btnXoa;
        private Button btnThoat;
    }
}