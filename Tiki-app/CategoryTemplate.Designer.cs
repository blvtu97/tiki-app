namespace Tiki_app
{
    partial class CategoryTemplate
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
            this.lbNameCategory = new System.Windows.Forms.Label();
            this.imgCategory = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameCategory
            // 
            this.lbNameCategory.AutoSize = true;
            this.lbNameCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCategory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNameCategory.Location = new System.Drawing.Point(20, 142);
            this.lbNameCategory.Name = "lbNameCategory";
            this.lbNameCategory.Size = new System.Drawing.Size(151, 25);
            this.lbNameCategory.TabIndex = 1;
            this.lbNameCategory.Text = "Name Category";
            // 
            // imgCategory
            // 
            this.imgCategory.Image = global::Tiki_app.Properties.Resources.img_category;
            this.imgCategory.ImageActive = null;
            this.imgCategory.Location = new System.Drawing.Point(26, 10);
            this.imgCategory.Name = "imgCategory";
            this.imgCategory.Size = new System.Drawing.Size(120, 120);
            this.imgCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCategory.TabIndex = 0;
            this.imgCategory.TabStop = false;
            this.imgCategory.Zoom = 10;
            // 
            // CategoryTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.lbNameCategory);
            this.Controls.Add(this.imgCategory);
            this.DoubleBuffered = true;
            this.Name = "CategoryTemplate";
            this.Size = new System.Drawing.Size(180, 180);
            ((System.ComponentModel.ISupportInitialize)(this.imgCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton imgCategory;
        private System.Windows.Forms.Label lbNameCategory;
    }
}
