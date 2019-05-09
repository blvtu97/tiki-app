namespace Tiki_app
{
    partial class tabViewOneComment
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
            this.lbReactionProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbIsBuyProduct = new System.Windows.Forms.Label();
            this.lbNameCustomer = new System.Windows.Forms.Label();
            this.lbDayCommentProduct = new System.Windows.Forms.Label();
            this.lbCommentProduct = new System.Windows.Forms.Label();
            this.imgCustomer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingProduct
            // 
            this.ratingProduct.BackColor = System.Drawing.Color.Transparent;
            this.ratingProduct.Enabled = false;
            this.ratingProduct.ForeColor = System.Drawing.Color.SeaGreen;
            this.ratingProduct.Location = new System.Drawing.Point(153, 24);
            this.ratingProduct.Name = "ratingProduct";
            this.ratingProduct.Size = new System.Drawing.Size(215, 27);
            this.ratingProduct.TabIndex = 1;
            this.ratingProduct.Value = 0;
            // 
            // lbReactionProduct
            // 
            this.lbReactionProduct.AutoSize = true;
            this.lbReactionProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReactionProduct.Location = new System.Drawing.Point(401, 30);
            this.lbReactionProduct.Name = "lbReactionProduct";
            this.lbReactionProduct.Size = new System.Drawing.Size(68, 21);
            this.lbReactionProduct.TabIndex = 2;
            this.lbReactionProduct.Text = "Hài lòng";
            // 
            // lbIsBuyProduct
            // 
            this.lbIsBuyProduct.AutoSize = true;
            this.lbIsBuyProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsBuyProduct.Location = new System.Drawing.Point(162, 63);
            this.lbIsBuyProduct.Name = "lbIsBuyProduct";
            this.lbIsBuyProduct.Size = new System.Drawing.Size(136, 21);
            this.lbIsBuyProduct.TabIndex = 3;
            this.lbIsBuyProduct.Text = "Đã mua sản phẩm";
            // 
            // lbNameCustomer
            // 
            this.lbNameCustomer.AutoSize = true;
            this.lbNameCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCustomer.Location = new System.Drawing.Point(22, 107);
            this.lbNameCustomer.Name = "lbNameCustomer";
            this.lbNameCustomer.Size = new System.Drawing.Size(76, 21);
            this.lbNameCustomer.TabIndex = 4;
            this.lbNameCustomer.Text = "Họ và tên";
            // 
            // lbDayCommentProduct
            // 
            this.lbDayCommentProduct.AutoSize = true;
            this.lbDayCommentProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayCommentProduct.Location = new System.Drawing.Point(13, 138);
            this.lbDayCommentProduct.Name = "lbDayCommentProduct";
            this.lbDayCommentProduct.Size = new System.Drawing.Size(117, 21);
            this.lbDayCommentProduct.TabIndex = 5;
            this.lbDayCommentProduct.Text = "Ngày comment";
            // 
            // lbCommentProduct
            // 
            this.lbCommentProduct.AutoSize = true;
            this.lbCommentProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommentProduct.Location = new System.Drawing.Point(162, 107);
            this.lbCommentProduct.Name = "lbCommentProduct";
            this.lbCommentProduct.Size = new System.Drawing.Size(72, 21);
            this.lbCommentProduct.TabIndex = 6;
            this.lbCommentProduct.Text = "Nhận xét";
            // 
            // imgCustomer
            // 
            this.imgCustomer.Location = new System.Drawing.Point(17, 24);
            this.imgCustomer.Name = "imgCustomer";
            this.imgCustomer.Size = new System.Drawing.Size(80, 80);
            this.imgCustomer.TabIndex = 0;
            this.imgCustomer.TabStop = false;
            // 
            // tabViewOneComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbCommentProduct);
            this.Controls.Add(this.lbDayCommentProduct);
            this.Controls.Add(this.lbNameCustomer);
            this.Controls.Add(this.lbIsBuyProduct);
            this.Controls.Add(this.lbReactionProduct);
            this.Controls.Add(this.ratingProduct);
            this.Controls.Add(this.imgCustomer);
            this.DoubleBuffered = true;
            this.Name = "tabViewOneComment";
            this.Size = new System.Drawing.Size(1000, 168);
            ((System.ComponentModel.ISupportInitialize)(this.imgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCustomer;
        private Bunifu.Framework.UI.BunifuRating ratingProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel lbReactionProduct;
        private System.Windows.Forms.Label lbIsBuyProduct;
        private System.Windows.Forms.Label lbNameCustomer;
        private System.Windows.Forms.Label lbDayCommentProduct;
        private System.Windows.Forms.Label lbCommentProduct;
    }
}
