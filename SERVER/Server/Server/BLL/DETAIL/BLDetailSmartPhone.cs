using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.DAL;
namespace Server.BLL
{
    class BLDetailSmartPhone
    {
        DBConnectDatabase db = null;
        public BLDetailSmartPhone()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from CHITIET_DIENTHOAI", CommandType.Text);
        }

        public bool Insert(string maSP, float manHinh, string camTruoc, string camSau,
                            bool flash, string ram, string chip, string heDieuHanh,
                            string dungLuongPin, string sim, string ketNoi, bool NFC, bool FM, ref string err)
        {
            string sqlString = "Insert Into CHITIET_DIENTHOAI Values(" + "N'" + maSP + "',N'" + manHinh + "',N'" + camTruoc + "','" + camSau
                               + "','" + flash + "','" + ram + "','" + chip + "','" + heDieuHanh + "','" + dungLuongPin + "','" + sim + "','" 
                               + ketNoi + "','" + NFC + "','" + FM + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string maSP, float manHinh, string camTruoc, string camSau,
                            bool flash, string ram, string chip, string heDieuHanh,
                            string dungLuongPin, string sim, string ketNoi, bool NFC, bool FM, ref string err)
        {
            string sqlString = "Update CHITIET_DIENTHOAI Set ManHinh = '" + manHinh + "',CameraTruoc = N'" + camTruoc + "',CameraSau = N'" + camSau + "',Flash = '" + flash +
                                "',Ram = N'" + ram + "',Chip = N'" + chip + "',HeDieuHanh = N'" + heDieuHanh + "',DungLuongPin = N'" + dungLuongPin + 
                                "',Sim = N'" + sim + "',KetNoi = N'" + ketNoi + "',NFC = '" + NFC + "',FM = '" + FM + "' Where MaSP= N'" + maSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string maSP, ref string err)
        {
            string sqlString = "Delete From CHITIET_DIENTHOAI Where MaSP='" + maSP + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
