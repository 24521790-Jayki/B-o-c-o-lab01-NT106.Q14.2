namespace _24521790_NT106.Q14._2
{
    partial class Lab01_Bai06
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
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNhapNgay = new TextBox();
            txtNhapThang = new TextBox();
            btnXemCungHoangDao = new Button();
            txtCungHoangDao = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 39);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 102);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập tháng";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNhapNgay
            // 
            txtNhapNgay.Location = new Point(141, 36);
            txtNhapNgay.Name = "txtNhapNgay";
            txtNhapNgay.Size = new Size(125, 27);
            txtNhapNgay.TabIndex = 3;
            // 
            // txtNhapThang
            // 
            txtNhapThang.Location = new Point(141, 102);
            txtNhapThang.Name = "txtNhapThang";
            txtNhapThang.Size = new Size(125, 27);
            txtNhapThang.TabIndex = 4;
            // 
            // btnXemCungHoangDao
            // 
            btnXemCungHoangDao.Location = new Point(237, 194);
            btnXemCungHoangDao.Name = "btnXemCungHoangDao";
            btnXemCungHoangDao.Size = new Size(355, 29);
            btnXemCungHoangDao.TabIndex = 5;
            btnXemCungHoangDao.Text = "Nhấn vào để biết cung hoàn đạo của bạn là gì";
            btnXemCungHoangDao.UseVisualStyleBackColor = true;
            btnXemCungHoangDao.Click += btnXemCungHoangDao_Click_1;
            // 
            // txtCungHoangDao
            // 
            txtCungHoangDao.Location = new Point(346, 282);
            txtCungHoangDao.Name = "txtCungHoangDao";
            txtCungHoangDao.Size = new Size(125, 27);
            txtCungHoangDao.TabIndex = 6;
            // 
            // Lab01_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCungHoangDao);
            Controls.Add(btnXemCungHoangDao);
            Controls.Add(txtNhapThang);
            Controls.Add(txtNhapNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai06";
            Text = "Lab01_Bai06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtNhapNgay;
        private TextBox txtNhapThang;
        private Button btnXemCungHoangDao;
        private TextBox txtCungHoangDao;
    }
}