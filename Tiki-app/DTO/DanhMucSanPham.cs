using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Tiki_app.DTO
{
    public class DanhMucSanPham
    {
        public string Loai { get; set; }

        public Image Image { get; set; }

        public DanhMucSanPham(string _loai, Image _image)
        {
            Loai = _loai;
            Image = _image;
        }

    }
}
