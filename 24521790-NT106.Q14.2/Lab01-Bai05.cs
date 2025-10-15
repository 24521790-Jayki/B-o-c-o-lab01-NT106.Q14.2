using System;
using System.Numerics;
using System.Windows.Forms;

namespace _24521790_NT106.Q14._2
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
            CaiDatGiaoDien();
        }

        private void CaiDatGiaoDien()
        {
            cboChucNang.Items.Add("(A - B)!  —  Giai thừa của hiệu A và B");
            cboChucNang.Items.Add("Tổng S = A^1 + A^2 + ... + A^B");
            cboChucNang.SelectedIndex = 0;

            btnTinhToan.Click += BtnTinhToan_Click;
            btnDelete.Click += BtnXoa_Click;
            btnOut.Click += BtnThoat_Click;
        }

        private void BtnTinhToan_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu(txtA.Text, txtB.Text, out int giaTriA, out int giaTriB))
                return;

            string luaChon = cboChucNang.SelectedItem.ToString();
            BigInteger ketQua;

            if (luaChon.StartsWith("(A - B)!"))
            {
                int hieu = giaTriA - giaTriB;
                if (hieu < 0)
                {
                    MessageBox.Show("Không thể tính giai thừa của số âm! Vui lòng nhập A ≥ B.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ketQua = TinhGiaiThua(hieu);
                txtKetQua.Text = $"{hieu}! = {ketQua}";
            }
            else
            {
                if (giaTriB < 1)
                {
                    MessageBox.Show("Giá trị B phải lớn hơn hoặc bằng 1 để tính tổng S.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ketQua = TinhTongLuyThua(giaTriA, giaTriB);
                txtKetQua.Text = $"S = {ketQua}";
            }
        }

        private bool KiemTraNhapLieu(string chuoiA, string chuoiB, out int giaTriA, out int giaTriB)
        {
            giaTriA = 0;
            giaTriB = 0;

            if (string.IsNullOrWhiteSpace(chuoiA) || string.IsNullOrWhiteSpace(chuoiB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giá trị cho A và B.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool hopLeA = int.TryParse(chuoiA, out giaTriA);
            bool hopLeB = int.TryParse(chuoiB, out giaTriB);

            if (!hopLeA || !hopLeB)
            {
                MessageBox.Show("Giá trị A và B phải là số nguyên hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Math.Abs(giaTriA) > 1000 || Math.Abs(giaTriB) > 1000)
            {
                MessageBox.Show("Vui lòng nhập A và B trong khoảng [-1000, 1000].", "Giá trị quá lớn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private BigInteger TinhGiaiThua(int n)
        {
            BigInteger ketQua = 1;
            for (int i = 2; i <= n; i++)
                ketQua *= i;
            return ketQua;
        }

        private BigInteger TinhTongLuyThua(int coSo, int muToiDa)
        {
            BigInteger tong = 0;
            for (int i = 1; i <= muToiDa; i++)
                tong += BigInteger.Pow(coSo, i);
            return tong;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            cboChucNang.SelectedIndex = 0;
            txtA.Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
