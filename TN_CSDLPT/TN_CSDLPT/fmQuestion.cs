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
    public partial class fmQuestion : Form
    {
        int vitri = 0;
        
        public fmQuestion()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void fmQuestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString= Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);

            string magv = "";
            if (Program.mGroup == "Truong")
            {
                barBtn_Add.Enabled = false;
                barBtn_Delete.Enabled = false;
                barBtn_Undo.Enabled = false;
                barBtn_Save.Enabled = false;
                barBtn_Forbid.Enabled = false;
                grpB_txtQuestion.Enabled = false;
                bODEGridControl.Enabled = false;
            }
            else if (Program.mGroup == "Coso")
            {
                barBtn_Add.Enabled =
                barBtn_Delete.Enabled =
                barBtn_Undo.Enabled =
                barBtn_Save.Enabled =
                barBtn_Refresh.Enabled =
                barBtn_Forbid.Enabled =
                barBtn_Exit.Enabled =
                bODEGridControl.Enabled=
                grpB_txtQuestion.Enabled = true;
            }
            else if (Program.mGroup == "Giangvien")
            {
                barBtn_Add.Enabled =
                barBtn_Delete.Enabled =
                barBtn_Undo.Enabled =
                barBtn_Save.Enabled =
                barBtn_Refresh.Enabled =
                barBtn_Forbid.Enabled =
                barBtn_Exit.Enabled =
                bODEGridControl.Enabled =
                grpB_txtQuestion.Enabled = true;
                mAGVTextBox.Enabled = false;
                //vitri = bODEBindingSource.Position;
                //magv = ((DataRowView)bODEBindingSource[vitri])["MAGV"].ToString();
                //if (magv == Program.username)
                //{
                //    barBtn_Delete.Enabled =
                //    barBtn_Save.Enabled= true;

                //}
                //else{
                //    barBtn_Delete.Enabled =
                //    barBtn_Save.Enabled = false;
                //}
            }
        }
        //=======================================Event button====================================//
        private void barBtn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bODEBindingSource.Position;

            
            bODEBindingSource.AddNew();

            mAGVTextBox.Text = Program.username;
            tRINHDOComboBox.SelectedIndex = 0;

            barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = false;
            barBtn_Save.Enabled = barBtn_Undo.Enabled = barBtn_Exit.Enabled =barBtn_Forbid.Enabled = true;

            bODEGridControl.Enabled = false;
        }

        private void barBtn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int stt = -1;
            string magv="";

                if (MessageBox.Show("Bạn có chắc muốn xóa câu hỏi này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {

                        stt = int.Parse(((DataRowView)bODEBindingSource[bODEBindingSource.Position])["CAUHOI"].ToString());

                        bODEBindingSource.RemoveCurrent();
                        this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                        this.bODETableAdapter.Update(this.dS.BODE);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa môn học. Vui lòng thử lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                        this.bODETableAdapter.Fill(this.dS.BODE);
                        bODEBindingSource.Position = bODEBindingSource.Find("CAUHOI", stt);
                        return;
                    }
                    if (bODEBindingSource.Count == 0)//bảng môn học trống thì ko cho xóa
                    {
                        barBtn_Delete.Enabled = false;
                    }
                    fmQuestion_Load(sender, e);
                }


        }

        private void barBtn_Undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            
        }

        private void barBtn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tRINHDOComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("trình độ đang để trống!", "", MessageBoxButtons.OK);
                tRINHDOComboBox.Focus();
                return;
            }
            try
            {
                bODEBindingSource.EndEdit();
                bODEBindingSource.ResetCurrentItem();
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Update(this.dS.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi dữ liệu. \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            bODEGridControl.Enabled = true;
            barBtn_Add.Enabled = barBtn_Delete.Enabled = barBtn_Refresh.Enabled = barBtn_Exit.Enabled = true;
            barBtn_Save.Enabled = barBtn_Undo.Enabled = barBtn_Forbid.Enabled = true;
        }

        private void barBtn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bODETableAdapter.Fill(this.dS.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void barBtn_Forbid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bODEBindingSource.CancelEdit();
            fmQuestion_Load(sender, e);
            bODEGridControl.Enabled =
            grpB_txtQuestion.Enabled = true;
            if (vitri > 0)
            {
                bODEBindingSource.Position = vitri;
            }
        }

        private void barBtn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grpB_txtQuestion.Enabled == true)
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

        private void gridView_Question_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int vitri = bODEBindingSource.Position;
            string magv = "";
            try
            {
                magv = ((DataRowView)bODEBindingSource[vitri])["MAGV"].ToString();
            }
            catch
            {

            }
            if (Program.username.CompareTo(magv.Trim())==0)
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
            int vitri = bODEBindingSource.Position;
            string magv = "";
            
            try
            {
                magv = ((DataRowView)bODEBindingSource[vitri])["MAGV"].ToString();
             
            }
            catch
            {
                
            }

            if (Program.username.CompareTo(magv.Trim()) == 0)
            {
                barBtn_Delete.Enabled = barBtn_Save.Enabled = true;
            }
            else
            {
                barBtn_Delete.Enabled =
                barBtn_Save.Enabled = false;
            }
        }
    }
}
