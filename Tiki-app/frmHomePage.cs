using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Tiki_app.BLL;
using Tiki_app.DTO;
using Tiki_app.Utils;
using Tiki_app.GUI;

namespace Tiki_app
{
    public partial class frmHomePage : Form, VIEW.OnClickListener, VIEW.OnChangeListener
    {
        List<SanPham> productsViewHistory = new List<SanPham>();

        SanPham sanPhamCurrent;

        tabNews tabs;

        bool done = false;

        List<SanPham> vax;

        object obj;

        private DataManager dataManager = DataManager.getInstance();

        private BillManager billManager = BillManager.getInstance();

        public frmHomePage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            initializeViews();
            initializeData();
        }

        /// <summary>
        /// Hàm đăng kí sự kiện cho các controls
        /// </summary>
        private void initializeViews()
        {
            pageProducts.setOnClickListener(this);
            pageDetailsProducts.TabChooseToBuy.setOnClickListener(this);
            pagePayProducts.TabOrder.setOnClickListener(this);
            pageNoProducts.setOnClickListener(this);
            tabInfoCustomer.setOnClickListener(this);
            tabInfoCustomer.setOnClickListener(this);
            tabChoosePayMethod.setOnClickListener(this);           
        }

        /// <summary>
        /// Sự kiện onClick
        /// </summary>
        /// <param name="sender"></param>
        public void onClick(VIEW view)
        {
            if (view.getID() == R.layout.CATEGORY_SAMPLES)
            {
                vax = dataManager.findProductFollowCategory(((tabCategorySamples)view.obj).danhMuc.Loai);
                asyncShowProductTask(view.obj);
            }
            else if (view.getID() == R.layout.PRODUCT_SAMPLES)
            {
                showDetailsProducts(view.obj);
            }
            else if (view.getID() == R.layout.TAB_GOOD)
            {
                if (((tabGood)view.obj).isRemove)
                    billManager.deleteBill(((tabGood)view.obj).sanPham);
                updateBill(true);
            }
            else if (view.getID() == R.layout.TAB_ORDER)
            {
                orderChoosedBillList();
            }

            else if (view.getID() == R.id.FILTER_PRICE_LOW_TO_HIGTH)
            {
                showPriceProductLowToHight(view.obj);
            }
            else if (view.getID() == R.id.FILTER_PRICE_HIGH_TO_LOW)
            {
                showPriceProductHightToLow(view.obj);
            }
            else if (view.getID() == R.id.CHOOSE_TO_BUY_PRODUCT)
            {
                buyChoosedProduct();
            }
            else if (view.getID() == R.id.CHOOSE_HOME_PAGE)
            {
                pageProducts.BringToFront();
            }
            else if (view.getID() == R.id.CONFIRM_INFO_CUSTOMER)
            {
                tabChoosePayMethod.BringToFront();
            }
            else if (view.getID() == R.id.CHOOSE_PAY_METHOD_BUY)
            {
                tabThankyou1.BringToFront();
            }
            else if (view.getID() == R.id.CHOOSE_HOME_PAGE)
            {
                pageProducts.BringToFront();
            }
        }

        /// <summary>
        /// Hàm xử lý bất đồng bộ khi lọc danh sách các sản phẩm theo yêu cầu, worker thread
        /// là nơi cập nhật dữ liệu, main thread chạy progress bar
        /// </summary>
        /// <param name="sender">tab sản phẩm cần hiển thị</param>
        private void asyncShowProductTask(object sender)
        {
            if (dataManager.tabFilterProducts.ContainsKey(sender))
            {
                tabNews temp = null;
                dataManager.tabFilterProducts.TryGetValue(sender, out temp);
                temp.BringToFront();
                temp.Focus();
            }
            else
            {
                obj = sender;
                Thread thread = new Thread(new ThreadStart(threadAddData));
                thread.Start();
                showCircleProgress();
            }
        }

        /// <summary>
        /// Thread dùng để cập nhật dữ liệu theo loại sản phẩm
        /// </summary>
        private void threadAddData()
        {
            createProductFollowCategory(obj, vax);
        }

        /// <summary>
        /// Hàm khởi tạo giao diện sản phẩm, và loại sản phẩm
        /// </summary>
        private void initializeData()
        {
            createProducts(pageProducts.TabProducts, dataManager.listProduct);
            createCategory(pageProducts.TabCategory, dataManager.listCategory);
        }

