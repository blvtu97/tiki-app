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
    public class BLogicCategory
    {
        DataConnector dataConnector;

        public BLogicCategory()
        {
            dataConnector = new DataConnector();
        }

        public List<DanhMucSanPham> getCategory(DataType type)
        {
            SqlDataReader dr = null;
            List<DanhMucSanPham> dm = null;
            try
            {
                dm = new List<DanhMucSanPham>();
                dr = dataConnector.getDataReader(type);
                while (dr.Read())
                {
                    DanhMucSanPham u = new DanhMucSanPham();
                    u.Loai = dr.GetString(0).Trim();
                    u.UrlImage = App.mkdir(dr.GetString(1).Trim());
                    dm.Add(u);
                }
                dataConnector.CloseConnection();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return dm;
        }

       
    }
}
