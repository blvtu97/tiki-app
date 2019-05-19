using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Server.BLL;
using System.Drawing;
using System.IO;
using Server.BLL.CATEGORY;
using Server.BLL.CUSTOMER;

namespace Server.DTO
{
    class OnClickListener
    {
        //DataTable table;
        private DataManager dataManager;
        //private List<Control> controls;
        public OnClickListener(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        #region Group Instruction Insert Data
        // Insert for table PRODUCT
        public bool Insert(string maSP, string tenSP, string thuongHieu, string loai,
                            string giaSP, string giaTT, string rate, string idImage,
                            Image image1, Image image2, Image image3, Image image4, DateTime ngayThem, ref string err)
        {
            float giaSanPham, giaThiTruong;
            try
            {
                giaSanPham = float.Parse(giaSP);
            }
            catch (Exception)
            {
                err = "Giá Trị GiaSP Không Đúng, Vui Lòng Nhập Lại";
                return false;
            }
            try
            {
                giaThiTruong = float.Parse(giaTT);
            }
            catch (Exception)
            {
                err = "Giá Trị GiaTT Không Đúng, Vui Lòng Nhập Lại";
                return false;
            }

            List<Image> fromFile = new List<Image>() { image1, image2, image3, image4 };
            List<byte[]> imgs = new List<byte[]>();
            foreach(Image i in fromFile)
            {
                MemoryStream ms = new MemoryStream();
                try
                {
                    i.Save(ms, i.RawFormat);
                }
                catch
                {
                    Properties.Resources.noimage.Save(ms, Properties.Resources.noimage.RawFormat);
                }
                imgs.Add(ms.ToArray());
            }

            switch (dataManager)
            {
                case DataManager.PRODUCTSMARTPHONE:
                    return new BLProductSmart().Insert(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);
                case DataManager.PRODUCTLAPTOP:
                    return new BLProductLaptop().Insert(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);

                case DataManager.PRODUCTFASHION:
                    return new BLProductFashion().Insert(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);

                case DataManager.PRODUCTCAR:
                    return new BLProductCar().Insert(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);

                case DataManager.PRODUCTBOOK:
                    return new BLProductBook().Insert(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);
            }
            return false;
        }
       
        // Insert for table DetailSmartphone
        public bool Insert(string maSP, string manHinh, string camTruoc, string camSau,
                            bool flash, string ram, string chip, string heDieuHanh,
                            string dungLuongPin, string sim, string ketNoi, bool NFC, bool FM, ref string err)
        {
            float value;
            try
            {
                value = float.Parse(manHinh);
            }
            catch
            {
                err = "Thông Số Màn Hình Là Kiểu Số Thực, Tính Theo Đơn Vị Inch!!!";
                return false;
            }
            return new BLDetailSmartPhone().Insert(maSP, value, camTruoc, camSau, flash, ram, chip, heDieuHanh,
                                                    dungLuongPin, sim, ketNoi, NFC, FM, ref err);
        }

        // Insert for table DetailLaptop
        public bool Insert(string maSP, string manHinh, string ram, string oCung, string chip, string heDieuHanh, string dungLuongPin, ref string err)
        {
            return new BLDetailLaptop().Insert(maSP, manHinh, ram, oCung, chip, heDieuHanh, dungLuongPin, ref err);
        }

        // Insert for table DetailFashion
        public bool Insert(string maSP, string mauSac, string size, string kieuDang, string chatLieu, ref string err)
        {
            return new BLDetailFashion().Insert(maSP, mauSac, size, kieuDang, chatLieu, ref err);
        }

        // Insert for Table DetailCar
        public bool Insert(string maSP, string mau,string dungTichXang,int dungTichXiLanh,string loai,ref string err)
        {
            float value;
            try
            {
                value = float.Parse(dungTichXang);
            }
            catch
            {
                err = "Dung Tích Xăng Là Kiểu Số Thực!!!";
                return false;
            }
            return new BLDetailCar().Insert(maSP, mau, value, dungTichXiLanh, loai, ref err);
        }

        // Insert Customer
        public bool Insert(string hoTen, string soDT, string email, string password, bool gioitinh,
                DateTime ngaySinh, string thanhPho, string quanHuyen, string diaChi, ref string err)
        {
            return new BLCustomer().Insert(hoTen, soDT, email, password, gioitinh, ngaySinh, thanhPho, quanHuyen, diaChi, ref err);
        }

        // Insert Bill
        public bool Insert(string maSP, string khachHang, DateTime ngayMua, string soLuong, ref string err)
        {
            int value;
            try
            {
                value = int.Parse(soLuong);
            }
            catch
            {
                err = "Số Lượng Không Đúng!";
                return false;
            }
            return new BLDetailBill().Insert(maSP, khachHang, ngayMua, value, ref err);
        }

        // Insert Comment
        public bool Insert(string maSP, string khachHang, DateTime ngayComment, string noiDung, int rate, ref string err)
        {
            return new BLComment().Insert(maSP, khachHang, ngayComment, noiDung, rate, ref err);
        }

        // Insert for Table DetailBook
        public bool Insert(string maSP, string nhaXB, DateTime ngayXB, string soTrang, string loaiBia, string dichGia, ref string err)
        {
            int value;
            try
            {
                value = int.Parse(soTrang);
            }
            catch
            {
                err = "Số Trang Là Một Số Nguyên Dương!!!";
                return false;
            }
            return new BLDetailBook().Insert(maSP, nhaXB, ngayXB, value, loaiBia, dichGia, ref err);
        }

        // Insert for table Catagory 
        public bool Insert(string loai, Image img, ref string err)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                img.Save(ms, img.RawFormat);
            }
            catch
            {
                Properties.Resources.noimage.Save(ms, Properties.Resources.noimage.RawFormat);
            }
            switch (dataManager)
            {
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    return new BLCategory_Smartphone_Tablet().Insert(loai.Trim(), ms.ToArray(), ref err);

                case DataManager.CATEGORY_LAPTOP:
                    return new BLCategory_Laptop().Insert(loai.Trim(), ms.ToArray(), ref err);

                case DataManager.CATEGORY_FASHION:
                    return new BLCategory_Fashion().Insert(loai.Trim(), ms.ToArray(), ref err);

                case DataManager.CATEGORY_CAR:
                    return new BLCategory_Car().Insert(loai.Trim(), ms.ToArray(), ref err);

                case DataManager.CATEGORY_BOOK:
                    return new BLCategory_Book().Insert(loai.Trim(), ms.ToArray(), ref err);
            }
            return false;
        }
        #endregion

