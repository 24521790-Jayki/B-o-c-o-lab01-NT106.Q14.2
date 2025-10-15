using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _24521790_NT106.Q14._2
{
    public partial class Lab01_Bai08 : Form
    {
        // Danh sách món ăn mặc định
        private List<string> danhSachMonAn = new List<string>
        {
            "Cơm tấm",
            "Phở bò",
            "Bún chả",
            "Bánh mì",
            "Gà rán",
            "Hủ tiếu"
        };

        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void Lab01_Bai08_Load(object sender, EventArgs e)
        {
            // Hiển thị danh sách món ăn ban đầu
            CapNhatDanhSachMonAn();

            // Gắn các sự kiện cho nút
            btnThemMon.Click += BtnThemMon_Click;
            btnTimMon.Click += BtnTimMon_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThoat.Click += BtnThoat_Click;
        }

        /// <summary>
        /// Cập nhật ListBox hiển thị danh sách món ăn.
        /// </summary>
        private void CapNhatDanhSachMonAn()
        {
            lbDanhSachMonAn.Items.Clear();
            foreach (var mon in danhSachMonAn)
            {
                lbDanhSachMonAn.Items.Add(mon);
            }
        }

        /// <summary>
        /// Xử lý sự kiện khi bấm nút "Thêm".
        /// </summary>
        private void BtnThemMon_Click(object sender, EventArgs e)
        {
            string monMoi = txtNhapMonAn.Text.Trim();

            if (string.IsNullOrEmpty(monMoi))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn trước khi thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            danhSachMonAn.Add(monMoi);
            CapNhatDanhSachMonAn();
            txtNhapMonAn.Clear();
            MessageBox.Show($"Đã thêm món \"{monMoi}\" vào danh sách!", "Thông báo");
        }

        /// <summary>
        /// Xử lý sự kiện khi bấm nút "Tìm món".
        /// </summary>
        private void BtnTimMon_Click(object sender, EventArgs e)
        {
            if (danhSachMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random rnd = new Random();
            int index = rnd.Next(danhSachMonAn.Count);
            string monAnHomNay = danhSachMonAn[index];

            MessageBox.Show("🍽 Món ăn hôm nay là: " + monAnHomNay, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Xử lý sự kiện khi bấm nút "Xóa".
        /// </summary>
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lbDanhSachMonAn.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string monXoa = lbDanhSachMonAn.SelectedItem.ToString();
            danhSachMonAn.Remove(monXoa);
            CapNhatDanhSachMonAn();
            MessageBox.Show($"Đã xóa món \"{monXoa}\" khỏi danh sách!", "Thông báo");
        }

        /// <summary>
        /// Xử lý sự kiện khi bấm nút "Thoát".
        /// </summary>
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
