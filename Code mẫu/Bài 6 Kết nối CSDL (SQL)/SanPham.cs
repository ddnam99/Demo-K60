using System;

namespace Bài_6_Kết_nối_CSDL__SQL_
{
    abstract class SanPham
    {
        protected String MaSP;
        protected String TenSP;
        protected String XuatSu;
        protected double DonGia;

        public SanPham() { }

        public SanPham(string _MaSP, string _TenSP, string _XuatSu, double _DonGia)
        {
            MaSP = _MaSP;
            TenSP = _TenSP;
            XuatSu = _XuatSu;
            DonGia = _DonGia;
        }

        public abstract double ThanhTien();
    }
}