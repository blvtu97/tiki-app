namespace Server
{
    partial class ReportView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBTIKIDataSet = new Server.DBTIKIDataSet();
            this.CHITIET_HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.COMMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptCustomer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CUSTOMERTableAdapter = new Server.DBTIKIDataSetTableAdapters.CUSTOMERTableAdapter();
            this.rptBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CHITIET_HOADONTableAdapter = new Server.DBTIKIDataSetTableAdapters.CHITIET_HOADONTableAdapter();
            this.rptComment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.COMMENTTableAdapter = new Server.DBTIKIDataSetTableAdapters.COMMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBTIKIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIET_HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CUSTOMERBindingSource
            // 
            this.CUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.CUSTOMERBindingSource.DataSource = this.DBTIKIDataSet;
            // 
            // DBTIKIDataSet
            // 
            this.DBTIKIDataSet.DataSetName = "DBTIKIDataSet";
            this.DBTIKIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHITIET_HOADONBindingSource
            // 
            this.CHITIET_HOADONBindingSource.DataMember = "CHITIET_HOADON";
            this.CHITIET_HOADONBindingSource.DataSource = this.DBTIKIDataSet;
            // 
            // COMMENTBindingSource
            // 
            this.COMMENTBindingSource.DataMember = "COMMENT";
            this.COMMENTBindingSource.DataSource = this.DBTIKIDataSet;
            // 
            // rptCustomer
            // 
            this.rptCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CUSTOMERBindingSource;
            this.rptCustomer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptCustomer.LocalReport.ReportEmbeddedResource = "Server.GUI.ReportCustomer.rdlc";
            this.rptCustomer.Location = new System.Drawing.Point(0, 0);
            this.rptCustomer.Name = "rptCustomer";
            this.rptCustomer.ServerReport.BearerToken = null;
            this.rptCustomer.Size = new System.Drawing.Size(800, 450);
            this.rptCustomer.TabIndex = 0;
            // 
            // CUSTOMERTableAdapter
            // 
            this.CUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // rptBill
            // 
            this.rptBill.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.CHITIET_HOADONBindingSource;
            this.rptBill.LocalReport.DataSources.Add(reportDataSource2);
            this.rptBill.LocalReport.ReportEmbeddedResource = "Server.GUI.ReportBill.rdlc";
            this.rptBill.Location = new System.Drawing.Point(0, 0);
            this.rptBill.Name = "rptBill";
            this.rptBill.ServerReport.BearerToken = null;
            this.rptBill.Size = new System.Drawing.Size(800, 450);
            this.rptBill.TabIndex = 1;
            // 
            // CHITIET_HOADONTableAdapter
            // 
            this.CHITIET_HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // rptComment
            // 
            this.rptComment.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.COMMENTBindingSource;
            this.rptComment.LocalReport.DataSources.Add(reportDataSource3);
            this.rptComment.LocalReport.ReportEmbeddedResource = "Server.GUI.ReportComment.rdlc";
            this.rptComment.Location = new System.Drawing.Point(0, 0);
            this.rptComment.MinimumSize = new System.Drawing.Size(800, 450);
            this.rptComment.Name = "rptComment";
            this.rptComment.ServerReport.BearerToken = null;
            this.rptComment.Size = new System.Drawing.Size(800, 450);
            this.rptComment.TabIndex = 2;
            // 
            // COMMENTTableAdapter
            // 
            this.COMMENTTableAdapter.ClearBeforeFill = true;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptComment);
            this.Controls.Add(this.rptBill);
            this.Controls.Add(this.rptCustomer);
            this.Name = "ReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportView";
            this.Load += new System.EventHandler(this.ReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBTIKIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIET_HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptCustomer;
        private System.Windows.Forms.BindingSource CUSTOMERBindingSource;
        private DBTIKIDataSet DBTIKIDataSet;
        private DBTIKIDataSetTableAdapters.CUSTOMERTableAdapter CUSTOMERTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptBill;
        private System.Windows.Forms.BindingSource CHITIET_HOADONBindingSource;
        private DBTIKIDataSetTableAdapters.CHITIET_HOADONTableAdapter CHITIET_HOADONTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptComment;
        private System.Windows.Forms.BindingSource COMMENTBindingSource;
        private DBTIKIDataSetTableAdapters.COMMENTTableAdapter COMMENTTableAdapter;
    }
}