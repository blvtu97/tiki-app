using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Tiki_app.DTO
{
    public class SanPham
    {
        public string MaSP { get; set; }

        public string TenSP { get; set; }

        public string ThuongHieu { get; set; }

        public string Loai { get; set; }

        public double GiaSP { get; set; }

        public double GiaTT { get; set; }

        public int Rate { get; set; }

        public int Count { get; set; }

        public Image[] Image { get; set; }

        public SanPham Clone()
        {
            return new SanPham
            {
                MaSP = MaSP,
                TenSP = TenSP,
                ThuongHieu = ThuongHieu,
                Loai = Loai,
                GiaSP = GiaSP,
                GiaTT = GiaTT,
                Rate = Rate,
                Count = Count,
                Image = Image,
            };
        }
    }
}
