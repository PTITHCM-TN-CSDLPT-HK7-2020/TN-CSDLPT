namespace TN_CSDLPT
{
    partial class fmFarculty
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmFarculty));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Undo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Branch = new System.Windows.Forms.Label();
            this.cbB_Branch = new System.Windows.Forms.ComboBox();
            this.dS = new TN_CSDLPT.DS();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new TN_CSDLPT.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.kHOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpB_Farculty = new System.Windows.Forms.GroupBox();
            this.gIAOVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gIAOVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mACSTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter = new TN_CSDLPT.DSTableAdapters.GIAOVIENTableAdapter();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.lOPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grpB_Farculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACSTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(12, 497);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(84, 22);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "Mã khoa:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(12, 544);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(88, 22);
            tENKHLabel.TabIndex = 4;
            tENKHLabel.Text = "Tên khoa:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(12, 591);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(91, 22);
            mACSLabel.TabIndex = 5;
            mACSLabel.Text = "Mã cơ sở:";
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
            this.barButtonItem1,
            this.barBtn_Add,
            this.barBtn_Delete,
            this.barBtn_Undo,
            this.barBtn_Refresh,
            this.barBtn_Save,
            this.barBtn_Exit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(69, 178);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Add, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Delete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Undo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtn_Exit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtn_Add
            // 
            this.barBtn_Add.Caption = "Thêm";
            this.barBtn_Add.Id = 1;
            this.barBtn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Add.ImageOptions.Image")));
            this.barBtn_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Add.ImageOptions.LargeImage")));
            this.barBtn_Add.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barBtn_Add.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barBtn_Add.Name = "barBtn_Add";
            // 
            // barBtn_Delete
            // 
            this.barBtn_Delete.Caption = "Xóa";
            this.barBtn_Delete.Id = 2;
            this.barBtn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Delete.ImageOptions.Image")));
            this.barBtn_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Delete.ImageOptions.LargeImage")));
            this.barBtn_Delete.Name = "barBtn_Delete";
            // 
            // barBtn_Undo
            // 
            this.barBtn_Undo.Caption = "Phục hồi";
            this.barBtn_Undo.Id = 3;
            this.barBtn_Undo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Undo.ImageOptions.Image")));
            this.barBtn_Undo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Undo.ImageOptions.LargeImage")));
            this.barBtn_Undo.Name = "barBtn_Undo";
            // 
            // barBtn_Save
            // 
            this.barBtn_Save.Caption = "Ghi";
            this.barBtn_Save.Id = 5;
            this.barBtn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Save.ImageOptions.Image")));
            this.barBtn_Save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Save.ImageOptions.LargeImage")));
            this.barBtn_Save.Name = "barBtn_Save";
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
            // barBtn_Exit
            // 
            this.barBtn_Exit.Caption = "Thoát";
            this.barBtn_Exit.Id = 7;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1332, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 930);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1332, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 899);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1332, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 899);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Branch);
            this.panel1.Controls.Add(this.cbB_Branch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 61);
            this.panel1.TabIndex = 4;
            // 
            // lb_Branch
            // 
            this.lb_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Branch.AutoSize = true;
            this.lb_Branch.Location = new System.Drawing.Point(119, 18);
            this.lb_Branch.Name = "lb_Branch";
            this.lb_Branch.Size = new System.Drawing.Size(58, 22);
            this.lb_Branch.TabIndex = 3;
            this.lb_Branch.Text = "Cơ sở";
            // 
            // cbB_Branch
            // 
            this.cbB_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbB_Branch.FormattingEnabled = true;
            this.cbB_Branch.Location = new System.Drawing.Point(183, 15);
            this.cbB_Branch.Name = "cbB_Branch";
            this.cbB_Branch.Size = new System.Drawing.Size(324, 30);
            this.cbB_Branch.TabIndex = 2;
            this.cbB_Branch.SelectedIndexChanged += new System.EventHandler(this.cbB_Branch_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHOAGridControl
            // 
            this.kHOAGridControl.DataSource = this.kHOABindingSource;
            this.kHOAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kHOAGridControl.Location = new System.Drawing.Point(3, 26);
            this.kHOAGridControl.MainView = this.gridView1;
            this.kHOAGridControl.MenuManager = this.barManager1;
            this.kHOAGridControl.Name = "kHOAGridControl";
            this.kHOAGridControl.Size = new System.Drawing.Size(1326, 438);
            this.kHOAGridControl.TabIndex = 5;
            this.kHOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.kHOAGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMAKH
            // 
            this.colMAKH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH.AppearanceCell.Options.UseFont = true;
            this.colMAKH.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colMAKH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKH.AppearanceHeader.Options.UseFont = true;
            this.colMAKH.Caption = "Mã khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 154;
            // 
            // colTENKH
            // 
            this.colTENKH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENKH.AppearanceCell.Options.UseFont = true;
            this.colTENKH.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colTENKH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENKH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENKH.AppearanceHeader.Options.UseFont = true;
            this.colTENKH.Caption = "Tên khoa";
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 25;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 193;
            // 
            // colMACS
            // 
            this.colMACS.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMACS.AppearanceCell.Options.UseFont = true;
            this.colMACS.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colMACS.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMACS.AppearanceHeader.Options.UseBackColor = true;
            this.colMACS.AppearanceHeader.Options.UseFont = true;
            this.colMACS.Caption = "Mã cơ sở";
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 25;
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 198;
            // 
            // grpB_Farculty
            // 
            this.grpB_Farculty.Controls.Add(this.gIAOVIENGridControl);
            this.grpB_Farculty.Controls.Add(mACSLabel);
            this.grpB_Farculty.Controls.Add(this.mACSTextEdit);
            this.grpB_Farculty.Controls.Add(this.kHOAGridControl);
            this.grpB_Farculty.Controls.Add(tENKHLabel);
            this.grpB_Farculty.Controls.Add(this.tENKHTextEdit);
            this.grpB_Farculty.Controls.Add(mAKHLabel);
            this.grpB_Farculty.Controls.Add(this.mAKHTextEdit);
            this.grpB_Farculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpB_Farculty.Location = new System.Drawing.Point(0, 92);
            this.grpB_Farculty.Name = "grpB_Farculty";
            this.grpB_Farculty.Size = new System.Drawing.Size(1332, 838);
            this.grpB_Farculty.TabIndex = 11;
            this.grpB_Farculty.TabStop = false;
            // 
            // gIAOVIENGridControl
            // 
            this.gIAOVIENGridControl.DataSource = this.gIAOVIENBindingSource1;
            this.gIAOVIENGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.gIAOVIENGridControl.Location = new System.Drawing.Point(355, 464);
            this.gIAOVIENGridControl.MainView = this.gridView2;
            this.gIAOVIENGridControl.MenuManager = this.barManager1;
            this.gIAOVIENGridControl.Name = "gIAOVIENGridControl";
            this.gIAOVIENGridControl.Size = new System.Drawing.Size(974, 371);
            this.gIAOVIENGridControl.TabIndex = 7;
            this.gIAOVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gIAOVIENBindingSource1
            // 
            this.gIAOVIENBindingSource1.DataMember = "FK_GIAOVIEN_KHOA";
            this.gIAOVIENBindingSource1.DataSource = this.kHOABindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colHOCVI,
            this.colMAKH1});
            this.gridView2.GridControl = this.gIAOVIENGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMAGV
            // 
            this.colMAGV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAGV.AppearanceCell.Options.UseFont = true;
            this.colMAGV.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colMAGV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAGV.AppearanceHeader.Options.UseBackColor = true;
            this.colMAGV.AppearanceHeader.Options.UseFont = true;
            this.colMAGV.Caption = "Mã giáo viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHO.AppearanceCell.Options.UseFont = true;
            this.colHO.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colHO.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHO.AppearanceHeader.Options.UseBackColor = true;
            this.colHO.AppearanceHeader.Options.UseFont = true;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN.AppearanceCell.Options.UseFont = true;
            this.colTEN.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colTEN.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN.AppearanceHeader.Options.UseBackColor = true;
            this.colTEN.AppearanceHeader.Options.UseFont = true;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colHOCVI
            // 
            this.colHOCVI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCVI.AppearanceCell.Options.UseFont = true;
            this.colHOCVI.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colHOCVI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCVI.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCVI.AppearanceHeader.Options.UseFont = true;
            this.colHOCVI.Caption = "Học vị";
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.MinWidth = 25;
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 3;
            this.colHOCVI.Width = 94;
            // 
            // colMAKH1
            // 
            this.colMAKH1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH1.AppearanceCell.Options.UseFont = true;
            this.colMAKH1.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colMAKH1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH1.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKH1.AppearanceHeader.Options.UseFont = true;
            this.colMAKH1.Caption = "Mã khoa";
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 25;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 4;
            this.colMAKH1.Width = 94;
            // 
            // mACSTextEdit
            // 
            this.mACSTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "MACS", true));
            this.mACSTextEdit.Enabled = false;
            this.mACSTextEdit.Location = new System.Drawing.Point(123, 588);
            this.mACSTextEdit.MenuManager = this.barManager1;
            this.mACSTextEdit.Name = "mACSTextEdit";
            this.mACSTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mACSTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mACSTextEdit.Size = new System.Drawing.Size(395, 28);
            this.mACSTextEdit.TabIndex = 3;
            // 
            // tENKHTextEdit
            // 
            this.tENKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "TENKH", true));
            this.tENKHTextEdit.Location = new System.Drawing.Point(123, 542);
            this.tENKHTextEdit.MenuManager = this.barManager1;
            this.tENKHTextEdit.Name = "tENKHTextEdit";
            this.tENKHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENKHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENKHTextEdit.Size = new System.Drawing.Size(395, 28);
            this.tENKHTextEdit.TabIndex = 2;
            // 
            // mAKHTextEdit
            // 
            this.mAKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "MAKH", true));
            this.mAKHTextEdit.Location = new System.Drawing.Point(123, 494);
            this.mAKHTextEdit.MenuManager = this.barManager1;
            this.mAKHTextEdit.Name = "mAKHTextEdit";
            this.mAKHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAKHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAKHTextEdit.Size = new System.Drawing.Size(395, 28);
            this.mAKHTextEdit.TabIndex = 1;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.dS;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource1
            // 
            this.lOPBindingSource1.DataMember = "FK_LOP_KHOA";
            this.lOPBindingSource1.DataSource = this.kHOABindingSource;
            // 
            // fmFarculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1332, 954);
            this.Controls.Add(this.grpB_Farculty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmFarculty";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.fmFarculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grpB_Farculty.ResumeLayout(false);
            this.grpB_Farculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACSTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barBtn_Refresh;
        private DevExpress.XtraBars.BarButtonItem barBtn_Save;
        private DevExpress.XtraBars.BarButtonItem barBtn_Exit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Branch;
        private System.Windows.Forms.ComboBox cbB_Branch;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DS dS;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl kHOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private System.Windows.Forms.GroupBox grpB_Farculty;
        private DevExpress.XtraEditors.TextEdit tENKHTextEdit;
        private DevExpress.XtraEditors.TextEdit mAKHTextEdit;
        private DevExpress.XtraEditors.TextEdit mACSTextEdit;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraGrid.GridControl gIAOVIENGridControl;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private System.Windows.Forms.BindingSource lOPBindingSource1;
    }
}