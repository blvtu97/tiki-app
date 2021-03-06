﻿using System;
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
        public List<SanPham> findProductFollowRate(int rate)
        {
            List<SanPham> pd = new List<SanPham>();
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].Rate == rate)
                {
                    pd.Add(listProduct[i]);
                }
            }
            return pd;
        }
        public List<SanPham> findProductFollowAboutPrice(double from, double to)
        {
            List<SanPham> pd = new List<SanPham>();
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].GiaSP >= from && listProduct[i].GiaSP <= to)
                {
                    pd.Add(listProduct[i]);
                }
            }
            return pd;
        }
        public List<SanPham> findProductFollowText(string text)
        {
            string content = RemoveUnicode(text);
            List<SanPham> pd = new List<SanPham>();
            for (int i = 0; i < listProduct.Count; i++)
            {
                string name = RemoveUnicode(listProduct[i].TenSP);
                if (name.Contains(content))
                {
                    pd.Add(listProduct[i]);
                }
            }
            return pd;
        }
        public List<SanPham> sortProductFollowSale()
        {
            List<SanPham> temp = Clone(listProduct);
            for (int i = 0; i < temp.Count - 1; i++)
            {
                for (int j = i + 1; j < temp.Count; j++)
                {
                    double salei = temp[i].GiaTT / temp[i].GiaSP;
                    double salej = temp[i].GiaTT / temp[i].GiaSP;
                    if (salei < salej)
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
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",  
    "đ",  
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",  
    "í","ì","ỉ","ĩ","ị",  
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",  
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",  
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",  
    "d",  
    "e","e","e","e","e","e","e","e","e","e","e",  
    "i","i","i","i","i",  
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",  
    "u","u","u","u","u","u","u","u","u","u","u",  
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            text=text.ToUpper();
            return text;
        }
    }
}
