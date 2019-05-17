using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

using Tiki_app.DAL;
using Tiki_app.DTO;
using System.Drawing;
using System.Diagnostics;
using System.IO;

namespace Tiki_app.BLL
{
    public class BLogicCategory
    {
        DataConnector dataConnector;
        public BLogicCategory()
        {
            dataConnector = new DataConnector();
        }

        public List<DanhMucSanPham> getCategory(DataType type, ref bool flag)
        {
            try
            {
                Debug.WriteLine("Lay category");
                //DataTable table = dataConnector.GetTable("CATEGORY_PHONE", ref flag);
                DataConnector.ConnectToServer();
                DataConnector.SendRequest("CATEGORY_PHONE");
                DataTable table = DataConnector.ReceiveResponse();
                DataConnector.Exit();
                Debug.WriteLine("Lay category thanh cong");

                List<DanhMucSanPham> sanPhams = new List<DanhMucSanPham>();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    MemoryStream mem = new MemoryStream((byte[])table.Rows[i][1]);
                    Image image = Image.FromStream(mem);
                    DanhMucSanPham sp = new DanhMucSanPham((string)table.Rows[i][0], image);
                    sanPhams.Add(sp);
                    Debug.WriteLine(i + " " + sp.Loai);
                }

                return sanPhams;
            }catch(Exception e)
            {
                Debug.WriteLine("Err Get du lieu Category :" + e);
                flag = false;
            }
            return null;
        }

       
    }
}
