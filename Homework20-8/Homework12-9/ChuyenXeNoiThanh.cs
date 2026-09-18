using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class ChuyenXeNoiThanh : ChuyenXe
    {
        private int soTuyen;
        private double soKmDiDuoc;

        public ChuyenXeNoiThanh()
        {
        }

        public ChuyenXeNoiThanh(
            string maSoChuyen,
            string hoTenTaiXe,
            string soXe,
            int soTuyen,
            double soKmDiDuoc,
            double doanhThu)
            : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            this.soTuyen = soTuyen;
            this.soKmDiDuoc = soKmDiDuoc;
        }

        public int SoTuyen
        {
            get { return soTuyen; }
            set { soTuyen = value; }
        }

        public double SoKmDiDuoc
        {
            get { return soKmDiDuoc; }
            set { soKmDiDuoc = value; }
        }

        public override string ToString()
        {
            return base.ToString()
                   + $", So tuyen: {SoTuyen}"
                   + $", So km: {SoKmDiDuoc}";
        }
    }
}
