using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

using Tiki_app.DAL;
using Tiki_app.DTO;
using System.Drawing;
using System.IO;
using System.Diagnostics;
namespace Tiki_app.BLL
{
    public class BLogicProduct
    {
        DataConnector dataConnector;

        public BLogicProduct()
        {
            dataConnector = DataConnector.getInstance();
        }

        public List<SanPham> getProducts(DataType type, ref bool flag)
        {
            try
            {
                dataConnector.Connect();
                Debug.WriteLine("lay du lieu san pham");
                DataTable table = dataConnector.GetTable("PRODUCT_PHONE", ref flag);
                DataTable tableImage = dataConnector.GetTable("IMAGE_PHONE", ref flag);

                //Đóng connect khi đã láy xong bảng category và bảng product

                Debug.WriteLine("lay dien thoai thanh cong");

                List<SanPham> sanPhams = new List<SanPham>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Image[] image = new Image[4];
                    for (int img = 0; img < 4; img++)
                    {
                        MemoryStream mem = new MemoryStream((byte[])tableImage.Rows[i][img + 1]);
                        image[img] = Image.FromStream(mem);
                    }

                    DienThoai dienThoai = new DienThoai(table.Rows[i][0].ToString(), table.Rows[i][1].ToString(),
                                      table.Rows[i][2].ToString(), table.Rows[i][3].ToString(), float.Parse(table.Rows[i][4].ToString()),
                                      float.Parse(table.Rows[i][5].ToString()), int.Parse(table.Rows[i][6].ToString()), 0, image);
                    Debug.WriteLine(i + " " + dienThoai.MaSP);
                    sanPhams.Add(dienThoai);
                }
                return sanPhams;

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                flag = false;
            }
            return null;
        }
    }
}
