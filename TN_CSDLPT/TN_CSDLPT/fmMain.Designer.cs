namespace TN_CSDLPT
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Login = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Class = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Farculty = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Subject = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_RegisTest = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Question = new DevExpress.XtraBars.BarButtonItem();
            this.ribPage_System = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribPageGroup_Student = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPg_Tabbar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Stslb_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.Stslb_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.Stslb_Group = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_Login,
            this.barButtonItem1,
            this.barButtonItem3,
            this.barBtn_Class,
            this.barBtn_Farculty,
            this.barBtn_Subject,
            this.barBtn_RegisTest,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barBtn_Question});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribPage_System,
            this.ribPg_Tabbar});
            this.ribbonControl1.Size = new System.Drawing.Size(1237, 178);
            // 
            // btn_Login
            // 
            this.btn_Login.Caption = "Đăng nhập";
            this.btn_Login.Id = 1;
            this.btn_Login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.ImageOptions.Image")));
            this.btn_Login.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.ImageOptions.LargeImage")));
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Login_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barBtn_Class
            // 
            this.barBtn_Class.Caption = "Lớp";
            this.barBtn_Class.Id = 6;
            this.barBtn_Class.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Class.ImageOptions.Image")));
            this.barBtn_Class.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Class.ImageOptions.LargeImage")));
            this.barBtn_Class.Name = "barBtn_Class";
            // 
            // barBtn_Farculty
            // 
            this.barBtn_Farculty.Caption = "Khoa";
            this.barBtn_Farculty.Id = 7;
            this.barBtn_Farculty.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Farculty.ImageOptions.Image")));
            this.barBtn_Farculty.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Farculty.ImageOptions.LargeImage")));
            this.barBtn_Farculty.Name = "barBtn_Farculty";
            this.barBtn_Farculty.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Farculty_ItemClick);
            // 
            // barBtn_Subject
            // 
            this.barBtn_Subject.Caption = "Môn thi";
            this.barBtn_Subject.Id = 8;
            this.barBtn_Subject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Subject.ImageOptions.Image")));
            this.barBtn_Subject.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Subject.ImageOptions.LargeImage")));
            this.barBtn_Subject.Name = "barBtn_Subject";
            this.barBtn_Subject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Subject_ItemClick);
            // 
            // barBtn_RegisTest
            // 
            this.barBtn_RegisTest.Caption = "Đăng ký thi";
            this.barBtn_RegisTest.Id = 9;
            this.barBtn_RegisTest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_RegisTest.ImageOptions.Image")));
            this.barBtn_RegisTest.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_RegisTest.ImageOptions.LargeImage")));
            this.barBtn_RegisTest.Name = "barBtn_RegisTest";
            this.barBtn_RegisTest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_RegisTest_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Thi thử";
            this.barButtonItem8.Id = 10;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Bảng điểm";
            this.barButtonItem9.Id = 11;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Danh sách đăng ký thi";
            this.barButtonItem10.Id = 12;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barBtn_Question
            // 
            this.barBtn_Question.Caption = "Bộ đề thi";
            this.barBtn_Question.Id = 14;
            this.barBtn_Question.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Question.ImageOptions.Image")));
            this.barBtn_Question.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Question.ImageOptions.LargeImage")));
            this.barBtn_Question.Name = "barBtn_Question";
            this.barBtn_Question.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Question_ItemClick);
            // 
            // ribPage_System
            // 
            this.ribPage_System.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribPageGroup_Student});
            this.ribPage_System.Name = "ribPage_System";
            this.ribPage_System.Text = "Hệ thống";
            // 
            // ribPageGroup_Student
            // 
            this.ribPageGroup_Student.ItemLinks.Add(this.btn_Login);
            this.ribPageGroup_Student.ItemLinks.Add(this.barButtonItem1);
            this.ribPageGroup_Student.Name = "ribPageGroup_Student";
            // 
            // ribPg_Tabbar
            // 
            this.ribPg_Tabbar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribPg_Tabbar.Name = "ribPg_Tabbar";
            this.ribPg_Tabbar.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_Farculty);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_Class);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý user";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_Subject);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_Question);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_RegisTest);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý đề thi";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Xem báo cáo";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Stslb_ID,
            this.Stslb_Name,
            this.Stslb_Group});
            this.statusStrip1.Location = new System.Drawing.Point(0, 677);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1237, 25);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Stslb_ID
            // 
            this.Stslb_ID.Name = "Stslb_ID";
            this.Stslb_ID.Size = new System.Drawing.Size(30, 20);
            this.Stslb_ID.Text = "Mã";
            // 
            // Stslb_Name
            // 
            this.Stslb_Name.Name = "Stslb_Name";
            this.Stslb_Name.Size = new System.Drawing.Size(54, 20);
            this.Stslb_Name.Text = "Họ tên";
            // 
            // Stslb_Group
            // 
            this.Stslb_Group.Name = "Stslb_Group";
            this.Stslb_Group.Size = new System.Drawing.Size(50, 20);
            this.Stslb_Group.Text = "Nhóm";
            // 
            // fmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 702);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm thi trắc nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPage_System;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPageGroup_Student;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btn_Login;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public System.Windows.Forms.ToolStripStatusLabel Stslb_ID;
        public System.Windows.Forms.ToolStripStatusLabel Stslb_Name;
        public System.Windows.Forms.ToolStripStatusLabel Stslb_Group;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtn_Subject;
        private DevExpress.XtraBars.BarButtonItem barBtn_RegisTest;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribPg_Tabbar;
        private DevExpress.XtraBars.BarButtonItem barBtn_Question;
        public DevExpress.XtraBars.BarButtonItem barBtn_Class;
        public DevExpress.XtraBars.BarButtonItem barBtn_Farculty;
    }
}

