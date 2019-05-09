namespace Tiki_app
{
    partial class tabGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabGood));
            this.lbNameProduct = new System.Windows.Forms.Label();
            this.edtCountProduct = new Bunifu.Framework.BunifuCustomTextbox();
            this.lbCountProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMinus = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPlus = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBuyLater = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.imgProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameProduct
            // 
            this.lbNameProduct.AutoSize = true;
            this.lbNameProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameProduct.Location = new System.Drawing.Point(143, 19);
            this.lbNameProduct.Name = "lbNameProduct";
            this.lbNameProduct.Size = new System.Drawing.Size(105, 21);
            this.lbNameProduct.TabIndex = 1;
            this.lbNameProduct.Text = "Tên sản phẩm";
            // 
            // edtCountProduct
            // 
            this.edtCountProduct.BorderColor = System.Drawing.Color.SeaGreen;
            this.edtCountProduct.Location = new System.Drawing.Point(726, 38);
            this.edtCountProduct.Name = "edtCountProduct";
            this.edtCountProduct.Size = new System.Drawing.Size(28, 20);
            this.edtCountProduct.TabIndex = 10;
            this.edtCountProduct.Tag = "12345685";
            this.edtCountProduct.Text = "0";
            this.edtCountProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCountProduct
            // 
            this.lbCountProduct.AutoSize = true;
            this.lbCountProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountProduct.Location = new System.Drawing.Point(707, 10);
            this.lbCountProduct.Name = "lbCountProduct";
            this.lbCountProduct.Size = new System.Drawing.Size(69, 20);
            this.lbCountProduct.TabIndex = 9;
            this.lbCountProduct.Text = "Số lượng";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.Image = global::Tiki_app.Properties.Resources.ic_minus;
            this.btnMinus.ImageActive = null;
            this.btnMinus.Location = new System.Drawing.Point(700, 38);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(20, 20);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinus.TabIndex = 12;
            this.btnMinus.TabStop = false;
            this.btnMinus.Zoom = 10;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.Image = global::Tiki_app.Properties.Resources.ic_plus;
            this.btnPlus.ImageActive = null;
            this.btnPlus.Location = new System.Drawing.Point(758, 38);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(20, 20);
            this.btnPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlus.TabIndex = 11;
            this.btnPlus.TabStop = false;
            this.btnPlus.Zoom = 10;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnBuyLater
            // 
            this.btnBuyLater.ActiveBorderThickness = 1;
            this.btnBuyLater.ActiveCornerRadius = 20;
            this.btnBuyLater.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBuyLater.ActiveForecolor = System.Drawing.Color.White;
            this.btnBuyLater.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuyLater.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuyLater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuyLater.BackgroundImage")));
            this.btnBuyLater.ButtonText = "Để dành mua sau";
            this.btnBuyLater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyLater.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyLater.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBuyLater.IdleBorderThickness = 1;
            this.btnBuyLater.IdleCornerRadius = 20;
            this.btnBuyLater.IdleFillColor = System.Drawing.Color.White;
            this.btnBuyLater.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBuyLater.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuyLater.Location = new System.Drawing.Point(255, 68);
            this.btnBuyLater.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuyLater.Name = "btnBuyLater";
            this.btnBuyLater.Size = new System.Drawing.Size(180, 40);
            this.btnBuyLater.TabIndex = 3;
            this.btnBuyLater.Tag = "";
            this.btnBuyLater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuyLater.Click += new System.EventHandler(this.btnBuyLater_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Xóa";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(131, 68);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Tag = "";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // imgProduct
            // 
            this.imgProduct.BackColor = System.Drawing.Color.White;
            this.imgProduct.Location = new System.Drawing.Point(10, 10);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(100, 100);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduct.TabIndex = 0;
            this.imgProduct.TabStop = false;
            // 
            // tabGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.edtCountProduct);
            this.Controls.Add(this.lbCountProduct);
            this.Controls.Add(this.btnBuyLater);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbNameProduct);
            this.Controls.Add(this.imgProduct);
            this.Name = "tabGood";
            this.Size = new System.Drawing.Size(798, 118);
            this.Tag = "12345680";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgProduct;
        private System.Windows.Forms.Label lbNameProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBuyLater;
        private Bunifu.Framework.UI.BunifuImageButton btnMinus;
        private Bunifu.Framework.UI.BunifuImageButton btnPlus;
        private Bunifu.Framework.BunifuCustomTextbox edtCountProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCountProduct;
    }
}
