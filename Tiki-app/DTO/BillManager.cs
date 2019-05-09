using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiki_app.DTO
{
    public class BillManager
    {
        public static BillManager instance;

        private BillManager() { }

        public static BillManager getInstance()
        {
            if (instance == null) instance = new BillManager();
            return instance;
        }

        public List<SanPham> billList = new List<SanPham>();

        public double totalBill()
        {
            double totalBill = 0;
            for (int i = 0; i < billList.Count; i++)
            {
                totalBill += billList[i].GiaSP * billList[i].Count;
            }
            return totalBill;
        }

        public int countBill()
        {
            int count = 0;
            for (int i = 0; i < billList.Count; i++)
            {
                count += billList[i].Count;
            }
            return count;
        }

        public void addBill(SanPham sanpham)
        {
            if (billList.Exists(p => p.MaSP == sanpham.MaSP)) return;
            billList.Add(sanpham);
        }

        public void deleteBill(SanPham sanpham)
        {
            if (billList.Exists(p => p.MaSP == sanpham.MaSP)) billList.Remove(sanpham);
        }

        public bool existBill(SanPham sanpham)
        {
            if (billList.Exists(p => p.MaSP == sanpham.MaSP)) return true;
            return false;
        }
    }
}
