using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    abstract class NhanVien
    {
        public string hoten;
        public int tuoi;
        public string gioitinh;
        public abstract string ChucVu();
        public abstract void CongViec();
    }
}
