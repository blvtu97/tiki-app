using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiki_app.DTO
{
    public class PayMethod
    {
        public bool GiaoHangNhanh { get; set; }

        public bool ThanhToanBoiTikiCash { get; set; }

        public bool ThanhToanTienMat { get; set; }

        public bool ThanhToanBangATM { get; set; }

        public bool ThanhToanBangZaloPay { get; set; }

        public PayMethod()
        {

        }

        public PayMethod(bool GiaoHangNhanh, bool ThanhToanBoiTikiCash,
            bool ThanhToanTienMat, bool ThanhToanBangATM, bool ThanhToanBangZaloPay)
        {
            this.GiaoHangNhanh = GiaoHangNhanh;
            this.ThanhToanBoiTikiCash = ThanhToanBoiTikiCash;
            this.ThanhToanTienMat = ThanhToanTienMat;
            this.ThanhToanBangZaloPay = ThanhToanBangZaloPay;
            this.ThanhToanBangATM = ThanhToanBangATM;
        }
    }
}
