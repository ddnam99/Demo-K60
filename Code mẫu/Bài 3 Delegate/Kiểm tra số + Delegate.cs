using System;
using System.Windows.Forms;

namespace Bài_3_Delegate
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

        //Khai báo delegate
        delegate bool KTra_So(int n);
        //Khai báo đối tượng của delegate
        private KTra_So KTra;

        private void BT_KT_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TB_So.Text);

            if (KTra(n)) LB_KQ.Text = n + " là " + CB_So.SelectedItem + "!";
            else LB_KQ.Text = n + " không phải " + CB_So.SelectedItem + "!";
        }

        private void CB_So_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_So.SelectedIndex)
            {
                case 0:
                    KTra = new KTra_So(KTra_SCP);
                    break;
                case 1:
                    KTra = new KTra_So(KTra_SNT);
                    break;
                case 2:
                    KTra = new KTra_So(KTra_SHC);
                    break;
                case 3:
                    KTra = new KTra_So(KTra_SDX);
                    break;
                case 4:
                    KTra = new KTra_So(KTra_SAS);
                    break;
            }
        }
    }
}