namespace Tiki_app
{
    partial class pageNoProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageNoProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContinue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.contactUs1 = new Tiki_app.tabContactUs();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIỎ HÀNG (0 sản phẩm)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 374);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiki_app.Properties.Resources.ic_cart;
            this.pictureBox1.Location = new System.Drawing.Point(409, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Không có sản phẩm nào trong giỏ hàng của bạn.";
            // 
            // btnContinue
            // 
            this.btnContinue.ActiveBorderThickness = 1;
            this.btnContinue.ActiveCornerRadius = 20;
            this.btnContinue.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnContinue.ActiveForecolor = System.Drawing.Color.White;
            this.btnContinue.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnContinue.BackColor = System.Drawing.Color.White;
            this.btnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinue.BackgroundImage")));
            this.btnContinue.ButtonText = "Tiếp tục mua sắm";
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnContinue.IdleBorderThickness = 1;
            this.btnContinue.IdleCornerRadius = 20;
            this.btnContinue.IdleFillColor = System.Drawing.Color.White;
            this.btnContinue.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnContinue.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnContinue.Location = new System.Drawing.Point(387, 281);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(5);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(229, 67);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Tag = "12345686";
            this.btnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // contactUs1
            // 
            this.contactUs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.contactUs1.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactUs1.Location = new System.Drawing.Point(0, 374);
            this.contactUs1.Name = "contactUs1";
            this.contactUs1.Size = new System.Drawing.Size(1000, 458);
            this.contactUs1.TabIndex = 3;
            // 
            // pageNoProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.contactUs1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "pageNoProduct";
            this.Size = new System.Drawing.Size(1000, 833);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContinue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private tabContactUs contactUs1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
