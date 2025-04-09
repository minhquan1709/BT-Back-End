using System;
using System.Linq;

public class Bai4
{
    // Viet ham de tim so lon thu hai trong mot mang cac so nguyen.
    public static int TimSoLonThuHai(int[] mang)
    {
        if (mang.Length < 2)
        {
            throw new ArgumentException("Mang phai co it nhat hai phan tu.");
        }

        // Loai bo cac phan tu trung lap va sap xep giam dan
        int[] mangDistinctGiamDan = mang.Distinct().OrderByDescending(x => x).ToArray();

        if (mangDistinctGiamDan.Length < 2)
        {
            throw new ArgumentException("Mang khong co so lon thu hai duy nhat.");
        }

        return mangDistinctGiamDan[1];
    }

    public static void Main(string[] args)
    {
        int[] mangSo = { 1, 5, 2, 8, 3, 8, 4 };
        try
        {
            int soLonThuHai = TimSoLonThuHai(mangSo);
            Console.WriteLine($"So lon thu hai trong mang la: {soLonThuHai}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Loi: {ex.Message}");
        }
        Console.ReadKey();
    }
}