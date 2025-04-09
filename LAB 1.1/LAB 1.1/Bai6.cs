using System;

public class Bai6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh kiem tra so duong, so am hay so khong");
        Console.Write("Nhap mot so: ");
        string inputNumber = Console.ReadLine();

        if (double.TryParse(inputNumber, out double number))
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} la so duong.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} la so am.");
            }
            else
            {
                Console.WriteLine($"{number} la so khong.");
            }
        }
        else
        {
            Console.WriteLine("Dau vao khong hop le. Vui long nhap mot so.");
        }

        Console.ReadKey();
    }
}