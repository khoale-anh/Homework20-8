using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_9_Bai3
{
    public class GiaoDichTienTe : GiaoDich
    {
        private double tiGia;
        private string loaiTienTe;

        public GiaoDichTienTe()
        {
        }

        public GiaoDichTienTe(
            string maGiaoDich,
            DateTime ngayGiaoDich,
            double donGia,
            int soLuong,
            double tiGia,
            string loaiTienTe)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            this.tiGia = tiGia;
            this.loaiTienTe = loaiTienTe;
        }

        public double TiGia
        {
            get { return tiGia; }
            set { tiGia = value; }
        }

        public string LoaiTienTe
        {
            get { return loaiTienTe; }
            set { loaiTienTe = value; }
        }

        public override double ThanhTien()
        {
            if (LoaiTienTe == "USD" || LoaiTienTe == "Euro")
                return SoLuong * DonGia * TiGia;

            return SoLuong * DonGia;
        }

        public override string ToString()
        {
            return base.ToString()
                   + $", Ti gia: {TiGia:N0}"
                   + $", Loai tien: {LoaiTienTe}"
                   + $", Thanh tien: {ThanhTien():N0}";
        }
    }
}
