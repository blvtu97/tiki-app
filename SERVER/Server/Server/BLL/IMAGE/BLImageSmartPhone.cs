using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.DAL;

namespace Server.BLL
{
    class BLImageSmartPhone
    {
        DBConnectDatabase db = null;
        public BLImageSmartPhone()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from HINHANH_DIENTHOAI", CommandType.Text);
        }

        public DataRow FindImageByID(string id)
        {
            DataRow row;
            string sqlString = "SELECT * From HINHANH_DIENTHOAI Where IdImage='" + id + "'";
            row = db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0];
            return row;
        }
    }
}
