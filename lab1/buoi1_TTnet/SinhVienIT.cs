using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_TTnet
{
    internal class SinhVienIT:SinhVien
    {
        public new void hienthi()
        {
            Console.WriteLine("\n-----------Sinh vien it:-------");
            base.hienthi();
        }
    }
}