        #region Group Instruction Update Data
        // Update for table Product
        public bool Update(string maSP, string tenSP, string thuongHieu, string loai,
                            string giaSP, string giaTT, string rate, string idImage,
                            Image image1, Image image2, Image image3, Image image4, DateTime ngayThem, ref string err)
        {

            float giaSanPham, giaThiTruong;
            try
            {
                giaSanPham = float.Parse(giaSP);
            }
            catch (Exception)
            {
                err = "Giá Trị GiaSP Không Đúng, Vui Lòng Nhập Lại";
                return false;
            }
            try
            {
                giaThiTruong = float.Parse(giaTT);
            }
            catch (Exception)
            {
                err = "Giá Trị GiaTT Không Đúng, Vui Lòng Nhập Lại";
                return false;
            }

            List<Image> fromFile = new List<Image>() { image1, image2, image3, image4 };
            List<byte[]> imgs = new List<byte[]>();
            foreach (Image i in fromFile)
            {
                MemoryStream ms = new MemoryStream();
                try
                {
                    i.Save(ms, i.RawFormat);
                }
                catch
                {
                    Properties.Resources.noimage.Save(ms, Properties.Resources.noimage.RawFormat);
                }
                imgs.Add(ms.ToArray());
            }
            switch (dataManager)
            {
                case DataManager.PRODUCTSMARTPHONE:
                    return new BLProductSmart().Update(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);
                case DataManager.PRODUCTLAPTOP:
                    return new BLProductLaptop().Update(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);

                case DataManager.PRODUCTFASHION:
                    return new BLProductFashion().Update(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);

                case DataManager.PRODUCTCAR:
                    return new BLProductCar().Update(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);

                case DataManager.PRODUCTBOOK:
                    return new BLProductBook().Update(maSP, tenSP, thuongHieu, loai, giaSanPham, giaThiTruong, int.Parse(rate),
                                            idImage, imgs[0], imgs[1], imgs[2], imgs[3], ngayThem, ref err);
            }
            return false;
        }

