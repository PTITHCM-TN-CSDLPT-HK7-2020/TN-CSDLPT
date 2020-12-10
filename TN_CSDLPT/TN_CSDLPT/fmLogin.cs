﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DS_PHANMANH);

            lb_IDStudent.Visible = false;

            cbBox_Branch.SelectedIndex = 1;// khi load form tự chọn giá trị cho cb cơ sở, tránh hiện chữ mà ko có giá trị được chọn thực sự 
            cbBox_Branch.SelectedIndex = 0;

        }

        private void grpBox_User_SinhVien_Change()
        {
            lb_IDStudent.Visible = true;
            txtBox_Password.ReadOnly = true;
            txtBox_Password.Text = "";

        }
        private void grpBox_User_GiangVien_Change()
        {
            lb_IDStudent.Visible = false;
            txtBox_Password.ReadOnly = false;

        }

        private void radBtn_Teacher_CheckedChanged(object sender, EventArgs e)
        {
            grpBox_User_GiangVien_Change();
        }

        private void radBtn_Student_CheckedChanged(object sender, EventArgs e)
        {
            grpBox_User_SinhVien_Change();
        }

        private void cbBox_Branch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbBox_Branch.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            if (txtBox_LgName.Text.Trim() == "")
            {
                MessageBox.Show("Login name không được để trống", "Báo lỗi", MessageBoxButtons.OK);
                txtBox_LgName.Focus();
                return;
            }
            if (txtBox_Password.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Báo lỗi", MessageBoxButtons.OK);
                txtBox_Password.Focus();
                return;
            }
            Program.mlogin = txtBox_LgName.Text.ToString();
            Program.password = txtBox_Password.Text.ToString();
            
            if (Program.KetNoi() == 0)
            {
                //textBox1.Text = Program.connstr;
                return;
            }
            //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
            Program.mCoso = cbBox_Branch.SelectedIndex;
            Program.bds_dspm = vDSPHANMANHBindingSource;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            
            String strLenh = "exec SP_THONGTINDANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);

            if (Program.myReader == null) return;
            Program.myReader.Read();//doc tung dong cua reader,hàm Read() trả về true||false,

  
            Program.username = Program.myReader.GetString(0);//lay dong dau tien cua reader
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu","Thông báo", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            
            Program.myReader.Close();
            Program.conn.Close();
            Program.fmChinh.HienThiTTUser();
            Program.fmChinh.ribPg_Tabbar.Visible = true;
            if (Program.mGroup == "Giangvien")
            {
                Program.fmChinh.barBtn_Class.Enabled=
                Program.fmChinh.barBtn_Farculty.Enabled = false;

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
