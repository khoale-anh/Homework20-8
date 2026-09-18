using Bai1;
using System;
using System.Collections.Generic;

namespace Bai1
{
    /// <summary>
    /// Chương trình quản lý danh sách chuyến xe.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ChuyenXe> danhSach = new List<ChuyenXe>();

            // 2 chuyến xe nội thành
            danhSach.Add(new ChuyenXeNoiThanh(
                "NT01",
                "Nguyen Van An",
                "51A-12345",
                5,
                120.5,
                1500000
            ));

            danhSach.Add(new ChuyenXeNoiThanh(
                "NT02",
                "Tran Van Binh",
                "51B-23456",
                7,
                180,
                2000000
            ));

            // 2 chuyến xe ngoại thành
            danhSach.Add(new ChuyenXeNgoaiThanh(
                "NG01",
                "Le Van Cuong",
                "51C-34567",
                "Da Lat",
                3,
                5000000
            ));

            danhSach.Add(new ChuyenXeNgoaiThanh(
                "NG02",
                "Pham Van Dung",
                "51D-45678",
                "Vung Tau",
                2,
                3500000
            ));

            // Xuất danh sách
            Console.WriteLine("===== DANH SACH CHUYEN XE =====");

            foreach (ChuyenXe xe in danhSach)
            {
                Console.WriteLine(xe);
            }

            // Tính tổng doanh thu
            double tongDoanhThu = 0;
            double tongNoiThanh = 0;
            double tongNgoaiThanh = 0;

            foreach (ChuyenXe xe in danhSach)
            {
                tongDoanhThu += xe.DoanhThu;

                if (xe is ChuyenXeNoiThanh)
                {
                    tongNoiThanh += xe.DoanhThu;
                }

                if (xe is ChuyenXeNgoaiThanh)
                {
                    tongNgoaiThanh += xe.DoanhThu;
                }
            }

            Console.WriteLine();
            Console.WriteLine("===== THONG KE =====");

            Console.WriteLine(
                $"Tong doanh thu: {tongDoanhThu:N0}"
            );

            Console.WriteLine(
                $"Tong doanh thu noi thanh: {tongNoiThanh:N0}"
            );

            Console.WriteLine(
                $"Tong doanh thu ngoai thanh: {tongNgoaiThanh:N0}"
            );
        }
    }
}