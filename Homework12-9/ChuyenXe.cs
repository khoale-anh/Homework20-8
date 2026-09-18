using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public abstract class ChuyenXe
    {
        private string maSoChuyen;
        private string hoTenTaiXe;
        private string soXe;
        private double doanhThu;

        public ChuyenXe()
        {
        }

        public ChuyenXe(
            string maSoChuyen,
            string hoTenTaiXe,
            string soXe,
            double doanhThu)
        {
            this.maSoChuyen = maSoChuyen;
            this.hoTenTaiXe = hoTenTaiXe;
            this.soXe = soXe;
            this.doanhThu = doanhThu;
        }

        public string MaSoChuyen
        {
            get { return maSoChuyen; }
            set { maSoChuyen = value; }
        }

        public string HoTenTaiXe
        {
            get { return hoTenTaiXe; }
            set { hoTenTaiXe = value; }
        }

        public string SoXe
        {
            get { return soXe; }
            set { soXe = value; }
        }

        public double DoanhThu
        {
            get { return doanhThu; }
            set { doanhThu = value; }
        }

        public override string ToString()
        {
            return $"Ma chuyen: {MaSoChuyen}, " +
                   $"Tai xe: {HoTenTaiXe}, " +
                   $"So xe: {SoXe}, " +
                   $"Doanh thu: {DoanhThu:N0}";
        }
    }
}
