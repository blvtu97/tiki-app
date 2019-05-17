using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    class BLDetailFashion
    {
        DBConnectDatabase db = null;
        public BLDetailFashion()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from CHITIET_THOITRANG", CommandType.Text);
        }

        public bool Insert(string maSP, string mauSac, string size, string kieuDang, string chatLieu, ref string err )
        {
            string sqlString = "Insert Into CHITIET_THOITRANG Values(" + "N'" + maSP + "',N'" + mauSac + "',N'"
                                + size + "','" + kieuDang + "','" + chatLieu + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string maSP, string mauSac, string size, string kieuDang, string chatLieu, ref string err)

        {
            string sqlString = "Update CHITIET_THOITRANG Set MauSac = N'" + mauSac + "',Size = N'" + size + 
                                "',KieuDang = N'" + kieuDang + "',ChatLieu = '" + chatLieu + "' Where MaSP= N'" + maSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string maSP, ref string err)
        {
            string sqlString = "Delete From CHITIET_THOITRANG Where MaSP='" + maSP + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
