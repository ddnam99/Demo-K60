using System;

namespace PhanSo {
    class Program {
        static void Main (string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var a = new PhanSo (3, 4);
            var b = new PhanSo ();

            b.Nhap ();

            // Lợi ích của việc override hàm ToString()
            Console.WriteLine ($"{a} + {b} = {a + b}");
            Console.WriteLine ($"{a} - {b} = {a - b}");
            Console.WriteLine ($"{a} * {b} = {a * b}");
            Console.WriteLine ($"{a} / {b} = {a / b}");
        }
    }
}