        /// <summary>
        /// Hàm tạo giao diện sản phẩm
        /// </summary>
        /// <param name="tabProducts">Tab để hiển thị hình ảnh</param>
        /// <param name="listProduct">Danh sách sản phẩm</param>
        private void createProducts(tabNews tabProducts, List<SanPham> listProduct)
        {
            Point pointOld = new Point(15, 20);
            int newLine = 0;
            for (int i = 0; i < listProduct.Count; i++)
            {
                SanPham u = listProduct[i];
                tabProductSamples product = new tabProductSamples(u)
                {
                    Location = pointOld,
                };
                product.setOnClickListener(this);
                newLine++;
                if (newLine > 3)
                {
                    newLine = 0;
                    pointOld = new Point(15, pointOld.Y + 360);
                }
                else
                {
                    pointOld = new Point(pointOld.X + 250, pointOld.Y);

                }
                tabProducts.Controls.Add(product);
            }

        }

        /// <summary>
        /// Hàm tạo giao diện loại sản phẩm
        /// </summary>
        /// <param name="tabCategory">Tab để hiển thị loại thư mục</param>
        /// <param name="listCategory">Danh sách thư mục</param>
        private void createCategory(tabNews tabCategory, List<DanhMucSanPham> listCategory)
        {
            Point pointOld = new Point(37, 7);
            for (int i = 0; i < listCategory.Count; i++)
            {
                DanhMucSanPham u = listCategory[i];
                tabCategorySamples category = new tabCategorySamples(u)
                {
                    Location = pointOld,
                };
                category.setOnClickListener(this);
                pointOld = new Point(pointOld.X + 252, pointOld.Y);
                tabCategory.Controls.Add(category);
            }

        }

        /// <summary>
        /// Hàm hiển thị thông tin chi tiết sản phẩm
        /// </summary>
        /// <param name="sender">Sản phẩm cần hiển thị</param>
        private void showDetailsProducts(object sender)
        {
            tabProductSamples product = sender as tabProductSamples;
            sanPhamCurrent = product.sanPham;
            if (!(productsViewHistory.Exists(p => p.MaSP == product.sanPham.MaSP)))
            {
                sanPhamCurrent = product.sanPham;
                productsViewHistory.Add(product.sanPham);
            }
            else
            {
                sanPhamCurrent = productsViewHistory.Find(p => p.MaSP == product.sanPham.MaSP);
            }
            pageDetailsProducts.attachInfoProduct(product.sanPham);
            saveViewHistory();
            pageDetailsProducts.TabChooseToBuy.CountProduct = "0";
            pageDetailsProducts.BringToFront();
        }

        /// <summary>
        /// Hàm tạo giao diện cho lịch sử xem sản phẩm của người dùng
        /// </summary>
        private void saveViewHistory()
        {
            Point pointOld = new Point(15, 20);
            for (int i = 0; i < productsViewHistory.Count; i++)
            {
                tabProductSamples product = new tabProductSamples(productsViewHistory[i])
                {
                    Location = pointOld,
                };
                pageProducts.TabProductsSeen.Controls.Add(product);
                product.setOnClickListener(this);
                pointOld = new Point(pointOld.X + 250, pointOld.Y);
            }
        }


        /// <summary>
        /// Hàm tiến hành đặt hàng, sau khi hàm nãy được gọi, nếu tồn tại đơn đặt hàng
        /// ứng dụng sẽ chuyển sang tab điền thông tin người dùng
        /// </summary>
        void orderChoosedBillList()
        {
            if (billManager.countBill() > 0)
            {
                tabInfoCustomer.BringToFront();
            }
            else
            {
                lbCountProduct.Visible = false;
                pageNoProducts.BringToFront();
            }
        }

        void ButtonContinue_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Hàm tạo giao diện những sản phẩm đã mua của người dùng
        /// </summary>
        private void createProductsPurchased()
        {
            Point pointOld = new Point(0, 0);
            for (int i = 0; i < billManager.billList.Count; i++)
            {
                tabGood product = new tabGood(billManager.billList[i])
                {
                    Location = pointOld,
                }; ;
                product.setOnChangeListener(this);
                product.setOnClickListener(this);
                pagePayProducts.TabProducts.Controls.Add(product);
                pointOld = new Point(pointOld.X, pointOld.Y + 118);
            }
        }

