using System;

public class Bai2
{
    // Viet ham de kiem tra xem mot so co phai la so nguyen to hay khong
    public static bool LaSoNguyenTo(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("So luong phan tu khong hop le.");
            return;
        }

        int[] mang = new int[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out mang[i]))
            {
                Console.WriteLine("Gia tri khong hop le. Vui long nhap so nguyen.");
                return;
            }
        }

        Console.WriteLine("\nCac so nguyen to trong mang:");
        for (int i = 0; i < mang.Length; i++)
        {
            if (LaSoNguyenTo(mang[i]))
            {
                Console.WriteLine($"Chi so: {i}, Gia tri: {mang[i]}");
            }
        }

        Console.ReadKey();
    }
}