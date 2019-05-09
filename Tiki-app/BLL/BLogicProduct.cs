using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using Tiki_app.DAL;
using Tiki_app.DTO;
using Tiki_app.Utils;

namespace Tiki_app.BLL
{
    public class BLogicProduct
    {
        DataConnector dataConnector;

        public BLogicProduct()
        {
            dataConnector = new DataConnector();
        }

        public List<SanPham> getProducts(DataType type)
        {
            SqlDataReader dr = null;
            List<SanPham> pd = null;
            try
            {
                pd = new List<SanPham>();
                dr = dataConnector.getDataReader(type);
                while (dr.Read())
                {
                    DienThoai u = new DienThoai();
                    u.MaSP = dr.GetString(0).Trim();
                    u.TenSP = dr.GetString(1).Trim();
                    u.ThuongHieu = dr.GetString(2).Trim();
                    u.Loai = dr.GetString(3).Trim();
                    u.GiaSP = dr.GetDouble(4);
                    u.GiaTT = dr.GetDouble(5);
                    u.Rate = dr.GetInt32(6);
                    u.UrlImage = App.mkdir(dr.GetString(7).Trim());
                    pd.Add(u);
                }
                dataConnector.CloseConnection();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return pd;
        }
    }
}
