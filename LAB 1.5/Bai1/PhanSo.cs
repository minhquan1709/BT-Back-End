using System;
using System.Collections.Generic;

public class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo()
    {
        TuSo = 0;
        MauSo = 1; // Mẫu số mặc định là 1
    }

    public PhanSo(int tuSo, int mauSo)
    {
        if (mauSo == 0)
        {
            throw new ArgumentException("Mau so khong the bang 0.");
        }
        TuSo = tuSo;
        MauSo = mauSo;
    }

    public void NhapPhanSo()
    {
        Console.Write("Nhap tu so: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so: ");
        int mauSo = int.Parse(Console.ReadLine());
        if (mauSo == 0)
        {
            throw new ArgumentException("Mau so khong the bang 0.");
        }
        MauSo = mauSo;
    }

    // Phương thức tìm ước chung lớn nhất (GCD)
    private int UCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Phương thức tối giản phân số
    public PhanSo ToiGian()
    {
        int ucln = UCLN(TuSo, MauSo);
        TuSo /= ucln;
        MauSo /= ucln;
        return this;
    }

    // Phương thức cộng hai phân số
    public PhanSo Cong(PhanSo phanSoKhac)
    {
        int tuSoMoi = (TuSo * phanSoKhac.MauSo) + (phanSoKhac.TuSo * MauSo);
        int mauSoMoi = MauSo * phanSoKhac.MauSo;
        PhanSo ketQua = new PhanSo(tuSoMoi, mauSoMoi);
        return ketQua.ToiGian();
    }

    // Override phương thức ToString để in phân số dễ đọc
    public override string ToString()
    {
        return $"{TuSo}/{MauSo}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<PhanSo> danhSachPhanSo = new List<PhanSo>();

        Console.WriteLine("Nhap so luong phan so muon tinh tong:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap phan so thu {i + 1}:");
            PhanSo phanSo = new PhanSo();
            try
            {
                phanSo.NhapPhanSo();
                danhSachPhanSo.Add(phanSo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
                i--; // Nhập lại phân số nếu có lỗi
            }
        }

        if (danhSachPhanSo.Count > 0)
        {
            PhanSo tong = new PhanSo(); // Khởi tạo tổng bằng 0/1
            foreach (PhanSo ps in danhSachPhanSo)
            {
                tong = tong.Cong(ps);
            }
            Console.WriteLine($"\nTong cac phan so la: {tong}");
        }
        else
        {
            Console.WriteLine("Danh sach phan so rong.");
        }

        Console.ReadKey();
    }
}