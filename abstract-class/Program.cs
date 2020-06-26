using System;
using System.Collections.Generic;

namespace demo.net {
    class Program {
        static void Main (string[] args) {
            var DSSV = new List<SinhVien> ();
            while (true) {
                Console.Write ("1. Nhập sinh viên\n" +
                    "2. Xuất DSSV\n" +
                    "Lựa chọn: ");
                string LuaChon = Console.ReadLine ();
                switch (LuaChon) {
                    case "1":
                        var SV = new SinhVien ();
                        SV.Nhap ();
                        DSSV.Add (SV);
                        break;
                    case "2":
                        Console.WriteLine ("MaSV\tHọ tên\tGiới tính\tQuê quán\tNgày sinh\tPhương tiện đi lại");
                        foreach (var i in DSSV)
                            i.Xuat ();
                        break;
                }

                Console.Write ("Press any key to continue...");
                Console.ReadKey ();
                Console.Clear ();
            }
        }
    }
}