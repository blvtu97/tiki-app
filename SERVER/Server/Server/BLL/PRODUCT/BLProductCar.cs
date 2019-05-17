using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    class BLProductCar
    {
        DBConnectDatabase db = null;
        public BLProductCar()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from XE", CommandType.Text);
        }

        public bool Insert(string maSP, string tenSP, string thuongHieu, string loai,
                            float giaSP, float giaTT, int rate, string idImage,
                            byte[] image1, byte[] image2, byte[] image3, byte[] image4, DateTime ngayThem, ref string err)
        {
            //Inert image
            string sqlStringImg = "Insert Into HINHANH_XE(IdImage, Image1, Image2, Image3, Image4) VALUES (@id,@img1,@img2,@img3,@img4)";

            db.AddParameters("@id", SqlDbType.NChar, maSP);
            db.AddParameters("@img1", SqlDbType.Image, image1);
            db.AddParameters("@img2", SqlDbType.Image, image2);
            db.AddParameters("@img3", SqlDbType.Image, image3);
            db.AddParameters("@img4", SqlDbType.Image, image4);

            if (!db.MyExecuteNonQuery(sqlStringImg, CommandType.Text, ref err))
                return false;


            string sqlString = "Insert Into XE   Values(" + "N'" + maSP + "',N'" + tenSP + "',N'" + thuongHieu + "','" + loai
                               + "','" + giaSP + "','" + giaTT + "','" + rate + "','" + idImage + "','" + ngayThem + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string maSP, string tenSP, string thuongHieu, string loai,
                            float giaSP, float giaTT, int rate, string idImage,
                            byte[] image1, byte[] image2, byte[] image3, byte[] image4, DateTime ngayThem, ref string err)
        {
            string sqlStringImg = "UPDATE HINHANH_XE SET Image1=@img1,Image2=@img2,Image3=@img3,Image4=@img4 WHERE IdImage = @id";

            db.AddParameters("@id", SqlDbType.NChar, maSP);
            db.AddParameters("@img1", SqlDbType.Image, image1);
            db.AddParameters("@img2", SqlDbType.Image, image2);
            db.AddParameters("@img3", SqlDbType.Image, image3);
            db.AddParameters("@img4", SqlDbType.Image, image4);

            if (!db.MyExecuteNonQuery(sqlStringImg, CommandType.Text, ref err))
                return false;
            string sqlString = "Update XE Set TenSP = N'" + tenSP + "',ThuongHieu = N'" + thuongHieu + "',Loai = N'" + loai +
                                "',GiaSP = '" + giaSP + "',GiaTT = '" + giaTT + "',Rate = '" + rate + "',IdImage = N'" + idImage + "' Where MaSP= N'" + maSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string maSP, string idImage, ref string err)
        {
            string sqlString = "Delete From XE Where MaSP='" + maSP + "'";

            string sqlStringImg = "Delete From HINHANH_XE Where IdImage='" + idImage + "'";

            if (!db.MyExecuteNonQuery(sqlStringImg, CommandType.Text, ref err))
                return false;

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
