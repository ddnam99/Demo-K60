using System;
using System.Windows.Forms;

namespace On_Tap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int SoLuongMuonNhap;
        private int SoMatHangDangNhap = 1;

        private void BT_NhapSoLuong_Click(object sender, EventArgs e)
        {
            // Convert TextBox số lượng muốn nhập thành số nguyên và gán giá trị vào biến SoLuongMuonNhap
            // Convert thành công thì hàm TryParse sẽ trả về true và ngược lại là false
            if (!int.TryParse(TB_SoLuongNhap.Text, out SoLuongMuonNhap))
                if (TB_SoLuongNhap.Text == "") MessageBox.Show("Chưa nhập dữ liệu!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Chỉ được phép nhập số nguyên!", "FormatExeption !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                BT_NhapSoLuong.Enabled = false;
                TB_SoLuongNhap.Enabled = false;

                if (SoLuongMuonNhap > 0)
                {
                    // Enable Form nhập thông tin và hiển thị thông báo đang nhập thông tin cho mặt hàng thứ mấy
                    LB_SoLuongNhap.Visible = true;
                    PN_Nhap.Enabled = true;
                }
            }
        }

        private bool CheckDuLieuNhap()
        {
            // Kiểm tra đã nhập đủ thông tin chưa
            if (TB_MaHang.Text == "" || TB_TenHang.Text == "" || TB_DonGia.Text == "" || (int)NUD_SoLuong.Value == 0 || CB_XuatSu.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            // Kiểm tra dữ liệu đơn giá có chính xác không
            try { double.Parse(TB_DonGia.Text); }
            catch
            {
                MessageBox.Show("Thông tin đơn giá bị lỗi!", "FormatExeption !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ResetFormNhapThongTin()
        {
            TB_MaHang.Text = TB_TenHang.Text = TB_DonGia.Text = "";
            DTP_NgayNhap.Value = DateTime.Now;
            NUD_SoLuong.Value = 0;
            CB_XuatSu.SelectedIndex = -1;
        }

        private void DisableFormNhap()
        {
            PN_Nhap.Enabled = false;
            LB_SoLuongNhap.Visible = false;
        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
            if (CheckDuLieuNhap())
            {
                DGV_ThongTin.Rows.Add(TB_MaHang.Text, TB_TenHang.Text, DTP_NgayNhap.Value.ToShortDateString(), NUD_SoLuong.Value, TB_DonGia.Text, CB_XuatSu.Text);

                ResetFormNhapThongTin();

                // Biến SoMatHangDangNhap tăng giá trị lên bằng cộng tiền tố
                LB_SoLuongNhap.Text = "Nhập thông tin thứ: " + ++SoMatHangDangNhap;

                if (SoMatHangDangNhap > SoLuongMuonNhap) DisableFormNhap();
            }
        }

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            ResetFormNhapThongTin();
            DisableFormNhap();

            // Reset giá trị và properties của các controls về mặc định
            DGV_ThongTin.Rows.Clear();
            BT_NhapSoLuong.Enabled = true;
            TB_SoLuongNhap.Enabled = true;
            TB_SoLuongNhap.Text = "";
            SoMatHangDangNhap = 1;
            LB_SoLuongNhap.Text = "Nhập thông tin thứ: 1";
        }
    }
}