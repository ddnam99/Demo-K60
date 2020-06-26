using System;

namespace demo.net {
    public class SinhVien {
        private string MaSV;
        private string HoTen;
        private string GioiTinh;
        private string QueQuan;
        private string NgaySinh;
        private PhuongTienDiLai PTDL;

        public void Nhap () {
            Console.Write ("MaSV: ");
            MaSV = Console.ReadLine ();
            Console.Write ("HoTen: ");
            HoTen = Console.ReadLine ();
            Console.Write ("GioiTinh: ");
            GioiTinh = Console.ReadLine ();
            Console.Write ("QueQuan: ");
            QueQuan = Console.ReadLine ();
            Console.Write ("NgaySinh: ");
            NgaySinh = Console.ReadLine ();
            while (true) {
                Console.Write ("PTDL:\n" +
                    "1. Ô tô\n" +
                    "2. Xe máy\n" +
                    "Lựa chọn: ");
                string LuaChon = Console.ReadLine ();
                switch (LuaChon) {
                    case "1":
                        PTDL = new OTo ();
                        return;
                    case "2":
                        PTDL = new XeMay ();
                        return;
                }
            }
        }

        public void Xuat () {
            Console.Write ($"{MaSV}\t{HoTen}\t{GioiTinh}\t\t{QueQuan}\t\t{NgaySinh}\t\t");
            PTDL.DiChuyen ();
        }
    }
}