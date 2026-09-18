using Homework12_9_Bai3;
using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        List<GiaoDich> danhSach = new List<GiaoDich>();

        // 3 giao dịch vàng
        danhSach.Add(new GiaoDichVang(
            "V01",
            new DateTime(2026, 1, 10),
            80000000,
            10,
            "SJC"
        ));

        danhSach.Add(new GiaoDichVang(
            "V02",
            new DateTime(2026, 2, 15),
            90000000,
            15,
            "9999"
        ));

        danhSach.Add(new GiaoDichVang(
            "V03",
            new DateTime(2026, 3, 20),
            1200000000,
            2,
            "SJC"
        ));

        // 3 giao dịch tiền tệ
        danhSach.Add(new GiaoDichTienTe(
            "TT01",
            new DateTime(2026, 1, 5),
            24000,
            1000,
            1,
            "VN"
        ));

        danhSach.Add(new GiaoDichTienTe(
            "TT02",
            new DateTime(2026, 2, 10),
            25000,
            2000,
            25000,
            "USD"
        ));

        danhSach.Add(new GiaoDichTienTe(
            "TT03",
            new DateTime(2026, 3, 15),
            27000,
            1500,
            29500,
            "Euro"
        ));

        Console.WriteLine("========== DANH SACH GIAO DICH ==========");

        foreach (GiaoDich gd in danhSach)
        {
            Console.WriteLine(gd);
        }

        // Tổng số lượng giao dịch vàng
        int tongSoLuongVang = 0;

        // Tổng số lượng giao dịch tiền tệ
        int tongSoLuongTienTe = 0;

        // Tổng thành tiền giao dịch tiền tệ
        double tongThanhTienTienTe = 0;

        // Đếm số giao dịch tiền tệ
        int soGiaoDichTienTe = 0;

        foreach (GiaoDich gd in danhSach)
        {
            if (gd is GiaoDichVang)
            {
                tongSoLuongVang += gd.SoLuong;
            }

            if (gd is GiaoDichTienTe)
            {
                tongSoLuongTienTe += gd.SoLuong;
                tongThanhTienTienTe += gd.ThanhTien();
                soGiaoDichTienTe++;
            }
        }

        // Trung bình thành tiền giao dịch tiền tệ
        double trungBinhTienTe = 0;

        if (soGiaoDichTienTe > 0)
        {
            trungBinhTienTe =
                tongThanhTienTienTe / soGiaoDichTienTe;
        }

        Console.WriteLine();
        Console.WriteLine("========== THONG KE ==========");

        Console.WriteLine(
            $"Tong so luong giao dich vang: {tongSoLuongVang}");

        Console.WriteLine(
            $"Tong so luong giao dich tien te: {tongSoLuongTienTe}");

        Console.WriteLine(
            $"Trung binh thanh tien giao dich tien te: {trungBinhTienTe:N0}");

        // Xuất giao dịch có đơn giá > 1 tỷ
        Console.WriteLine();
        Console.WriteLine(
            "===== GIAO DICH CO DON GIA > 1 TY =====");

        foreach (GiaoDich gd in danhSach)
        {
            if (gd.DonGia > 1000000000)
            {
                Console.WriteLine(gd);
            }
        }
    }
}
