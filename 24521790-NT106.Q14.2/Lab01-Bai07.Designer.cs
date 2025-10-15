namespace _24521790_NT106.Q14._2
{
    partial class Lab01_Bai07
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
            txtInput = new TextBox();
            rtbKetQua = new RichTextBox();
            btnPhanTich = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(60, 24);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += textBox1_TextChanged;
            // 
            // rtbKetQua
            // 
            rtbKetQua.Location = new Point(236, 86);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.Size = new Size(332, 325);
            rtbKetQua.TabIndex = 1;
            rtbKetQua.Text = "";
            // 
            // btnPhanTich
            // 
            btnPhanTich.Location = new Point(306, 23);
            btnPhanTich.Name = "btnPhanTich";
            btnPhanTich.Size = new Size(185, 29);
            btnPhanTich.TabIndex = 2;
            btnPhanTich.Text = "Kết quả hoc tập";
            btnPhanTich.UseVisualStyleBackColor = true;
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPhanTich);
            Controls.Add(rtbKetQua);
            Controls.Add(txtInput);
            Name = "Lab01_Bai07";
            Text = "Lab01_Bai07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private RichTextBox rtbKetQua;
        private Button btnPhanTich;
    }
}