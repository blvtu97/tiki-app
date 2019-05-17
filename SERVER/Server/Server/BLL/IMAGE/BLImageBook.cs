using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    class BLImageBook
    {
        DBConnectDatabase db = null;
        public BLImageBook()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from HINHANH_SACH", CommandType.Text);
        }

        public DataRow FindImageByID(string id)
        {
            DataRow row;
            string sqlString = "SELECT * From HINHANH_SACH Where IdImage='" + id + "'";
            row = db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0];
            return row;
        }
    }
}
