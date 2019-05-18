using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tiki_app.DTO;
using Tiki_app.BLL;

namespace Tiki_app.DTO
{
    public class DataManager
    {
        public static DataManager instance;

        private DataManager()
        {
            //loadData();
        }

        public static DataManager getInstance()
        {
            if (instance == null) instance = new DataManager();
            return instance;
        }

        public Dictionary<object, tabNews> tabFilterProducts = new Dictionary<object, tabNews>();
       
        private BLogicProduct logicProduct = new BLogicProduct();

        private BLogicCategory logicCategory = new BLogicCategory();

        public List<SanPham> listProduct { get; set; }

        public List<DanhMucSanPham> listCategory { get; set; }

        public List<SanPham> listPurchased = new List<SanPham>();

        public bool loadData()
        {
            bool flag = false;
            while (!flag)
            {
                listCategory = logicCategory.getCategory(DataType.CATEGORY_DIENTHOAI_TABLET, ref flag);

            }


            flag = false;
            while (!flag)
            {
                listProduct = logicProduct.getProducts(DataType.DIENTHOAI, ref flag);
            }


            return flag;
            //while (!flag)
            //{
            //    listProduct = logicProduct.getProducts(DataType.DIENTHOAI,ref flag);
            //    if (listProduct != null)
            //        break;
            //}
            //flag = false;
            //while (!flag)
            //{
            //    listCategory = logicCategory.getCategory(DataType.CATEGORY_DIENTHOAI_TABLET, ref flag);
            //    if (listCategory != null)
            //        return true;
            //}
            //return false;

        }

        public List<SanPham> findProductFollowCategory(string type)
        {
            List<SanPham> pd = new List<SanPham>();
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].Loai.Equals(type))
                {
                    pd.Add(listProduct[i]);
                }
            }
            return pd;
        }

        public List<SanPham> sortPriceProductHighToLow()
        {
            List<SanPham> temp = Clone(listProduct);
            for (int i = 0; i < temp.Count - 1; i++)
            {
                for (int j = i + 1; j < temp.Count; j++)
                {
                    if (temp[i].GiaSP < temp[j].GiaSP)
                    {
                        SanPham pd = temp[i];
                        temp[i] = temp[j];
                        temp[j] = pd;
                    }
                }
            }
            return temp;
        }

        public List<SanPham> sortPriceProductLowToHight()
        {
            List<SanPham> temp = Clone(listProduct);
            for (int i = 0; i < temp.Count - 1; i++)
            {
                for (int j = i + 1; j < temp.Count; j++)
                {
                    if (temp[i].GiaSP > temp[j].GiaSP)
                    {
                        SanPham pd = temp[i];
                        temp[i] = temp[j];
                        temp[j] = pd;
                    }
                }
            }
            return temp;
        }

        private List<SanPham> Clone(List<SanPham> list)
        {
            List<SanPham> temp = new List<SanPham>();
            for (int i = 0; i < list.Count; i++)
            {
                temp.Add(list[i].Clone());
            }
            return temp;
        }
    }
}
