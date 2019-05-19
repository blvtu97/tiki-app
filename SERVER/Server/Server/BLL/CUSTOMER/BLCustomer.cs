using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.DAL;

namespace Server.BLL.CUSTOMER
{
    class BLCustomer
    {
        DBConnectDatabase db = null;
        public BLCustomer()
        {
            db = new DBConnectDatabase();
        }

        public DataSet GetData()
        {
            return db.ExecuteQueryDataSet("select * from CUSTOMER", CommandType.Text);
        }

        public bool Insert(string hoTen, string soDT, string email, string password, bool gioitinh,
                        DateTime ngaySinh, string thanhPho, string quanHuyen, string diaChi, ref string err)
        {
            string sqlString = "Insert Into CUSTOMER Values(" + "N'" + hoTen + "','" + soDT + "',N'" + email + "','" +
                                password + "','" + gioitinh + "','" + ngaySinh + "',N'" + thanhPho + "',N'" + quanHuyen + "',N'" + diaChi + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Update(string hoTen, string soDT, string email, string password, bool gioitinh,
                        DateTime ngaySinh, string thanhPho, string quanHuyen, string diaChi, ref string err)
        {
            string sqlString = "Update CUSTOMER Set HoTen = N'" + hoTen + "',Password = '" + password + "',SoDT = '" + soDT + "',GioiTinh = '" +
                                gioitinh + "',NgaySinh = '" + ngaySinh + "',TinhThanhPho = N'" + thanhPho + "',QuanHuyen = N'" + quanHuyen + "',DiaChi = N'" + diaChi + "' Where Email= N'" + email + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Delete(string email, ref string err)
        {
            string sqlString = "Delete From CUSTOMER Where Email='" + email + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
