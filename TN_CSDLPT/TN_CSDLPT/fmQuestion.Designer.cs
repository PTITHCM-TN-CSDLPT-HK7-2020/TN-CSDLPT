namespace TN_CSDLPT
{
    partial class fmQuestion
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmQuestion));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Undo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Forbid = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new TN_CSDLPT.DS();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new TN_CSDLPT.DSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.bODEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView_Question = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpB_txtQuestion = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tRINHDOComboBox = new System.Windows.Forms.ComboBox();
            this.mAGVTextBox = new System.Windows.Forms.TextBox();
            this.dAP_ANComboBox = new System.Windows.Forms.ComboBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.nOIDUNGTextBox = new System.Windows.Forms.TextBox();
            this.mAMHTextBox = new System.Windows.Forms.TextBox();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Question)).BeginInit();
            this.grpB_txtQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.ForeColor = System.Drawing.Color.Yellow;
            mAMHLabel.Location = new System.Drawing.Point(207, 128);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(113, 22);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã môn học:";
            mAMHLabel.Click += new System.EventHandler(this.mAMHLabel_Click);
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.ForeColor = System.Drawing.Color.Yellow;
            tRINHDOLabel.Location = new System.Drawing.Point(233, 198);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(83, 22);
            tRINHDOLabel.TabIndex = 2;
            tRINHDOLabel.Text = "Trình độ:";
            tRINHDOLabel.Click += new System.EventHandler(this.tRINHDOLabel_Click);
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.ForeColor = System.Drawing.Color.Yellow;
            nOIDUNGLabel.Location = new System.Drawing.Point(232, 330);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(88, 22);
            nOIDUNGLabel.TabIndex = 4;
            nOIDUNGLabel.Text = "Nội dung:";
            nOIDUNGLabel.Click += new System.EventHandler(this.nOIDUNGLabel_Click);
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.ForeColor = System.Drawing.Color.Yellow;
            aLabel.Location = new System.Drawing.Point(290, 418);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(30, 22);
            aLabel.TabIndex = 6;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.ForeColor = System.Drawing.Color.Yellow;
            bLabel.Location = new System.Drawing.Point(290, 464);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(29, 22);
            bLabel.TabIndex = 8;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.ForeColor = System.Drawing.Color.Yellow;
            cLabel.Location = new System.Drawing.Point(914, 413);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(29, 22);
            cLabel.TabIndex = 10;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.ForeColor = System.Drawing.Color.Yellow;
            dLabel.Location = new System.Drawing.Point(914, 462);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(30, 22);
            dLabel.TabIndex = 12;
            dLabel.Text = "D:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.ForeColor = System.Drawing.Color.Yellow;
            dAP_ANLabel.Location = new System.Drawing.Point(871, 334);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(72, 22);
            dAP_ANLabel.TabIndex = 14;
            dAP_ANLabel.Text = "Đáp án:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.ForeColor = System.Drawing.Color.Yellow;
            mAGVLabel.Location = new System.Drawing.Point(207, 268);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(120, 22);
            mAGVLabel.TabIndex = 16;
            mAGVLabel.Text = "Mã giáo viên:";
            mAGVLabel.Click += new System.EventHandler(this.mAGVLabel_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtn_Add,
            this.barBtn_Delete,
            this.barBtn_Undo,
            this.barBtn_Save,
            this.barBtn_Refresh,
            this.barBtn_Forbid,
            this.barBtn_Exit,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Add, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Delete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Undo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Forbid, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Exit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtn_Add
            // 
            this.barBtn_Add.Caption = "Thêm";
            this.barBtn_Add.Id = 0;
            this.barBtn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Add.ImageOptions.Image")));
            this.barBtn_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Add.ImageOptions.LargeImage")));
            this.barBtn_Add.Name = "barBtn_Add";
            this.barBtn_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Add_ItemClick);
            // 
            // barBtn_Delete
            // 
            this.barBtn_Delete.Caption = "Xóa";
            this.barBtn_Delete.Id = 1;
            this.barBtn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Delete.ImageOptions.Image")));
            this.barBtn_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Delete.ImageOptions.LargeImage")));
            this.barBtn_Delete.Name = "barBtn_Delete";
            this.barBtn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Delete_ItemClick);
            // 
            // barBtn_Undo
            // 
            this.barBtn_Undo.Caption = "Phục hồi";
            this.barBtn_Undo.Id = 2;
            this.barBtn_Undo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Undo.ImageOptions.Image")));
            this.barBtn_Undo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Undo.ImageOptions.LargeImage")));
            this.barBtn_Undo.Name = "barBtn_Undo";
            this.barBtn_Undo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Undo_ItemClick);
            // 
            // barBtn_Save
            // 
            this.barBtn_Save.Caption = "Ghi";
            this.barBtn_Save.Id = 3;
            this.barBtn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Save.ImageOptions.Image")));
            this.barBtn_Save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Save.ImageOptions.LargeImage")));
            this.barBtn_Save.Name = "barBtn_Save";
            this.barBtn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Save_ItemClick);
            // 
            // barBtn_Refresh
            // 
            this.barBtn_Refresh.Caption = "Làm mới";
            this.barBtn_Refresh.Id = 4;
            this.barBtn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Refresh.ImageOptions.Image")));
            this.barBtn_Refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Refresh.ImageOptions.LargeImage")));
            this.barBtn_Refresh.Name = "barBtn_Refresh";
            this.barBtn_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Refresh_ItemClick);
            // 
            // barBtn_Forbid
            // 
            this.barBtn_Forbid.Caption = "Hủy";
            this.barBtn_Forbid.Id = 5;
            this.barBtn_Forbid.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_Forbid.ImageOptions.SvgImage")));
            this.barBtn_Forbid.Name = "barBtn_Forbid";
            this.barBtn_Forbid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Forbid_ItemClick);
            // 
            // barBtn_Exit
            // 
            this.barBtn_Exit.Caption = "Đóng";
            this.barBtn_Exit.Id = 6;
            this.barBtn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Exit.ImageOptions.Image")));
            this.barBtn_Exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Exit.ImageOptions.LargeImage")));
            this.barBtn_Exit.Name = "barBtn_Exit";
            this.barBtn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Exit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1697, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1018);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1697, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 988);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1697, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 988);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "BODE";
            this.bODEBindingSource.DataSource = this.dS;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.CHITIETBAITHISVTableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODEGridControl
            // 
            this.bODEGridControl.DataSource = this.bODEBindingSource;
            this.bODEGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bODEGridControl.Location = new System.Drawing.Point(0, 30);
            this.bODEGridControl.MainView = this.gridView_Question;
            this.bODEGridControl.MenuManager = this.barManager1;
            this.bODEGridControl.Name = "bODEGridControl";
            this.bODEGridControl.Size = new System.Drawing.Size(1697, 416);
            this.bODEGridControl.TabIndex = 5;
            this.bODEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Question});
            // 
            // gridView_Question
            // 
            this.gridView_Question.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colMAMH,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gridView_Question.GridControl = this.bODEGridControl;
            this.gridView_Question.Name = "gridView_Question";
            this.gridView_Question.OptionsView.ShowGroupPanel = false;
            this.gridView_Question.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Question_RowClick);
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colCAUHOI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCAUHOI.AppearanceCell.Options.UseBackColor = true;
            this.colCAUHOI.AppearanceCell.Options.UseFont = true;
            this.colCAUHOI.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colCAUHOI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCAUHOI.AppearanceHeader.Options.UseBackColor = true;
            this.colCAUHOI.AppearanceHeader.Options.UseFont = true;
            this.colCAUHOI.Caption = "Câu hỏi";
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 25;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 100;
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colMAMH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceCell.Options.UseBackColor = true;
            this.colMAMH.AppearanceCell.Options.UseFont = true;
            this.colMAMH.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colMAMH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAMH.AppearanceHeader.Options.UseFont = true;
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 125;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colTRINHDO.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRINHDO.AppearanceCell.Options.UseBackColor = true;
            this.colTRINHDO.AppearanceCell.Options.UseFont = true;
            this.colTRINHDO.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colTRINHDO.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRINHDO.AppearanceHeader.Options.UseBackColor = true;
            this.colTRINHDO.AppearanceHeader.Options.UseFont = true;
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            this.colTRINHDO.Width = 125;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colNOIDUNG.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNOIDUNG.AppearanceCell.Options.UseBackColor = true;
            this.colNOIDUNG.AppearanceCell.Options.UseFont = true;
            this.colNOIDUNG.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colNOIDUNG.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNOIDUNG.AppearanceHeader.Options.UseBackColor = true;
            this.colNOIDUNG.AppearanceHeader.Options.UseFont = true;
            this.colNOIDUNG.Caption = "Nội dung";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            this.colNOIDUNG.Width = 125;
            // 
            // colA
            // 
            this.colA.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colA.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colA.AppearanceCell.Options.UseBackColor = true;
            this.colA.AppearanceCell.Options.UseFont = true;
            this.colA.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colA.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colA.AppearanceHeader.Options.UseBackColor = true;
            this.colA.AppearanceHeader.Options.UseFont = true;
            this.colA.Caption = "A";
            this.colA.FieldName = "A";
            this.colA.MinWidth = 25;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            this.colA.Width = 125;
            // 
            // colB
            // 
            this.colB.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colB.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colB.AppearanceCell.Options.UseBackColor = true;
            this.colB.AppearanceCell.Options.UseFont = true;
            this.colB.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colB.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colB.AppearanceHeader.Options.UseBackColor = true;
            this.colB.AppearanceHeader.Options.UseFont = true;
            this.colB.Caption = "B";
            this.colB.FieldName = "B";
            this.colB.MinWidth = 25;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            this.colB.Width = 125;
            // 
            // colC
            // 
            this.colC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colC.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colC.AppearanceCell.Options.UseBackColor = true;
            this.colC.AppearanceCell.Options.UseFont = true;
            this.colC.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colC.AppearanceHeader.Options.UseBackColor = true;
            this.colC.AppearanceHeader.Options.UseFont = true;
            this.colC.Caption = "C";
            this.colC.FieldName = "C";
            this.colC.MinWidth = 25;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            this.colC.Width = 125;
            // 
            // colD
            // 
            this.colD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colD.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colD.AppearanceCell.Options.UseBackColor = true;
            this.colD.AppearanceCell.Options.UseFont = true;
            this.colD.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colD.AppearanceHeader.Options.UseBackColor = true;
            this.colD.AppearanceHeader.Options.UseFont = true;
            this.colD.Caption = "D";
            this.colD.FieldName = "D";
            this.colD.MinWidth = 25;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            this.colD.Width = 125;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colDAP_AN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDAP_AN.AppearanceCell.Options.UseBackColor = true;
            this.colDAP_AN.AppearanceCell.Options.UseFont = true;
            this.colDAP_AN.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colDAP_AN.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDAP_AN.AppearanceHeader.Options.UseBackColor = true;
            this.colDAP_AN.AppearanceHeader.Options.UseFont = true;
            this.colDAP_AN.Caption = "Đáp án";
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 25;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            this.colDAP_AN.Width = 125;
            // 
            // colMAGV
            // 
            this.colMAGV.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colMAGV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAGV.AppearanceCell.Options.UseBackColor = true;
            this.colMAGV.AppearanceCell.Options.UseFont = true;
            this.colMAGV.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.colMAGV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAGV.AppearanceHeader.Options.UseBackColor = true;
            this.colMAGV.AppearanceHeader.Options.UseFont = true;
            this.colMAGV.Caption = "Mã giáo viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            this.colMAGV.Width = 134;
            // 
            // grpB_txtQuestion
            // 
            this.grpB_txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpB_txtQuestion.Controls.Add(this.pictureBox1);
            this.grpB_txtQuestion.Controls.Add(this.label1);
            this.grpB_txtQuestion.Controls.Add(this.tRINHDOComboBox);
            this.grpB_txtQuestion.Controls.Add(mAGVLabel);
            this.grpB_txtQuestion.Controls.Add(this.mAGVTextBox);
            this.grpB_txtQuestion.Controls.Add(dAP_ANLabel);
            this.grpB_txtQuestion.Controls.Add(this.dAP_ANComboBox);
            this.grpB_txtQuestion.Controls.Add(dLabel);
            this.grpB_txtQuestion.Controls.Add(this.dTextBox);
            this.grpB_txtQuestion.Controls.Add(cLabel);
            this.grpB_txtQuestion.Controls.Add(this.cTextBox);
            this.grpB_txtQuestion.Controls.Add(bLabel);
            this.grpB_txtQuestion.Controls.Add(this.bTextBox);
            this.grpB_txtQuestion.Controls.Add(aLabel);
            this.grpB_txtQuestion.Controls.Add(this.aTextBox);
            this.grpB_txtQuestion.Controls.Add(nOIDUNGLabel);
            this.grpB_txtQuestion.Controls.Add(this.nOIDUNGTextBox);
            this.grpB_txtQuestion.Controls.Add(tRINHDOLabel);
            this.grpB_txtQuestion.Controls.Add(mAMHLabel);
            this.grpB_txtQuestion.Controls.Add(this.mAMHTextBox);
            this.grpB_txtQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpB_txtQuestion.ForeColor = System.Drawing.Color.Yellow;
            this.grpB_txtQuestion.Location = new System.Drawing.Point(0, 446);
            this.grpB_txtQuestion.Name = "grpB_txtQuestion";
            this.grpB_txtQuestion.Size = new System.Drawing.Size(1697, 572);
            this.grpB_txtQuestion.TabIndex = 6;
            this.grpB_txtQuestion.TabStop = false;
            this.grpB_txtQuestion.Enter += new System.EventHandler(this.grpB_txtQuestion_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TN_CSDLPT.Properties.Resources.question_mark;
            this.pictureBox1.Location = new System.Drawing.Point(47, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 132);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(589, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thông tin về câu hỏi";
            // 
            // tRINHDOComboBox
            // 
            this.tRINHDOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bODEBindingSource, "TRINHDO", true));
            this.tRINHDOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tRINHDOComboBox.FormattingEnabled = true;
            this.tRINHDOComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.tRINHDOComboBox.Location = new System.Drawing.Point(335, 194);
            this.tRINHDOComboBox.Name = "tRINHDOComboBox";
            this.tRINHDOComboBox.Size = new System.Drawing.Size(251, 30);
            this.tRINHDOComboBox.TabIndex = 2;
            // 
            // mAGVTextBox
            // 
            this.mAGVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "MAGV", true));
            this.mAGVTextBox.Location = new System.Drawing.Point(335, 260);
            this.mAGVTextBox.Name = "mAGVTextBox";
            this.mAGVTextBox.Size = new System.Drawing.Size(251, 30);
            this.mAGVTextBox.TabIndex = 3;
            this.mAGVTextBox.TextChanged += new System.EventHandler(this.mAGVTextBox_TextChanged);
            // 
            // dAP_ANComboBox
            // 
            this.dAP_ANComboBox.AllowDrop = true;
            this.dAP_ANComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "DAP_AN", true));
            this.dAP_ANComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dAP_ANComboBox.FormattingEnabled = true;
            this.dAP_ANComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.dAP_ANComboBox.Location = new System.Drawing.Point(950, 331);
            this.dAP_ANComboBox.Name = "dAP_ANComboBox";
            this.dAP_ANComboBox.Size = new System.Drawing.Size(151, 30);
            this.dAP_ANComboBox.TabIndex = 9;
            // 
            // dTextBox
            // 
            this.dTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "D", true));
            this.dTextBox.Location = new System.Drawing.Point(950, 459);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(520, 30);
            this.dTextBox.TabIndex = 8;
            // 
            // cTextBox
            // 
            this.cTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "C", true));
            this.cTextBox.Location = new System.Drawing.Point(950, 410);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(520, 30);
            this.cTextBox.TabIndex = 7;
            // 
            // bTextBox
            // 
            this.bTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "B", true));
            this.bTextBox.Location = new System.Drawing.Point(334, 461);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(520, 30);
            this.bTextBox.TabIndex = 6;
            // 
            // aTextBox
            // 
            this.aTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "A", true));
            this.aTextBox.Location = new System.Drawing.Point(334, 415);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(520, 30);
            this.aTextBox.TabIndex = 5;
            // 
            // nOIDUNGTextBox
            // 
            this.nOIDUNGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "NOIDUNG", true));
            this.nOIDUNGTextBox.Location = new System.Drawing.Point(334, 326);
            this.nOIDUNGTextBox.Multiline = true;
            this.nOIDUNGTextBox.Name = "nOIDUNGTextBox";
            this.nOIDUNGTextBox.Size = new System.Drawing.Size(520, 67);
            this.nOIDUNGTextBox.TabIndex = 4;
            // 
            // mAMHTextBox
            // 
            this.mAMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "MAMH", true));
            this.mAMHTextBox.Location = new System.Drawing.Point(335, 128);
            this.mAMHTextBox.Name = "mAMHTextBox";
            this.mAMHTextBox.Size = new System.Drawing.Size(251, 30);
            this.mAMHTextBox.TabIndex = 1;
            // 
            // fmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1697, 1042);
            this.Controls.Add(this.grpB_txtQuestion);
            this.Controls.Add(this.bODEGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmQuestion";
            this.Text = "Bộ đề thi";
            this.Load += new System.EventHandler(this.fmQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Question)).EndInit();
            this.grpB_txtQuestion.ResumeLayout(false);
            this.grpB_txtQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtn_Add;
        private DevExpress.XtraBars.BarButtonItem barBtn_Delete;
        private DevExpress.XtraBars.BarButtonItem barBtn_Undo;
        private DevExpress.XtraBars.BarButtonItem barBtn_Save;
        private DevExpress.XtraBars.BarButtonItem barBtn_Refresh;
        private DevExpress.XtraBars.BarButtonItem barBtn_Forbid;
        private DevExpress.XtraBars.BarButtonItem barBtn_Exit;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private DS dS;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bODEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Question;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private System.Windows.Forms.GroupBox grpB_txtQuestion;
        private System.Windows.Forms.TextBox mAGVTextBox;
        private System.Windows.Forms.ComboBox dAP_ANComboBox;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox nOIDUNGTextBox;
        private System.Windows.Forms.TextBox mAMHTextBox;
        private System.Windows.Forms.ComboBox tRINHDOComboBox;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}