using System;

namespace PhanSo {
    class PhanSo {
        private int TuSo;
        private int MauSo;

        public PhanSo () {
            TuSo = 0;
            MauSo = 1;
        }

        public PhanSo (int tuSo, int mauSo) {
            TuSo = tuSo;
            MauSo = mauSo;
        }

        public void Nhap () {
            do Console.Write ("Nhập tử số: ");
            while (!int.TryParse (Console.ReadLine (), out TuSo));

            do {
                Console.Write ("Nhập mẫu số: ");
                if (!int.TryParse (Console.ReadLine (), out MauSo)) continue;
            }
            while (MauSo == 0);
        }

        public static PhanSo operator + (PhanSo a, PhanSo b) {
            // Đối với những việc cơ bản ta có thể sử dụng hàm tạo cho ngắn gọn
            return new PhanSo () {
                TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo,
                    MauSo = a.MauSo * b.MauSo
            };
        }

        public static PhanSo operator - (PhanSo a, PhanSo b) {
            return new PhanSo () {
                TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo,
                    MauSo = a.MauSo * b.MauSo
            };
        }

        public static PhanSo operator * (PhanSo a, PhanSo b) {
            return new PhanSo (a.TuSo * b.TuSo, a.MauSo * b.MauSo);
        }

        public static PhanSo operator / (PhanSo a, PhanSo b) {
            return new PhanSo (a.TuSo * b.MauSo, a.MauSo * b.TuSo);
        }

        public override string ToString () {
            // Ghi đè hàm ToString() để có thể xuất dữ liệu ra dễ hơn
            // Một cách viết khác của formatstring
            return $"{TuSo}/{MauSo}";
        }
    }
}