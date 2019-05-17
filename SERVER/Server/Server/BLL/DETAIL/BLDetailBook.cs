using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    class BLDetailBook
    {
        DBConnectDatabase db = null;
        public BLDetailBook()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from CHITIET_SACH", CommandType.Text);
        }

        public bool Insert(string maSP, string nxb, DateTime ngayXB, int soTrang, string loaiBia, string dichGia, ref string err)
        {
            string sqlString = "Insert Into CHITIET_SACH Values(" + "N'" + maSP + "',N'" + nxb + "',N'"
                                + ngayXB + "','" + soTrang + "','" + loaiBia + "','" + dichGia + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string maSP, string nxb, DateTime ngayXB, int soTrang, string loaiBia, string dichGia, ref string err)
        {
            string sqlString = "Update CHITIET_SACH Set NhaXB = N'" + nxb + "',NgayXB = '" + ngayXB + "',SoTrang = N'" +
                                soTrang + "',LoaiBia = '" + loaiBia + "',DichGia = '" + dichGia + "' Where MaSP= N'" + maSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string maSP, ref string err)
        {
            string sqlString = "Delete From CHITIET_SACH Where MaSP='" + maSP + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
