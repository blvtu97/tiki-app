namespace Tiki_app
{
    partial class tabProductSamples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabProductSamples));
            this.ratingProduct = new Bunifu.Framework.UI.BunifuRating();
            this.lbNameProduct = new System.Windows.Forms.Label();
            this.lbPriceCurrent = new System.Windows.Forms.Label();
            this.lbPriceOld = new System.Windows.Forms.Label();
            this.imgProduct = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingProduct
            // 
            this.ratingProduct.BackColor = System.Drawing.Color.Transparent;
            this.ratingProduct.Enabled = false;
            this.ratingProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(190)))), ((int)(((byte)(32)))));
            this.ratingProduct.Location = new System.Drawing.Point(18, 294);
            this.ratingProduct.Name = "ratingProduct";
            this.ratingProduct.Size = new System.Drawing.Size(180, 24);
            this.ratingProduct.TabIndex = 1;
            this.ratingProduct.Value = 0;
            this.ratingProduct.Click += new System.EventHandler(this.product_Click);
            // 
            // lbNameProduct
            // 
            this.lbNameProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbNameProduct.Location = new System.Drawing.Point(20, 198);
            this.lbNameProduct.Name = "lbNameProduct";
            this.lbNameProduct.Size = new System.Drawing.Size(178, 40);
            this.lbNameProduct.TabIndex = 2;
            this.lbNameProduct.Text = "Tên sản phẩm";
            this.lbNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNameProduct.Click += new System.EventHandler(this.product_Click);
            // 
            // lbPriceCurrent
            // 
            this.lbPriceCurrent.AutoSize = true;
            this.lbPriceCurrent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceCurrent.Location = new System.Drawing.Point(19, 238);
            this.lbPriceCurrent.Name = "lbPriceCurrent";
            this.lbPriceCurrent.Size = new System.Drawing.Size(88, 21);
            this.lbPriceCurrent.TabIndex = 3;
            this.lbPriceCurrent.Text = "Giá hiện tại";
            this.lbPriceCurrent.Click += new System.EventHandler(this.product_Click);
            // 
            // lbPriceOld
            // 
            this.lbPriceOld.AutoSize = true;
            this.lbPriceOld.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceOld.Location = new System.Drawing.Point(19, 270);
            this.lbPriceOld.Name = "lbPriceOld";
            this.lbPriceOld.Size = new System.Drawing.Size(53, 21);
            this.lbPriceOld.TabIndex = 4;
            this.lbPriceOld.Text = "Giá cũ";
            this.lbPriceOld.Click += new System.EventHandler(this.product_Click);
            // 
            // imgProduct
            // 
            this.imgProduct.Image = ((System.Drawing.Image)(resources.GetObject("imgProduct.Image")));
            this.imgProduct.ImageActive = null;
            this.imgProduct.InitialImage = null;
            this.imgProduct.Location = new System.Drawing.Point(20, 15);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(180, 180);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduct.TabIndex = 5;
            this.imgProduct.TabStop = false;
            this.imgProduct.Zoom = 10;
            this.imgProduct.Click += new System.EventHandler(this.product_Click);
            // 
            // tabProductSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.imgProduct);
            this.Controls.Add(this.lbPriceOld);
            this.Controls.Add(this.lbPriceCurrent);
            this.Controls.Add(this.lbNameProduct);
            this.Controls.Add(this.ratingProduct);
            this.DoubleBuffered = true;
            this.Name = "tabProductSamples";
            this.Size = new System.Drawing.Size(220, 330);
            this.Tag = "12345678";
            this.Click += new System.EventHandler(this.product_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuRating ratingProduct;
        private System.Windows.Forms.Label lbNameProduct;
        private System.Windows.Forms.Label lbPriceCurrent;
        private System.Windows.Forms.Label lbPriceOld;
        private Bunifu.Framework.UI.BunifuImageButton imgProduct;
    }
}
