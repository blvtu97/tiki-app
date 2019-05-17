using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    class BLDetailLaptop
    {
        DBConnectDatabase db = null;
        public BLDetailLaptop()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from CHITIET_LAPTOP", CommandType.Text);
        }

        public bool Insert(string maSP, string manHinh, string ram, string oCung, string chip, string heDieuHanh, string dungLuongPin, ref string err)
        {
            string sqlString = "Insert Into CHITIET_LAPTOP Values(" + "N'" + maSP + "',N'" + manHinh + "',N'"
                                + ram + "','" + oCung + "','" + chip + "','" + heDieuHanh + "','" + dungLuongPin + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string maSP, string manHinh, string ram, string oCung, string chip, string heDieuHanh, string dungLuongPin, ref string err)
        {
            string sqlString = "Update CHITIET_LAPTOP Set ManHinh = N'" + manHinh + "',Ram = N'" + ram +
                                "',OCung = N'" + oCung + "',Chip = '" + chip + "',HeDieuHanh = '" + 
                                heDieuHanh + "',DungLuongPin = '" + dungLuongPin + "' Where MaSP= N'" + maSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string maSP, ref string err)
        {
            string sqlString = "Delete From CHITIET_LAPTOP Where MaSP='" + maSP + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
