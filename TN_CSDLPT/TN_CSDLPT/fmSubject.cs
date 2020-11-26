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
    public partial class fmSubject : Form
    {
        int vitri=0;
        public fmSubject()
        {
            InitializeComponent();
        }

        private void fmTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;//thực hiện lấy kết nối đến csdl phân tán mà ta đã chọn đăng nhập ở login
            this.mONHOCTableAdapter.Fill(this.ds1.MONHOC);
         
            // TODO: This line of code loads data into the 'ds1.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.ds1.BODE);

            cbB_Branch.DataSource = Program.bds_dspm;//sao chép bds dspm đã load ở form login đưa vào, chứa 2 cơ sở :1 và 2
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
                grpB_Subjects.Enabled = false;
            }
            else cbB_Branch.Enabled = false;
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds1);

        }

        private void cbB_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_Branch.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.servername = cbB_Branch.SelectedValue.ToString();//server name sẽ được đổi qua sever name mới vừa chọn ở combo box
            //Nếu chi nhánh được chọn khác chi nhánh lúc đầu thì đăng nhập bằng tài khoản HTKN
            if (cbB_Branch.SelectedIndex!=Program.mCoso)
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
                MessageBox.Show("Lỗi kết nối tới cơ sở vừa chọn!","Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                //Program.servername = cbB_Branch.SelectedValue.ToString();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.ds1.MONHOC);
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(this.ds1.BODE);
            }
        }

        private void barBtn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = mONHOCBindingSource.Position;
            grpB_Subjects.Enabled = true;
            mONHOCBindingSource.AddNew();//thêm vào cuối
            barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = barBtn_Exit.Enabled=false;//Tránh trường hợp chưa thêm đã xóa hoặc ghi,...
            barBtn_Save.Enabled = barBtn_Undo.Enabled = true;
            mONHOCGridControl.Enabled = false;
        }

        private void barBtn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAMHTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK);
                mAMHTextEdit.Focus();
                return;
            }
            try
            {
                mONHOCBindingSource.EndEdit();
                mONHOCBindingSource.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.ds1.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi dữ liệu. \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            mONHOCGridControl.Enabled = true;
            barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = barBtn_Exit.Enabled = true;
            barBtn_Save.Enabled = barBtn_Undo.Enabled = false;
            grpB_Subjects.Enabled = false;
        }

        private void barBtn_Undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mONHOCBindingSource.CancelEdit();
            if (barBtn_Add.Enabled == false) mONHOCBindingSource.Position = vitri;
            mONHOCGridControl.Enabled = true;
            grpB_Subjects.Enabled = false;
            barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = barBtn_Exit.Enabled = true;
            barBtn_Save.Enabled = barBtn_Undo.Enabled = false;
        }

        private void barBtn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Fill(this.ds1.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void barBtn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mamh = "";
            if (bODEBindingSource_FK.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có bộ đề của môn học", "Thông báo", MessageBoxButtons.OK);
            }
            if(MessageBox.Show("Bạn có chắc muốn xóa môn học này?","Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mamh = ((DataRowView)mONHOCBindingSource[mONHOCBindingSource.Position])["MAMH"].ToString();//giữ mã để xóa lỗi, quay về lại 
                    mONHOCBindingSource.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.ds1.MONHOC);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Vui lòng thử lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.ds1.MONHOC);
                    mONHOCBindingSource.Position = mONHOCBindingSource.Find("MAMH", mamh);
                    return;
                }
                if (mONHOCBindingSource.Count == 0)//bảng môn học trống thì ko cho xóa
                {
                    barBtn_Delete.Enabled = false;
                }
            }
        }

        private void barBtn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
