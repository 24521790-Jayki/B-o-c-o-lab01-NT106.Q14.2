using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace _24521790_NT106.Q14._2
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
            btnPhanTich.Click += BtnPhanTich_Click;
        }

        /// <summary>
        /// Xử lý khi nhấn nút "Kết quả học tập"
        /// </summary>
        private void BtnPhanTich_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            // 🧩 Kiểm tra rỗng
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🧩 Tách các phần tử bằng dấu phẩy
            string[] parts = input.Split(',');

            if (parts.Length < 2)
            {
                MessageBox.Show("❌ Sai format! Phải có tên và ít nhất 1 điểm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hoTen = parts[0].Trim();
            List<double> diem = new List<double>();

            // 🧩 Kiểm tra và đọc điểm
            bool hopLe = true;
            for (int i = 1; i < parts.Length; i++)
            {
                string s = parts[i].Trim();
                double d;
                if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out d))
                {
                    // Điểm phải từ 0 đến 10
                    if (d < 0 || d > 10)
                    {
                        hopLe = false;
                        break;
                    }
                    diem.Add(d);
                }
                else
                {
                    hopLe = false;
                    break;
                }
            }

            if (!hopLe)
            {
                MessageBox.Show("❌ Sai format điểm! Vui lòng nhập các số từ 0 đến 10, cách nhau bởi dấu phẩy.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🧩 Hiển thị tên sinh viên
            rtbKetQua.Clear();
            rtbKetQua.AppendText($"Họ và tên: {hoTen}\n");
            rtbKetQua.AppendText("------------------------------\n");

            // 🧩 In danh sách điểm
            for (int i = 0; i < diem.Count; i++)
            {
                rtbKetQua.AppendText($"Môn {i + 1}: {diem[i]}\n");
            }

            // 🧩 Tính điểm trung bình
            double dtb = diem.Average();

            // 🧩 Tìm điểm cao nhất & thấp nhất
            double max = diem.Max();
            double min = diem.Min();

            // 🧩 Tính số môn đậu / rớt
            int dau = diem.Count(d => d >= 5);
            int rot = diem.Count - dau;

            // 🧩 Xếp loại
            string xepLoai = XepLoaiSinhVien(diem, dtb);

            // 🧩 In kết quả
            rtbKetQua.AppendText("------------------------------\n");
            rtbKetQua.AppendText($"Điểm trung bình: {dtb:F2}\n");
            rtbKetQua.AppendText($"Điểm cao nhất: {max}\n");
            rtbKetQua.AppendText($"Điểm thấp nhất: {min}\n");
            rtbKetQua.AppendText($"Số môn đậu: {dau}\n");
            rtbKetQua.AppendText($"Số môn không đậu: {rot}\n");
            rtbKetQua.AppendText($"Xếp loại: {xepLoai}\n");

            MessageBox.Show("✅ Đã nhập đúng format và xử lý thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Hàm xếp loại sinh viên theo quy tắc
        /// </summary>
        private string XepLoaiSinhVien(List<double> dsDiem, double dtb)
        {
            if (dtb >= 8 && dsDiem.All(d => d >= 6.5))
                return "Giỏi";
            else if (dtb >= 6.5 && dsDiem.All(d => d >= 5))
                return "Khá";
            else if (dtb >= 5 && dsDiem.All(d => d >= 3.5))
                return "Trung Bình";
            else if (dtb >= 3.5 && dsDiem.All(d => d >= 2))
                return "Yếu";
            else
                return "Kém";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Không làm gì cả
        }

        private void btnPhanTich_Click_1(object sender, EventArgs e)
        {

        }
    }
}
