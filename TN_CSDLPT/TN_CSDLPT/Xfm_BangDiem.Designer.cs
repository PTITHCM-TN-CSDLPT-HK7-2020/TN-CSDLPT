namespace TN_CSDLPT
{
    partial class Xfm_BangDiem
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label mAMHLabel;
            this.dS = new TN_CSDLPT.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.bANGDIEMTableAdapter = new TN_CSDLPT.DSTableAdapters.BANGDIEMTableAdapter();
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.tENLOPComboBox = new System.Windows.Forms.ComboBox();
            this.bANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAMHComboBox = new System.Windows.Forms.ComboBox();
            this.button_Prereview = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            tENLOPLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(121, 35);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(90, 22);
            tENLOPLabel.TabIndex = 0;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(813, 35);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(55, 22);
            lANLabel.TabIndex = 2;
            lANLabel.Text = "LAN:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(442, 35);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(85, 22);
            mAMHLabel.TabIndex = 4;
            mAMHLabel.Text = "TENMH:";
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
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
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
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tENLOPComboBox
            // 
            this.tENLOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.tENLOPComboBox.DataSource = this.lOPBindingSource;
            this.tENLOPComboBox.DisplayMember = "TENLOP";
            this.tENLOPComboBox.FormattingEnabled = true;
            this.tENLOPComboBox.Location = new System.Drawing.Point(217, 32);
            this.tENLOPComboBox.Name = "tENLOPComboBox";
            this.tENLOPComboBox.Size = new System.Drawing.Size(192, 30);
            this.tENLOPComboBox.TabIndex = 1;
            this.tENLOPComboBox.ValueMember = "MALOP";
            // 
            // bANGDIEMBindingSource
            // 
            this.bANGDIEMBindingSource.DataMember = "BANGDIEM";
            this.bANGDIEMBindingSource.DataSource = this.dS;
            // 
            // lANSpinEdit
            // 
            this.lANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "LAN", true));
            this.lANSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lANSpinEdit.Location = new System.Drawing.Point(874, 32);
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lANSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.lANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lANSpinEdit.Properties.IsFloatValue = false;
            this.lANSpinEdit.Properties.Mask.EditMask = "N00";
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
            this.lANSpinEdit.Size = new System.Drawing.Size(192, 28);
            this.lANSpinEdit.TabIndex = 3;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // mAMHComboBox
            // 
            this.mAMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.mAMHComboBox.DataSource = this.mONHOCBindingSource;
            this.mAMHComboBox.DisplayMember = "TENMH";
            this.mAMHComboBox.FormattingEnabled = true;
            this.mAMHComboBox.Location = new System.Drawing.Point(526, 32);
            this.mAMHComboBox.Name = "mAMHComboBox";
            this.mAMHComboBox.Size = new System.Drawing.Size(223, 30);
            this.mAMHComboBox.TabIndex = 5;
            this.mAMHComboBox.ValueMember = "MAMH";
            // 
            // button_Prereview
            // 
            this.button_Prereview.Location = new System.Drawing.Point(314, 135);
            this.button_Prereview.Name = "button_Prereview";
            this.button_Prereview.Size = new System.Drawing.Size(186, 37);
            this.button_Prereview.TabIndex = 6;
            this.button_Prereview.Text = "Xem";
            this.button_Prereview.UseVisualStyleBackColor = true;
            this.button_Prereview.Click += new System.EventHandler(this.button_Prereview_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(682, 135);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(186, 37);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "Thoát";
            this.button_Exit.UseVisualStyleBackColor = true;
            // 
            // Xfm_BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 195);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Prereview);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.mAMHComboBox);
            this.Controls.Add(lANLabel);
            this.Controls.Add(this.lANSpinEdit);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.tENLOPComboBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Xfm_BangDiem";
            this.Text = "Xfm_BangDiem";
            this.Load += new System.EventHandler(this.Xfm_BangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private System.Windows.Forms.ComboBox tENLOPComboBox;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.SpinEdit lANSpinEdit;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.ComboBox mAMHComboBox;
        private System.Windows.Forms.Button button_Prereview;
        private System.Windows.Forms.Button button_Exit;
    }
}