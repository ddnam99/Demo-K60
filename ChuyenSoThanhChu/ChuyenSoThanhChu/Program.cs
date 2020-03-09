using System;

namespace ChuyenSoThanhChu
{
    class Program
    {
        private static string[] So = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

        private static string ChuyenDoi(long n)
        {
            string Result = "";

            switch (n.ToString().Length)
            {
                case 1:
                    return So[n];
                case 2:
                    Result = n < 20 ? "Mười " : ChuyenDoi(n / 10) + " Mươi ";

                    if (n % 10 != 0)
                        if (n % 10 == 5) return Result + "Lăm ";
                        else if (n % 10 == 1) return Result + "Mốt ";
                        else return Result + ChuyenDoi(n % 10);

                    return Result;
                case 3:
                    Result = ChuyenDoi(n / 100) + " Trăm ";

                    if (n % 10 != 0)
                        Result += (n % 100 < 10 ? "Linh " : "") + ChuyenDoi(n % 100);

                    return Result;
                case 4:
                case 5:
                case 6:
                    Result = ChuyenDoi(n / 1000) + " Nghìn ";

                    if (n % 1000 != 0)
                        Result += (n % 1000 < 100 ? ("Không Trăm " + (n % 1000 < 10 ? "Linh " : "")) : "") + ChuyenDoi(n % 1000);

                    return Result;
                case 7:
                case 8:
                case 9:
                    Result = ChuyenDoi(n / 1000000) + " Triệu ";

                    if (n / 1000000 != 0) Result += ChuyenDoi(n % 1000000);

                    return Result;
                default:
                    Result = ChuyenDoi(n / 1000000000) + " Tỷ ";

                    if (n / 1000000000 != 0) Result += ChuyenDoi(n % 1000000000);

                    return Result;
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Chuyển số thành chữ";
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            while (true)
            {
                Console.Write("Nhập số: ");
                long n = long.Parse(Console.ReadLine());

                Console.WriteLine(ChuyenDoi(n));
            }
        }
    }
}
