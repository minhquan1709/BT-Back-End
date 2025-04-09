using System;

public class Bai9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh tinh giai thua");
        Console.Write("Nhap mot so nguyen duong n: ");
        string inputN = Console.ReadLine();

        if (int.TryParse(inputN, out int n) && n >= 0)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"{n}! = {factorial}");
        }
        else
        {
            Console.WriteLine("Dau vao khong hop le. Vui long nhap mot so nguyen duong.");
        }

        Console.ReadKey();
    }
}
}