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
    public partial class fmFarculty : Form
    {
        int vitri = 0;
        public fmFarculty()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void fmFarculty_Load(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            cbB_Branch.DataSource = Program.bds_dspm;
            cbB_Branch.DisplayMember = "TENCOSO";
            cbB_Branch.ValueMember = "TENSERVER";
            cbB_Branch.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "Truong")
            {
                cbB_Branch.Enabled = true;//chi nhom tai khoản trường mới được đổi giữa hai cơ sở 1 và 2
                barBtn_Add.Enabled = false;
                barBtn_Delete.Enabled = false;
                barBtn_Undo.Enabled = false;
                barBtn_Save.Enabled = false;
                grpB_Farculty.Enabled = false;
            }
            else cbB_Branch.Enabled = false;
        }

        private void cbB_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_Branch.SelectedIndex.ToString() == "System.Data.DataRowView")
            {
                Program.servername = cbB_Branch.SelectedValue.ToString();//server name sẽ được đổi qua sever name mới vừa chọn ở combo box
            }

            //Nếu chi nhánh được chọn khác chi nhánh lúc đầu thì đăng nhập bằng tài khoản HTKN
            if (cbB_Branch.SelectedIndex != Program.mCoso)
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
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);

                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
        }

        private void barBtn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barBtn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
