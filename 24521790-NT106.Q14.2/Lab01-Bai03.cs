using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24521790_NT106.Q14._2
{
    public partial class Lab01_Bai03 : Form
    {
        int enterCount = 0; // biến đếm số lần Enter

        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int so;
            if (!int.TryParse(textBox1.Text, out so))  // kiểm tra nhập hợp lệ
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0–9!");
                return;
            }

            string ketQua = "";
            switch (so)
            {
                case 0: ketQua = "Không"; break;
                case 1: ketQua = "Một"; break;
                case 2: ketQua = "Hai"; break;
                case 3: ketQua = "Ba"; break;
                case 4: ketQua = "Bốn"; break;
                case 5: ketQua = "Năm"; break;
                case 6: ketQua = "Sáu"; break;
                case 7: ketQua = "Bảy"; break;
                case 8: ketQua = "Tám"; break;
                case 9: ketQua = "Chín"; break;
                default: ketQua = "Không nằm trong khoảng 0–9"; break;
            }
            textBox2.Text = ketQua;
        }

    }
}
