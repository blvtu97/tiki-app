namespace Tiki_app
{
    partial class pagePayProduct
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
            this.ListProduct = new System.Windows.Forms.Panel();
            this.tabContactUs1 = new Tiki_app.tabContactUs();
            this.tabOrder = new Tiki_app.tabOrder();
            this.SuspendLayout();
            // 
            // ListProduct
            // 
            this.ListProduct.AutoScroll = true;
            this.ListProduct.Location = new System.Drawing.Point(3, 0);
            this.ListProduct.Name = "ListProduct";
            this.ListProduct.Size = new System.Drawing.Size(790, 472);
            this.ListProduct.TabIndex = 0;
            // 
            // tabContactUs1
            // 
            this.tabContactUs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.tabContactUs1.Location = new System.Drawing.Point(3, 478);
            this.tabContactUs1.Name = "tabContactUs1";
            this.tabContactUs1.Size = new System.Drawing.Size(1008, 446);
            this.tabContactUs1.TabIndex = 2;
            // 
            // tabOrder
            // 
            this.tabOrder.BackColor = System.Drawing.Color.White;
            this.tabOrder.Location = new System.Drawing.Point(797, 3);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.PriceReal = "0";
            this.tabOrder.PriceTemporary = "0";
            this.tabOrder.Size = new System.Drawing.Size(200, 200);
            this.tabOrder.TabIndex = 1;
            // 
            // pagePayProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tabContactUs1);
            this.Controls.Add(this.tabOrder);
            this.Controls.Add(this.ListProduct);
            this.DoubleBuffered = true;
            this.Name = "pagePayProduct";
            this.Size = new System.Drawing.Size(847, 771);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListProduct;
        private tabOrder tabOrder;
        private tabContactUs tabContactUs1;
    }
}