        /// <summary>
        /// Hàm cập nhật lại hóa đơn sản phẩm đã mua của người dùng
        /// </summary>
        public void updateBill(bool draw)
        {
            if (draw)
            {
                pagePayProducts.TabProducts.Controls.Clear();
                createProductsPurchased();
                pagePayProducts.TabProducts.Invalidate();
            }
            lbCountProduct.Text = billManager.countBill().ToString();
            pagePayProducts.TabOrder.PriceTemporary = billManager.totalBill() + "đ";
            pagePayProducts.TabOrder.PriceReal = billManager.totalBill() + "đ";

        }

        /// <summary>
        /// Hàm tiến hành gọi mua một sản phẩm
        /// </summary>
        private void buyChoosedProduct()
        {
            int count = Convert.ToInt32(pageDetailsProducts.TabChooseToBuy.CountProduct);
            if (billManager.existBill(sanPhamCurrent))
            {
                sanPhamCurrent.Count += count;
                updateBill(true);
            }
            else if (count > 0)
            {
                sanPhamCurrent.Count = count;
                billManager.addBill(sanPhamCurrent);
                lbCountProduct.Text = billManager.countBill().ToString();
                lbCountProduct.Visible = true;
                createProductsPurchased();
            }
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            pageNews.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            lblmain.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            lblmain.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            pageProducts.BringToFront();
        }

        private void tab3_Click(object sender, EventArgs e)
        {
            pageNews.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            lblmain.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }

        private void tab4_Click(object sender, EventArgs e)
        {
            pageNews.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            lblmain.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }

        private void tab5_Click(object sender, EventArgs e)
        {
            pageNews.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            lblmain.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }

        /// <summary>
        /// Hàm xem danh sách những hóa đơn được mua của người dùng
        /// </summary>
        private void showProductPurchased()
        {
            if (billManager.countBill() > 0)
            {
                updateBill(false);
                createProductsPurchased();
                pagePayProducts.BringToFront();
            }
            else
            {
                pageNoProducts.BringToFront();
            }
        }

        /// <summary>
        /// Hàm chạy progressbar để cập nhật giao diện
        /// </summary>
        private void showCircleProgress()
        {
            circleProgress.Visible = true;
            circleProgress.animated = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (done)
            {
                timer.Stop();
                circleProgress.Visible = false;
                circleProgress.animated = false;
                tabs.BringToFront();
                tabs.Focus();
                done = false;
            }
        }

        /// <summary>
        /// Hàm tạo giao diện sản phẩm theo loại danh mục sản phẩm
        /// </summary>
        /// <param name="sender">Đối tượng hiển khi click vào sẽ hiển thị danh mục này</param>
        /// <param name="var">Danh sách sản phẩm</param>
        private void createProductFollowCategory(object sender, List<SanPham> var)
        {
            tabNews tab = new tabNews()
            {
                Location = new Point(0, 0),
            };
            tab.Dock = DockStyle.Fill;
            createProducts(tab, var);
            pageProducts.BeginInvoke((Action)(() =>
            {
                pageProducts.TabProducts.Controls.Add(tab);
            }));
            dataManager.tabFilterProducts.Add(sender, tab);
            done = true;
            tabs = tab;
        }

        /// <summary>
        /// Hàm hiển thị danh sách sản phẩm được sắp xếp giá từ cao tới thấp, thực hiện lấy danh
        /// sách và chạy bất đồng bộ để cập nhật giao diện
        /// </summary>
        /// <param name="sender">Đối tượng khi click vào sẽ hiển thị danh sách này</param>
        private void showPriceProductHightToLow(object sender)
        {
            vax = dataManager.sortPriceProductHighToLow();
            asyncShowProductTask(sender);
        }

        /// <summary>
        /// Hàm hiển thị danh sách sản phẩm được sắp xếp giá từ thấp tới cao, thực hiện lấy danh
        /// sách và chạy bất đồng bộ để cập nhật giao diện
        /// </summary>
        /// <param name="sender">Đối tượng khi click vào sẽ hiển thị danh sách này</param>
        private void showPriceProductLowToHight(object sender)
        {
            vax = dataManager.sortPriceProductLowToHight();
            asyncShowProductTask(sender);
        }

        /// <summary>
        /// Sự kiện click button xem giỏ hàng, hàm sẽ thực hiện gọi hàm hiển thị danh sách
        /// sản phẩm đã mua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            showProductPurchased();
        }

        /// <summary>
        /// Sự kiện onChange
        /// </summary>
        /// <param name="sender"></param>
        public void onChange(VIEW view)
        {
            if (view.getID() == R.id.CHANGE_COUNT_PRODUCT_OF_BILL)
            {
                updateBill(false);
            }
        }
    }
}
