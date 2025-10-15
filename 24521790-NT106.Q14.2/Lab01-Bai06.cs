using System;
using System.Windows.Forms;

namespace _24521790_NT106.Q14._2
{
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
            btnXemCungHoangDao.Click += BtnXemCungHoangDao_Click;
        }

        private void BtnXemCungHoangDao_Click(object sender, EventArgs e)
        {
            int ngay, thang;

            // 🧩 Kiểm tra dữ liệu nhập vào
            if (!int.TryParse(txtNhapNgay.Text, out ngay) || !int.TryParse(txtNhapThang.Text, out thang))
            {
                MessageBox.Show("⚠️ Vui lòng nhập số hợp lệ cho ngày và tháng!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🧩 Kiểm tra giá trị hợp lệ
            if (thang < 1 || thang > 12 || ngay < 1 || ngay > 31)
            {
                MessageBox.Show("❌ Ngày hoặc tháng không hợp lệ!", "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🧩 Lấy tên cung hoàng đạo
            string cung = LayCungHoangDao(ngay, thang);

            // 🧩 Hiển thị kết quả
            txtCungHoangDao.Text = cung;
            MessageBox.Show($"🌟 Cung hoàng đạo của bạn là: {cung}!", "Kết quả",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 📘 Hàm xác định cung hoàng đạo
        private string LayCungHoangDao(int ngay, int thang)
        {
            if ((ngay >= 21 && thang == 3) || (ngay <= 20 && thang == 4))
                return "Bạch Dương ♈";
            else if ((ngay >= 21 && thang == 4) || (ngay <= 21 && thang == 5))
                return "Kim Ngưu ♉";
            else if ((ngay >= 22 && thang == 5) || (ngay <= 21 && thang == 6))
                return "Song Tử ♊";
            else if ((ngay >= 22 && thang == 6) || (ngay <= 22 && thang == 7))
                return "Cự Giải ♋";
            else if ((ngay >= 23 && thang == 7) || (ngay <= 22 && thang == 8))
                return "Sư Tử ♌";
            else if ((ngay >= 23 && thang == 8) || (ngay <= 23 && thang == 9))
                return "Xử Nữ ♍";
            else if ((ngay >= 24 && thang == 9) || (ngay <= 23 && thang == 10))
                return "Thiên Bình ♎";
            else if ((ngay >= 24 && thang == 10) || (ngay <= 22 && thang == 11))
                return "Thần Nông ♏";
            else if ((ngay >= 23 && thang == 11) || (ngay <= 21 && thang == 12))
                return "Nhân Mã ♐";
            else if ((ngay >= 22 && thang == 12) || (ngay <= 20 && thang == 1))
                return "Ma Kết ♑";
            else if ((ngay >= 21 && thang == 1) || (ngay <= 19 && thang == 2))
                return "Bảo Bình ♒";
            else if ((ngay >= 20 && thang == 2) || (ngay <= 20 && thang == 3))
                return "Song Ngư ♓";
            else
                return "Không xác định";
        }

        private void btnXemCungHoangDao_Click_1(object sender, EventArgs e)
        {

        }
    }
}
