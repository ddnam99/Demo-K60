using System;
using System.Threading;
using System.Windows.Forms;

namespace Bài_4_Thread
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

        private void HienThiCacSoChinhPhuong()
        {
            int n = int.Parse(TB_So.Text);

            for (int i = 1; i <= n; i++)
                if (KTra_SCP(i)) RTB_SCP.Text += i + " ";
        }

        private void BT_SCP_Click(object sender, EventArgs e)
        {
            RTB_SCP.Text = "";

            Thread T = new Thread(new ThreadStart(HienThiCacSoChinhPhuong));

            T.Start();
        }

        private void BT_SNT_Click(object sender, EventArgs e)
        {
            RTB_SNT.Text = "";

            new Thread(() =>
            {
                int n = int.Parse(TB_So.Text);

                for (int i = 1; i <= n; i++)
                    if (KTra_SNT(i)) RTB_SNT.Text += i + " ";
            }).Start();
        }

        private void BT_SHC_Click(object sender, EventArgs e)
        {
            RTB_SHC.Text = "";

            new Thread(() =>
            {
                int n = int.Parse(TB_So.Text);

                for (int i = 1; i <= n; i++)
                    if (KTra_SHC(i)) RTB_SHC.Text += i + " ";
            }).Start();
        }

        private void BT_SDX_Click(object sender, EventArgs e)
        {
            RTB_SDX.Text = "";

            new Thread(() =>
            {
                int n = int.Parse(TB_So.Text);

                for (int i = 1; i <= n; i++)
                    if (KTra_SDX(i)) RTB_SDX.Text += i + " ";
            }).Start();
        }

        private void BT_SAS_Click(object sender, EventArgs e)
        {
            RTB_SAS.Text = "";

            new Thread(() =>
            {
                int n = int.Parse(TB_So.Text);

                for (int i = 1; i <= n; i++)
                    if (KTra_SAS(i)) RTB_SAS.Text += i + " ";
            }).Start();
        }
    }
}