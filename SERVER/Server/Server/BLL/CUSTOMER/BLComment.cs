using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL.CUSTOMER
{
    class BLComment
    {
        DBConnectDatabase db = null;
        public BLComment()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from COMMENT", CommandType.Text);
        }

        public bool Insert(string maSP, string khachHang, DateTime ngayComment, string noiDung, int rate, ref string err)
        {
            string sqlString = "Insert Into COMMENT Values(" + "N'" + maSP + "','" + khachHang + "','"
                                + ngayComment + "','" + noiDung + "','" + rate + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string maSP, string khachHang, DateTime ngayComment, string noiDung, int rate, ref string err)
        {
            string sqlString = "Update COMMENT Set NgayComment = '" + ngayComment + "', NoiDung = N'"+noiDung+"',Rate = '"+rate+
                                "' Where MaSP= N'" + maSP + "'and HoTen ='" + khachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string maSP, string khachHang, ref string err)
        {
            string sqlString = "Delete From COMMENT Where MaSP = N'" + maSP + "'and HoTen ='" + khachHang + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
