using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tiki_app.DTO
{
    public class DienThoai:SanPham
    {
        public DienThoai(string maSP, string tenSP, string thuongHieu, string loai, float giaSP, float giaTT, int rate, int count, Image[] image)
        {
            MaSP = maSP;
            TenSP = tenSP;
            ThuongHieu = thuongHieu;
            Loai = loai;
            GiaSP = giaSP;
            GiaTT = giaTT;
            Rate = rate;
            Count = count;
            Image = image;
        }
    }
}
