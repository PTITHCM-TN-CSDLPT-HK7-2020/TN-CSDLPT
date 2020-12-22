namespace TN_CSDLPT
{
    partial class fmScoreTable
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
            System.Windows.Forms.Label lANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmScoreTable));
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TN_CSDLPT.DS();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.pnl_InfoStu = new System.Windows.Forms.Panel();
            this.grpB_txtExam = new System.Windows.Forms.GroupBox();
            this.mALOPComboBox = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAMHComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView_Score = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            lANLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.pnl_InfoStu.SuspendLayout();
            this.grpB_txtExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lANLabel
            // 
            resources.ApplyResources(lANLabel, "lANLabel");
            lANLabel.Name = "lANLabel";
            // 
            // mAMHLabel
            // 
            resources.ApplyResources(mAMHLabel, "mAMHLabel");
            mAMHLabel.Name = "mAMHLabel";
            // 
            // mALOPLabel
            // 
            resources.ApplyResources(mALOPLabel, "mALOPLabel");
            mALOPLabel.Name = "mALOPLabel";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
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
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_InfoStu
            // 
            this.pnl_InfoStu.Controls.Add(this.grpB_txtExam);
            resources.ApplyResources(this.pnl_InfoStu, "pnl_InfoStu");
            this.pnl_InfoStu.Name = "pnl_InfoStu";
            // 
            // grpB_txtExam
            // 
            this.grpB_txtExam.Controls.Add(mALOPLabel);
            this.grpB_txtExam.Controls.Add(this.mALOPComboBox);
            this.grpB_txtExam.Controls.Add(this.btn_Refresh);
            this.grpB_txtExam.Controls.Add(this.btn_Search);
            this.grpB_txtExam.Controls.Add(lANLabel);
            this.grpB_txtExam.Controls.Add(this.lANSpinEdit);
            this.grpB_txtExam.Controls.Add(this.mAMHComboBox);
            this.grpB_txtExam.Controls.Add(mAMHLabel);
            resources.ApplyResources(this.grpB_txtExam, "grpB_txtExam");
            this.grpB_txtExam.Name = "grpB_txtExam";
            this.grpB_txtExam.TabStop = false;
            // 
            // mALOPComboBox
            // 
            this.mALOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.mALOPComboBox.DataSource = this.lOPBindingSource;
            this.mALOPComboBox.DisplayMember = "TENLOP";
            this.mALOPComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.mALOPComboBox, "mALOPComboBox");
            this.mALOPComboBox.Name = "mALOPComboBox";
            this.mALOPComboBox.ValueMember = "MALOP";
            // 
            // btn_Refresh
            // 
            resources.ApplyResources(this.btn_Refresh, "btn_Refresh");
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            resources.ApplyResources(this.btn_Search, "btn_Search");
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lANSpinEdit
            // 
            resources.ApplyResources(this.lANSpinEdit, "lANSpinEdit");
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lANSpinEdit.Properties.Appearance.Font")));
            this.lANSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.lANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lANSpinEdit.Properties.Buttons"))))});
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
            // 
            // mAMHComboBox
            // 
            this.mAMHComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mAMHComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mAMHComboBox.DataSource = this.mONHOCBindingSource;
            this.mAMHComboBox.DisplayMember = "TENMH";
            this.mAMHComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.mAMHComboBox, "mAMHComboBox");
            this.mAMHComboBox.Name = "mAMHComboBox";
            this.mAMHComboBox.ValueMember = "MAMH";
            // 
            // dataGridView_Score
            // 
            this.dataGridView_Score.AllowUserToAddRows = false;
            this.dataGridView_Score.AllowUserToDeleteRows = false;
            this.dataGridView_Score.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView_Score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView_Score, "dataGridView_Score");
            this.dataGridView_Score.Name = "dataGridView_Score";
            this.dataGridView_Score.ReadOnly = true;
            this.dataGridView_Score.RowTemplate.Height = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Score);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // fmScoreTable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_InfoStu);
            this.Name = "fmScoreTable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScoreTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.pnl_InfoStu.ResumeLayout(false);
            this.grpB_txtExam.ResumeLayout(false);
            this.grpB_txtExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.Panel pnl_InfoStu;
        private System.Windows.Forms.GroupBox grpB_txtExam;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private DevExpress.XtraEditors.SpinEdit lANSpinEdit;
        private System.Windows.Forms.ComboBox mAMHComboBox;
        private System.Windows.Forms.ComboBox mALOPComboBox;
        private System.Windows.Forms.DataGridView dataGridView_Score;
        private System.Windows.Forms.Panel panel1;
    }
}