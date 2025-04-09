using System;

public class Bai8
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bang cuu chuong tu 1 den 10:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Bang cuu chuong {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine(); // Dong trong giua cac bang cuu chuong
        }

        Console.ReadKey();
    }
}