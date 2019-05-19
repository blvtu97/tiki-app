using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Server
{
    public partial class ReportView : Form
    {
        static public DataManager dataType;
        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DBTIKIDataSet.COMMENT' table. You can move, or remove it, as needed.
            this.COMMENTTableAdapter.Fill(this.DBTIKIDataSet.COMMENT);
            // TODO: This line of code loads data into the 'DBTIKIDataSet.CHITIET_HOADON' table. You can move, or remove it, as needed.
            this.CHITIET_HOADONTableAdapter.Fill(this.DBTIKIDataSet.CHITIET_HOADON);
            // TODO: This line of code loads data into the 'DBTIKIDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.CUSTOMERTableAdapter.Fill(this.DBTIKIDataSet.CUSTOMER);

            this.rptCustomer.RefreshReport();
            this.rptBill.RefreshReport();
            this.rptComment.RefreshReport();

            ReportViewer[] reportViews = { rptBill, rptComment, rptCustomer };
            foreach (ReportViewer rp in reportViews)
                rp.Enabled = false;
            switch(dataType)
            {
                case DataManager.CUSTOMER:
                    rptCustomer.Enabled = true;
                    rptCustomer.BringToFront();
                    break;

               case DataManager.DETAILBILL:
                    rptBill.Enabled = true;
                    rptBill.BringToFront();
                    break;

               case DataManager.COMMENT:
                    rptComment.Enabled = true;
                    rptComment.BringToFront();
                    break;
            }
        }
    }
}
