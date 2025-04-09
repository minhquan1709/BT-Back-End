using System;

public class Bai3
{
    // Viet mot ham de dem so luong so am va so duong trong mot mang gom n phan tu nhap
    // tu ban phim.
    public static void DemSoAmDuong(int[] mang)
    {
        int demAm = 0;
        int demDuong = 0;
        foreach (int so in mang)
        {
            if (so < 0)
            {
                demAm++;
            }
            else if (so > 0)
            {
                demDuong++;
            }
        }
        Console.WriteLine($"So luong so am: {demAm}");
        Console.WriteLine($"So luong so duong: {demDuong}");
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

        DemSoAmDuong(mang);
        Console.ReadKey();
    }
}