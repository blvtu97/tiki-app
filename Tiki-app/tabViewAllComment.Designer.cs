namespace Tiki_app
{
    partial class tabViewAllComment
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewComment4 = new Tiki_app.tabViewOneComment();
            this.viewComment3 = new Tiki_app.tabViewOneComment();
            this.viewComment2 = new Tiki_app.tabViewOneComment();
            this.viewComment1 = new Tiki_app.tabViewOneComment();
            this.contactUs1 = new Tiki_app.tabContactUs();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Tất cả các sao",
            "5 sao",
            "4 sao",
            "3 sao",
            "2 sao",
            "1 sao",
            "Hài lòng",
            "Chưa hài lòng"});
            this.comboBox3.Location = new System.Drawing.Point(572, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 25);
            this.comboBox3.TabIndex = 33;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tất cả các khách hàng",
            "Khách đã mua hàng"});
            this.comboBox2.Location = new System.Drawing.Point(382, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 25);
            this.comboBox2.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hữu ích",
            "Mới nhất"});
            this.comboBox1.Location = new System.Drawing.Point(183, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 25);
            this.comboBox1.TabIndex = 31;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(20, 9);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(143, 21);
            this.bunifuCustomLabel10.TabIndex = 30;
            this.bunifuCustomLabel10.Text = "Chọn xem nhận xét";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 47);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.viewComment4);
            this.panel2.Controls.Add(this.viewComment3);
            this.panel2.Controls.Add(this.viewComment2);
            this.panel2.Controls.Add(this.viewComment1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 684);
            this.panel2.TabIndex = 35;
            // 
            // viewComment4
            // 
            this.viewComment4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewComment4.CommentProduct = "Nhận xét";
            this.viewComment4.DayCommentProduct = "Ngày comment";
            this.viewComment4.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewComment4.ImageCustomer = null;
            this.viewComment4.IsBuyProduct = "Đã mua sản phẩm";
            this.viewComment4.Location = new System.Drawing.Point(0, 510);
            this.viewComment4.Name = "viewComment4";
            this.viewComment4.NameCustomer = "Họ và tên";
            this.viewComment4.RatingProduct = 0;
            this.viewComment4.ReactionProduct = "Hài lòng";
            this.viewComment4.Size = new System.Drawing.Size(949, 168);
            this.viewComment4.TabIndex = 3;
            // 
            // viewComment3
            // 
            this.viewComment3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewComment3.CommentProduct = "Nhận xét";
            this.viewComment3.DayCommentProduct = "Ngày comment";
            this.viewComment3.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewComment3.ImageCustomer = null;
            this.viewComment3.IsBuyProduct = "Đã mua sản phẩm";
            this.viewComment3.Location = new System.Drawing.Point(0, 340);
            this.viewComment3.Name = "viewComment3";
            this.viewComment3.NameCustomer = "Họ và tên";
            this.viewComment3.RatingProduct = 0;
            this.viewComment3.ReactionProduct = "Hài lòng";
            this.viewComment3.Size = new System.Drawing.Size(949, 170);
            this.viewComment3.TabIndex = 2;
            // 
            // viewComment2
            // 
            this.viewComment2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewComment2.CommentProduct = "Nhận xét";
            this.viewComment2.DayCommentProduct = "Ngày comment";
            this.viewComment2.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewComment2.ImageCustomer = null;
            this.viewComment2.IsBuyProduct = "Đã mua sản phẩm";
            this.viewComment2.Location = new System.Drawing.Point(0, 170);
            this.viewComment2.Name = "viewComment2";
            this.viewComment2.NameCustomer = "Họ và tên";
            this.viewComment2.RatingProduct = 0;
            this.viewComment2.ReactionProduct = "Hài lòng";
            this.viewComment2.Size = new System.Drawing.Size(949, 170);
            this.viewComment2.TabIndex = 1;
            // 
            // viewComment1
            // 
            this.viewComment1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewComment1.CommentProduct = "Nhận xét";
            this.viewComment1.DayCommentProduct = "Ngày comment";
            this.viewComment1.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewComment1.ImageCustomer = null;
            this.viewComment1.IsBuyProduct = "Đã mua sản phẩm";
            this.viewComment1.Location = new System.Drawing.Point(0, 0);
            this.viewComment1.Name = "viewComment1";
            this.viewComment1.NameCustomer = "Họ và tên";
            this.viewComment1.RatingProduct = 0;
            this.viewComment1.ReactionProduct = "Hài lòng";
            this.viewComment1.Size = new System.Drawing.Size(949, 170);
            this.viewComment1.TabIndex = 0;
            // 
            // contactUs1
            // 
            this.contactUs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.contactUs1.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactUs1.Location = new System.Drawing.Point(0, 731);
            this.contactUs1.Name = "contactUs1";
            this.contactUs1.Size = new System.Drawing.Size(949, 458);
            this.contactUs1.TabIndex = 36;
            // 
            // ViewAllComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contactUs1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAllComment";
            this.Size = new System.Drawing.Size(949, 1182);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private tabViewOneComment viewComment3;
        private tabViewOneComment viewComment2;
        private tabViewOneComment viewComment1;
        private tabViewOneComment viewComment4;
        private tabContactUs contactUs1;
    }
}
