namespace TN_CSDLPT
{
    partial class fmExamHistoryResult
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
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label tHOIGIANLabel1;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            this.pnl_InfoStu = new System.Windows.Forms.Panel();
            this.grpB_txtStudent = new System.Windows.Forms.GroupBox();
            this.txtB_IDClass = new System.Windows.Forms.TextBox();
            this.lb_IDClass = new System.Windows.Forms.Label();
            this.txtB_FullName = new System.Windows.Forms.TextBox();
            this.txtB_NameClass = new System.Windows.Forms.TextBox();
            this.txtB_IDStudent = new System.Windows.Forms.TextBox();
            this.lb_NameClass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpB_txtExam = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.nGAYTHIDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tHOIGIANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sOCAUTHISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAMHComboBox1 = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TN_CSDLPT.DS();
            this.tRINHDOComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView_Result = new System.Windows.Forms.DataGridView();
            this.dataGridView_DetailExam = new System.Windows.Forms.DataGridView();
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Display = new System.Windows.Forms.Button();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            tHOIGIANLabel1 = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            this.pnl_InfoStu.SuspendLayout();
            this.grpB_txtStudent.SuspendLayout();
            this.grpB_txtExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetailExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(60, 76);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(82, 22);
            nGAYTHILabel.TabIndex = 29;
            nGAYTHILabel.Text = "Ngày thi:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(42, 117);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(100, 22);
            lANLabel.TabIndex = 28;
            lANLabel.Text = "Lần thi thứ:";
            // 
            // tHOIGIANLabel1
            // 
            tHOIGIANLabel1.AutoSize = true;
            tHOIGIANLabel1.Location = new System.Drawing.Point(444, 117);
            tHOIGIANLabel1.Name = "tHOIGIANLabel1";
            tHOIGIANLabel1.Size = new System.Drawing.Size(92, 22);
            tHOIGIANLabel1.TabIndex = 25;
            tHOIGIANLabel1.Text = "Thời gian:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(444, 75);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(94, 22);
            sOCAUTHILabel.TabIndex = 23;
            sOCAUTHILabel.Text = "Số câu thi:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(57, 35);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(85, 22);
            mAMHLabel.TabIndex = 14;
            mAMHLabel.Text = "Môn học:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(455, 35);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(83, 22);
            tRINHDOLabel.TabIndex = 15;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // pnl_InfoStu
            // 
            this.pnl_InfoStu.Controls.Add(this.grpB_txtStudent);
            this.pnl_InfoStu.Controls.Add(this.grpB_txtExam);
            this.pnl_InfoStu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_InfoStu.Location = new System.Drawing.Point(0, 0);
            this.pnl_InfoStu.Name = "pnl_InfoStu";
            this.pnl_InfoStu.Size = new System.Drawing.Size(1585, 156);
            this.pnl_InfoStu.TabIndex = 4;
            // 
            // grpB_txtStudent
            // 
            this.grpB_txtStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpB_txtStudent.Controls.Add(this.txtB_IDClass);
            this.grpB_txtStudent.Controls.Add(this.lb_IDClass);
            this.grpB_txtStudent.Controls.Add(this.txtB_FullName);
            this.grpB_txtStudent.Controls.Add(this.txtB_NameClass);
            this.grpB_txtStudent.Controls.Add(this.txtB_IDStudent);
            this.grpB_txtStudent.Controls.Add(this.lb_NameClass);
            this.grpB_txtStudent.Controls.Add(this.label2);
            this.grpB_txtStudent.Controls.Add(this.label4);
            this.grpB_txtStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpB_txtStudent.ForeColor = System.Drawing.Color.Yellow;
            this.grpB_txtStudent.Location = new System.Drawing.Point(912, 0);
            this.grpB_txtStudent.Name = "grpB_txtStudent";
            this.grpB_txtStudent.Size = new System.Drawing.Size(934, 156);
            this.grpB_txtStudent.TabIndex = 1;
            this.grpB_txtStudent.TabStop = false;
            this.grpB_txtStudent.Text = "Thông tin sinh viên";
            // 
            // txtB_IDClass
            // 
            this.txtB_IDClass.Enabled = false;
            this.txtB_IDClass.Location = new System.Drawing.Point(455, 32);
            this.txtB_IDClass.Name = "txtB_IDClass";
            this.txtB_IDClass.Size = new System.Drawing.Size(187, 30);
            this.txtB_IDClass.TabIndex = 8;
            // 
            // lb_IDClass
            // 
            this.lb_IDClass.AutoSize = true;
            this.lb_IDClass.Location = new System.Drawing.Point(376, 30);
            this.lb_IDClass.Name = "lb_IDClass";
            this.lb_IDClass.Size = new System.Drawing.Size(74, 22);
            this.lb_IDClass.TabIndex = 7;
            this.lb_IDClass.Text = "Mã lớp:";
            // 
            // txtB_FullName
            // 
            this.txtB_FullName.Enabled = false;
            this.txtB_FullName.Location = new System.Drawing.Point(163, 93);
            this.txtB_FullName.Name = "txtB_FullName";
            this.txtB_FullName.Size = new System.Drawing.Size(187, 30);
            this.txtB_FullName.TabIndex = 6;
            // 
            // txtB_NameClass
            // 
            this.txtB_NameClass.Enabled = false;
            this.txtB_NameClass.Location = new System.Drawing.Point(456, 92);
            this.txtB_NameClass.Name = "txtB_NameClass";
            this.txtB_NameClass.Size = new System.Drawing.Size(187, 30);
            this.txtB_NameClass.TabIndex = 5;
            // 
            // txtB_IDStudent
            // 
            this.txtB_IDStudent.Enabled = false;
            this.txtB_IDStudent.Location = new System.Drawing.Point(163, 27);
            this.txtB_IDStudent.Name = "txtB_IDStudent";
            this.txtB_IDStudent.Size = new System.Drawing.Size(187, 30);
            this.txtB_IDStudent.TabIndex = 4;
            // 
            // lb_NameClass
            // 
            this.lb_NameClass.AutoSize = true;
            this.lb_NameClass.Location = new System.Drawing.Point(372, 95);
            this.lb_NameClass.Name = "lb_NameClass";
            this.lb_NameClass.Size = new System.Drawing.Size(78, 22);
            this.lb_NameClass.TabIndex = 3;
            this.lb_NameClass.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã sinh viên:";
            // 
            // grpB_txtExam
            // 
            this.grpB_txtExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpB_txtExam.Controls.Add(this.btn_Refresh);
            this.grpB_txtExam.Controls.Add(this.nGAYTHIDateTimePicker);
            this.grpB_txtExam.Controls.Add(this.btn_Search);
            this.grpB_txtExam.Controls.Add(nGAYTHILabel);
            this.grpB_txtExam.Controls.Add(lANLabel);
            this.grpB_txtExam.Controls.Add(this.lANSpinEdit);
            this.grpB_txtExam.Controls.Add(this.tHOIGIANSpinEdit);
            this.grpB_txtExam.Controls.Add(tHOIGIANLabel1);
            this.grpB_txtExam.Controls.Add(sOCAUTHILabel);
            this.grpB_txtExam.Controls.Add(this.sOCAUTHISpinEdit);
            this.grpB_txtExam.Controls.Add(this.mAMHComboBox1);
            this.grpB_txtExam.Controls.Add(mAMHLabel);
            this.grpB_txtExam.Controls.Add(this.tRINHDOComboBox);
            this.grpB_txtExam.Controls.Add(tRINHDOLabel);
            this.grpB_txtExam.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpB_txtExam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpB_txtExam.ForeColor = System.Drawing.Color.Yellow;
            this.grpB_txtExam.Location = new System.Drawing.Point(0, 0);
            this.grpB_txtExam.Name = "grpB_txtExam";
            this.grpB_txtExam.Size = new System.Drawing.Size(912, 156);
            this.grpB_txtExam.TabIndex = 0;
            this.grpB_txtExam.TabStop = false;
            this.grpB_txtExam.Text = "Thông tin bài thi";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Refresh.Location = new System.Drawing.Point(787, 96);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(104, 47);
            this.btn_Refresh.TabIndex = 32;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // nGAYTHIDateTimePicker
            // 
            this.nGAYTHIDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nGAYTHIDateTimePicker.Location = new System.Drawing.Point(148, 70);
            this.nGAYTHIDateTimePicker.Name = "nGAYTHIDateTimePicker";
            this.nGAYTHIDateTimePicker.Size = new System.Drawing.Size(214, 30);
            this.nGAYTHIDateTimePicker.TabIndex = 31;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Search.Location = new System.Drawing.Point(787, 35);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(104, 47);
            this.btn_Search.TabIndex = 30;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lANSpinEdit
            // 
            this.lANSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lANSpinEdit.Location = new System.Drawing.Point(148, 116);
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lANSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.lANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lANSpinEdit.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lANSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lANSpinEdit.Size = new System.Drawing.Size(214, 26);
            this.lANSpinEdit.TabIndex = 26;
            // 
            // tHOIGIANSpinEdit
            // 
            this.tHOIGIANSpinEdit.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Enabled = false;
            this.tHOIGIANSpinEdit.Location = new System.Drawing.Point(544, 116);
            this.tHOIGIANSpinEdit.Name = "tHOIGIANSpinEdit";
            this.tHOIGIANSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHOIGIANSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.tHOIGIANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tHOIGIANSpinEdit.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Properties.MinValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Size = new System.Drawing.Size(214, 26);
            this.tHOIGIANSpinEdit.TabIndex = 21;
            // 
            // sOCAUTHISpinEdit
            // 
            this.sOCAUTHISpinEdit.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sOCAUTHISpinEdit.Enabled = false;
            this.sOCAUTHISpinEdit.Location = new System.Drawing.Point(544, 75);
            this.sOCAUTHISpinEdit.Name = "sOCAUTHISpinEdit";
            this.sOCAUTHISpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOCAUTHISpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sOCAUTHISpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOCAUTHISpinEdit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.sOCAUTHISpinEdit.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sOCAUTHISpinEdit.Size = new System.Drawing.Size(214, 26);
            this.sOCAUTHISpinEdit.TabIndex = 19;
            // 
            // mAMHComboBox1
            // 
            this.mAMHComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mAMHComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mAMHComboBox1.DataSource = this.mONHOCBindingSource;
            this.mAMHComboBox1.DisplayMember = "MAMH";
            this.mAMHComboBox1.FormattingEnabled = true;
            this.mAMHComboBox1.Location = new System.Drawing.Point(148, 32);
            this.mAMHComboBox1.Name = "mAMHComboBox1";
            this.mAMHComboBox1.Size = new System.Drawing.Size(214, 30);
            this.mAMHComboBox1.TabIndex = 12;
            this.mAMHComboBox1.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRINHDOComboBox
            // 
            this.tRINHDOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tRINHDOComboBox.Enabled = false;
            this.tRINHDOComboBox.FormattingEnabled = true;
            this.tRINHDOComboBox.ItemHeight = 22;
            this.tRINHDOComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.tRINHDOComboBox.Location = new System.Drawing.Point(544, 32);
            this.tRINHDOComboBox.Name = "tRINHDOComboBox";
            this.tRINHDOComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tRINHDOComboBox.Size = new System.Drawing.Size(214, 30);
            this.tRINHDOComboBox.TabIndex = 13;
            // 
            // dataGridView_Result
            // 
            this.dataGridView_Result.AllowUserToAddRows = false;
            this.dataGridView_Result.AllowUserToDeleteRows = false;
            this.dataGridView_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Result.Location = new System.Drawing.Point(0, 156);
            this.dataGridView_Result.Name = "dataGridView_Result";
            this.dataGridView_Result.RowTemplate.Height = 24;
            this.dataGridView_Result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Result.Size = new System.Drawing.Size(1585, 106);
            this.dataGridView_Result.TabIndex = 6;
            this.dataGridView_Result.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Result_CellClick);
            // 
            // dataGridView_DetailExam
            // 
            this.dataGridView_DetailExam.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView_DetailExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DetailExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DetailExam.Location = new System.Drawing.Point(0, 262);
            this.dataGridView_DetailExam.Name = "dataGridView_DetailExam";
            this.dataGridView_DetailExam.RowTemplate.Height = 24;
            this.dataGridView_DetailExam.Size = new System.Drawing.Size(1585, 439);
            this.dataGridView_DetailExam.TabIndex = 7;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHISVTableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.dS;
            // 
            // btn_Display
            // 
            this.btn_Display.BackColor = System.Drawing.Color.Aqua;
            this.btn_Display.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Display.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Display.Location = new System.Drawing.Point(1151, 187);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(173, 43);
            this.btn_Display.TabIndex = 8;
            this.btn_Display.Text = "Xem";
            this.btn_Display.UseVisualStyleBackColor = false;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // fmExamHistoryResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1585, 701);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.dataGridView_DetailExam);
            this.Controls.Add(this.dataGridView_Result);
            this.Controls.Add(this.pnl_InfoStu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmExamHistoryResult";
            this.Text = "Xem chi tiết bài thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmExamHistoryResult_Load);
            this.pnl_InfoStu.ResumeLayout(false);
            this.grpB_txtStudent.ResumeLayout(false);
            this.grpB_txtStudent.PerformLayout();
            this.grpB_txtExam.ResumeLayout(false);
            this.grpB_txtExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetailExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_InfoStu;
        private System.Windows.Forms.GroupBox grpB_txtStudent;
        private System.Windows.Forms.TextBox txtB_IDClass;
        private System.Windows.Forms.Label lb_IDClass;
        private System.Windows.Forms.TextBox txtB_FullName;
        private System.Windows.Forms.TextBox txtB_NameClass;
        private System.Windows.Forms.TextBox txtB_IDStudent;
        private System.Windows.Forms.Label lb_NameClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpB_txtExam;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DateTimePicker nGAYTHIDateTimePicker;
        private System.Windows.Forms.Button btn_Search;
        private DevExpress.XtraEditors.SpinEdit lANSpinEdit;
        private DevExpress.XtraEditors.SpinEdit tHOIGIANSpinEdit;
        private DevExpress.XtraEditors.SpinEdit sOCAUTHISpinEdit;
        private System.Windows.Forms.ComboBox mAMHComboBox1;
        private System.Windows.Forms.ComboBox tRINHDOComboBox;
        private System.Windows.Forms.DataGridView dataGridView_Result;
        private System.Windows.Forms.DataGridView dataGridView_DetailExam;
        private DS dS;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private System.Windows.Forms.Button btn_Display;
    }
}