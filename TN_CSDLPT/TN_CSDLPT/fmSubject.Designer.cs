namespace TN_CSDLPT
{
    partial class fmSubject
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
            System.Windows.Forms.Label tENMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSubject));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar_Funtion = new DevExpress.XtraBars.Bar();
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
            this.ds1 = new TN_CSDLPT.DS();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Branch = new System.Windows.Forms.Label();
            this.cbB_Branch = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gV_Subjects = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpB_Subjects = new System.Windows.Forms.GroupBox();
            this.tENMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new TN_CSDLPT.DSTableAdapters.BODETableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_Subjects)).BeginInit();
            this.grpB_Subjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(43, 26);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(113, 22);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã môn học:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(43, 68);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(117, 22);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "Tên môn học:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar_Funtion,
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
            this.barBtn_Exit});
            this.barManager1.MainMenu = this.bar_Funtion;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar_Funtion
            // 
            this.bar_Funtion.BarAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_Funtion.BarAppearance.Disabled.Options.UseFont = true;
            this.bar_Funtion.BarAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_Funtion.BarAppearance.Hovered.Options.UseFont = true;
            this.bar_Funtion.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_Funtion.BarAppearance.Normal.Options.UseFont = true;
            this.bar_Funtion.BarAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_Funtion.BarAppearance.Pressed.Options.UseFont = true;
            this.bar_Funtion.BarName = "Main menu";
            this.bar_Funtion.DockCol = 0;
            this.bar_Funtion.DockRow = 0;
            this.bar_Funtion.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar_Funtion.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Undo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Refresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Exit)});
            this.bar_Funtion.OptionsBar.MultiLine = true;
            this.bar_Funtion.OptionsBar.UseWholeRow = true;
            this.bar_Funtion.Text = "Main menu";
            // 
            // barBtn_Add
            // 
            this.barBtn_Add.Caption = "Thêm";
            this.barBtn_Add.Id = 0;
            this.barBtn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Add.ImageOptions.Image")));
            this.barBtn_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Add.ImageOptions.LargeImage")));
            this.barBtn_Add.Name = "barBtn_Add";
            this.barBtn_Add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtn_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Add_ItemClick);
            // 
            // barBtn_Delete
            // 
            this.barBtn_Delete.Caption = "Xóa";
            this.barBtn_Delete.Id = 1;
            this.barBtn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Delete.ImageOptions.Image")));
            this.barBtn_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Delete.ImageOptions.LargeImage")));
            this.barBtn_Delete.Name = "barBtn_Delete";
            this.barBtn_Delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Delete_ItemClick);
            // 
            // barBtn_Undo
            // 
            this.barBtn_Undo.Caption = "Phục hồi";
            this.barBtn_Undo.Id = 2;
            this.barBtn_Undo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Undo.ImageOptions.Image")));
            this.barBtn_Undo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Undo.ImageOptions.LargeImage")));
            this.barBtn_Undo.Name = "barBtn_Undo";
            this.barBtn_Undo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtn_Undo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Undo_ItemClick);
            // 
            // barBtn_Save
            // 
            this.barBtn_Save.Caption = "Ghi";
            this.barBtn_Save.Id = 3;
            this.barBtn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Save.ImageOptions.Image")));
            this.barBtn_Save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Save.ImageOptions.LargeImage")));
            this.barBtn_Save.Name = "barBtn_Save";
            this.barBtn_Save.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Save_ItemClick);
            // 
            // barBtn_Refresh
            // 
            this.barBtn_Refresh.Caption = "Làm mới";
            this.barBtn_Refresh.Id = 4;
            this.barBtn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Refresh.ImageOptions.Image")));
            this.barBtn_Refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Refresh.ImageOptions.LargeImage")));
            this.barBtn_Refresh.Name = "barBtn_Refresh";
            this.barBtn_Refresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtn_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Refresh_ItemClick);
            // 
            // barBtn_Exit
            // 
            this.barBtn_Exit.Caption = "Thoát";
            this.barBtn_Exit.Id = 6;
            this.barBtn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Exit.ImageOptions.Image")));
            this.barBtn_Exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Exit.ImageOptions.LargeImage")));
            this.barBtn_Exit.Name = "barBtn_Exit";
            this.barBtn_Exit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1053, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 642);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1053, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 611);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1053, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 611);
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.EnforceConstraints = false;
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Branch);
            this.panel1.Controls.Add(this.cbB_Branch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 44);
            this.panel1.TabIndex = 4;
            // 
            // lb_Branch
            // 
            this.lb_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Branch.AutoSize = true;
            this.lb_Branch.Location = new System.Drawing.Point(96, 12);
            this.lb_Branch.Name = "lb_Branch";
            this.lb_Branch.Size = new System.Drawing.Size(58, 22);
            this.lb_Branch.TabIndex = 1;
            this.lb_Branch.Text = "Cơ sở";
            // 
            // cbB_Branch
            // 
            this.cbB_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbB_Branch.FormattingEnabled = true;
            this.cbB_Branch.Location = new System.Drawing.Point(160, 9);
            this.cbB_Branch.Name = "cbB_Branch";
            this.cbB_Branch.Size = new System.Drawing.Size(324, 30);
            this.cbB_Branch.TabIndex = 0;
            this.cbB_Branch.SelectedIndexChanged += new System.EventHandler(this.cbB_Branch_SelectedIndexChanged);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.ds1;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.mONHOCBindingSource;
            this.mONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 75);
            this.mONHOCGridControl.LookAndFeel.SkinMaskColor = System.Drawing.Color.Black;
            this.mONHOCGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.mONHOCGridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.mONHOCGridControl.MainView = this.gV_Subjects;
            this.mONHOCGridControl.MenuManager = this.barManager1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(1053, 326);
            this.mONHOCGridControl.TabIndex = 9;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gV_Subjects});
            // 
            // gV_Subjects
            // 
            this.gV_Subjects.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colrowguid});
            this.gV_Subjects.DetailHeight = 385;
            this.gV_Subjects.GridControl = this.mONHOCGridControl;
            this.gV_Subjects.Name = "gV_Subjects";
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colMAMH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceCell.Options.UseBackColor = true;
            this.colMAMH.AppearanceCell.Options.UseFont = true;
            this.colMAMH.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colMAMH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAMH.AppearanceHeader.Options.UseFont = true;
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 27;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 103;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colTENMH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENMH.AppearanceCell.Options.UseBackColor = true;
            this.colTENMH.AppearanceCell.Options.UseFont = true;
            this.colTENMH.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colTENMH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENMH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENMH.AppearanceHeader.Options.UseFont = true;
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 27;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 103;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.MinWidth = 27;
            this.colrowguid.Name = "colrowguid";
            this.colrowguid.Width = 103;
            // 
            // grpB_Subjects
            // 
            this.grpB_Subjects.Controls.Add(tENMHLabel);
            this.grpB_Subjects.Controls.Add(this.tENMHTextEdit);
            this.grpB_Subjects.Controls.Add(mAMHLabel);
            this.grpB_Subjects.Controls.Add(this.mAMHTextEdit);
            this.grpB_Subjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpB_Subjects.Location = new System.Drawing.Point(0, 401);
            this.grpB_Subjects.Name = "grpB_Subjects";
            this.grpB_Subjects.Size = new System.Drawing.Size(1053, 241);
            this.grpB_Subjects.TabIndex = 10;
            this.grpB_Subjects.TabStop = false;
            // 
            // tENMHTextEdit
            // 
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "TENMH", true));
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.tENMHTextEdit.Location = new System.Drawing.Point(175, 68);
            this.tENMHTextEdit.MenuManager = this.barManager1;
            this.tENMHTextEdit.Name = "tENMHTextEdit";
            this.tENMHTextEdit.Size = new System.Drawing.Size(340, 22);
            this.tENMHTextEdit.TabIndex = 2;
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "MAMH", true));
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(175, 26);
            this.mAMHTextEdit.MenuManager = this.barManager1;
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Size = new System.Drawing.Size(340, 22);
            this.mAMHTextEdit.TabIndex = 1;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "BODE";
            this.bODEBindingSource.DataSource = this.ds1;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // fmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 666);
            this.Controls.Add(this.grpB_Subjects);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_Subjects)).EndInit();
            this.grpB_Subjects.ResumeLayout(false);
            this.grpB_Subjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar_Funtion;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtn_Add;
        private DevExpress.XtraBars.BarButtonItem barBtn_Delete;
        private DevExpress.XtraBars.BarButtonItem barBtn_Undo;
        private DevExpress.XtraBars.BarButtonItem barBtn_Save;
        private DS ds1;
        private DevExpress.XtraBars.BarButtonItem barBtn_Refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Branch;
        private System.Windows.Forms.ComboBox cbB_Branch;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gV_Subjects;
        private System.Windows.Forms.GroupBox grpB_Subjects;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraEditors.TextEdit tENMHTextEdit;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private DevExpress.XtraBars.BarButtonItem barBtn_Exit;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
    }
}