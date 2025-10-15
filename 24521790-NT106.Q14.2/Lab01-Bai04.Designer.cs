using System.Drawing;
using System.Windows.Forms;

namespace _24521790_NT106.Q14._2
{
    partial class Lab01_Bai04
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng tài nguyên
        /// </summary>
        /// <param name="disposing">true nếu muốn giải phóng tài nguyên</param>
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
        /// Thiết kế giao diện Form
        /// </summary>
        private void InitializeComponent()
        {
            txtHoTenKhachHang = new TextBox();
            rtbKetQua = new RichTextBox();
            cbChonPhim = new ComboBox();
            cbChonPhongChieu = new ComboBox();
            clbChoNgoi = new CheckedListBox();
            btnThanhToan = new Button();
            lblTen = new Label();
            lblPhim = new Label();
            lblPhong = new Label();
            lblGhe = new Label();
            SuspendLayout();
            // 
            // txtHoTenKhachHang
            // 
            txtHoTenKhachHang.Location = new Point(160, 40);
            txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            txtHoTenKhachHang.Size = new Size(200, 27);
            txtHoTenKhachHang.TabIndex = 0;
            // 
            // cbChonPhim
            // 
            cbChonPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChonPhim.Location = new Point(160, 90);
            cbChonPhim.Name = "cbChonPhim";
            cbChonPhim.Size = new Size(200, 28);
            cbChonPhim.TabIndex = 1;
            // 
            // cbChonPhongChieu
            // 
            cbChonPhongChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChonPhongChieu.Location = new Point(160, 140);
            cbChonPhongChieu.Name = "cbChonPhongChieu";
            cbChonPhongChieu.Size = new Size(200, 28);
            cbChonPhongChieu.TabIndex = 2;
            // 
            // clbChoNgoi
            // 
            clbChoNgoi.CheckOnClick = true;
            clbChoNgoi.FormattingEnabled = true;
            clbChoNgoi.Location = new Point(420, 40);
            clbChoNgoi.Name = "clbChoNgoi";
            clbChoNgoi.Size = new Size(150, 200);
            clbChoNgoi.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(260, 200);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(120, 35);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // rtbKetQua
            // 
            rtbKetQua.Location = new Point(100, 260);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.ReadOnly = true;
            rtbKetQua.Size = new Size(470, 160);
            rtbKetQua.TabIndex = 5;
            rtbKetQua.Text = "";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(40, 43);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(114, 20);
            lblTen.Text = "Họ tên khách:";
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(40, 93);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(91, 20);
            lblPhim.Text = "Chọn phim:";
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new Point(40, 143);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(106, 20);
            lblPhong.Text = "Phòng chiếu:";
            // 
            // lblGhe
            // 
            lblGhe.AutoSize = true;
            lblGhe.Location = new Point(420, 17);
            lblGhe.Name = "lblGhe";
            lblGhe.Size = new Size(79, 20);
            lblGhe.Text = "Chọn ghế:";
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(lblGhe);
            Controls.Add(lblPhong);
            Controls.Add(lblPhim);
            Controls.Add(lblTen);
            Controls.Add(rtbKetQua);
            Controls.Add(btnThanhToan);
            Controls.Add(clbChoNgoi);
            Controls.Add(cbChonPhongChieu);
            Controls.Add(cbChonPhim);
            Controls.Add(txtHoTenKhachHang);
            Name = "Lab01_Bai04";
            Text = "Phần mềm bán vé rạp phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTenKhachHang;
        private RichTextBox rtbKetQua;
        private ComboBox cbChonPhim;
        private ComboBox cbChonPhongChieu;
        private CheckedListBox clbChoNgoi;
        private Button btnThanhToan;
        private Label lblTen;
        private Label lblPhim;
        private Label lblPhong;
        private Label lblGhe;
    }
}
