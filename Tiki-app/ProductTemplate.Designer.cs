namespace Tiki_app
{
    partial class ProductTemplate
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
            this.ratingProduct.ForeColor = System.Drawing.Color.Green;
            this.ratingProduct.Location = new System.Drawing.Point(18, 296);
            this.ratingProduct.Name = "ratingProduct";
            this.ratingProduct.Size = new System.Drawing.Size(180, 22);
            this.ratingProduct.TabIndex = 1;
            this.ratingProduct.Value = 0;
            // 
            // lbNameProduct
            // 
            this.lbNameProduct.AutoSize = true;
            this.lbNameProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameProduct.Location = new System.Drawing.Point(19, 199);
            this.lbNameProduct.Name = "lbNameProduct";
            this.lbNameProduct.Size = new System.Drawing.Size(105, 21);
            this.lbNameProduct.TabIndex = 2;
            this.lbNameProduct.Text = "Tên sản phẩm";
            // 
            // lbPriceCurrent
            // 
            this.lbPriceCurrent.AutoSize = true;
            this.lbPriceCurrent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceCurrent.Location = new System.Drawing.Point(19, 236);
            this.lbPriceCurrent.Name = "lbPriceCurrent";
            this.lbPriceCurrent.Size = new System.Drawing.Size(88, 21);
            this.lbPriceCurrent.TabIndex = 3;
            this.lbPriceCurrent.Text = "Giá hiện tại";
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
            // 
            // imgProduct
            // 
            this.imgProduct.Image = global::Tiki_app.Properties.Resources.img_product;
            this.imgProduct.ImageActive = null;
            this.imgProduct.Location = new System.Drawing.Point(18, 16);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(180, 180);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduct.TabIndex = 5;
            this.imgProduct.TabStop = false;
            this.imgProduct.Zoom = 10;
            // 
            // ProductTemplate
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
            this.Name = "ProductTemplate";
            this.Size = new System.Drawing.Size(220, 333);
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
