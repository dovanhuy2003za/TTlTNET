using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    abstract class NhanVien : iNguoi
    {
        public string hoten;
        public int tuoi;
        public string gioitinh;
        public string className;
        public abstract string ChucVu();
        public abstract void CongViec();
        public void hienthi()
        {
            Console.Write("Lop dan xuat '{4}' : {0},{1},{2},{3}", this.hoten, this.tuoi, this.gioitinh, this.ChucVu(),this.className);
        }
    }
}
