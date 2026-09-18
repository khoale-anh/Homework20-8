using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork12_9_Bai2
{
    public class SachGiaoKhoa : Sach
    {
        private string tinhTrang;

        public SachGiaoKhoa()
        {
        }

        public SachGiaoKhoa(
            string maSach,
            DateTime ngayNhap,
            double donGia,
            int soLuong,
            string nhaXuatBan,
            string tinhTrang)
            : base(
                maSach,
                ngayNhap,
                donGia,
                soLuong,
                nhaXuatBan)
        {
            this.tinhTrang = tinhTrang;
        }

        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        public override double ThanhTien()
        {
            if (TinhTrang.ToLower() == "moi")
            {
                return SoLuong * DonGia;
            }

            return SoLuong * DonGia * 0.5;
        }

        public override string ToString()
        {
            return base.ToString()
                   + $", Tinh trang: {TinhTrang}"
                   + $", Thanh tien: {ThanhTien():N0}";
        }
    }
}
