using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class GiamDoc : NhanVien
    {
        public GiamDoc()
        {
            this.className=this.GetType().Name;
        }

        public override string ChucVu()
        {
            return "Giam Doc";
        }

        public override void CongViec()
        {
            Console.WriteLine(", Ban hanh  quyet dinh, chi ra duong loi chien luoc kinh doanh");
        }
    }
}
