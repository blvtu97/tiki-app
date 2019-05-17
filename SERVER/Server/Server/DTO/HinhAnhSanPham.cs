using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Server.DTO
{
    class HinhAnhSanPham
    {
        public string id;
        public Image hinh1;
        public Image hinhf2;
        public Image hinh3;
        public Image hinh4;

        public HinhAnhSanPham(string id, Image h1, Image h2, Image h3, Image h4)
        {
            hinh1 = h1;
            hinhf2 = h2;
            hinh3 = h3;
            hinh4 = h4;
            this.id = id;
        }
    }
}
