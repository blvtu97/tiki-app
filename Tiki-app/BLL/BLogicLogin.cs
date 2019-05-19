using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Tiki_app.DAL;
using Tiki_app.DTO;

namespace Tiki_app.BLL
{
    public class BLogicLogin
    {
        private DataConnector connector;

        public BLogicLogin()
        {
            connector = DataConnector.getInstance();
        }

        /// <summary>
        /// This is the method that requires the DAL layer to get data from the system, 
        /// then use the obtained data to process the login request from Login tier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pass"></param>
        /// <returns>true if login success, else false</returns>
        public Customer LoginSuccess(string id, string pass, ref bool flag)
        {
            Customer cus = null;
            try
            {
                connector.Connect();
                DataTable dt = connector.GetTable("CUSTOMER", ref flag);
                //DataTable dt = connector.getDataTable("CUSTOMER");
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i][1].ToString().Trim().Equals(id) ||
                        dt.Rows[i][2].ToString().Trim().Equals(id))
                    {
                        if (dt.Rows[i][3].ToString().Trim().Equals(pass))
                        {
                            cus = new Customer();
                            cus.HoTen = dt.Rows[i][0].ToString().Trim();
                            cus.DienThoai = dt.Rows[i][1].ToString().Trim();
                            cus.DiaChiEmail = dt.Rows[i][2].ToString().Trim();
                            cus.MatKhau = dt.Rows[i][3].ToString().Trim();
                            cus.sex = (bool)dt.Rows[i][4];
                            cus.NgaySinh = dt.Rows[i][5].ToString();
                            cus.TinhThanhPho = dt.Rows[i][6].ToString();
                            cus.QuanHuyen = dt.Rows[i][7].ToString();
                            cus.DiaChi = dt.Rows[i][8].ToString();
                            return cus;
                        }
                    }

                }
                //connector.CloseConnection();
                flag = true;
            }catch
            {
                flag = false;
            }
            return cus;
        }

        public bool UpdateInfoCustomer(Customer customer)
        {
            string query =
                "UPDATE CUSTOMER SET HoTen = " +
                "N'" + customer.HoTen + "'" +
                ",SoDT = '" + customer.DienThoai + "'" +
                ",Email = '" + customer.DiaChiEmail + "'" +
                ",GioiTinh = '" + customer.sex + "'" +
                ",NgaySinh = '" + customer.NgaySinh + "'" +
                ",TinhThanhPho = N'" + customer.TinhThanhPho + "'" +
                ",QuanHuyen = N'" + customer.QuanHuyen + "'" +
                ",DiaChi = N'" + customer.DiaChi + "'" +
                " WHERE SoDT = '" + customer.DienThoai + "'" + " AND " +
                "Email = '" + customer.DiaChiEmail + "'";

            bool temp = connector.MyExcuteNonquery(query);
            connector.CloseConnection();
            return temp;
        }

        public bool AddCustomer(Customer customer)
        {
            string query =
               "INSERT INTO CUSTOMER VALUES(N'"
               + customer.HoTen + "'" +
               ",'" + customer.DienThoai + "'" +
               ",'" + customer.DiaChiEmail + "'" +
               ",'" + customer.MatKhau+"'"+
               ",'" + customer.sex + "'" +
               ",'" + customer.NgaySinh + "'" +
               ",N'" + customer.TinhThanhPho + "'" +
               ",N'" + customer.QuanHuyen + "'" +
               ",N'" + customer.DiaChi + "')";

            bool temp = connector.MyExcuteNonquery(query);
            connector.CloseConnection();
            return temp;
        }

    }
}
