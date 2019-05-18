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
namespace Server.GUI
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
        public bool Delete(string maSP, ref string err)
        {
            switch(dataManager)
            {
                case DataManager.PRODUCTSMARTPHONE:
                    return new BLProductSmart().Delete(maSP, maSP, ref err);
                case DataManager.DETAILSMARTPHONE:
                    return new BLDetailSmartPhone().Delete(maSP, ref err);
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    return new BLCategory_Smartphone_Tablet().Delete(maSP, ref err);

                case DataManager.PRODUCTLAPTOP:
                    return new BLProductLaptop().Delete(maSP, maSP, ref err);
                case DataManager.DETAILLAPTOP:
                    return new BLDetailLaptop().Delete(maSP, ref err);
                case DataManager.CATEGORY_LAPTOP:
                    return new BLCategory_Laptop().Delete(maSP, ref err);

                case DataManager.PRODUCTFASHION:
                    return new BLProductFashion().Delete(maSP, maSP, ref err);
                case DataManager.DETAILFASHION:
                    return new BLDetailFashion().Delete(maSP, ref err);
                case DataManager.CATEGORY_FASHION:
                    return new BLCategory_Fashion().Delete(maSP, ref err);

                case DataManager.PRODUCTCAR:
                    return new BLProductCar().Delete(maSP, maSP, ref err);
                case DataManager.DETAILCAR:
                    return new BLDetailCar().Delete(maSP, ref err);
                case DataManager.CATEGORY_CAR:
                    return new BLCategory_Car().Delete(maSP, ref err);

                case DataManager.PRODUCTBOOK:
                    return new BLProductBook().Delete(maSP, maSP, ref err);
                case DataManager.DETAILBOOK:
                    return new BLDetailBook().Delete(maSP, ref err);
                case DataManager.CATEGORY_BOOK:
                    return new BLCategory_Book().Delete(maSP, ref err);

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
