using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.DAL;
namespace Server.BLL
{
    class BLProductSmart
    {
        DBConnectDatabase db = null;
        public BLProductSmart()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from DIENTHOAI", CommandType.Text);
        }

        public bool Insert(string maSP, string tenSP, string thuongHieu,string loai,
                            float giaSP, float giaTT, int rate, string idImage, 
                            byte[] image1,byte[] image2, byte[] image3, byte[] image4, DateTime ngayThem, ref string err)
        {
            //Inert image
            string sqlStringImg = "Insert Into HINHANH_DIENTHOAI(IdImage, Image1, Image2, Image3, Image4) VALUES (@id,@img1,@img2,@img3,@img4)";

            db.AddParameters("@id", SqlDbType.NChar, maSP);
            db.AddParameters("@img1", SqlDbType.Image, image1);
            db.AddParameters("@img2", SqlDbType.Image, image2);
            db.AddParameters("@img3", SqlDbType.Image, image3);
            db.AddParameters("@img4", SqlDbType.Image, image4);

            if (!db.MyExecuteNonQuery(sqlStringImg, CommandType.Text, ref err))
                return false;


            string sqlString = "Insert Into DIENTHOAI Values(" + "N'" + maSP + "',N'" + tenSP + "',N'" + thuongHieu + "','" + loai
                               + "','" + giaSP + "','" + giaTT + "','" + rate + "','" + idImage + "','" + ngayThem + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string maSP, string tenSP, string thuongHieu, string loai,
                            float giaSP, float giaTT, int rate, string idImage,
                            byte[] image1, byte[] image2, byte[] image3, byte[] image4, DateTime ngayThem, ref string err)
        {
            string sqlStringImg = "UPDATE HINHANH_DIENTHOAI SET Image1=@img1,Image2=@img2,Image3=@img3,Image4=@img4 WHERE IdImage = @id";

            db.AddParameters("@id", SqlDbType.NChar, maSP);
            db.AddParameters("@img1", SqlDbType.Image, image1);
            db.AddParameters("@img2", SqlDbType.Image, image2);
            db.AddParameters("@img3", SqlDbType.Image, image3);
            db.AddParameters("@img4", SqlDbType.Image, image4);

            if (!db.MyExecuteNonQuery(sqlStringImg, CommandType.Text, ref err))
                return false;
            string sqlString = "Update DIENTHOAI Set TenSP = N'" + tenSP + "',ThuongHieu = N'" + thuongHieu + "',Loai = N'" + loai + 
                                "',GiaSP = '" + giaSP + "',GiaTT = '" + giaTT + "',Rate = '" + rate + "',IdImage = N'" + idImage + "' Where MaSP= N'" + maSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string maSP, string idImage, ref string err)
        {
            string sqlString = "Delete From DIENTHOAI Where MaSP='" + maSP + "'";

            string sqlStringImg = "Delete From HINHANH_DIENTHOAI Where IdImage='" + idImage + "'";

            // Delete to HINHANH_SANPHAM
            if (!db.MyExecuteNonQuery(sqlStringImg, CommandType.Text, ref err))
                return false;

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
