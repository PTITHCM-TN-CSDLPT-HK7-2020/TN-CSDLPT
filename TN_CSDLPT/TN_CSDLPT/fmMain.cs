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
            ribbonPage_Stu.Visible = false;
            ribbonPageGroup_CreateAccount.Visible = false;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
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

        private void barBtn_Question_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(fmQuestion));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                fmQuestion f = new fmQuestion();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barBtn_RegisTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(fmRegistTest));
            if(form != null)
            {
                form.Activate();
            }
            else
            {
                fmRegistTest f = new fmRegistTest();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//Form thi thử
        {
            Form form = this.CheckExists(typeof(fmDoExam));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                fmDoExam f = new fmDoExam();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_TestStu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(fmDoExam));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                fmDoExam f = new fmDoExam();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void Xe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(fmExamHistoryResult));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                fmExamHistoryResult f = new fmExamHistoryResult();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_ScoreTable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(fmScoreTable));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                fmScoreTable f = new fmScoreTable();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void barButtonItem2_Createaccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(fmCreateAccount));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                fmCreateAccount f = new fmCreateAccount();
                f.MdiParent = this;
                f.Show();
            }
        }
        //==========Lưu bài thi khi đóng cả form chính
        private void fmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.CheckExists(typeof(fmDoExam));
            if (form != null)
            {

            }
        }

      
    }
}
