using System;

public class Bai4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh kiem tra so chan");
        Console.Write("Nhap mot so nguyen: ");

        // Đọc số nguyên người dùng nhập vào dưới dạng chuỗi
        string inputNumber = Console.ReadLine();

        // Thử chuyển đổi chuỗi nhập vào thành số nguyên
        if (int.TryParse(inputNumber, out int number))
        {
            // Kiểm tra xem số đó có phải là số chẵn hay không
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} la so chan.");
            }
            else
            {
                Console.WriteLine($"{number} khong phai la so chan.");
            }
        }
        else
        {
            Console.WriteLine("Dau vao khong hop le. Vui long nhap mot so nguyen.");
        }

        // Giữ cửa sổ console mở cho đến khi người dùng nhấn một phím
        Console.ReadKey();
    }
}