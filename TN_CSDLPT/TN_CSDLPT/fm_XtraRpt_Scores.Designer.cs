namespace TN_CSDLPT
{
    partial class fm_XtraRpt_Scores
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label label2;
            this.dS = new TN_CSDLPT.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.mALOPComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.mAMHComboBox = new System.Windows.Forms.ComboBox();
            this.tENMHTextBox = new System.Windows.Forms.TextBox();
            this.Lan_numberic_UD = new System.Windows.Forms.NumericUpDown();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lan_numberic_UD)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(24, 75);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(67, 19);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mALOPComboBox
            // 
            this.mALOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.mALOPComboBox.DataSource = this.lOPBindingSource;
            this.mALOPComboBox.DisplayMember = "MALOP";
            this.mALOPComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPComboBox.FormattingEnabled = true;
            this.mALOPComboBox.Location = new System.Drawing.Point(99, 71);
            this.mALOPComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mALOPComboBox.Name = "mALOPComboBox";
            this.mALOPComboBox.Size = new System.Drawing.Size(175, 27);
            this.mALOPComboBox.TabIndex = 1;
            this.mALOPComboBox.ValueMember = "MALOP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lập báo cáo bảng điểm lớp học";
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
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(382, 75);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(105, 19);
            mAMHLabel.TabIndex = 3;
            mAMHLabel.Text = "Mã môn học:";
            // 
            // mAMHComboBox
            // 
            this.mAMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.mAMHComboBox.DataSource = this.mONHOCBindingSource;
            this.mAMHComboBox.DisplayMember = "MAMH";
            this.mAMHComboBox.FormattingEnabled = true;
            this.mAMHComboBox.Location = new System.Drawing.Point(487, 72);
            this.mAMHComboBox.Name = "mAMHComboBox";
            this.mAMHComboBox.Size = new System.Drawing.Size(121, 27);
            this.mAMHComboBox.TabIndex = 2;
            this.mAMHComboBox.ValueMember = "MAMH";
            // 
            // tENMHTextBox
            // 
            this.tENMHTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tENMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.tENMHTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENMHTextBox.ForeColor = System.Drawing.Color.Black;
            this.tENMHTextBox.Location = new System.Drawing.Point(614, 72);
            this.tENMHTextBox.Name = "tENMHTextBox";
            this.tENMHTextBox.ReadOnly = true;
            this.tENMHTextBox.Size = new System.Drawing.Size(303, 27);
            this.tENMHTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(24, 145);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 19);
            label2.TabIndex = 7;
            label2.Text = "Lần thi:";
            // 
            // Lan_numberic_UD
            // 
            this.Lan_numberic_UD.Location = new System.Drawing.Point(98, 145);
            this.Lan_numberic_UD.Name = "Lan_numberic_UD";
            this.Lan_numberic_UD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lan_numberic_UD.Size = new System.Drawing.Size(176, 27);
            this.Lan_numberic_UD.TabIndex = 3;
            this.Lan_numberic_UD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Lan_numberic_UD.ThousandsSeparator = true;
            this.Lan_numberic_UD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Exit.Location = new System.Drawing.Point(789, 145);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(128, 41);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Aqua;
            this.btn_preview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_preview.Location = new System.Drawing.Point(614, 145);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(128, 41);
            this.btn_preview.TabIndex = 10;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // fm_XtraRpt_Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(955, 245);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Lan_numberic_UD);
            this.Controls.Add(label2);
            this.Controls.Add(this.tENMHTextBox);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.mAMHComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.mALOPComboBox);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fm_XtraRpt_Scores";
            this.Text = "Báo cáo bảng điểm";
            this.Load += new System.EventHandler(this.fm_XtraRpt_Scores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lan_numberic_UD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox mALOPComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox mAMHComboBox;
        private System.Windows.Forms.TextBox tENMHTextBox;
        private System.Windows.Forms.NumericUpDown Lan_numberic_UD;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_preview;
    }
}