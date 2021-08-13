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
    public partial class fmRegistTest : Form
    {
        int vitri = 0;
        string macs = "";

        public fmRegistTest()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        //=======================Function=========================================//
        private void reloadConnection()
        {
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

        }
        private bool CheckDeleteRegisting(string query)
        {
            DataTable data = Program.ExecSqlDataTable(query);
            DataRow[] rows;
            rows = data.Select();
            int numberOfRecords = rows.Length;
            return numberOfRecords > 0;
        }
        //=========================================================================//
        private void fmRegistTest_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

                // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);


            if (gIAOVIEN_DANGKYBindingSource.Count > 0)
            {
                //fix loi dong dau combobox
                mAMHComboBox1.SelectedValue = ((DataRowView)gIAOVIEN_DANGKYBindingSource[0])["MAMH"].ToString();
                mALOPComboBox.SelectedValue = ((DataRowView)gIAOVIEN_DANGKYBindingSource[0])["MALOP"].ToString();
            }

            cbBox_Branch.DataSource = Program.bds_dspm;//sao chép bds dspm đã load ở form login đưa vào, chứa 2 cơ sở :1 và 2
            cbBox_Branch.DisplayMember = "TENCOSO";
            cbBox_Branch.ValueMember = "TENSERVER";
            cbBox_Branch.SelectedIndex = Program.mCoso;
            mAGVTextBox.Text = Program.username;
            if (Program.mGroup == "Truong")
            {
                cbBox_Branch.Enabled = true;//chi nhom tai khoản trường mới được đổi giữa hai cơ sở 1 và 2
                barBtn_Add.Enabled = false;
                barBtn_Delete.Enabled = false;
                barBtn_Undo.Enabled = false;
                barBtn_Save.Enabled = false;
                barBtn_Forbid.Enabled = false;
                grpB_txtRegistTest.Enabled = false;
            }
            else if (Program.mGroup == "Coso" || Program.mGroup == "Giangvien")
            {
                cbBox_Branch.Enabled = false;
                barBtn_Forbid.Enabled =
                barBtn_Add.Enabled =
                barBtn_Delete.Enabled =
                barBtn_Undo.Enabled =
                barBtn_Save.Enabled =
                barBtn_Refresh.Enabled =
                barBtn_Exit.Enabled =
                grpB_txtRegistTest.Enabled = true;
            }

        }

        private void barBtn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIAOVIEN_DANGKYBindingSource.AddNew();

            vitri = gIAOVIEN_DANGKYBindingSource.Position;
            mAGVTextBox.Text = Program.username;
            mALOPComboBox.SelectedIndex =
            mAMHComboBox1.SelectedIndex = 0;
            tRINHDOComboBox.SelectedIndex = -1;

            grpB_txtRegistTest.Enabled = true;

            nGAYTHIDateEdit.DateTime = DateTime.Now;
            lANNumericUpDown.Value = 1;
            sOCAUTHISpinEdit.Value = sOCAUTHISpinEdit.Properties.MinValue;
            tHOIGIANSpinEdit.Value = tHOIGIANSpinEdit.Properties.MinValue;


            barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = false;
            barBtn_Save.Enabled = barBtn_Undo.Enabled = barBtn_Exit.Enabled = barBtn_Forbid.Enabled = true;
            mAGVTextBox.Enabled = false;
            gIAOVIEN_DANGKYGridControl.Enabled = false;

        }

        private void barBtn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mamh = mAMHComboBox1.SelectedValue.ToString();
            string malop = mALOPComboBox.SelectedValue.ToString();
            int lan = int.Parse(lANNumericUpDown.Value.ToString());
            string query = "exec  SP_CHECKXOAGVDK "+mamh+","+malop+","+lan;
            if (gIAOVIEN_DANGKYBindingSource.Count == 0)//bảng môn học trống thì ko cho xóa
            {
                barBtn_Delete.Enabled = false;
            }
            if (CheckDeleteRegisting(query))
            {
                MessageBox.Show("Không thể xóa dòng này vì đã có điểm sinh viên thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        mamh = ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["MAMH"].ToString();//giữ mã để xóa lỗi, quay về lại 
                        malop = ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["MALOP"].ToString();
                        lan = int.Parse(((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["LAN"].ToString());
                            gIAOVIEN_DANGKYBindingSource.RemoveCurrent();
                        this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa. Vui lòng thử lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                        this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                        return;
                    }
                    
                }
                fmRegistTest_Load(sender, e);
            }
        }

        private void barBtn_Undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //lấy những param cần thiết của SP_CHECKXOAGVDK
            string mamh = ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["MAMH"].ToString();
            string malop = ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["MALOP"].ToString();
            //int lan = int.Parse(((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["LAN"].ToString());
            int lan = 1;
            Console.Write("Test lần:" +lan);
            string query = "exec  SP_CHECKXOAGVDK " + mamh + "," + malop + "," + lan;
            
            //kiểm tra nhập rỗng
            if (mALOPComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                mALOPComboBox.Focus();
                return;
            }
            if (mAGVTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Mã giáo viên không được để trống!", "", MessageBoxButtons.OK);
                mAGVTextBox.Focus();
                return;
            }
            if (tRINHDOComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Trình độ không được để trống!", "", MessageBoxButtons.OK);
                tRINHDOComboBox.Focus();
                return;
            }
            if (lANNumericUpDown.Value.ToString()=="")
            {
                MessageBox.Show("Lần thi không được để trống!", "", MessageBoxButtons.OK);
                lANNumericUpDown.Focus();
                return;
            }
            if (sOCAUTHISpinEdit.Value.ToString() == "")
            {
                MessageBox.Show("Số câu thi không được để trống!", "", MessageBoxButtons.OK);
                sOCAUTHISpinEdit.Focus();
                return;
            }
            if (nGAYTHIDateEdit.DateTime.ToString() == "")
            {
                MessageBox.Show("Thời gian thi không được để trống!", "", MessageBoxButtons.OK);
                nGAYTHIDateEdit.Focus();
                return;
            }
            if(nGAYTHIDateEdit.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày thi không thể ở quá khứ!", "", MessageBoxButtons.OK);
                nGAYTHIDateEdit.Focus();
                return;
            }
            if (tHOIGIANSpinEdit.Value.ToString() == "")
            {
                MessageBox.Show("Thời gian không được để trống!", "", MessageBoxButtons.OK);
                tHOIGIANSpinEdit.Focus();
                return;
            }
            try
            {
                //nhấn ghi khi thêm mới hoặc sửa dòng đăng ký thi
                if (!CheckDeleteRegisting(query)) { //check xem đã có điểm thi của sv trong dòng đăng ký nào chưa, nếu ko thì có thể sửa
                    gIAOVIEN_DANGKYBindingSource.EndEdit();
                    gIAOVIEN_DANGKYBindingSource.ResetCurrentItem();
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                    gIAOVIEN_DANGKYGridControl.Enabled = grpB_txtRegistTest.Enabled = true;
                    barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = barBtn_Exit.Enabled =
                    barBtn_Save.Enabled = barBtn_Undo.Enabled = true;
                    reloadConnection();
                }
                else //đã có sv thi ko thể sửa dòng đăng ký này
                {
                    DialogResult dr = MessageBox.Show("Không thể sửa dòng này vì đã có điểm sinh viên! Vui lòng xem lại!", "", MessageBoxButtons.RetryCancel);

                    if (dr == DialogResult.Retry)
                    {
                        vitri = gIAOVIEN_DANGKYBindingSource.Position;

                        gIAOVIEN_DANGKYGridControl.Enabled = grpB_txtRegistTest.Enabled = false;
                        barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = false;
                        barBtn_Save.Enabled = barBtn_Undo.Enabled = barBtn_Exit.Enabled = barBtn_Forbid.Enabled = true;
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
            gIAOVIEN_DANGKYGridControl.Enabled = true;
            barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = barBtn_Exit.Enabled =
            barBtn_Save.Enabled = barBtn_Undo.Enabled = true;
            grpB_txtRegistTest.Enabled = true;
            reloadConnection();
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

        private void barBtn_Forbid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIAOVIEN_DANGKYBindingSource.CancelEdit();
            fmRegistTest_Load(sender, e);
            gIAOVIEN_DANGKYGridControl.Enabled =
            grpB_txtRegistTest.Enabled = true;
            if (vitri > 0)
            {
                gIAOVIEN_DANGKYBindingSource.Position = vitri;
            }
        }

        private void barBtn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gIAOVIEN_DANGKYGridControl.Enabled == false && Program.mGroup != "Truong")
            {
                DialogResult dr = MessageBox.Show("Dữ liệu chưa được lưu lại. Bạn có muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.OK)
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

        private void cbBox_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbBox_Branch.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }

                Program.servername = cbBox_Branch.SelectedValue.ToString();//server name sẽ được đổi qua sever name mới vừa chọn ở combo box
            }
            catch (Exception ex)
            {

            }

            //Nếu chi nhánh được chọn khác chi nhánh lúc đầu thì đăng nhập bằng tài khoản HTKN
            if (cbBox_Branch.SelectedIndex != Program.mCoso)
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
                reloadConnection();

            }
        }

        private void gridView_RegistTest_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int vitri = gIAOVIEN_DANGKYBindingSource.Position;
            string magv = "";
            try
            {
                magv = ((DataRowView)gIAOVIEN_DANGKYBindingSource[vitri])["MAGV"].ToString();
            }
            catch
            {

            }
            if (Program.username.CompareTo(magv.Trim()) == 0)
            {
                barBtn_Delete.Enabled =
                barBtn_Save.Enabled = true;
            }
            else
            {
                barBtn_Delete.Enabled =
                barBtn_Save.Enabled = false;
            }

        }

        private void mAGVTextBox_TextChanged(object sender, EventArgs e)
        {
            int vitri = gIAOVIEN_DANGKYBindingSource.Position;
            string magv = "";
            try
            {
                magv = ((DataRowView)gIAOVIEN_DANGKYBindingSource[vitri])["MAGV"].ToString();
            }
            catch
            {

            }
            if (Program.username.CompareTo(magv.Trim()) == 0)
            {
                barBtn_Delete.Enabled =
                barBtn_Save.Enabled = true;
            }
            else
            {
                barBtn_Delete.Enabled =
                barBtn_Save.Enabled = false;
            }

        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void tRINHDOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tRINHDOComboBox.SelectedIndex == -1)
            {
                label_TD.Text = "Chọn trình độ";
            }
            else
            {
                label_TD.Text = Program.trinhDo[tRINHDOComboBox.SelectedIndex];
            }
        }
    }
}
