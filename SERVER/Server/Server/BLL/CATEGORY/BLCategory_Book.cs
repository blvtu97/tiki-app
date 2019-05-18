using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL.CATEGORY
{
    class BLCategory_Book
    {
        DBConnectDatabase db = null;
        public BLCategory_Book()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from CATEGORY_SACH", CommandType.Text);
        }

        public bool Insert(string loai, byte[] img, ref string err)
        {
            string sqlString = "Insert Into CATEGORY_SACH(Loai, Image) VALUES (@id,@img)";
            db.AddParameters("@id", SqlDbType.NChar, loai);
            db.AddParameters("@img", SqlDbType.Image, img);
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string loai, byte[] img, ref string err)
        {
            string sqlString = "UPDATE CATEGORY_SACH SET Image=@img WHERE Loai = @id";
            db.AddParameters("@id", SqlDbType.NChar, loai);
            db.AddParameters("@img", SqlDbType.Image, img);
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string loai, ref string err)
        {
            string sqlString = "Delete From CATEGORY_SACH Where Loai='" + loai + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
