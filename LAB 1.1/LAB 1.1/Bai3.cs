using System;

public class Bai3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chuyen doi nhiet do tu do C sang do F");
        Console.Write("Nhap nhiet do theo do C: ");

        // Đọc nhiệt độ người dùng nhập vào
        string inputCelsius = Console.ReadLine();

        // Thử chuyển đổi chuỗi nhập vào thành số double
        if (double.TryParse(inputCelsius, out double celsius))
        {
            // Tính toán nhiệt độ theo độ F
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Hiển thị kết quả
            Console.WriteLine($"{celsius} do C tuong duong voi {fahrenheit} do F.");
        }
        else
        {
            Console.WriteLine("Dau vao khong hop le. Vui long nhap mot so.");
        }

        // Giữ cửa sổ console mở cho đến khi người dùng nhấn một phím
        Console.ReadKey();
    }
}