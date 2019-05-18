using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiki_app.DTO
{
    public class Customer
    {
        public string HoTen { get; set; }

        public string DienThoai { get; set; }

        public string DiaChiEmail { get; set; }

        public string MatKhau { get; set; }

        public string NgaySinh { get; set; }

        public bool sex { get; set; }

        public string TinhThanhPho { get; set; }

        public string QuanHuyen { get; set; }

        public string DiaChi { get; set; }

        public Customer()
        {
            TinhThanhPho = "";
            QuanHuyen = "";
            DiaChi = "";
        }

        public Customer(string HoTen, string DienThoai, string DiaChiEmail, string MatKhau,
            string NgaySinh, bool sex, string TinhThanhPho, string QuanHuyen, string DiaChi)
        {
            this.HoTen = HoTen;
            this.DienThoai = DienThoai;
            this.DiaChiEmail = DiaChiEmail;
            this.sex = sex;
            this.TinhThanhPho = TinhThanhPho;
            this.QuanHuyen = QuanHuyen;
            this.DiaChi = DiaChi;
            this.NgaySinh = NgaySinh;
            this.MatKhau = MatKhau;
        }
    }
}
