using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class ChuyenXeNgoaiThanh : ChuyenXe
    {
        private string noiDen;
        private int soNgayDiDuoc;

        public ChuyenXeNgoaiThanh()
        {
        }

        public ChuyenXeNgoaiThanh(
            string maSoChuyen,
            string hoTenTaiXe,
            string soXe,
            string noiDen,
            int soNgayDiDuoc,
            double doanhThu)
            : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            this.noiDen = noiDen;
            this.soNgayDiDuoc = soNgayDiDuoc;
        }

        public string NoiDen
        {
            get { return noiDen; }
            set { noiDen = value; }
        }

        public int SoNgayDiDuoc
        {
            get { return soNgayDiDuoc; }
            set { soNgayDiDuoc = value; }
        }

        public override string ToString()
        {
            return base.ToString()
                   + $", Nơi đến: {NoiDen}"
                   + $", Số ngày: {SoNgayDiDuoc}";
        }
    }
}