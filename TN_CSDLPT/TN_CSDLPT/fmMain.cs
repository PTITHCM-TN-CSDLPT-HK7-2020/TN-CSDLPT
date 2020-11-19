using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class fmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            ribPg_Tabbar.Visible = false;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btn_Login_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(fmLogin));
            if (frm != null) frm.Activate();
            else
            {
                fmLogin f = new fmLogin();
                f.MdiParent = this;
                f.Show();
            }

        }
        public void HienThiTTUser()
        {

            Stslb_ID.Text = "Mã giáo viên: "+Program.username;
            Stslb_Name.Text = "Họ và tên: "+Program.mHoten;
            Stslb_Group.Text = "Nhóm: "+Program.mGroup;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        //==============================Event button=============================================//
        private void barBtn_Subject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(fmSubject));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fmSubject f = new fmSubject();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barBtn_Farculty_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(fmFarculty));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fmFarculty f = new fmFarculty();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
