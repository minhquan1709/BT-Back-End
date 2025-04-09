using System;

public class Bai10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh kiem tra so nguyen to");
        Console.Write("Nhap mot so nguyen duong: ");
        string inputNumber = Console.ReadLine();

        if (int.TryParse(inputNumber, out int number) && number > 1)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{number} khong phai la so nguyen to.");
            }
        }
        else
        {
            Console.WriteLine("Dau vao khong hop le. Vui long nhap mot so nguyen duong lon hon 1.");
        }

        Console.ReadKey();
    }
}