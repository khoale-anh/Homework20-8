using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork12_9_Bai2
{
    public class SachThamKhao : Sach
    {
        private double thue;

        public SachThamKhao()
        {
        }

        public SachThamKhao(
            string maSach,
            DateTime ngayNhap,
            double donGia,
            int soLuong,
            string nhaXuatBan,
            double thue)
            : base(
                maSach,
                ngayNhap,
                donGia,
                soLuong,
                nhaXuatBan)
        {
            this.thue = thue;
        }

        public double Thue
        {
            get { return thue; }
            set { thue = value; }
        }

        public override double ThanhTien()
        {
            return SoLuong * DonGia + Thue;
        }

        public override string ToString()
        {
            return base.ToString()
                   + $", Thue: {Thue:N0}"
                   + $", Thanh tien: {ThanhTien():N0}";
        }
    }
}
