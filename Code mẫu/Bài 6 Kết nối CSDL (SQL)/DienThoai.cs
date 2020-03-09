using System;
using System.Windows.Forms;

namespace Bài_6_Kết_nối_CSDL__SQL_
{
    class DienThoai : SanPham
    {
        private int SoLuong;

        public DienThoai() { }

        public DienThoai(string _MaSP, string _TenSP, string _XuatSu, double _DonGia, int _SoLuong) : base(_MaSP, _TenSP, _XuatSu, _DonGia)
        {
            SoLuong = _SoLuong;
        }

        public DienThoai(DataGridViewRow Row)
        {
            MaSP = Row.Cells[0].Value.ToString();
            TenSP = Row.Cells[1].Value.ToString();
            XuatSu = Row.Cells[2].Value.ToString();
            DonGia = Convert.ToDouble(Row.Cells[3].Value);
            SoLuong = Convert.ToInt32(Row.Cells[4].Value);
        }

        public override double ThanhTien()
        {
            switch (XuatSu)
            {
                case "Việt Nam":
                    return DonGia * SoLuong;
                case "Trung Quốc":
                    return DonGia * SoLuong * 1.5;
                case "Mỹ":
                    return DonGia * SoLuong * 1.1;
                case "Hàn Quốc":
                    return DonGia * SoLuong * 1.2;
                default:
                    return -1;
            }
        }

        public String GSMaSP { get => MaSP; set => MaSP = value; }
        public String GSTenSP { get => TenSP; set => TenSP = value; }
        public String GSXuatSu { get => XuatSu; set => XuatSu = value; }
        public double GSDonGia { get => DonGia; set => DonGia = value; }
        public int GSSoLuong { get => SoLuong; set => SoLuong = value; }
    }
}