﻿namespace TN_CSDLPT
{
    partial class fmDoExam
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
            System.Windows.Forms.Label tHOIGIANLabel1;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            this.grpB_txtExam = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.nGAYTHIDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tHOIGIANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sOCAUTHISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAMHComboBox1 = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TN_CSDLPT.DS();
            this.tRINHDOComboBox = new System.Windows.Forms.ComboBox();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
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
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_Start = new System.Windows.Forms.Panel();
            this.dataGridView_Result = new System.Windows.Forms.DataGridView();
            this.sP_LISTBANGSVTHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_TImer = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_StartTesting = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.pnl_S = new System.Windows.Forms.Panel();
            this.sP_LISTBANGSVTHITableAdapter = new TN_CSDLPT.DSTableAdapters.SP_LISTBANGSVTHITableAdapter();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.lOPTableAdapter = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.bAITHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAITHITableAdapter = new TN_CSDLPT.DSTableAdapters.BAITHITableAdapter();
            this.flowLayoutPanel_Question = new System.Windows.Forms.FlowLayoutPanel();
            this.lANSpinEdit = new System.Windows.Forms.NumericUpDown();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            tHOIGIANLabel1 = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            this.grpB_txtExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.pnl_InfoStu.SuspendLayout();
            this.grpB_txtStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.pnl_Start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LISTBANGSVTHIBindingSource)).BeginInit();
            this.pnl_S.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.ForeColor = System.Drawing.Color.Purple;
            mAMHLabel.Location = new System.Drawing.Point(57, 35);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(85, 22);
            mAMHLabel.TabIndex = 14;
            mAMHLabel.Text = "Môn học:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.ForeColor = System.Drawing.Color.Purple;
            tRINHDOLabel.Location = new System.Drawing.Point(401, 38);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(83, 22);
            tRINHDOLabel.TabIndex = 15;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // tHOIGIANLabel1
            // 
            tHOIGIANLabel1.AutoSize = true;
            tHOIGIANLabel1.ForeColor = System.Drawing.Color.Purple;
            tHOIGIANLabel1.Location = new System.Drawing.Point(390, 120);
            tHOIGIANLabel1.Name = "tHOIGIANLabel1";
            tHOIGIANLabel1.Size = new System.Drawing.Size(92, 22);
            tHOIGIANLabel1.TabIndex = 25;
            tHOIGIANLabel1.Text = "Thời gian:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.ForeColor = System.Drawing.Color.Purple;
            sOCAUTHILabel.Location = new System.Drawing.Point(390, 78);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(94, 22);
            sOCAUTHILabel.TabIndex = 23;
            sOCAUTHILabel.Text = "Số câu thi:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.ForeColor = System.Drawing.Color.Purple;
            nGAYTHILabel.Location = new System.Drawing.Point(60, 76);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(82, 22);
            nGAYTHILabel.TabIndex = 29;
            nGAYTHILabel.Text = "Ngày thi:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.ForeColor = System.Drawing.Color.Purple;
            lANLabel.Location = new System.Drawing.Point(42, 117);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(100, 22);
            lANLabel.TabIndex = 28;
            lANLabel.Text = "Lần thi thứ:";
            // 
            // grpB_txtExam
            // 
            this.grpB_txtExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpB_txtExam.Controls.Add(this.lANSpinEdit);
            this.grpB_txtExam.Controls.Add(this.btn_Refresh);
            this.grpB_txtExam.Controls.Add(this.nGAYTHIDateTimePicker);
            this.grpB_txtExam.Controls.Add(this.btn_Search);
            this.grpB_txtExam.Controls.Add(nGAYTHILabel);
            this.grpB_txtExam.Controls.Add(lANLabel);
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
            this.grpB_txtExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpB_txtExam.Location = new System.Drawing.Point(0, 0);
            this.grpB_txtExam.Name = "grpB_txtExam";
            this.grpB_txtExam.Size = new System.Drawing.Size(912, 156);
            this.grpB_txtExam.TabIndex = 0;
            this.grpB_txtExam.TabStop = false;
            this.grpB_txtExam.Text = "Thông tin bài thi";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Aqua;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Refresh.Location = new System.Drawing.Point(759, 92);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(104, 47);
            this.btn_Refresh.TabIndex = 32;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // nGAYTHIDateTimePicker
            // 
            this.nGAYTHIDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nGAYTHIDateTimePicker.Location = new System.Drawing.Point(148, 70);
            this.nGAYTHIDateTimePicker.Name = "nGAYTHIDateTimePicker";
            this.nGAYTHIDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nGAYTHIDateTimePicker.Size = new System.Drawing.Size(144, 30);
            this.nGAYTHIDateTimePicker.TabIndex = 31;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Aqua;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Search.Location = new System.Drawing.Point(759, 29);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(104, 47);
            this.btn_Search.TabIndex = 30;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tHOIGIANSpinEdit
            // 
            this.tHOIGIANSpinEdit.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Enabled = false;
            this.tHOIGIANSpinEdit.Location = new System.Drawing.Point(490, 119);
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
            this.tHOIGIANSpinEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tHOIGIANSpinEdit.Size = new System.Drawing.Size(148, 26);
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
            this.sOCAUTHISpinEdit.Location = new System.Drawing.Point(490, 78);
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
            this.sOCAUTHISpinEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sOCAUTHISpinEdit.Size = new System.Drawing.Size(148, 26);
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
            this.mAMHComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mAMHComboBox1.Size = new System.Drawing.Size(144, 30);
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
            this.tRINHDOComboBox.Location = new System.Drawing.Point(490, 35);
            this.tRINHDOComboBox.Name = "tRINHDOComboBox";
            this.tRINHDOComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tRINHDOComboBox.Size = new System.Drawing.Size(148, 30);
            this.tRINHDOComboBox.TabIndex = 13;
            // 
            // pnl_InfoStu
            // 
            this.pnl_InfoStu.Controls.Add(this.grpB_txtStudent);
            this.pnl_InfoStu.Controls.Add(this.grpB_txtExam);
            this.pnl_InfoStu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_InfoStu.Location = new System.Drawing.Point(0, 0);
            this.pnl_InfoStu.Name = "pnl_InfoStu";
            this.pnl_InfoStu.Size = new System.Drawing.Size(1592, 156);
            this.pnl_InfoStu.TabIndex = 3;
            // 
            // grpB_txtStudent
            // 
            this.grpB_txtStudent.BackColor = System.Drawing.Color.Purple;
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
            this.txtB_IDClass.Location = new System.Drawing.Point(456, 32);
            this.txtB_IDClass.Name = "txtB_IDClass";
            this.txtB_IDClass.Size = new System.Drawing.Size(187, 30);
            this.txtB_IDClass.TabIndex = 8;
            // 
            // lb_IDClass
            // 
            this.lb_IDClass.AutoSize = true;
            this.lb_IDClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_IDClass.Location = new System.Drawing.Point(376, 40);
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
            this.txtB_IDStudent.Location = new System.Drawing.Point(163, 35);
            this.txtB_IDStudent.Name = "txtB_IDStudent";
            this.txtB_IDStudent.Size = new System.Drawing.Size(187, 30);
            this.txtB_IDStudent.TabIndex = 4;
            // 
            // lb_NameClass
            // 
            this.lb_NameClass.AutoSize = true;
            this.lb_NameClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_NameClass.Location = new System.Drawing.Point(372, 95);
            this.lb_NameClass.Name = "lb_NameClass";
            this.lb_NameClass.Size = new System.Drawing.Size(78, 22);
            this.lb_NameClass.TabIndex = 3;
            this.lb_NameClass.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(54, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(28, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã sinh viên:";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // pnl_Start
            // 
            this.pnl_Start.Controls.Add(this.dataGridView_Result);
            this.pnl_Start.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Start.Location = new System.Drawing.Point(0, 156);
            this.pnl_Start.Name = "pnl_Start";
            this.pnl_Start.Size = new System.Drawing.Size(1592, 100);
            this.pnl_Start.TabIndex = 3;
            // 
            // dataGridView_Result
            // 
            this.dataGridView_Result.AllowUserToAddRows = false;
            this.dataGridView_Result.AllowUserToDeleteRows = false;
            this.dataGridView_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Result.BackgroundColor = System.Drawing.Color.Olive;
            this.dataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Result.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Result.Name = "dataGridView_Result";
            this.dataGridView_Result.RowTemplate.Height = 24;
            this.dataGridView_Result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Result.Size = new System.Drawing.Size(1592, 100);
            this.dataGridView_Result.TabIndex = 0;
            this.dataGridView_Result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Result_CellContentClick);
            this.dataGridView_Result.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Result_CellMouseClick);
            // 
            // sP_LISTBANGSVTHIBindingSource
            // 
            this.sP_LISTBANGSVTHIBindingSource.DataMember = "SP_LISTBANGSVTHI";
            this.sP_LISTBANGSVTHIBindingSource.DataSource = this.dS;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(508, 20);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(92, 22);
            this.lb_Time.TabIndex = 3;
            this.lb_Time.Text = "Thời gian:";
            // 
            // lb_TImer
            // 
            this.lb_TImer.AutoSize = true;
            this.lb_TImer.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TImer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TImer.Location = new System.Drawing.Point(606, 6);
            this.lb_TImer.Name = "lb_TImer";
            this.lb_TImer.Size = new System.Drawing.Size(108, 43);
            this.lb_TImer.TabIndex = 2;
            this.lb_TImer.Text = "60:00";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Submit.Location = new System.Drawing.Point(912, 9);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(173, 43);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "Nộp bài";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_StartTesting
            // 
            this.btn_StartTesting.BackColor = System.Drawing.Color.Aqua;
            this.btn_StartTesting.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartTesting.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_StartTesting.Location = new System.Drawing.Point(148, 6);
            this.btn_StartTesting.Name = "btn_StartTesting";
            this.btn_StartTesting.Size = new System.Drawing.Size(173, 43);
            this.btn_StartTesting.TabIndex = 0;
            this.btn_StartTesting.Text = "Bắt đầu";
            this.btn_StartTesting.UseVisualStyleBackColor = false;
            this.btn_StartTesting.Click += new System.EventHandler(this.btn_StartTesting_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pnl_S
            // 
            this.pnl_S.Controls.Add(this.lb_Time);
            this.pnl_S.Controls.Add(this.btn_StartTesting);
            this.pnl_S.Controls.Add(this.lb_TImer);
            this.pnl_S.Controls.Add(this.btn_Submit);
            this.pnl_S.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_S.Location = new System.Drawing.Point(0, 256);
            this.pnl_S.Name = "pnl_S";
            this.pnl_S.Size = new System.Drawing.Size(1592, 58);
            this.pnl_S.TabIndex = 2;
            // 
            // sP_LISTBANGSVTHITableAdapter
            // 
            this.sP_LISTBANGSVTHITableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.dS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // bAITHIBindingSource
            // 
            this.bAITHIBindingSource.DataMember = "BAITHI";
            this.bAITHIBindingSource.DataSource = this.dS;
            // 
            // bAITHITableAdapter
            // 
            this.bAITHITableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel_Question
            // 
            this.flowLayoutPanel_Question.AutoScroll = true;
            this.flowLayoutPanel_Question.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Question.Location = new System.Drawing.Point(0, 314);
            this.flowLayoutPanel_Question.Name = "flowLayoutPanel_Question";
            this.flowLayoutPanel_Question.Size = new System.Drawing.Size(1592, 619);
            this.flowLayoutPanel_Question.TabIndex = 19;
            // 
            // lANSpinEdit
            // 
            this.lANSpinEdit.Location = new System.Drawing.Point(148, 109);
            this.lANSpinEdit.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lANSpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Size = new System.Drawing.Size(144, 30);
            this.lANSpinEdit.TabIndex = 33;
            this.lANSpinEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fmDoExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1592, 933);
            this.Controls.Add(this.flowLayoutPanel_Question);
            this.Controls.Add(this.pnl_S);
            this.Controls.Add(this.pnl_Start);
            this.Controls.Add(this.pnl_InfoStu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmDoExam";
            this.Text = "Thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmDoExam_FormClosed);
            this.Load += new System.EventHandler(this.fmDoExam_Load);
            this.grpB_txtExam.ResumeLayout(false);
            this.grpB_txtExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.pnl_InfoStu.ResumeLayout(false);
            this.grpB_txtStudent.ResumeLayout(false);
            this.grpB_txtStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.pnl_Start.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LISTBANGSVTHIBindingSource)).EndInit();
            this.pnl_S.ResumeLayout(false);
            this.pnl_S.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpB_txtExam;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private System.Windows.Forms.Panel pnl_InfoStu;
        private System.Windows.Forms.Panel pnl_Start;
        private System.Windows.Forms.GroupBox grpB_txtStudent;
        private System.Windows.Forms.TextBox txtB_FullName;
        private System.Windows.Forms.TextBox txtB_NameClass;
        private System.Windows.Forms.TextBox txtB_IDStudent;
        private System.Windows.Forms.Label lb_NameClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mAMHComboBox1;
        private System.Windows.Forms.ComboBox tRINHDOComboBox;
        private DevExpress.XtraEditors.SpinEdit tHOIGIANSpinEdit;
        private DevExpress.XtraEditors.SpinEdit sOCAUTHISpinEdit;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_TImer;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_StartTesting;
        private System.Windows.Forms.Timer timer1;
        private DS dS;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lb_IDClass;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel pnl_S;
        private System.Windows.Forms.BindingSource sP_LISTBANGSVTHIBindingSource;
        private DSTableAdapters.SP_LISTBANGSVTHITableAdapter sP_LISTBANGSVTHITableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_Result;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.DateTimePicker nGAYTHIDateTimePicker;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.TextBox txtB_IDClass;
        private System.Windows.Forms.BindingSource bAITHIBindingSource;
        private DSTableAdapters.BAITHITableAdapter bAITHITableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Question;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.NumericUpDown lANSpinEdit;
    }
}