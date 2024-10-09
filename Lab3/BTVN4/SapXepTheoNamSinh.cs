using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4
{
    internal class SapXepTheoNamSinh: IComparer
    {
        public int Compare(object x, object y)
        {   
            SinhVien sv1 = x as SinhVien;
            SinhVien sv2 = y as SinhVien;
            // Sắp xếp giảm dần: nếu sv1.NamSinh > sv2.NamSinh thì sv1 trước sv2
            return sv2.NamSinh.CompareTo(sv1.NamSinh);
        }
    }
}
