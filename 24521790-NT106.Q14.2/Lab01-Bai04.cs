using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _24521790_NT106.Q14._2
{
    public partial class Lab01_Bai04 : Form
    {
        // Dữ liệu phim: tên phim -> (giá chuẩn, danh sách phòng chiếu)
        private Dictionary<string, (int GiaChuan, List<int> PhongChieu)> danhSachPhim =
            new Dictionary<string, (int GiaChuan, List<int>)>
            {
                { "Đào, phở và piano", (45000, new List<int>{1, 2, 3}) },
                { "Mai", (100000, new List<int>{2, 3}) },
                { "Gặp lại chị bầu", (70000, new List<int>{1}) },
                { "Tarot", (90000, new List<int>{3}) }
            };

        // Danh sách ghế đã bán
        private HashSet<string> gheDaBan = new HashSet<string>();

        // Phân loại ghế
        private List<string> veVot = new List<string> { "A1", "A5", "C1", "C5" };
        private List<string> veThuong = new List<string> { "A2", "A3", "A4", "C2", "C3", "C4" };
        private List<string> veVIP = new List<string> { "B2", "B3", "B4" };

        public Lab01_Bai04()
        {
            InitializeComponent();
            NapDuLieu();
        }

        /// <summary>
        /// Nạp dữ liệu khởi tạo cho ComboBox phim và phòng chiếu
        /// </summary>
        private void NapDuLieu()
        {
            cbChonPhim.Items.AddRange(danhSachPhim.Keys.ToArray());
            cbChonPhongChieu.Items.AddRange(new string[] { "1", "2", "3" });

            // Nạp ghế
            foreach (var hang in new[] { "A", "B", "C" })
                foreach (var so in Enumerable.Range(1, 5))
                    clbChoNgoi.Items.Add($"{hang}{so}");
        }

        /// <summary>
        /// Sự kiện khi nhấn nút "Thanh toán"
        /// </summary>
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string tenKhach = txtHoTenKhachHang.Text.Trim();
            string phim = cbChonPhim.SelectedItem?.ToString();
            string phong = cbChonPhongChieu.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tenKhach))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phim == null)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phong == null)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int phongInt = int.Parse(phong);
            var (giaChuan, dsPhongHopLe) = danhSachPhim[phim];

            // Kiểm tra phòng chiếu hợp lệ cho phim
            if (!dsPhongHopLe.Contains(phongInt))
            {
                MessageBox.Show($"Phim '{phim}' không chiếu tại phòng {phong}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy danh sách ghế được chọn
            var gheDaChon = clbChoNgoi.CheckedItems.Cast<string>().ToList();
            if (gheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 chỗ ngồi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gheDaChon.Count > 2)
            {
                MessageBox.Show("Không thể chọn nhiều hơn 2 ghế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ghế đã bán chưa
            foreach (var ghe in gheDaChon)
            {
                if (gheDaBan.Contains($"{phim}-{phong}-{ghe}"))
                {
                    MessageBox.Show($"Ghế {ghe} đã được mua trước đó!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Tính tổng tiền
            double tongTien = 0;
            foreach (var ghe in gheDaChon)
            {
                if (veVot.Contains(ghe))
                    tongTien += giaChuan / 4.0;
                else if (veThuong.Contains(ghe))
                    tongTien += giaChuan;
                else if (veVIP.Contains(ghe))
                    tongTien += giaChuan * 2;
            }

            // Đánh dấu ghế đã bán
            foreach (var ghe in gheDaChon)
                gheDaBan.Add($"{phim}-{phong}-{ghe}");

            // Xuất kết quả
            string ketQua =
                $"👤 Khách hàng: {tenKhach}\n" +
                $"🎬 Phim: {phim}\n" +
                $"🏢 Phòng chiếu: {phong}\n" +
                $"💺 Ghế: {string.Join(", ", gheDaChon)}\n" +
                $"💰 Tổng tiền: {tongTien:N0} đ";

            rtbKetQua.Text = ketQua;

            MessageBox.Show(ketQua, "Thông tin vé phim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Bỏ chọn ghế sau khi thanh toán
            for (int i = 0; i < clbChoNgoi.Items.Count; i++)
                clbChoNgoi.SetItemChecked(i, false);
        }
    }
}
