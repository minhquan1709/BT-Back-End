using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten cua ban: ");
            string ten = Console.ReadLine();

            Console.Write("Nhap tuoi cua ban: ");
            string tuoiStr = Console.ReadLine();
            int tuoi;

            // Thử chuyển đổi tuổi sang số nguyên, xử lý trường hợp nhập không hợp lệ
            if (int.TryParse(tuoiStr, out tuoi))
            {
                Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
            }
            else
            {
                Console.WriteLine("Tuoi nhap vao khong hop le.");
            }

            // Giữ cho cửa sổ console không đóng lại ngay lập tức
            Console.ReadKey();
        }
    }
}