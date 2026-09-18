using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_9_Bai3
{
    public abstract class GiaoDich
    {
        private string maGiaoDich;
        private DateTime ngayGiaoDich;
        private double donGia;
        private int soLuong;

        public GiaoDich()
        {
        }

        public GiaoDich(
            string maGiaoDich,
            DateTime ngayGiaoDich,
            double donGia,
            int soLuong)
        {
            this.maGiaoDich = maGiaoDich;
            this.ngayGiaoDich = ngayGiaoDich;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }

        public string MaGiaoDich
        {
            get { return maGiaoDich; }
            set { maGiaoDich = value; }
        }

        public DateTime NgayGiaoDich
        {
            get { return ngayGiaoDich; }
            set { ngayGiaoDich = value; }
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

        public abstract double ThanhTien();

        public override string ToString()
        {
            return $"Ma GD: {MaGiaoDich}, " +
                   $"Ngay: {NgayGiaoDich:dd/MM/yyyy}, " +
                   $"Đon gia: {DonGia:N0}, " +
                   $"So luong: {SoLuong}";
        }
    }
}

