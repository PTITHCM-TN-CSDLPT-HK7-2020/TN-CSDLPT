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
        string makh = ""; string malop = ""; string macs = "";
        
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
            // TODO: This line of code loads data into the 'dS.BANGDIEM' table. You can move, or remove it, as needed.
            //this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            // TODO: This line of code loads data into the 'dS.CHITIETBAITHISV' table. You can move, or remove it, as needed.
            //this.cHITIETBAITHISVTableAdapter.Fill(this.dS.CHITIETBAITHISV);

            malop = ((DataRowView)lOPBindingSource[0])["MALOP"].ToString();
            makh = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
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
                //gridView1.OptionsBehavior.ReadOnly = true;
               // gridView2.OptionsBehavior.ReadOnly = true;
                gr_Student.Enabled = false;
                MenuStr_Student.Enabled = false;
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
                    malop = ((DataRowView)lOPBindingSource[0])["MALOP"].ToString();

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

            lOPBindingSource.AddNew(); //thêm cuối

            mAKHTextEdit.Text = makh;

            bar_Add.Enabled = bar_Del.Enabled = bar_New.Enabled = false;
            bar_Save.Enabled = bar_Undo.Enabled = bar_exit.Enabled = true;

            lOPGridControl.Enabled = 
            sINHVIENGridControl.Enabled =
            gr_Student.Enabled = false;
        }

        private void bar_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lOPGridControl.Enabled == false && Program.mGroup != "Truong")
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

        private void bar_Del_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string malop = "";
            if(fKSINHVIENLOPBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["MALOP"].ToString(); //giữ mã để xóa lỗi, quay về lại 
                    lOPBindingSource.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Vui lòng thử lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    lOPBindingSource.Position = lOPBindingSource.Find("MALOP", malop);
                    return;
                }
                if (lOPBindingSource.Count == 0)
                {
                    bar_Del.Enabled = false;
                }
                fmClass_Load(sender, e);
            }
        }

        private void bar_Undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bar_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mALOPTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                mALOPTextBox.Focus();
                return;
            }
            if (tENLOPTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được để trống!", "", MessageBoxButtons.OK);
                tENLOPTextEdit.Focus();
                return;
            }
            try
            {
                string malop = "", tenlop = "";
                string query = "";
                tenlop = tENLOPTextEdit.Text.ToString();
                malop = mALOPTextBox.Text.ToString();
                query = "exec SP_CHECKTRUNGKHOA '" + malop + "'"; /////// ty check lai /////////
                if (!CheckDuplicateLOP(query))
                {
                    lOPBindingSource.EndEdit();
                    lOPBindingSource.ResetCurrentItem();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    lOPGridControl.Enabled = sINHVIENGridControl.Enabled = gr_Student.Enabled = true;
                    bar_Add.Enabled = bar_Del.Enabled = bar_New.Enabled = bar_exit.Enabled =
                    bar_Save.Enabled = bar_Undo.Enabled = true;
                    reloadConnection();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Lỗi trùng mã lớp! Vui lòng xem lại!", "", MessageBoxButtons.RetryCancel);

                    if (dr == DialogResult.Retry)
                    {
                        vitriLOP = lOPBindingSource.Position;
                        //kHOABindingSource.AddNew();

                        mALOPTextBox.Text = malop;
                        tENLOPTextEdit.Text = tenlop;
                        mAKHTextEdit.Text = makh;
                        lOPGridControl.Enabled = sINHVIENGridControl.Enabled = gr_Student.Enabled = false;
                        bar_Add.Enabled = bar_Del.Enabled = bar_New.Enabled = false;
                        bar_Save.Enabled = bar_Undo.Enabled = bar_exit.Enabled =bar_forbit.Enabled = true;
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

        private void bar_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void bar_forbit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           lOPBindingSource.CancelEdit();
            fmClass_Load(sender, e);
            lOPGridControl.Enabled =
            sINHVIENGridControl.Enabled =
            gr_Student.Enabled = true;
            if (vitriLOP > 0)
            {
                lOPBindingSource.Position = vitriLOP;
            }
        }

        /////EVENT CAC NUT ///////
        private void tHEMSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string masv = "";
            if (lOPBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã có lớp", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position])["MASV"].ToString(); //giữ mã để xóa lỗi, quay về lại 
                    sINHVIENBindingSource.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Vui lòng thử lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    sINHVIENBindingSource.Position = sINHVIENBindingSource.Find("MASV", masv);
                    return;
                }
                if (sINHVIENBindingSource.Count == 0)//bảng môn học trống thì ko cho xóa
                {
                    xóaToolStripMenuItem.Enabled = false;
                }
                fmClass_Load(sender, e);
            }
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mALOPTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "", MessageBoxButtons.OK);
                mALOPTextBox.Focus();
                return;
            }
            try
            {
               sINHVIENBindingSource.EndEdit();
               sINHVIENBindingSource.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi dữ liệu. \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled =
            gr_Class.Enabled = gr_Student.Enabled = true;

            thêmLớpToolStripMenuItem.Enabled = xóaToolStripMenuItem.Enabled = làmMớiToolStripMenuItem.Enabled =
            ghiToolStripMenuItem.Enabled = phụcHồiToolStripMenuItem.Enabled = true;
            reloadConnection();

        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sINHVIENBindingSource.CancelEdit();
            fmClass_Load(sender, e);
            lOPGridControl.Enabled =
            sINHVIENGridControl.Enabled =
            gr_Student.Enabled =
            thêmLớpToolStripMenuItem.Enabled = xóaToolStripMenuItem.Enabled = làmMớiToolStripMenuItem.Enabled =
            ghiToolStripMenuItem.Enabled = phụcHồiToolStripMenuItem.Enabled = true;
            if (vitriLOP> 0)
            {
                lOPBindingSource.Position = vitriLOP;
            }
        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitriSV = lOPBindingSource.Position;
            if (fKSINHVIENLOPBindingSource.Count == 0)
            {
                malop = mALOPTextBox.Text.ToString();
            }
            else
            {
                malop = ((DataRowView)lOPBindingSource[0])["MALOP"].ToString();
            }
            fKSINHVIENLOPBindingSource.AddNew();//thêm cuối

            mALOPTextBox.Text = malop;

            thêmToolStripMenuItem.Enabled =
            xóaStripMenuItem.Enabled =
            mớiStripMenuItem.Enabled = false;
            p_hồiStripMenuItem.Enabled = true;
            lOPGridControl.Enabled =
             gr_Class.Enabled =
            sINHVIENGridControl.Enabled = false;
        }

        private void hủyStripMenuItem_Click(object sender, EventArgs e)
        {
            fKSINHVIENLOPBindingSource.CancelEdit();
            fmClass_Load(sender, e);
            lOPGridControl.Enabled =
            sINHVIENGridControl.Enabled =
            groupBox2.Enabled =
            thêmToolStripMenuItem.Enabled = xóaStripMenuItem.Enabled = mớiStripMenuItem.Enabled =
            ghiStripMenuItem.Enabled = p_hồiStripMenuItem.Enabled = true;
            if (vitriSV > 0)
            {
                lOPBindingSource.Position = vitriSV;
            }
        }


        private void mớiStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void ghiStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mASVTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã giáo viên không được để trống!", "", MessageBoxButtons.OK);
                mASVTextEdit.Focus();
                return;
            }
            try
            {
                fKSINHVIENLOPBindingSource.EndEdit();
                fKSINHVIENLOPBindingSource.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi dữ liệu. \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled =
            groupBox1.Enabled = groupBox2.Enabled = true;

            thêmToolStripMenuItem.Enabled = xóaStripMenuItem.Enabled = mớiStripMenuItem.Enabled =
            ghiStripMenuItem.Enabled = p_hồiStripMenuItem.Enabled = true;
            reloadConnection();
        }

        private void xóaStripMenuItem_Click(object sender, EventArgs e)
        {
            string masv = "";
            if (fK_BANGDIEM_SINHVIEN_BindingSource.Count > 0 || fK_CHITIETBAITHISV_SINHVIEN_BindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên viên này vì đã có điểm thi hoặc bài thi!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)fKSINHVIENLOPBindingSource[fKSINHVIENLOPBindingSource.Position])["MASV"].ToString();//giữ mã để xóa lỗi, quay về lại 
                    fKSINHVIENLOPBindingSource.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên. Vui lòng thử lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    fKSINHVIENLOPBindingSource.Position = fKSINHVIENLOPBindingSource.Find("MASV", masv);
                    return;
                }
                if (fKSINHVIENLOPBindingSource.Count == 0)//bảng môn học trống thì ko cho xóa
                {
                    xóaStripMenuItem.Enabled = false;
                }
                fmClass_Load(sender, e);
            }
        }
    }

}
