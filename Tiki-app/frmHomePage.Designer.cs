namespace Tiki_app
{
    partial class frmHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPhone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabLaptop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabFashion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabVehicle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNotification = new System.Windows.Forms.Label();
            this.btnNotification = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbCountProduct = new System.Windows.Forms.Label();
            this.btnBuyProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.edtFindProduct = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnFind = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblmain = new System.Windows.Forms.Label();
            this.circleProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pageProducts = new Tiki_app.pageProducts();
            this.pageNews = new Tiki_app.pageNews();
            this.tabFilterProducts = new Tiki_app.tabFilterProducts();
            this.pageDetailsProducts = new Tiki_app.pageDetailsProduct();
            this.pageNoProducts = new Tiki_app.pageNoProduct();
            this.pagePayProducts = new Tiki_app.pagePayProduct();
            this.tabInfoCustomer = new Tiki_app.tabInfoCustomer();
            this.tabThankyou1 = new Tiki_app.tabThankyou();
            this.tabChoosePayMethod = new Tiki_app.tabChoseDeliveryMethod();
            this.pageLogin = new Tiki_app.pageLogin();
            this.tabInfoUser = new Tiki_app.tabInfoUser();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.tabPhone);
            this.panel1.Controls.Add(this.tabLaptop);
            this.panel1.Controls.Add(this.tabFashion);
            this.panel1.Controls.Add(this.tabVehicle);
            this.panel1.Controls.Add(this.tabBook);
            this.panel1.Controls.Add(this.bunifuFlatButton3);
            this.panel1.Controls.Add(this.bar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 681);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabFilterProducts);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 450);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 231);
            this.panel4.TabIndex = 18;
            // 
            // tabPhone
            // 
            this.tabPhone.Active = false;
            this.tabPhone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabPhone.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPhone.BorderRadius = 0;
            this.tabPhone.ButtonText = "    Điện thoại, máy tính bảng";
            this.tabPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPhone.DisabledColor = System.Drawing.Color.Gray;
            this.tabPhone.Iconcolor = System.Drawing.Color.Transparent;
            this.tabPhone.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabPhone.Iconimage")));
            this.tabPhone.Iconimage_right = null;
            this.tabPhone.Iconimage_right_Selected = null;
            this.tabPhone.Iconimage_Selected = null;
            this.tabPhone.IconMarginLeft = 0;
            this.tabPhone.IconMarginRight = 0;
            this.tabPhone.IconRightVisible = true;
            this.tabPhone.IconRightZoom = 0D;
            this.tabPhone.IconVisible = true;
            this.tabPhone.IconZoom = 50D;
            this.tabPhone.IsTab = false;
            this.tabPhone.Location = new System.Drawing.Point(16, 130);
            this.tabPhone.Name = "tabPhone";
            this.tabPhone.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.tabPhone.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.tabPhone.OnHoverTextColor = System.Drawing.Color.White;
            this.tabPhone.selected = false;
            this.tabPhone.Size = new System.Drawing.Size(255, 50);
            this.tabPhone.TabIndex = 17;
            this.tabPhone.Text = "    Điện thoại, máy tính bảng";
            this.tabPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabPhone.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(46)))));
            this.tabPhone.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPhone.Click += new System.EventHandler(this.tab1_Click);
            // 
            // tabLaptop
            // 
            this.tabLaptop.Active = false;
            this.tabLaptop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabLaptop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabLaptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLaptop.BorderRadius = 0;
            this.tabLaptop.ButtonText = "    Laptop, thiết bị IT";
            this.tabLaptop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabLaptop.DisabledColor = System.Drawing.Color.Gray;
            this.tabLaptop.Iconcolor = System.Drawing.Color.Transparent;
            this.tabLaptop.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabLaptop.Iconimage")));
            this.tabLaptop.Iconimage_right = null;
            this.tabLaptop.Iconimage_right_Selected = null;
            this.tabLaptop.Iconimage_Selected = null;
            this.tabLaptop.IconMarginLeft = 0;
            this.tabLaptop.IconMarginRight = 0;
            this.tabLaptop.IconRightVisible = true;
            this.tabLaptop.IconRightZoom = 0D;
            this.tabLaptop.IconVisible = true;
            this.tabLaptop.IconZoom = 50D;
            this.tabLaptop.IsTab = false;
            this.tabLaptop.Location = new System.Drawing.Point(16, 196);
            this.tabLaptop.Name = "tabLaptop";
            this.tabLaptop.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.tabLaptop.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.tabLaptop.OnHoverTextColor = System.Drawing.Color.White;
            this.tabLaptop.selected = false;
            this.tabLaptop.Size = new System.Drawing.Size(255, 50);
            this.tabLaptop.TabIndex = 16;
            this.tabLaptop.Text = "    Laptop, thiết bị IT";
            this.tabLaptop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabLaptop.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(46)))));
            this.tabLaptop.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLaptop.Click += new System.EventHandler(this.tab2_Click);
            // 
            // tabFashion
            // 
            this.tabFashion.Active = false;
            this.tabFashion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabFashion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabFashion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabFashion.BorderRadius = 0;
            this.tabFashion.ButtonText = "    Thời trang, phụ kiện";
            this.tabFashion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabFashion.DisabledColor = System.Drawing.Color.Gray;
            this.tabFashion.Iconcolor = System.Drawing.Color.Transparent;
            this.tabFashion.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabFashion.Iconimage")));
            this.tabFashion.Iconimage_right = null;
            this.tabFashion.Iconimage_right_Selected = null;
            this.tabFashion.Iconimage_Selected = null;
            this.tabFashion.IconMarginLeft = 0;
            this.tabFashion.IconMarginRight = 0;
            this.tabFashion.IconRightVisible = true;
            this.tabFashion.IconRightZoom = 0D;
            this.tabFashion.IconVisible = true;
            this.tabFashion.IconZoom = 50D;
            this.tabFashion.IsTab = false;
            this.tabFashion.Location = new System.Drawing.Point(16, 262);
            this.tabFashion.Name = "tabFashion";
            this.tabFashion.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.tabFashion.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.tabFashion.OnHoverTextColor = System.Drawing.Color.White;
            this.tabFashion.selected = false;
            this.tabFashion.Size = new System.Drawing.Size(255, 50);
            this.tabFashion.TabIndex = 15;
            this.tabFashion.Text = "    Thời trang, phụ kiện";
            this.tabFashion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabFashion.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(46)))));
            this.tabFashion.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFashion.Click += new System.EventHandler(this.tab3_Click);
            // 
            // tabVehicle
            // 
            this.tabVehicle.Active = false;
            this.tabVehicle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabVehicle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabVehicle.BorderRadius = 0;
            this.tabVehicle.ButtonText = "   Xe máy, Ô tô, Xe đạp";
            this.tabVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabVehicle.DisabledColor = System.Drawing.Color.Gray;
            this.tabVehicle.Iconcolor = System.Drawing.Color.Transparent;
            this.tabVehicle.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabVehicle.Iconimage")));
            this.tabVehicle.Iconimage_right = null;
            this.tabVehicle.Iconimage_right_Selected = null;
            this.tabVehicle.Iconimage_Selected = null;
            this.tabVehicle.IconMarginLeft = 0;
            this.tabVehicle.IconMarginRight = 0;
            this.tabVehicle.IconRightVisible = true;
            this.tabVehicle.IconRightZoom = 0D;
            this.tabVehicle.IconVisible = true;
            this.tabVehicle.IconZoom = 70D;
            this.tabVehicle.IsTab = false;
            this.tabVehicle.Location = new System.Drawing.Point(16, 328);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.tabVehicle.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.tabVehicle.OnHoverTextColor = System.Drawing.Color.White;
            this.tabVehicle.selected = false;
            this.tabVehicle.Size = new System.Drawing.Size(255, 50);
            this.tabVehicle.TabIndex = 14;
            this.tabVehicle.Text = "   Xe máy, Ô tô, Xe đạp";
            this.tabVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabVehicle.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(46)))));
            this.tabVehicle.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVehicle.Click += new System.EventHandler(this.tab4_Click);
            // 
            // tabBook
            // 
            this.tabBook.Active = false;
            this.tabBook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabBook.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBook.BorderRadius = 0;
            this.tabBook.ButtonText = "    Sách";
            this.tabBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabBook.DisabledColor = System.Drawing.Color.Gray;
            this.tabBook.Iconcolor = System.Drawing.Color.Transparent;
            this.tabBook.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabBook.Iconimage")));
            this.tabBook.Iconimage_right = null;
            this.tabBook.Iconimage_right_Selected = null;
            this.tabBook.Iconimage_Selected = null;
            this.tabBook.IconMarginLeft = 0;
            this.tabBook.IconMarginRight = 0;
            this.tabBook.IconRightVisible = true;
            this.tabBook.IconRightZoom = 0D;
            this.tabBook.IconVisible = true;
            this.tabBook.IconZoom = 50D;
            this.tabBook.IsTab = false;
            this.tabBook.Location = new System.Drawing.Point(16, 394);
            this.tabBook.Name = "tabBook";
            this.tabBook.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.tabBook.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.tabBook.OnHoverTextColor = System.Drawing.Color.White;
            this.tabBook.selected = false;
            this.tabBook.Size = new System.Drawing.Size(255, 50);
            this.tabBook.TabIndex = 13;
            this.tabBook.Text = "    Sách";
            this.tabBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabBook.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(46)))));
            this.tabBook.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBook.Click += new System.EventHandler(this.tab5_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "bunifuFlatButton3";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(-23, -46);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton3.TabIndex = 12;
            this.bunifuFlatButton3.Text = "bunifuFlatButton3";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(179)))), ((int)(((byte)(240)))));
            this.bar.Location = new System.Drawing.Point(0, 130);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(5, 50);
            this.bar.TabIndex = 6;
            this.bar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiki_app.Properties.Resources.logo_store;
            this.pictureBox1.Location = new System.Drawing.Point(38, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lbNotification);
            this.panel2.Controls.Add(this.btnNotification);
            this.panel2.Controls.Add(this.lbCountProduct);
            this.panel2.Controls.Add(this.btnBuyProduct);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.edtFindProduct);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(284, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 65);
            this.panel2.TabIndex = 6;
            // 
            // lbNotification
            // 
            this.lbNotification.BackColor = System.Drawing.Color.Red;
            this.lbNotification.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.Color.White;
            this.lbNotification.Location = new System.Drawing.Point(572, 16);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(15, 15);
            this.lbNotification.TabIndex = 12;
            this.lbNotification.Text = "0";
            this.lbNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNotification
            // 
            this.btnNotification.Active = false;
            this.btnNotification.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotification.BorderRadius = 5;
            this.btnNotification.ButtonText = "     Thông báo";
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.DisabledColor = System.Drawing.Color.Gray;
            this.btnNotification.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNotification.Iconimage = global::Tiki_app.Properties.Resources.ic_bell;
            this.btnNotification.Iconimage_right = null;
            this.btnNotification.Iconimage_right_Selected = null;
            this.btnNotification.Iconimage_Selected = null;
            this.btnNotification.IconMarginLeft = 0;
            this.btnNotification.IconMarginRight = 0;
            this.btnNotification.IconRightVisible = true;
            this.btnNotification.IconRightZoom = 0D;
            this.btnNotification.IconVisible = true;
            this.btnNotification.IconZoom = 50D;
            this.btnNotification.IsTab = false;
            this.btnNotification.Location = new System.Drawing.Point(547, 10);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnNotification.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(109)))), ((int)(((byte)(172)))));
            this.btnNotification.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNotification.selected = false;
            this.btnNotification.Size = new System.Drawing.Size(140, 45);
            this.btnNotification.TabIndex = 11;
            this.btnNotification.Text = "     Thông báo";
            this.btnNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.Textcolor = System.Drawing.Color.White;
            this.btnNotification.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lbCountProduct
            // 
            this.lbCountProduct.BackColor = System.Drawing.Color.Red;
            this.lbCountProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountProduct.ForeColor = System.Drawing.Color.White;
            this.lbCountProduct.Location = new System.Drawing.Point(965, 18);
            this.lbCountProduct.Name = "lbCountProduct";
            this.lbCountProduct.Size = new System.Drawing.Size(20, 25);
            this.lbCountProduct.TabIndex = 10;
            this.lbCountProduct.Text = "0";
            this.lbCountProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCountProduct.Visible = false;
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.Active = false;
            this.btnBuyProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnBuyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnBuyProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuyProduct.BorderRadius = 5;
            this.btnBuyProduct.ButtonText = "     Giỏ hàng";
            this.btnBuyProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuyProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuyProduct.Iconimage = global::Tiki_app.Properties.Resources.ic_buy;
            this.btnBuyProduct.Iconimage_right = null;
            this.btnBuyProduct.Iconimage_right_Selected = null;
            this.btnBuyProduct.Iconimage_Selected = null;
            this.btnBuyProduct.IconMarginLeft = 0;
            this.btnBuyProduct.IconMarginRight = 0;
            this.btnBuyProduct.IconRightVisible = true;
            this.btnBuyProduct.IconRightZoom = 0D;
            this.btnBuyProduct.IconVisible = true;
            this.btnBuyProduct.IconZoom = 60D;
            this.btnBuyProduct.IsTab = false;
            this.btnBuyProduct.Location = new System.Drawing.Point(852, 10);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnBuyProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(109)))), ((int)(((byte)(172)))));
            this.btnBuyProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuyProduct.selected = false;
            this.btnBuyProduct.Size = new System.Drawing.Size(140, 45);
            this.btnBuyProduct.TabIndex = 9;
            this.btnBuyProduct.Text = "     Giỏ hàng";
            this.btnBuyProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyProduct.Textcolor = System.Drawing.Color.White;
            this.btnBuyProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyProduct.Click += new System.EventHandler(this.btnBuyProduct_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Active = false;
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.ButtonText = "     Đăng nhập";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = global::Tiki_app.Properties.Resources.ic_login;
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 50D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(700, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(109)))), ((int)(((byte)(172)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(140, 45);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "     Đăng nhập";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(409, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(97, 30);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Tìm kiếm";
            // 
            // edtFindProduct
            // 
            this.edtFindProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.edtFindProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.edtFindProduct.BackColor = System.Drawing.Color.White;
            this.edtFindProduct.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.edtFindProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFindProduct.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.edtFindProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edtFindProduct.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(56)))));
            this.edtFindProduct.HintText = "Tìm sản phẩm, danh mục, thương hiệu,...";
            this.edtFindProduct.isPassword = false;
            this.edtFindProduct.LineFocusedColor = System.Drawing.Color.Blue;
            this.edtFindProduct.LineIdleColor = System.Drawing.Color.Navy;
            this.edtFindProduct.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.edtFindProduct.LineThickness = 2;
            this.edtFindProduct.Location = new System.Drawing.Point(24, 10);
            this.edtFindProduct.Margin = new System.Windows.Forms.Padding(4);
            this.edtFindProduct.MaxLength = 32767;
            this.edtFindProduct.Name = "edtFindProduct";
            this.edtFindProduct.Size = new System.Drawing.Size(337, 45);
            this.edtFindProduct.TabIndex = 6;
            this.edtFindProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageActive = null;
            this.btnFind.Location = new System.Drawing.Point(368, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(35, 35);
            this.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFind.TabIndex = 5;
            this.btnFind.TabStop = false;
            this.btnFind.Zoom = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblmain);
            this.panel3.Controls.Add(this.circleProgress);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(284, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 65);
            this.panel3.TabIndex = 7;
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.Color.White;
            this.lblmain.Location = new System.Drawing.Point(20, 20);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(109, 24);
            this.lblmain.TabIndex = 2;
            this.lblmain.Text = "SẢN PHẨM";
            // 
            // circleProgress
            // 
            this.circleProgress.animated = false;
            this.circleProgress.animationIterval = 5;
            this.circleProgress.animationSpeed = 7;
            this.circleProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.circleProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleProgress.BackgroundImage")));
            this.circleProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.circleProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.circleProgress.LabelVisible = true;
            this.circleProgress.LineProgressThickness = 6;
            this.circleProgress.LineThickness = 4;
            this.circleProgress.Location = new System.Drawing.Point(481, 7);
            this.circleProgress.Margin = new System.Windows.Forms.Padding(4);
            this.circleProgress.MaxValue = 100;
            this.circleProgress.Name = "circleProgress";
            this.circleProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleProgress.ProgressColor = System.Drawing.Color.Red;
            this.circleProgress.Size = new System.Drawing.Size(51, 51);
            this.circleProgress.TabIndex = 3;
            this.circleProgress.Value = 69;
            this.circleProgress.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pageProducts
            // 
            this.pageProducts.AutoScroll = true;
            this.pageProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.pageProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageProducts.Location = new System.Drawing.Point(284, 130);
            this.pageProducts.Name = "pageProducts";
            this.pageProducts.Size = new System.Drawing.Size(1015, 551);
            this.pageProducts.TabIndex = 9;
            // 
            // pageNews
            // 
            this.pageNews.AutoScroll = true;
            this.pageNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.pageNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageNews.Location = new System.Drawing.Point(284, 130);
            this.pageNews.Name = "pageNews";
            this.pageNews.Size = new System.Drawing.Size(1015, 551);
            this.pageNews.TabIndex = 8;
            // 
            // tabFilterProducts
            // 
            this.tabFilterProducts.AutoScroll = true;
            this.tabFilterProducts.BackColor = System.Drawing.Color.White;
            this.tabFilterProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabFilterProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFilterProducts.Location = new System.Drawing.Point(0, 0);
            this.tabFilterProducts.Name = "tabFilterProducts";
            this.tabFilterProducts.Size = new System.Drawing.Size(284, 231);
            this.tabFilterProducts.TabIndex = 0;
            // 
            // pageDetailsProducts
            // 
            this.pageDetailsProducts.AutoScroll = true;
            this.pageDetailsProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pageDetailsProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageDetailsProducts.Location = new System.Drawing.Point(0, 0);
            this.pageDetailsProducts.Name = "pageDetailsProducts";
            this.pageDetailsProducts.Size = new System.Drawing.Size(1299, 681);
            this.pageDetailsProducts.TabIndex = 10;
            // 
            // pageNoProducts
            // 
            this.pageNoProducts.AutoScroll = true;
            this.pageNoProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageNoProducts.Location = new System.Drawing.Point(0, 0);
            this.pageNoProducts.Name = "pageNoProducts";
            this.pageNoProducts.Size = new System.Drawing.Size(1299, 681);
            this.pageNoProducts.TabIndex = 11;
            // 
            // pagePayProducts
            // 
            this.pagePayProducts.AutoScroll = true;
            this.pagePayProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePayProducts.Location = new System.Drawing.Point(0, 0);
            this.pagePayProducts.Name = "pagePayProducts";
            this.pagePayProducts.Size = new System.Drawing.Size(1299, 681);
            this.pagePayProducts.TabIndex = 12;
            // 
            // tabInfoCustomer
            // 
            this.tabInfoCustomer.AddressCustomer = "";
            this.tabInfoCustomer.AutoScroll = true;
            this.tabInfoCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tabInfoCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfoCustomer.KhachHang = null;
            this.tabInfoCustomer.Location = new System.Drawing.Point(0, 0);
            this.tabInfoCustomer.Name = "tabInfoCustomer";
            this.tabInfoCustomer.NameCustomer = "";
            this.tabInfoCustomer.PhoneCustomer = "";
            this.tabInfoCustomer.Size = new System.Drawing.Size(1299, 681);
            this.tabInfoCustomer.TabIndex = 13;
            // 
            // tabThankyou1
            // 
            this.tabThankyou1.BackColor = System.Drawing.Color.White;
            this.tabThankyou1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThankyou1.Location = new System.Drawing.Point(0, 0);
            this.tabThankyou1.Name = "tabThankyou1";
            this.tabThankyou1.Size = new System.Drawing.Size(1299, 681);
            this.tabThankyou1.TabIndex = 14;
            // 
            // tabChoosePayMethod
            // 
            this.tabChoosePayMethod.AutoScroll = true;
            this.tabChoosePayMethod.BackColor = System.Drawing.Color.White;
            this.tabChoosePayMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChoosePayMethod.Location = new System.Drawing.Point(0, 0);
            this.tabChoosePayMethod.Name = "tabChoosePayMethod";
            this.tabChoosePayMethod.Size = new System.Drawing.Size(1299, 681);
            this.tabChoosePayMethod.TabIndex = 15;
            // 
            // pageLogin
            // 
            this.pageLogin.AutoScroll = true;
            this.pageLogin.BackColor = System.Drawing.Color.White;
            this.pageLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageLogin.Location = new System.Drawing.Point(0, 0);
            this.pageLogin.Name = "pageLogin";
            this.pageLogin.Size = new System.Drawing.Size(1299, 681);
            this.pageLogin.TabIndex = 16;
            // 
            // tabInfoUser
            // 
            this.tabInfoUser.AutoScroll = true;
            this.tabInfoUser.BackColor = System.Drawing.Color.White;
            this.tabInfoUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfoUser.Location = new System.Drawing.Point(0, 0);
            this.tabInfoUser.Name = "tabInfoUser";
            this.tabInfoUser.Size = new System.Drawing.Size(1299, 681);
            this.tabInfoUser.TabIndex = 17;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 681);
            this.Controls.Add(this.pageProducts);
            this.Controls.Add(this.pageNews);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pageDetailsProducts);
            this.Controls.Add(this.pageNoProducts);
            this.Controls.Add(this.pagePayProducts);
            this.Controls.Add(this.tabInfoCustomer);
            this.Controls.Add(this.tabThankyou1);
            this.Controls.Add(this.tabChoosePayMethod);
            this.Controls.Add(this.pageLogin);
            this.Controls.Add(this.tabInfoUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIKI";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblmain;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuyProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox edtFindProduct;
        private Bunifu.Framework.UI.BunifuImageButton btnFind;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private pageNews pageNews;
        private pageProducts pageProducts;
        private Bunifu.Framework.UI.BunifuFlatButton tabBook;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton tabPhone;
        private Bunifu.Framework.UI.BunifuFlatButton tabLaptop;
        private Bunifu.Framework.UI.BunifuFlatButton tabFashion;
        private Bunifu.Framework.UI.BunifuFlatButton tabVehicle;
        private pageDetailsProduct pageDetailsProducts;
        private pageNoProduct pageNoProducts;
        private pagePayProduct pagePayProducts;
        private tabInfoCustomer tabInfoCustomer;
        private System.Windows.Forms.Label lbCountProduct;
        private tabThankyou tabThankyou1;
        private System.Windows.Forms.Panel panel4;
        private tabFilterProducts tabFilterProducts;
        private tabChoseDeliveryMethod tabChoosePayMethod;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleProgress;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuFlatButton btnNotification;
        private System.Windows.Forms.Label lbNotification;
        private pageLogin pageLogin;
        private tabInfoUser tabInfoUser;
    }
}