        // Update for table DetailLaptop
        public bool Update(string maSP, string manHinh, string ram, string oCung, string chip, string heDieuHanh, string dungLuongPin, ref string err)
        {

            return new BLDetailLaptop().Update(maSP, manHinh, ram, oCung, chip, heDieuHanh, dungLuongPin, ref err);
        }

        // Update for table DetailSmartphone
        public bool Update(string maSP, string manHinh, string camTruoc, string camSau,
                            bool flash, string ram, string chip, string heDieuHanh,
                            string dungLuongPin, string sim, string ketNoi, bool NFC, bool FM, ref string err)
        {
            float value;
            try
            {
                value = float.Parse(manHinh);
            }
            catch
            {
                err = "Thông Số Màn Hình Là Kiểu Số Thực, Tính Theo Đơn Vị Inch!!!";
                return false;
            }
            return new BLDetailSmartPhone().Update(maSP, value, camTruoc, camSau, flash, ram, chip, heDieuHanh, 
                                                    dungLuongPin, sim, ketNoi, NFC, FM, ref err);
        }

        // Update for table DetailFashion
        public bool Update(string maSP, string mauSac, string size, string kieuDang, string chatLieu, ref string err)
        {
            return new BLDetailFashion().Update(maSP, mauSac, size, kieuDang, chatLieu, ref err);
        }

        // Update for Table DetailCar
        public bool Update(string maSP, string mau, string dungTichXang, int dungTichXiLanh, string loai, ref string err)
        {
            float value;
            try
            {
                value = float.Parse(dungTichXang);
            }
            catch
            {
                err = "Dung Tích Xăng Là Kiểu Số Thực!!!";
                return false;
            }
            return new BLDetailCar().Update(maSP, mau, value, dungTichXiLanh, loai, ref err);
        }

        // Update for Table DetailBook
        public bool Update(string maSP, string nhaXB, DateTime ngayXB, string soTrang, string loaiBia, string dichGia, ref string err)
        {
            int value;
            try
            {
                value = int.Parse(soTrang);
            }
            catch
            {
                err = "Số Trang Là Một Số Nguyên Dương!!!";
                return false;
            }
            return new BLDetailBook().Update(maSP, nhaXB, ngayXB, value, loaiBia, dichGia, ref err);
        }

        // Update Customer
        public bool Update(string hoTen, string soDT, string email, string password, bool gioitinh,
                        DateTime ngaySinh, string thanhPho, string quanHuyen, string diaChi, ref string err)
        {
            return new BLCustomer().Update(hoTen, soDT, email, password, gioitinh, ngaySinh, thanhPho, quanHuyen, diaChi, ref err);
        }

        // Update Bill
        public bool Update(string maSP, string khachHang, string soLuong, ref string err)
        {
            int value;
            try
            {
                value = int.Parse(soLuong);
            }
            catch
            {
                err = "Số Lượng Không Đúng!";
                return false;
            }
            return new BLDetailBill().Update(maSP, khachHang, value, ref err);
        }

        // Update Comment
        public bool Update(string maSP, string khachHang, DateTime ngayComment, string noiDung, int rate, ref string err)
        {
            return new BLComment().Update(maSP, khachHang, ngayComment, noiDung, rate, ref err);
        }

