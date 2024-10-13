using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class GiamDoc : NhanVien
    {
        public override string ChucVu()
        {
            return "Giam Doc";
        }

        public override void CongViec()
        {
            Console.WriteLine("Ban hanh  quyet dinh, chi ra duong loi chien luoc kinh doanh");
        }
    }
}
