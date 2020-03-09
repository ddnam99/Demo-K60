using System;
using System.Windows.Forms;

namespace Bài_6_Kết_nối_CSDL__SQL_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lấy toàn bộ dữ liệu trong DataBase đổ vào DataGridView.
        /// </summary>
        private void CapNhatDGV()
        {
            DGV.DataSource = DBConnection.LayToanBoDuLieuDuLieu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhatDGV();
        }

        /// <summary>
        /// Lấy dữ liệu người dùng nhập vào và chuyển thành Object DienThoai.
        /// </summary>
        private DienThoai LayDuLieuVao()
        {
            DienThoai DT = new DienThoai();

            DT.GSMaSP = TB_MaSP.Text;
            DT.GSTenSP = TB_TenSP.Text;
            DT.GSXuatSu = CB_XuatSu.SelectedItem.ToString();
            DT.GSDonGia = Convert.ToDouble(TB_DonGia.Text);
            DT.GSSoLuong = Convert.ToInt32(NUD_SoLuong.Value);

            return DT;
        }

        /// <summary>
        /// Xóa dữ liệu người dùng nhập vào.
        /// </summary>
        private void XoaDuLieuNhap()
        {
            TB_MaSP.Text = "";
            TB_TenSP.Text = "";
            CB_XuatSu.SelectedIndex = 0;
            TB_DonGia.Text = "";
            NUD_SoLuong.Value = 0;
        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
            DienThoai DT = LayDuLieuVao();

            DBConnection.InsertDuLieu(DT);

            CapNhatDGV();

            XoaDuLieuNhap();
        }

        /// <summary>
        /// Đổ dữ liệu DT ra màn hình.
        /// </summary>
        private void DoDuLieuRa(DienThoai DT)
        {
            TB_MaSP.Text = DT.GSMaSP;
            TB_TenSP.Text = DT.GSTenSP;
            CB_XuatSu.SelectedItem = DT.GSXuatSu;
            TB_DonGia.Text = DT.GSDonGia.ToString();
            NUD_SoLuong.Value = DT.GSSoLuong;
        }

        /// <summary>
        /// Lưu index của hàng mà người dùng đã click vào DataGridView.
        /// </summary>
        int indexClicked = -1;
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexClicked = e.RowIndex;

            DienThoai DT = new DienThoai(DGV.Rows[indexClicked]);

            DoDuLieuRa(DT);
        }

        private void BT_Sua_Click(object sender, EventArgs e)
        {
            string MaSPCanSua = DGV.Rows[indexClicked].Cells[0].Value.ToString();

            DienThoai DT = LayDuLieuVao();

            DBConnection.UpdateDuLieu(MaSPCanSua, DT);

            CapNhatDGV();

            indexClicked = -1;

            XoaDuLieuNhap();
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            string MaSPCanXoa = DGV.Rows[indexClicked].Cells[0].Value.ToString();

            DBConnection.DeleteDuLieuBangMaSP(MaSPCanXoa);

            CapNhatDGV();

            indexClicked = -1;

            XoaDuLieuNhap();
        }
    }
}