using System;

public class Bai7
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh kiem tra nam nhuan");
        Console.Write("Nhap mot nam: ");
        string inputYear = Console.ReadLine();

        if (int.TryParse(inputYear, out int year))
        {
            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            if (isLeap)
            {
                Console.WriteLine($"{year} la nam nhuan.");
            }
            else
            {
                Console.WriteLine($"{year} khong phai la nam nhuan.");
            }
        }
        else
        {
            Console.WriteLine("Dau vao khong hop le. Vui long nhap mot nam (so nguyen).");
        }

        Console.ReadKey();
    }
}