using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL.CUSTOMER
{
    class BLDetailBill
    {
        DBConnectDatabase db = null;
        public BLDetailBill()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from CHITIET_HOADON", CommandType.Text);
        }

        public bool Insert(string maSP, string khachHang, DateTime ngayMua, int soLuong, ref string err)
        {
            string sqlString = "Insert Into CHITIET_HOADON Values(" + "N'" + maSP + "','" + khachHang + "','"
                                + ngayMua + "','" + soLuong + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string maSP, string khachHang, int soLuong, ref string err)
        {
            string sqlString = "Update CHITIET_HOADON Set SoLuong = '" + soLuong +
                                "' Where MaSP= N'" + maSP + "'and KhachHang ='" + khachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string maSP, string khachHang, ref string err)
        {
            string sqlString = "Delete From CHITIET_HOADON Where MaSP = N'" + maSP + "'and KhachHang ='" + khachHang + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
