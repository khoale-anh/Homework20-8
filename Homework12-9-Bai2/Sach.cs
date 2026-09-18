using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork12_9_Bai2
{
    public abstract class Sach
    {
        private string maSach;
        private DateTime ngayNhap;
        private double donGia;
        private int soLuong;
        private string nhaXuatBan;

        public Sach()
        {
        }

        public Sach(
            string maSach,
            DateTime ngayNhap,
            double donGia,
            int soLuong,
            string nhaXuatBan)
        {
            this.maSach = maSach;
            this.ngayNhap = ngayNhap;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.nhaXuatBan = nhaXuatBan;
        }

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public string NhaXuatBan
        {
            get { return nhaXuatBan; }
            set { nhaXuatBan = value; }
        }

        public abstract double ThanhTien();

        public override string ToString()
        {
            return $"Ma sach: {MaSach}, " +
                   $"Ngay nhap: {NgayNhap:dd/MM/yyyy}, " +
                   $"Đon gia: {DonGia:N0}, " +
                   $"So luong: {SoLuong}, " +
                   $"NXB: {NhaXuatBan}";
        }
    }
}
