namespace TN_CSDLPT
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
            System.Windows.Forms.ColumnHeader columnHeader_Ques;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label tHOIGIANLabel1;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            this.grpB_txtExam = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listV_ChosenAnswer = new System.Windows.Forms.ListView();
            this.columnHeader_Ans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.pnl_InfoStu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpB_txtStudent = new System.Windows.Forms.GroupBox();
            this.txtB_FullName = new System.Windows.Forms.TextBox();
            this.txtB_IDClass = new System.Windows.Forms.TextBox();
            this.txtB_IDStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mAMHComboBox1 = new System.Windows.Forms.ComboBox();
            this.tRINHDOComboBox = new System.Windows.Forms.ComboBox();
            this.tHOIGIANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sOCAUTHISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.btn_StartTesting = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lb_TImer = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dS = new TN_CSDLPT.DS();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.nGAYTHIDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            columnHeader_Ques = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            tHOIGIANLabel1 = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            this.grpB_txtExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.pnl_InfoStu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpB_txtStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader_Ques
            // 
            columnHeader_Ques.Text = "Câu hỏi";
            columnHeader_Ques.Width = 84;
            // 
            // grpB_txtExam
            // 
            this.grpB_txtExam.Controls.Add(this.nGAYTHIDateEdit);
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
            this.grpB_txtExam.Location = new System.Drawing.Point(0, 0);
            this.grpB_txtExam.Name = "grpB_txtExam";
            this.grpB_txtExam.Size = new System.Drawing.Size(858, 214);
            this.grpB_txtExam.TabIndex = 0;
            this.grpB_txtExam.TabStop = false;
            this.grpB_txtExam.Text = "Thông tin bài thi";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1121, 598);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // listV_ChosenAnswer
            // 
            this.listV_ChosenAnswer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader_Ques,
            this.columnHeader_Ans});
            this.listV_ChosenAnswer.Dock = System.Windows.Forms.DockStyle.Right;
            this.listV_ChosenAnswer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listV_ChosenAnswer.HideSelection = false;
            this.listV_ChosenAnswer.Location = new System.Drawing.Point(1121, 0);
            this.listV_ChosenAnswer.Name = "listV_ChosenAnswer";
            this.listV_ChosenAnswer.Size = new System.Drawing.Size(205, 598);
            this.listV_ChosenAnswer.TabIndex = 2;
            this.listV_ChosenAnswer.UseCompatibleStateImageBehavior = false;
            this.listV_ChosenAnswer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Ans
            // 
            this.columnHeader_Ans.Text = "Đáp án chọn";
            this.columnHeader_Ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Ans.Width = 115;
            // 
            // pnl_InfoStu
            // 
            this.pnl_InfoStu.Controls.Add(this.grpB_txtStudent);
            this.pnl_InfoStu.Controls.Add(this.grpB_txtExam);
            this.pnl_InfoStu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_InfoStu.Location = new System.Drawing.Point(0, 0);
            this.pnl_InfoStu.Name = "pnl_InfoStu";
            this.pnl_InfoStu.Size = new System.Drawing.Size(1326, 214);
            this.pnl_InfoStu.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_Time);
            this.panel2.Controls.Add(this.lb_TImer);
            this.panel2.Controls.Add(this.btn_Submit);
            this.panel2.Controls.Add(this.btn_StartTesting);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 121);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.listV_ChosenAnswer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1326, 598);
            this.panel3.TabIndex = 5;
            // 
            // grpB_txtStudent
            // 
            this.grpB_txtStudent.Controls.Add(this.txtB_FullName);
            this.grpB_txtStudent.Controls.Add(this.txtB_IDClass);
            this.grpB_txtStudent.Controls.Add(this.txtB_IDStudent);
            this.grpB_txtStudent.Controls.Add(this.label1);
            this.grpB_txtStudent.Controls.Add(this.label2);
            this.grpB_txtStudent.Controls.Add(this.label4);
            this.grpB_txtStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpB_txtStudent.Location = new System.Drawing.Point(858, 0);
            this.grpB_txtStudent.Name = "grpB_txtStudent";
            this.grpB_txtStudent.Size = new System.Drawing.Size(934, 214);
            this.grpB_txtStudent.TabIndex = 8;
            this.grpB_txtStudent.TabStop = false;
            this.grpB_txtStudent.Text = "Thông tin sinh viên";
            // 
            // txtB_FullName
            // 
            this.txtB_FullName.Enabled = false;
            this.txtB_FullName.Location = new System.Drawing.Point(163, 93);
            this.txtB_FullName.Name = "txtB_FullName";
            this.txtB_FullName.Size = new System.Drawing.Size(187, 30);
            this.txtB_FullName.TabIndex = 6;
            // 
            // txtB_IDClass
            // 
            this.txtB_IDClass.Enabled = false;
            this.txtB_IDClass.Location = new System.Drawing.Point(163, 161);
            this.txtB_IDClass.Name = "txtB_IDClass";
            this.txtB_IDClass.Size = new System.Drawing.Size(187, 30);
            this.txtB_IDClass.TabIndex = 5;
            // 
            // txtB_IDStudent
            // 
            this.txtB_IDStudent.Enabled = false;
            this.txtB_IDStudent.Location = new System.Drawing.Point(163, 27);
            this.txtB_IDStudent.Name = "txtB_IDStudent";
            this.txtB_IDStudent.Size = new System.Drawing.Size(187, 30);
            this.txtB_IDStudent.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lớp:";
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
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(57, 35);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(85, 22);
            mAMHLabel.TabIndex = 14;
            mAMHLabel.Text = "Môn học:";
            // 
            // tRINHDOComboBox
            // 
            this.tRINHDOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tRINHDOComboBox.FormattingEnabled = true;
            this.tRINHDOComboBox.ItemHeight = 22;
            this.tRINHDOComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.tRINHDOComboBox.Location = new System.Drawing.Point(609, 32);
            this.tRINHDOComboBox.Name = "tRINHDOComboBox";
            this.tRINHDOComboBox.Size = new System.Drawing.Size(214, 30);
            this.tRINHDOComboBox.TabIndex = 13;
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(498, 35);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(83, 22);
            tRINHDOLabel.TabIndex = 15;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // tHOIGIANSpinEdit
            // 
            this.tHOIGIANSpinEdit.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Location = new System.Drawing.Point(609, 160);
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
            // tHOIGIANLabel1
            // 
            tHOIGIANLabel1.AutoSize = true;
            tHOIGIANLabel1.Location = new System.Drawing.Point(498, 164);
            tHOIGIANLabel1.Name = "tHOIGIANLabel1";
            tHOIGIANLabel1.Size = new System.Drawing.Size(92, 22);
            tHOIGIANLabel1.TabIndex = 25;
            tHOIGIANLabel1.Text = "Thời gian:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(496, 96);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(94, 22);
            sOCAUTHILabel.TabIndex = 23;
            sOCAUTHILabel.Text = "Số câu thi:";
            // 
            // sOCAUTHISpinEdit
            // 
            this.sOCAUTHISpinEdit.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sOCAUTHISpinEdit.Location = new System.Drawing.Point(609, 95);
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
            // btn_StartTesting
            // 
            this.btn_StartTesting.BackColor = System.Drawing.Color.Aqua;
            this.btn_StartTesting.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartTesting.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_StartTesting.Location = new System.Drawing.Point(227, 34);
            this.btn_StartTesting.Name = "btn_StartTesting";
            this.btn_StartTesting.Size = new System.Drawing.Size(173, 43);
            this.btn_StartTesting.TabIndex = 0;
            this.btn_StartTesting.Text = "Bắt đầu";
            this.btn_StartTesting.UseVisualStyleBackColor = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Submit.Location = new System.Drawing.Point(1015, 34);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(173, 43);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "Nộp bài";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // lb_TImer
            // 
            this.lb_TImer.AutoSize = true;
            this.lb_TImer.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TImer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TImer.Location = new System.Drawing.Point(703, 34);
            this.lb_TImer.Name = "lb_TImer";
            this.lb_TImer.Size = new System.Drawing.Size(108, 43);
            this.lb_TImer.TabIndex = 2;
            this.lb_TImer.Text = "60:00";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(605, 48);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(92, 22);
            this.lb_Time.TabIndex = 3;
            this.lb_Time.Text = "Thời gian:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
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
            // nGAYTHIDateEdit
            // 
            this.nGAYTHIDateEdit.EditValue = null;
            this.nGAYTHIDateEdit.Location = new System.Drawing.Point(151, 157);
            this.nGAYTHIDateEdit.Name = "nGAYTHIDateEdit";
            this.nGAYTHIDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nGAYTHIDateEdit.Properties.Appearance.Options.UseFont = true;
            this.nGAYTHIDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Size = new System.Drawing.Size(214, 26);
            this.nGAYTHIDateEdit.TabIndex = 27;
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(60, 161);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(82, 22);
            nGAYTHILabel.TabIndex = 29;
            nGAYTHILabel.Text = "Ngày thi:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(42, 96);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(100, 22);
            lANLabel.TabIndex = 28;
            lANLabel.Text = "Lần thi thứ:";
            // 
            // lANSpinEdit
            // 
            this.lANSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lANSpinEdit.Location = new System.Drawing.Point(148, 95);
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
            // fmDoExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1326, 933);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_InfoStu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmDoExam";
            this.Text = "fmDoExam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmDoExam_Load);
            this.grpB_txtExam.ResumeLayout(false);
            this.grpB_txtExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.pnl_InfoStu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grpB_txtStudent.ResumeLayout(false);
            this.grpB_txtStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpB_txtExam;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ColumnHeader columnHeader_Ans;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private System.Windows.Forms.Panel pnl_InfoStu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpB_txtStudent;
        private System.Windows.Forms.TextBox txtB_FullName;
        private System.Windows.Forms.TextBox txtB_IDClass;
        private System.Windows.Forms.TextBox txtB_IDStudent;
        private System.Windows.Forms.Label label1;
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
        private DevExpress.XtraEditors.DateEdit nGAYTHIDateEdit;
        private DevExpress.XtraEditors.SpinEdit lANSpinEdit;
        public System.Windows.Forms.ListView listV_ChosenAnswer;
    }
}