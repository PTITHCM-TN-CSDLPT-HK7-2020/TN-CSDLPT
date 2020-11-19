namespace TN_CSDLPT
{
    partial class fmLogin
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
            System.Windows.Forms.Label branch_Lb;
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.txtBox_LgName = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lb_IDStudent = new System.Windows.Forms.Label();
            this.grpBox_Login = new System.Windows.Forms.GroupBox();
            this.cbBox_Branch = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tN_CSDLPTDataSet = new TN_CSDLPT.TN_CSDLPTDataSet();
            this.grpBox_User = new System.Windows.Forms.GroupBox();
            this.radBtn_Student = new System.Windows.Forms.RadioButton();
            this.radBtn_Teacher = new System.Windows.Forms.RadioButton();
            this.v_DS_PHANMANHTableAdapter = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            branch_Lb = new System.Windows.Forms.Label();
            this.grpBox_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            this.grpBox_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // branch_Lb
            // 
            branch_Lb.AutoSize = true;
            branch_Lb.Location = new System.Drawing.Point(41, 107);
            branch_Lb.Name = "branch_Lb";
            branch_Lb.Size = new System.Drawing.Size(56, 21);
            branch_Lb.TabIndex = 3;
            branch_Lb.Text = "Cơ sở";
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.Location = new System.Drawing.Point(41, 164);
            this.lb_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(91, 21);
            this.lb_Login.TabIndex = 1;
            this.lb_Login.Text = "Đăng nhập";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(41, 228);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(79, 21);
            this.lb_Password.TabIndex = 2;
            this.lb_Password.Text = "Mật khẩu";
            // 
            // txtBox_LgName
            // 
            this.txtBox_LgName.Location = new System.Drawing.Point(166, 161);
            this.txtBox_LgName.Name = "txtBox_LgName";
            this.txtBox_LgName.Size = new System.Drawing.Size(317, 28);
            this.txtBox_LgName.TabIndex = 4;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(166, 228);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.PasswordChar = '*';
            this.txtBox_Password.Size = new System.Drawing.Size(317, 28);
            this.txtBox_Password.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(166, 300);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(121, 46);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(362, 300);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(121, 46);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lb_IDStudent
            // 
            this.lb_IDStudent.AutoSize = true;
            this.lb_IDStudent.Location = new System.Drawing.Point(41, 164);
            this.lb_IDStudent.Name = "lb_IDStudent";
            this.lb_IDStudent.Size = new System.Drawing.Size(104, 21);
            this.lb_IDStudent.TabIndex = 7;
            this.lb_IDStudent.Text = "Mã sinh viên";
            // 
            // grpBox_Login
            // 
            this.grpBox_Login.Controls.Add(branch_Lb);
            this.grpBox_Login.Controls.Add(this.lb_IDStudent);
            this.grpBox_Login.Controls.Add(this.btn_Exit);
            this.grpBox_Login.Controls.Add(this.btn_Login);
            this.grpBox_Login.Controls.Add(this.cbBox_Branch);
            this.grpBox_Login.Controls.Add(this.txtBox_Password);
            this.grpBox_Login.Controls.Add(this.grpBox_User);
            this.grpBox_Login.Controls.Add(this.lb_Password);
            this.grpBox_Login.Controls.Add(this.txtBox_LgName);
            this.grpBox_Login.Controls.Add(this.lb_Login);
            this.grpBox_Login.Location = new System.Drawing.Point(121, 12);
            this.grpBox_Login.Name = "grpBox_Login";
            this.grpBox_Login.Size = new System.Drawing.Size(615, 428);
            this.grpBox_Login.TabIndex = 9;
            this.grpBox_Login.TabStop = false;
            // 
            // cbBox_Branch
            // 
            this.cbBox_Branch.DataSource = this.vDSPHANMANHBindingSource;
            this.cbBox_Branch.DisplayMember = "TENCOSO";
            this.cbBox_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Branch.FormattingEnabled = true;
            this.cbBox_Branch.Location = new System.Drawing.Point(166, 100);
            this.cbBox_Branch.Name = "cbBox_Branch";
            this.cbBox_Branch.Size = new System.Drawing.Size(317, 28);
            this.cbBox_Branch.TabIndex = 3;
            this.cbBox_Branch.ValueMember = "TENSERVER";
            this.cbBox_Branch.SelectedIndexChanged += new System.EventHandler(this.cbBox_Branch_SelectedIndexChanged_1);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpBox_User
            // 
            this.grpBox_User.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.grpBox_User.Controls.Add(this.radBtn_Student);
            this.grpBox_User.Controls.Add(this.radBtn_Teacher);
            this.grpBox_User.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBox_User.Location = new System.Drawing.Point(189, 24);
            this.grpBox_User.Name = "grpBox_User";
            this.grpBox_User.Size = new System.Drawing.Size(264, 61);
            this.grpBox_User.TabIndex = 2;
            this.grpBox_User.TabStop = false;
            // 
            // radBtn_Student
            // 
            this.radBtn_Student.AutoSize = true;
            this.radBtn_Student.Location = new System.Drawing.Point(134, 21);
            this.radBtn_Student.Name = "radBtn_Student";
            this.radBtn_Student.Size = new System.Drawing.Size(99, 25);
            this.radBtn_Student.TabIndex = 2;
            this.radBtn_Student.TabStop = true;
            this.radBtn_Student.Text = "Sinh viên";
            this.radBtn_Student.UseVisualStyleBackColor = true;
            this.radBtn_Student.CheckedChanged += new System.EventHandler(this.radBtn_Student_CheckedChanged);
            // 
            // radBtn_Teacher
            // 
            this.radBtn_Teacher.AutoSize = true;
            this.radBtn_Teacher.Location = new System.Drawing.Point(0, 21);
            this.radBtn_Teacher.Name = "radBtn_Teacher";
            this.radBtn_Teacher.Size = new System.Drawing.Size(110, 25);
            this.radBtn_Teacher.TabIndex = 1;
            this.radBtn_Teacher.TabStop = true;
            this.radBtn_Teacher.Text = "Giảng viên";
            this.radBtn_Teacher.UseVisualStyleBackColor = true;
            this.radBtn_Teacher.CheckedChanged += new System.EventHandler(this.radBtn_Teacher_CheckedChanged);
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 468);
            this.Controls.Add(this.grpBox_Login);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fmLogin_Load);
            this.grpBox_Login.ResumeLayout(false);
            this.grpBox_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            this.grpBox_User.ResumeLayout(false);
            this.grpBox_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox txtBox_LgName;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lb_IDStudent;
        private System.Windows.Forms.GroupBox grpBox_Login;
        private System.Windows.Forms.ComboBox cbBox_Branch;
        private System.Windows.Forms.GroupBox grpBox_User;
        private System.Windows.Forms.RadioButton radBtn_Student;
        private System.Windows.Forms.RadioButton radBtn_Teacher;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        public System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}