using System;

public class Bai1
{
    // Bai 1: Viet mot ham de tinh tong cua tat ca cac so chan trong mot mang.
    public static int TinhTongSoChan(int[] mang)
    {
        int tong = 0;
        foreach (int so in mang)
        {
            if (so % 2 == 0)
            {
                tong += so;
            }
        }
        return tong;
    }

    public static void Main(string[] args)
    {
        int[] mangSo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int tongChan = TinhTongSoChan(mangSo);
        Console.WriteLine($"Tong cac so chan trong mang la: {tongChan}");
        Console.ReadKey();
    }
}