using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
     class GiaoDichHangHoa:iGiaoDich
    {
        private double so_luong;
        private string ma_hang_hoa;
        private string ngay;

        public GiaoDichHangHoa()
        {
            ma_hang_hoa = "";
            ngay = "";
            so_luong = 0;
        }

        public GiaoDichHangHoa(double so_luong, string ma_hang_hoa, string ngay)
        {
            this.so_luong = so_luong;
            this.ma_hang_hoa = ma_hang_hoa;
            this.ngay = ngay;
        }

        public void hienThiThongTinGiaoDich()
        {
            Console.WriteLine("Ma hang hoa: {0}",ma_hang_hoa);
            Console.WriteLine("Ngay giao dich: {0}",ngay);
            Console.WriteLine("So luong giao dich: {0}", laySoLuong());
        }

        public double laySoLuong()
        {
            return so_luong;
        }
    }
}
