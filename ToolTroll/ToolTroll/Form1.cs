using System;
using System.Windows.Forms;

namespace ToolTroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Tinh_Click(object sender, EventArgs e)
        {
            double ChieuCao = double.Parse(TB_Nhap.Text);
            
            // Hiển thị kết quả tính chiều cao và kiểm tra xem người dùng chọn nút Yes hay No
        batDau: if (MessageBox.Show("Chiều cao của bạn là: " + (ChieuCao + 20) + "cm\nBạn có muốn biết tại sao không?", "Kết quả", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Thử sờ lên đầu bạn đi =))");

                MessageBox.Show("Có mấy cái \"sừng\" vậy?");

                MessageBox.Show("====))))))");
            }
            else
            {
                MessageBox.Show("Muốn biết thì đừng có dối lòng :V");

                goto batDau;
            }
        }
    }
}