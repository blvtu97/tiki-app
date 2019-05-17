using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    class BLDetailCar
    {
        DBConnectDatabase db = null;
        public BLDetailCar()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from CHITIET_XE", CommandType.Text);
        }

        public bool Insert(string maSP, string mau, float dungTichxang, int dungTichXilanh, string loai, ref string err)
        {
            string sqlString = "Insert Into CHITIET_XE Values(" + "N'" + maSP + "',N'" + mau + "',N'"
                                + dungTichxang + "','" + dungTichXilanh + "','" + loai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string maSP, string mau, float dungTichxang, int dungTichXilanh, string loai, ref string err)
        {
            string sqlString = "Update CHITIET_XE Set Mau = N'" + mau + "',DungTichXang = '" + dungTichxang + "',DungTichXiLanh = '" +
                                dungTichXilanh + "',Loai = N'" + loai + "' Where MaSP= N'" + maSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string maSP, ref string err)
        {
            string sqlString = "Delete From CHITIET_XE Where MaSP='" + maSP + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
