namespace Tiki_app
{
    partial class BuyProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyProduct));
            this.lbTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbCountProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.edtCountProduct = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBuyProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContent3 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnContent2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnContent1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLoveProduct = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoveProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(24, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(38, 20);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Title";
            // 
            // lbCountProduct
            // 
            this.lbCountProduct.AutoSize = true;
            this.lbCountProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountProduct.Location = new System.Drawing.Point(41, 125);
            this.lbCountProduct.Name = "lbCountProduct";
            this.lbCountProduct.Size = new System.Drawing.Size(69, 20);
            this.lbCountProduct.TabIndex = 5;
            this.lbCountProduct.Text = "Số lượng";
            // 
            // edtCountProduct
            // 
            this.edtCountProduct.BorderColor = System.Drawing.Color.SeaGreen;
            this.edtCountProduct.Location = new System.Drawing.Point(58, 153);
            this.edtCountProduct.Name = "edtCountProduct";
            this.edtCountProduct.Size = new System.Drawing.Size(30, 20);
            this.edtCountProduct.TabIndex = 6;
            this.edtCountProduct.Text = "   0";
            this.edtCountProduct.TextChanged += new System.EventHandler(this.edtCountProduct_TextChanged);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = global::Tiki_app.Properties.Resources.ic_minus;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(34, 153);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 8;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = global::Tiki_app.Properties.Resources.ic_plus;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(92, 153);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.Active = false;
            this.btnBuyProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.btnBuyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.btnBuyProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuyProduct.BorderRadius = 5;
            this.btnBuyProduct.ButtonText = "    CHỌN MUA";
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
            this.btnBuyProduct.IconZoom = 90D;
            this.btnBuyProduct.IsTab = false;
            this.btnBuyProduct.Location = new System.Drawing.Point(197, 125);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.btnBuyProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.btnBuyProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuyProduct.selected = false;
            this.btnBuyProduct.Size = new System.Drawing.Size(241, 48);
            this.btnBuyProduct.TabIndex = 3;
            this.btnBuyProduct.Text = "    CHỌN MUA";
            this.btnBuyProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyProduct.Textcolor = System.Drawing.Color.White;
            this.btnBuyProduct.TextFont = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            // 
            // btnContent3
            // 
            this.btnContent3.ActiveBorderThickness = 1;
            this.btnContent3.ActiveCornerRadius = 20;
            this.btnContent3.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnContent3.ActiveForecolor = System.Drawing.Color.White;
            this.btnContent3.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnContent3.BackColor = System.Drawing.SystemColors.Control;
            this.btnContent3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContent3.BackgroundImage")));
            this.btnContent3.ButtonText = "Content3";
            this.btnContent3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContent3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContent3.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnContent3.IdleBorderThickness = 1;
            this.btnContent3.IdleCornerRadius = 20;
            this.btnContent3.IdleFillColor = System.Drawing.Color.White;
            this.btnContent3.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnContent3.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnContent3.Location = new System.Drawing.Point(367, 52);
            this.btnContent3.Margin = new System.Windows.Forms.Padding(5);
            this.btnContent3.Name = "btnContent3";
            this.btnContent3.Size = new System.Drawing.Size(160, 41);
            this.btnContent3.TabIndex = 2;
            this.btnContent3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContent2
            // 
            this.btnContent2.ActiveBorderThickness = 1;
            this.btnContent2.ActiveCornerRadius = 20;
            this.btnContent2.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnContent2.ActiveForecolor = System.Drawing.Color.White;
            this.btnContent2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnContent2.BackColor = System.Drawing.SystemColors.Control;
            this.btnContent2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContent2.BackgroundImage")));
            this.btnContent2.ButtonText = "Content2";
            this.btnContent2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContent2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContent2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnContent2.IdleBorderThickness = 1;
            this.btnContent2.IdleCornerRadius = 20;
            this.btnContent2.IdleFillColor = System.Drawing.Color.White;
            this.btnContent2.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnContent2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnContent2.Location = new System.Drawing.Point(197, 52);
            this.btnContent2.Margin = new System.Windows.Forms.Padding(5);
            this.btnContent2.Name = "btnContent2";
            this.btnContent2.Size = new System.Drawing.Size(160, 41);
            this.btnContent2.TabIndex = 1;
            this.btnContent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContent1
            // 
            this.btnContent1.ActiveBorderThickness = 1;
            this.btnContent1.ActiveCornerRadius = 20;
            this.btnContent1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnContent1.ActiveForecolor = System.Drawing.Color.White;
            this.btnContent1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnContent1.BackColor = System.Drawing.SystemColors.Control;
            this.btnContent1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContent1.BackgroundImage")));
            this.btnContent1.ButtonText = "Content1";
            this.btnContent1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContent1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContent1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnContent1.IdleBorderThickness = 1;
            this.btnContent1.IdleCornerRadius = 20;
            this.btnContent1.IdleFillColor = System.Drawing.Color.White;
            this.btnContent1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnContent1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnContent1.Location = new System.Drawing.Point(27, 52);
            this.btnContent1.Margin = new System.Windows.Forms.Padding(5);
            this.btnContent1.Name = "btnContent1";
            this.btnContent1.Size = new System.Drawing.Size(160, 41);
            this.btnContent1.TabIndex = 0;
            this.btnContent1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoveProduct
            // 
            this.btnLoveProduct.Image = global::Tiki_app.Properties.Resources.ic_heart;
            this.btnLoveProduct.ImageActive = null;
            this.btnLoveProduct.InitialImage = null;
            this.btnLoveProduct.Location = new System.Drawing.Point(451, 129);
            this.btnLoveProduct.Name = "btnLoveProduct";
            this.btnLoveProduct.Size = new System.Drawing.Size(40, 40);
            this.btnLoveProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoveProduct.TabIndex = 9;
            this.btnLoveProduct.TabStop = false;
            this.btnLoveProduct.Zoom = 10;
            // 
            // BuyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoveProduct);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.edtCountProduct);
            this.Controls.Add(this.lbCountProduct);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnBuyProduct);
            this.Controls.Add(this.btnContent3);
            this.Controls.Add(this.btnContent2);
            this.Controls.Add(this.btnContent1);
            this.Name = "BuyProduct";
            this.Size = new System.Drawing.Size(547, 196);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoveProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnContent1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContent2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContent3;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuyProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCountProduct;
        private Bunifu.Framework.BunifuCustomTextbox edtCountProduct;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnLoveProduct;

    }
}
