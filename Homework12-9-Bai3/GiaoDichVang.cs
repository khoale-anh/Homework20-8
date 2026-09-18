using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_9_Bai3
{
    public class GiaoDichVang : GiaoDich
    {
        private string loaiVang;

        public GiaoDichVang()
        {
        }

        public GiaoDichVang(
            string maGiaoDich,
            DateTime ngayGiaoDich,
            double donGia,
            int soLuong,
            string loaiVang)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            this.loaiVang = loaiVang;
        }

        public string LoaiVang
        {
            get { return loaiVang; }
            set { loaiVang = value; }
        }

        public override double ThanhTien()
        {
            return SoLuong * DonGia;
        }

        public override string ToString()
        {
            return base.ToString()
                   + $", Loai vang: {LoaiVang}"
                   + $", Thanh tien: {ThanhTien():N0}";
        }
    }
}
