using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT
{
    public partial class XtraReport_Scores : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_Scores(string malop, string mamh, int lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = mamh;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }

    }
}