        // Update for table Catagory 
        public bool Update(string loai,Image img, ref string err)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                img.Save(ms, img.RawFormat);
            }
            catch
            {
                Properties.Resources.noimage.Save(ms, Properties.Resources.noimage.RawFormat);
            }
            switch (dataManager)
            {
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    return new BLCategory_Smartphone_Tablet().Update(loai.Trim(), ms.ToArray(), ref err);

                case DataManager.CATEGORY_LAPTOP:
                    return new BLCategory_Laptop().Update(loai.Trim(), ms.ToArray(), ref err);

                case DataManager.CATEGORY_FASHION:
                    return new BLCategory_Fashion().Update(loai.Trim(), ms.ToArray(), ref err);

                case DataManager.CATEGORY_CAR:
                    return new BLCategory_Car().Update(loai.Trim(), ms.ToArray(), ref err);

                case DataManager.CATEGORY_BOOK:
                    return new BLCategory_Book().Update(loai.Trim(), ms.ToArray(), ref err);
            }
            return false;
        }
        #endregion

        #region Group Instruction Delete Data
        public bool Delete(string key, ref string err)
        {
            switch(dataManager)
            {
                case DataManager.PRODUCTSMARTPHONE:
                    return new BLProductSmart().Delete(key, key, ref err);
                case DataManager.DETAILSMARTPHONE:
                    return new BLDetailSmartPhone().Delete(key, ref err);
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    return new BLCategory_Smartphone_Tablet().Delete(key, ref err);

                case DataManager.PRODUCTLAPTOP:
                    return new BLProductLaptop().Delete(key, key, ref err);
                case DataManager.DETAILLAPTOP:
                    return new BLDetailLaptop().Delete(key, ref err);
                case DataManager.CATEGORY_LAPTOP:
                    return new BLCategory_Laptop().Delete(key, ref err);

                case DataManager.PRODUCTFASHION:
                    return new BLProductFashion().Delete(key, key, ref err);
                case DataManager.DETAILFASHION:
                    return new BLDetailFashion().Delete(key, ref err);
                case DataManager.CATEGORY_FASHION:
                    return new BLCategory_Fashion().Delete(key, ref err);

                case DataManager.PRODUCTCAR:
                    return new BLProductCar().Delete(key, key, ref err);
                case DataManager.DETAILCAR:
                    return new BLDetailCar().Delete(key, ref err);
                case DataManager.CATEGORY_CAR:
                    return new BLCategory_Car().Delete(key, ref err);

                case DataManager.PRODUCTBOOK:
                    return new BLProductBook().Delete(key, key, ref err);
                case DataManager.DETAILBOOK:
                    return new BLDetailBook().Delete(key, ref err);
                case DataManager.CATEGORY_BOOK:
                    return new BLCategory_Book().Delete(key, ref err);

                case DataManager.CUSTOMER:
                    return new BLCustomer().Delete(key, ref err);

                default:
                    err = "Không Có Thông Tin Của Bảng Dữ Liệu";
                    return false;

            }
        }

        // Detele Bill, Comment
        public bool Delete(string maSP, string khachHang, ref string err)
        {
            switch(dataManager)
            {
                case DataManager.DETAILBILL:
                    return new BLDetailBill().Delete(maSP, khachHang, ref err);
                case DataManager.COMMENT:
                    return new BLComment().Delete(maSP, khachHang, ref err);
                default:
                    err = "Không Có Thông Tin Của Bảng Dữ Liệu";
                    return false;
            }
        }
        #endregion

        // Send To Database Lastest
        public DataTable Reload()
        {
            switch(dataManager)
            {
                case DataManager.CUSTOMER:
                    return new BLCustomer().GetData().Tables[0];
                case DataManager.COMMENT:
                    return new BLComment().GetData().Tables[0];
                case DataManager.DETAILBILL:
                    return new BLDetailBill().GetData().Tables[0];

                case DataManager.PRODUCTSMARTPHONE:
                    return new BLProductSmart().GetData().Tables[0];
                case DataManager.DETAILSMARTPHONE:
                    return new BLDetailSmartPhone().GetData().Tables[0];
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    return new BLCategory_Smartphone_Tablet().GetData().Tables[0];

                case DataManager.PRODUCTLAPTOP:
                    return new BLProductLaptop().GetData().Tables[0];
                case DataManager.DETAILLAPTOP:
                    return new BLDetailLaptop().GetData().Tables[0];
                case DataManager.CATEGORY_LAPTOP:
                    return new BLCategory_Laptop().GetData().Tables[0];

                case DataManager.PRODUCTFASHION:
                    return new BLProductFashion().GetData().Tables[0];
                case DataManager.DETAILFASHION:
                    return new BLDetailFashion().GetData().Tables[0];
                case DataManager.CATEGORY_FASHION:
                    return new BLCategory_Fashion().GetData().Tables[0];

                case DataManager.PRODUCTCAR:
                    return new BLProductCar().GetData().Tables[0];
                case DataManager.DETAILCAR:
                    return new BLDetailCar().GetData().Tables[0];
                case DataManager.CATEGORY_CAR:
                    return new BLCategory_Car().GetData().Tables[0];

                case DataManager.PRODUCTBOOK:
                    return new BLProductBook().GetData().Tables[0];
                case DataManager.DETAILBOOK:
                    return new BLDetailBook().GetData().Tables[0];
                case DataManager.CATEGORY_BOOK:
                    return new BLCategory_Book().GetData().Tables[0];

                default:
                    MessageBox.Show("Not Found");
                    return null;
            }
        }
    }
}
