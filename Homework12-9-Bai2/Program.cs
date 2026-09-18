
using System;
using System.Collections.Generic;

namespace Homwork12_9_Bai2
{ 
public class Program
{
    public static void Main(string[] args)
    {
        List<Sach> danhSach = new List<Sach>();

        // =================================
        // 3 SÁCH GIÁO KHOA
        // =================================

        danhSach.Add(new SachGiaoKhoa(
            "GK01",
            new DateTime(2026, 1, 10),
            50000,
            10,
            "K",
            "moi"
        ));

        danhSach.Add(new SachGiaoKhoa(
            "GK02",
            new DateTime(2026, 2, 15),
            70000,
            8,
            "NXB Giao Duc",
            "cu"
        ));

        danhSach.Add(new SachGiaoKhoa(
            "GK03",
            new DateTime(2026, 3, 20),
            60000,
            12,
            "K",
            "moi"
        ));

        // =================================
        // 3 SÁCH THAM KHẢO
        // =================================

        danhSach.Add(new SachThamKhao(
            "TK01",
            new DateTime(2026, 1, 5),
            100000,
            5,
            "NXB Tre",
            10000
        ));

        danhSach.Add(new SachThamKhao(
            "TK02",
            new DateTime(2026, 2, 10),
            120000,
            4,
            "K",
            15000
        ));

        danhSach.Add(new SachThamKhao(
            "TK03",
            new DateTime(2026, 3, 15),
            90000,
            6,
            "NXB Kim Đong",
            12000
        ));

        // =================================
        // XUẤT DANH SÁCH
        // =================================

        Console.WriteLine("========== DANH SACH SACH ==========");

        foreach (Sach sach in danhSach)
        {
            Console.WriteLine(sach);
        }

        // =================================
        // TỔNG THÀNH TIỀN TỪNG LOẠI
        // =================================

        double tongGiaoKhoa = 0;
        double tongThamKhao = 0;

        foreach (Sach sach in danhSach)
        {
            if (sach is SachGiaoKhoa)
            {
                tongGiaoKhoa += sach.ThanhTien();
            }

            if (sach is SachThamKhao)
            {
                tongThamKhao += sach.ThanhTien();
            }
        }

        Console.WriteLine();
        Console.WriteLine("========== TONG THANH TIEN ==========");

        Console.WriteLine(
            $"Tong sach giao khoa: {tongGiaoKhoa:N0}"
        );

        Console.WriteLine(
            $"Tong sach tham khao: {tongThamKhao:N0}"
        );

        // =================================
        // NHẬP NHÀ XUẤT BẢN K
        // =================================

        Console.WriteLine();
        Console.Write("Nhap nha xuat ban can tim: ");

        string nxbCanTim = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(
            $"===== SACH GIAO KHOA CUA NXB {nxbCanTim} ====="
        );

        foreach (Sach sach in danhSach)
        {
            if (sach is SachGiaoKhoa &&
                sach.NhaXuatBan.Equals(
                    nxbCanTim,
                    StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(sach);
            }
        }

        // =================================
        // TÌM THÀNH TIỀN CAO NHẤT
        // =================================

        double max = 0;

        foreach (Sach sach in danhSach)
        {
            if (sach.ThanhTien() > max)
            {
                max = sach.ThanhTien();
            }
        }

        Console.WriteLine();
        Console.WriteLine("========== THANH TIEN CAO NHAT ==========");

        Console.WriteLine($"{max:N0}");
    }
}
}
