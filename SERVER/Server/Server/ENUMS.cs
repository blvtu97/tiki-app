using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public enum DataManager
    {
        CUSTOMER,
        COMMENT,
        DETAILBILL,

        PRODUCTSMARTPHONE,
        CATEGORY_SMARTPHONE_TABLET,
        DETAILSMARTPHONE,

        PRODUCTLAPTOP,
        DETAILLAPTOP,
        CATEGORY_LAPTOP,

        PRODUCTFASHION,
        DETAILFASHION,
        CATEGORY_FASHION,

        PRODUCTBOOK,
        DETAILBOOK,
        CATEGORY_BOOK,

        PRODUCTCAR,
        DETAILCAR,
        CATEGORY_CAR,
    }

    public enum DataTableName
    {
        DIENTHOAI,
        CHITIET_DIENTHOAI,
        KHACHHANG,
        CATEGORY_DIENTHOAI_TABLET,
        HINHANH_SANPHAM,
    }
}
