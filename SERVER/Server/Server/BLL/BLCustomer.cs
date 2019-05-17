using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.DAL;

namespace Server.BLL
{
    class BLCustomer
    {
        DBConnectDatabase db = null;
        public BLCustomer()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from KHACHHANG", CommandType.Text);
        }
    }
}
