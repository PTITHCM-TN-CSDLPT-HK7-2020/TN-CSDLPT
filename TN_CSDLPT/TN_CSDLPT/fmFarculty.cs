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
        int vitriKH = 0;
        int vitriGV=0;
        string macs = ""; string makh = "";
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
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            //this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);

            macs = ((DataRowView)kHOABindingSource[0])["MACS"].ToString();
            
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
                barBtn_forbid.Enabled = false;
                grpB_Farculty.Enabled = false;
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView2.OptionsBehavior.ReadOnly = true;
                grpB_txtTeacher.Enabled = false;
            }
            else if(Program.mGroup == "Coso")
            {
                cbB_Branch.Enabled = false;
                barBtn_Add.Enabled =
                barBtn_Delete.Enabled =
                barBtn_Undo.Enabled =
                barBtn_Save.Enabled =
                barBtn_Refresh.Enabled=
                barBtn_forbid.Enabled=
                barBtn_Exit.Enabled=
                grpB_Farculty.Enabled = true;
            }
        }
        //=======================Function=========================================//
        private void reloadConnection()
        {
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
        }
        private bool CheckDuplicateFarculty(string query)
        {
            DataTable data= Program.ExecSqlDataTable(query);
            DataRow[] rows;
            rows = data.Select();
            int numberOfRecords = rows.Length;
            return numberOfRecords>0;
        }
        //=======================Event button=====================================//
        private void barBtn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitriKH = kHOABindingSource.Position;
            //grpB_txtFarculty.Enabled = true;
            
            kHOABindingSource.AddNew();//thêm cuối

            mACSTextBox.Text = macs;
            
            barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = false;
            barBtn_Save.Enabled = barBtn_Undo.Enabled = barBtn_Exit.Enabled = true;

            kHOAGridControl.Enabled =
            gIAOVIENGridControl.Enabled =
            grpB_txtTeacher.Enabled= false;
        }

        private void barBtn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string makh = "";
            if (gIAOVIENBindingSource_FK.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã có giáo viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    makh = ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["MAKH"].ToString();//giữ mã để xóa lỗi, quay về lại 
                    kHOABindingSource.RemoveCurrent();
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa. Vui lòng thử lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                    kHOABindingSource.Position = kHOABindingSource.Find("MAKH", makh);
                    return;
                }
                if (kHOABindingSource.Count == 0)//bảng môn học trống thì ko cho xóa
                {
                    barBtn_Delete.Enabled = false;
                }
                fmFarculty_Load(sender, e);
            }
        }

        private void barBtn_Undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (mAKHTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "", MessageBoxButtons.OK);
                mAKHTextBox.Focus();
                return;
            }
            if (tENKHTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Tên khoa không được để trống!", "", MessageBoxButtons.OK);
                tENKHTextBox.Focus();
                return;
            }
            try
            {
                string makh = "", tenkh = "";
                string query = "";
                tenkh = tENKHTextBox.Text.ToString();
                makh = mAKHTextBox.Text.ToString();
                query = "exec SP_CHECKTRUNGKHOA '"+makh+"'";
                if (!CheckDuplicateFarculty(query))
                {
                    kHOABindingSource.EndEdit();
                    kHOABindingSource.ResetCurrentItem();
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                    kHOAGridControl.Enabled = gIAOVIENGridControl.Enabled = grpB_txtTeacher.Enabled = true;
                    barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = barBtn_Exit.Enabled =
                    barBtn_Save.Enabled = barBtn_Undo.Enabled = true;
                    reloadConnection();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Lỗi trùng mã khoa! Vui lòng xem lại!","",MessageBoxButtons.RetryCancel);
                    
                    if (dr == DialogResult.Retry)
                    {
                        vitriKH = kHOABindingSource.Position;
                        //kHOABindingSource.AddNew();

                        mAKHTextBox.Text = makh;
                        tENKHTextBox.Text = tenkh;
                        mACSTextBox.Text = macs;
                        kHOAGridControl.Enabled = gIAOVIENGridControl.Enabled = grpB_txtTeacher.Enabled = false;
                        barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = false;
                        barBtn_Save.Enabled = barBtn_Undo.Enabled = barBtn_Exit.Enabled = barBtn_forbid.Enabled = true;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi dữ liệu. \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void barBtn_forbid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kHOABindingSource.CancelEdit();
            fmFarculty_Load(sender,e);
            kHOAGridControl.Enabled =
            gIAOVIENGridControl.Enabled =
            grpB_txtTeacher.Enabled = true;
            if (vitriKH > 0)
            {
                kHOABindingSource.Position = vitriKH;
            }
        }

        private void barBtn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kHOAGridControl.Enabled == false && Program.mGroup !="Truong")
            {
                DialogResult dr = MessageBox.Show("Dữ liệu chưa được lưu lại. Bạn có muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel);
                if(dr == DialogResult.Cancel)
                {
                    return;
                }
                else if(dr == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
                return;
            }
            
        }

        private void barBtn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                reloadConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void cbB_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbB_Branch.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
            
                Program.servername = cbB_Branch.SelectedValue.ToString();//server name sẽ được đổi qua sever name mới vừa chọn ở combo box
            }
            catch (Exception ex)
            {

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

                //this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.lOPTableAdapter.Fill(this.dS.LOP);

                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(this.dS.BODE);
                try {
                    macs = ((DataRowView)kHOABindingSource[0])["MACS"].ToString();

                }
                catch (Exception ex)
                {

                }
            }
        }
        //=====================Event các nút chức năng bảng giáo viên=======================//
        private void thêmGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitriGV = kHOABindingSource.Position;
            if (gIAOVIENBindingSource_FK.Count == 0)
            {
                makh = mAKHTextBox.Text.ToString();
            }
            else
            {
                makh = ((DataRowView)gIAOVIENBindingSource_FK[0])["MAKH"].ToString();
            }
            gIAOVIENBindingSource_FK.AddNew();//thêm cuối

            mAKHTextEdit.Text = makh;

            thêmLớpToolStripMenuItem.Enabled =
            xóaToolStripMenuItem.Enabled =
            làmMớiToolStripMenuItem.Enabled = false;
            phụcHồiToolStripMenuItem.Enabled = true;
            kHOAGridControl.Enabled=
            grpB_txtFarculty.Enabled=
            gIAOVIENGridControl.Enabled = false;
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string magv = "";
            if (bODEBindingSource_FK.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên này vì đã có lập bộ đề", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa giáo viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    magv = ((DataRowView)gIAOVIENBindingSource_FK[gIAOVIENBindingSource_FK.Position])["MAGV"].ToString();//giữ mã để xóa lỗi, quay về lại 
                    gIAOVIENBindingSource_FK.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên. Vui lòng thử lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                    gIAOVIENBindingSource_FK.Position = gIAOVIENBindingSource_FK.Find("MAGV", makh);
                    return;
                }
                if (gIAOVIENBindingSource_FK.Count == 0)//bảng môn học trống thì ko cho xóa
                {
                    xóaToolStripMenuItem.Enabled = false;
                }
                fmFarculty_Load(sender, e);
            }
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mAGVTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã giáo viên không được để trống!", "", MessageBoxButtons.OK);
                mAKHTextBox.Focus();
                return;
            }
            try
            {
                gIAOVIENBindingSource_FK.EndEdit();
                gIAOVIENBindingSource_FK.ResetCurrentItem();
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi dữ liệu. \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            kHOAGridControl.Enabled= gIAOVIENGridControl.Enabled =
            grpB_txtFarculty.Enabled=grpB_txtTeacher.Enabled    = true;
     
            thêmLớpToolStripMenuItem.Enabled = xóaToolStripMenuItem.Enabled = làmMớiToolStripMenuItem.Enabled =
            ghiToolStripMenuItem.Enabled = phụcHồiToolStripMenuItem.Enabled = true;
            reloadConnection();

        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gIAOVIENBindingSource_FK.CancelEdit();
            fmFarculty_Load(sender, e);
            kHOAGridControl.Enabled =
            gIAOVIENGridControl.Enabled =
            grpB_txtTeacher.Enabled =
            thêmLớpToolStripMenuItem.Enabled = xóaToolStripMenuItem.Enabled = làmMớiToolStripMenuItem.Enabled =
            ghiToolStripMenuItem.Enabled = phụcHồiToolStripMenuItem.Enabled = true;
            if (vitriKH > 0)
            {
                kHOABindingSource.Position = vitriKH;
            }
        }       
    }
}
