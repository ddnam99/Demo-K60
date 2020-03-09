using System;
using System.Windows.Forms;

namespace Bài_5_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        /// Xóa dữ liệu người dùng đã nhập vào.
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

            DGV.Rows.Add(DT.GSMaSP, DT.GSTenSP, DT.GSXuatSu, DT.GSDonGia, DT.GSSoLuong, DT.ThanhTien());

            XoaDuLieuNhap();
        }

        /// <summary>
        /// Đổ dữ liệu từ DT ra màn hình.
        /// </summary>
        private void DoDuLieuRa(DienThoai DT)
        {
            TB_MaSP.Text = DT.GSMaSP;
            TB_TenSP.Text = DT.GSTenSP;
            CB_XuatSu.SelectedItem = DT.GSXuatSu;
            TB_DonGia.Text = DT.GSDonGia.ToString();
            NUD_SoLuong.Value = DT.GSSoLuong;
        }

        int indexClicked = -1;
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexClicked = e.RowIndex;

            DienThoai DT = new DienThoai(DGV.Rows[indexClicked]);

            DoDuLieuRa(DT);
        }

        /// <summary>
        /// Sửa dữ liệu DT ở hàng thứ index.
        /// </summary>
        private void SuaDuLieuDGV(DienThoai DT, int index)
        {
            object[] Row = new object[] { DT.GSMaSP, DT.GSTenSP, DT.GSXuatSu, DT.GSDonGia, DT.GSSoLuong, DT.ThanhTien() };

            DGV.Rows[index].SetValues(Row);
        }

        private void BT_Sua_Click(object sender, EventArgs e)
        {
            DienThoai DT = LayDuLieuVao();

            SuaDuLieuDGV(DT, indexClicked);

            indexClicked = -1;

            XoaDuLieuNhap();
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            DGV.Rows.RemoveAt(indexClicked);

            indexClicked = -1;

            XoaDuLieuNhap();
        }
    }
}