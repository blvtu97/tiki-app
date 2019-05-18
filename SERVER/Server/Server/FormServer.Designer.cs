namespace Server
{
    partial class frmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.metMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.metCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.metProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.metProSmart = new System.Windows.Forms.ToolStripMenuItem();
            this.metProLaptop = new System.Windows.Forms.ToolStripMenuItem();
            this.metProBook = new System.Windows.Forms.ToolStripMenuItem();
            this.metProFashion = new System.Windows.Forms.ToolStripMenuItem();
            this.metProCar = new System.Windows.Forms.ToolStripMenuItem();
            this.metDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.metDetSmart = new System.Windows.Forms.ToolStripMenuItem();
            this.metDetLaptop = new System.Windows.Forms.ToolStripMenuItem();
            this.metDetBook = new System.Windows.Forms.ToolStripMenuItem();
            this.metDetFashion = new System.Windows.Forms.ToolStripMenuItem();
            this.metDetCar = new System.Windows.Forms.ToolStripMenuItem();
            this.metCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.metCatSmart = new System.Windows.Forms.ToolStripMenuItem();
            this.metCatLaptop = new System.Windows.Forms.ToolStripMenuItem();
            this.metCatBook = new System.Windows.Forms.ToolStripMenuItem();
            this.metCatFashion = new System.Windows.Forms.ToolStripMenuItem();
            this.metCatCar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartServer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnStop = new Bunifu.Framework.UI.BunifuThinButton2();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // metMenu
            // 
            this.metMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metCustomer,
            this.metProduct,
            this.metDetail,
            this.metCategory});
            this.metMenu.Name = "metMenu";
            this.metMenu.Size = new System.Drawing.Size(112, 20);
            this.metMenu.Text = "Contact &Database";
            // 
            // metCustomer
            // 
            this.metCustomer.Name = "metCustomer";
            this.metCustomer.Size = new System.Drawing.Size(176, 22);
            this.metCustomer.Tag = "CUSTOMER";
            this.metCustomer.Text = "&Customer Manager";
            this.metCustomer.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metProduct
            // 
            this.metProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metProSmart,
            this.metProLaptop,
            this.metProBook,
            this.metProFashion,
            this.metProCar});
            this.metProduct.Name = "metProduct";
            this.metProduct.Size = new System.Drawing.Size(176, 22);
            this.metProduct.Tag = "PRODUCT";
            this.metProduct.Text = "&Product Manager";
            // 
            // metProSmart
            // 
            this.metProSmart.Name = "metProSmart";
            this.metProSmart.Size = new System.Drawing.Size(139, 22);
            this.metProSmart.Tag = "PRODUCTSMART";
            this.metProSmart.Text = "SmartPhone";
            this.metProSmart.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metProLaptop
            // 
            this.metProLaptop.Name = "metProLaptop";
            this.metProLaptop.Size = new System.Drawing.Size(139, 22);
            this.metProLaptop.Tag = "PRODUCTLAPTOP";
            this.metProLaptop.Text = "Laptop";
            this.metProLaptop.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metProBook
            // 
            this.metProBook.Name = "metProBook";
            this.metProBook.Size = new System.Drawing.Size(139, 22);
            this.metProBook.Tag = "PRODUCTBOOK";
            this.metProBook.Text = "Book";
            this.metProBook.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metProFashion
            // 
            this.metProFashion.Name = "metProFashion";
            this.metProFashion.Size = new System.Drawing.Size(139, 22);
            this.metProFashion.Tag = "PRODUCTFASHION";
            this.metProFashion.Text = "Fashion";
            this.metProFashion.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metProCar
            // 
            this.metProCar.Name = "metProCar";
            this.metProCar.Size = new System.Drawing.Size(139, 22);
            this.metProCar.Tag = "PRODUCTCAR";
            this.metProCar.Text = "MotoBike";
            this.metProCar.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metDetail
            // 
            this.metDetail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metDetSmart,
            this.metDetLaptop,
            this.metDetBook,
            this.metDetFashion,
            this.metDetCar});
            this.metDetail.Name = "metDetail";
            this.metDetail.Size = new System.Drawing.Size(176, 22);
            this.metDetail.Tag = "DETAIL";
            this.metDetail.Text = "D&etail Manager";
            // 
            // metDetSmart
            // 
            this.metDetSmart.Name = "metDetSmart";
            this.metDetSmart.Size = new System.Drawing.Size(139, 22);
            this.metDetSmart.Tag = "DETAILSMART";
            this.metDetSmart.Text = "SmartPhone";
            this.metDetSmart.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metDetLaptop
            // 
            this.metDetLaptop.Name = "metDetLaptop";
            this.metDetLaptop.Size = new System.Drawing.Size(139, 22);
            this.metDetLaptop.Tag = "DETAILLAPTOP";
            this.metDetLaptop.Text = "Laptop";
            this.metDetLaptop.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metDetBook
            // 
            this.metDetBook.Name = "metDetBook";
            this.metDetBook.Size = new System.Drawing.Size(139, 22);
            this.metDetBook.Tag = "DETAILBOOK";
            this.metDetBook.Text = "Book";
            this.metDetBook.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metDetFashion
            // 
            this.metDetFashion.Name = "metDetFashion";
            this.metDetFashion.Size = new System.Drawing.Size(139, 22);
            this.metDetFashion.Tag = "DETAILFASHION";
            this.metDetFashion.Text = "Fashion";
            this.metDetFashion.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metDetCar
            // 
            this.metDetCar.Name = "metDetCar";
            this.metDetCar.Size = new System.Drawing.Size(139, 22);
            this.metDetCar.Tag = "DETAILCAR";
            this.metDetCar.Text = "MotoBike";
            this.metDetCar.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metCategory
            // 
            this.metCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metCatSmart,
            this.metCatLaptop,
            this.metCatBook,
            this.metCatFashion,
            this.metCatCar});
            this.metCategory.Name = "metCategory";
            this.metCategory.Size = new System.Drawing.Size(176, 22);
            this.metCategory.Tag = "CATEGORY";
            this.metCategory.Text = "C&ategory Manager";
            // 
            // metCatSmart
            // 
            this.metCatSmart.Name = "metCatSmart";
            this.metCatSmart.Size = new System.Drawing.Size(139, 22);
            this.metCatSmart.Tag = "CATEGORYSMART";
            this.metCatSmart.Text = "SmartPhone";
            this.metCatSmart.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metCatLaptop
            // 
            this.metCatLaptop.Name = "metCatLaptop";
            this.metCatLaptop.Size = new System.Drawing.Size(139, 22);
            this.metCatLaptop.Tag = "CATEGORYLAPTOP";
            this.metCatLaptop.Text = "Laptop";
            this.metCatLaptop.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metCatBook
            // 
            this.metCatBook.Name = "metCatBook";
            this.metCatBook.Size = new System.Drawing.Size(139, 22);
            this.metCatBook.Tag = "CATEGORYBOOK";
            this.metCatBook.Text = "Book";
            this.metCatBook.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metCatFashion
            // 
            this.metCatFashion.Name = "metCatFashion";
            this.metCatFashion.Size = new System.Drawing.Size(139, 22);
            this.metCatFashion.Tag = "CATEGORYFASHION";
            this.metCatFashion.Text = "Fashion";
            this.metCatFashion.Click += new System.EventHandler(this.Menu_Click);
            // 
            // metCatCar
            // 
            this.metCatCar.Name = "metCatCar";
            this.metCatCar.Size = new System.Drawing.Size(139, 22);
            this.metCatCar.Tag = "CATEGORYCAR";
            this.metCatCar.Text = "MotoBike";
            this.metCatCar.Click += new System.EventHandler(this.Menu_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.ActiveBorderThickness = 1;
            this.btnStartServer.ActiveCornerRadius = 20;
            this.btnStartServer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnStartServer.ActiveForecolor = System.Drawing.Color.White;
            this.btnStartServer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnStartServer.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartServer.BackgroundImage")));
            this.btnStartServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartServer.ButtonText = "Start Server";
            this.btnStartServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartServer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnStartServer.IdleBorderThickness = 1;
            this.btnStartServer.IdleCornerRadius = 20;
            this.btnStartServer.IdleFillColor = System.Drawing.Color.White;
            this.btnStartServer.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnStartServer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnStartServer.Location = new System.Drawing.Point(33, 29);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(5);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(187, 59);
            this.btnStartServer.TabIndex = 3;
            this.btnStartServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnStop
            // 
            this.btnStop.ActiveBorderThickness = 1;
            this.btnStop.ActiveCornerRadius = 20;
            this.btnStop.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnStop.ActiveForecolor = System.Drawing.Color.White;
            this.btnStop.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.ButtonText = "Stop Server";
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnStop.IdleBorderThickness = 1;
            this.btnStop.IdleCornerRadius = 20;
            this.btnStop.IdleFillColor = System.Drawing.Color.White;
            this.btnStop.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnStop.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnStop.Location = new System.Drawing.Point(33, 88);
            this.btnStop.Margin = new System.Windows.Forms.Padding(5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(187, 59);
            this.btnStop.TabIndex = 4;
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 172);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem metMenu;
        private System.Windows.Forms.ToolStripMenuItem metCustomer;
        private System.Windows.Forms.ToolStripMenuItem metProduct;
        private System.Windows.Forms.ToolStripMenuItem metDetail;
        private System.Windows.Forms.ToolStripMenuItem metCategory;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStartServer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStop;
        private System.Windows.Forms.ToolStripMenuItem metProSmart;
        private System.Windows.Forms.ToolStripMenuItem metProLaptop;
        private System.Windows.Forms.ToolStripMenuItem metProBook;
        private System.Windows.Forms.ToolStripMenuItem metProFashion;
        private System.Windows.Forms.ToolStripMenuItem metProCar;
        private System.Windows.Forms.ToolStripMenuItem metDetSmart;
        private System.Windows.Forms.ToolStripMenuItem metDetLaptop;
        private System.Windows.Forms.ToolStripMenuItem metDetBook;
        private System.Windows.Forms.ToolStripMenuItem metDetFashion;
        private System.Windows.Forms.ToolStripMenuItem metDetCar;
        private System.Windows.Forms.ToolStripMenuItem metCatSmart;
        private System.Windows.Forms.ToolStripMenuItem metCatLaptop;
        private System.Windows.Forms.ToolStripMenuItem metCatBook;
        private System.Windows.Forms.ToolStripMenuItem metCatFashion;
        private System.Windows.Forms.ToolStripMenuItem metCatCar;
    }
}

