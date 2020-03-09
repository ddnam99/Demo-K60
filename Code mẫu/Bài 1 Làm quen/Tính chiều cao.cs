using System;
using System.Windows.Forms;

namespace Bài_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Tinh_Click(object sender, EventArgs e)
        {
            double ChieuCao = Convert.ToDouble(TB_ChieuCao.Text);

            MessageBox.Show("Chiều cao của bạn là: " + ChieuCao + "cm", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}