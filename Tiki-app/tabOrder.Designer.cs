namespace Tiki_app
{
    partial class tabOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabOrder));
            this.btnOrder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMoney2 = new System.Windows.Forms.Label();
            this.lbMoney1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.ActiveBorderThickness = 1;
            this.btnOrder.ActiveCornerRadius = 20;
            this.btnOrder.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOrder.ActiveForecolor = System.Drawing.Color.White;
            this.btnOrder.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.BackgroundImage")));
            this.btnOrder.ButtonText = "Đặt hàng";
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOrder.IdleBorderThickness = 1;
            this.btnOrder.IdleCornerRadius = 20;
            this.btnOrder.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.btnOrder.IdleForecolor = System.Drawing.Color.White;
            this.btnOrder.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.btnOrder.Location = new System.Drawing.Point(8, 145);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(180, 50);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạm tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label3.Location = new System.Drawing.Point(77, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "(Đã bao gồm VAT)";
            // 
            // lbMoney2
            // 
            this.lbMoney2.AutoSize = true;
            this.lbMoney2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbMoney2.Location = new System.Drawing.Point(90, 91);
            this.lbMoney2.Name = "lbMoney2";
            this.lbMoney2.Size = new System.Drawing.Size(17, 20);
            this.lbMoney2.TabIndex = 4;
            this.lbMoney2.Text = "0";
            // 
            // lbMoney1
            // 
            this.lbMoney1.AutoSize = true;
            this.lbMoney1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbMoney1.Location = new System.Drawing.Point(90, 21);
            this.lbMoney1.Name = "lbMoney1";
            this.lbMoney1.Size = new System.Drawing.Size(17, 20);
            this.lbMoney1.TabIndex = 5;
            this.lbMoney1.Text = "0";
            // 
            // tabOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbMoney1);
            this.Controls.Add(this.lbMoney2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrder);
            this.Name = "tabOrder";
            this.Size = new System.Drawing.Size(200, 200);
            this.Tag = "12345681";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMoney2;
        private System.Windows.Forms.Label lbMoney1;
    }
}
