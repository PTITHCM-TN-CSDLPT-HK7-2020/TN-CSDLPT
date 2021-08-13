using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class fm_XtraRpt_Scores : Form
    {
        public fm_XtraRpt_Scores()
        {
            InitializeComponent();
        }


        private void fm_XtraRpt_Scores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);

        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string malop= mALOPComboBox.SelectedValue.ToString();
            string mamh= mAMHComboBox.SelectedValue.ToString();
            int lan= int.Parse(Lan_numberic_UD.Value.ToString());
            XtraReport_Scores rpt = new XtraReport_Scores(malop, mamh, lan);
            rpt.xrLblLop.Text = malop;
            rpt.xrLblMH.Text = mamh;
            rpt.xrLblLan.Text = lan.ToString();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}
