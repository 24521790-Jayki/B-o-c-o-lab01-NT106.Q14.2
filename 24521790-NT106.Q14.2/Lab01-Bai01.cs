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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ 2 số!",
                                "Lỗi hệ thống",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            bool check1 = int.TryParse(textBox1.Text, out int so1);
            bool check2 = int.TryParse(textBox2.Text, out int so2);
            if (!check1 || !check2)
            {
                MessageBox.Show("Cả hai ô phải nhập số nguyên hợp lệ!",
                                "Lỗi định dạng",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            int tong = so1 + so2;
            textBox3.Text = tong.ToString();
        }
    }
}
