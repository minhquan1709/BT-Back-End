using System;

public class Bai5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh tinh tong va tich cua hai so");

        Console.Write("Nhap so thu nhat: ");
        string inputNum1 = Console.ReadLine();
        if (!double.TryParse(inputNum1, out double num1))
        {
            Console.WriteLine("Dau vao khong hop le cho so thu nhat.");
            return;
        }

        Console.Write("Nhap so thu hai: ");
        string inputNum2 = Console.ReadLine();
        if (!double.TryParse(inputNum2, out double num2))
        {
            Console.WriteLine("Dau vao khong hop le cho so thu hai.");
            return;
        }

        double sum = num1 + num2;
        double product = num1 * num2;

        Console.WriteLine($"Tong cua {num1} va {num2} la: {sum}");
        Console.WriteLine($"Tich cua {num1} va {num2} la: {product}");

        Console.ReadKey();
    }
}