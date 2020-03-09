using System;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Các hàm kiểm tra số

        private bool KTra_SCP(int n)
        {
            return Math.Sqrt(n) == (int)Math.Sqrt(n);
        }

        private bool KTra_SNT(int n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;

            return (n >= 2);
        }

        private bool KTra_SHC(int n)
        {
            int Tong = 0;

            for (int i = 1; i * 2 <= n; i++)
                if (n % i == 0) Tong += i;

            return (Tong == n);
        }

        private bool KTra_SDX(int n)
        {
            int SoDaoNguoc = 0;

            for (int i = n; i != 0; i /= 10)
                SoDaoNguoc = (SoDaoNguoc * 10) + (i % 10);

            return (SoDaoNguoc == n);
        }

        private bool KTra_SAS(int n)
        {
            int k = n.ToString().Length;
            int Tong = 0;

            for (int i = n; i != 0; i /= 10)
                Tong += (int)Math.Pow(i % 10, k);

            return (Tong == n);
        }

        #endregion

        private void BT_SCP_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu người dùng nhập vào
            int n = int.Parse(TB_So.Text);

            //Sử dụng các hàm kiểm tra và hiển thị kết quả ra màn hình
            if (KTra_SCP(n)) LB_KQ.Text = n + " là số chính phương !";
            else LB_KQ.Text = n + " không phải số chính phương !";
        }

        private void BT_SNT_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TB_So.Text);

            if (KTra_SNT(n)) LB_KQ.Text = n + " là số nguyên tố !";
            else LB_KQ.Text = n + " không phải số nguyên tố !";
        }

        private void BT_SHC_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TB_So.Text);

            if (KTra_SHC(n)) LB_KQ.Text = n + " là số hoàn chỉnh !";
            else LB_KQ.Text = n + " không phải số hoàn chỉnh !";
        }

        private void BT_SDX_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TB_So.Text);

            if (KTra_SDX(n)) LB_KQ.Text = n + " là số đối xứng !";
            else LB_KQ.Text = n + " không phải số đối xứng !";
        }

        private void BT_SAS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TB_So.Text);

            if (KTra_SAS(n)) LB_KQ.Text = n + " là số Amstrong !";
            else LB_KQ.Text = n + " không phải số Amstrong !";
        }
    }
}