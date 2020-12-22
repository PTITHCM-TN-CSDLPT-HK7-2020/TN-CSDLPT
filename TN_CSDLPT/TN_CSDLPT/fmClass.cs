using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class fmClass : Form
    {
        int vitriLOP = 0;
        int vitriSV = 0;
        string macs = ""; string malop = "";
        
        public fmClass()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void fmClass_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            //this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            

            macs = ((DataRowView)lOPBindingSource[0])["MACS"].ToString();

            cb_Branch.DataSource = Program.bds_dspm;
            cb_Branch.DisplayMember = "TENCOSO";
            cb_Branch.ValueMember = "TENSERVER";
            cb_Branch.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "Truong")
            {
                cb_Branch.Enabled = true;//chi nhom tai khoản trường mới được đổi giữa hai cơ sở 1 và 2
                bar_Add.Enabled = false;
                bar_Del.Enabled = false;
                bar_Undo.Enabled = false;
                bar_Save.Enabled = false;
                bar_forbit.Enabled = false;
                gr_Class.Enabled = false;
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView2.OptionsBehavior.ReadOnly = true;
                gr_Student.Enabled = false;
            }
            else if (Program.mGroup == "Coso")
            {
                cb_Branch.Enabled = false;
                bar_Add.Enabled =
                bar_Del.Enabled =
                bar_Undo.Enabled =
                 bar_Save.Enabled =
                bar_New.Enabled =
                bar_forbit.Enabled =
                bar_exit.Enabled =
                gr_Class.Enabled = true;
            }

        }
                         //funtion//
        private void reloadConnection()
        {
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
        }

        private bool CheckDuplicateLOP(string query)
        {
            DataTable data = Program.ExecSqlDataTable(query);
            DataRow[] rows;
            rows = data.Select();
            int numberOfRecords = rows.Length;
            return numberOfRecords > 0;
        }
                                            /////button///////
        private void cb_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_Branch.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }

                Program.servername = cb_Branch.SelectedValue.ToString();//server name sẽ được đổi qua sever name mới vừa chọn ở combo box
            }
            catch (Exception ex)
            {

            }

            //Nếu chi nhánh được chọn khác chi nhánh lúc đầu thì đăng nhập bằng tài khoản HTKN
            if (cb_Branch.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remotelogin;//="HTKN"
                Program.password = Program.remotepassword;//="123"
            }
            else//ngược lại giống cho tài khoản bằng tài khoản ban đầu đã đăng nhập
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở vừa chọn!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                //this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.lOPTableAdapter.Fill(this.dS.LOP);

                
                try
                {
                    macs = ((DataRowView)lOPBindingSource[0])["MACS"].ToString();

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void bar_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //vitriLOP = lOPTableAdapter.Position;
            ////grpB_txtFarculty.Enabled = true;

            //lOPBindingSource.AddNew();//thêm cuối

            //mACSTextBox.Text = macs;

            //barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = false;
            //barBtn_Save.Enabled = barBtn_Undo.Enabled = barBtn_Exit.Enabled = true;

            //kHOAGridControl.Enabled =
            //gIAOVIENGridControl.Enabled =
            //grpB_txtTeacher.Enabled = false;
        }
    }
}
