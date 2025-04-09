using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai cua hinh chu nhat: ");
            string chieuDaiStr = Console.ReadLine();
            double chieuDai;

            Console.Write("Nhap chieu rong cua hinh chu nhat: ");
            string chieuRongStr = Console.ReadLine();
            double chieuRong;

            // Thử chuyển đổi chiều dài sang số thực
            if (double.TryParse(chieuDaiStr, out chieuDai))
            {
                // Thử chuyển đổi chiều rộng sang số thực
                if (double.TryParse(chieuRongStr, out chieuRong))
                {
                    // Kiểm tra xem chiều dài và chiều rộng có phải là số dương hay không
                    if (chieuDai > 0 && chieuRong > 0)
                    {
                        // Tính diện tích
                        double dienTich = chieuDai * chieuRong;

                        // In kết quả ra màn hình
                        Console.WriteLine($"Dien tich cua hinh chu nhat la: {dienTich}");
                    }
                    else
                    {
                        Console.WriteLine("Chieu dai va chieu rong phai la so duong.");
                    }
                }
                else
                {
                    Console.WriteLine("Chieu rong nhap vao khong hop le. Vui long nhap so.");
                }
            }
            else
            {
                Console.WriteLine("Chieu dai nhap vao khong hop le. Vui long nhap so.");
            }

            // Giữ cho cửa sổ console không đóng lại ngay lập tức
            Console.ReadKey();
        }
    }
}