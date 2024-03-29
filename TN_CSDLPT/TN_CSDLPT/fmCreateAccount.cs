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
    public partial class fmCreateAccount : Form
    {
        public static Boolean checkSave = true;
        private Boolean checkThem = false;
        private int dem = 0;
        string loginCu = "";
        string passwordCu = "";

        public fmCreateAccount()
        {
            InitializeComponent();
        }

        private void DNTK_SA_TAOTK(string login, string password)
        {
            Program.mlogin = login;
            Program.password = password;

            if (Program.KetNoi() == 0)
            {
                return;
            }
            MessageBox.Show(Program.connstr);
        }

        private void fmCreateAccount_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Program.connstr1 = Program.connstr;
            MessageBox.Show(Program.connstr1);
            //lấy login cũ để quay lại sau khi tạo tài khoản
            loginCu = Program.mlogin;
            passwordCu = Program.password;

            ds1.EnforceConstraints = false;

            try
            {
                cbbCoSo.DataSource = Program.bds_dspm;
                cbbCoSo.DisplayMember = "TENCOSO";
                cbbCoSo.ValueMember = "TENSERVER";

                cbbCoSo.SelectedIndex = Program.mCoso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load cơ sở " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            // TODO: This line of code loads data into the 'ds1.SP_MA_GV_CHUA_TAO_TK' table. You can move, or remove it, as needed.
            this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Fill(this.ds1.SP_MA_GV_CHUA_TAO_TK);

            // phân quyền
            if (Program.mGroup == "Coso")
            {
                cbbCoSo.Enabled = false;
                cbbLoaiTK.Items.Add("Coso");
                cbbLoaiTK.Items.Add("Giangvien");
            }
            else if (Program.mGroup == "Truong")
            {
                cbbCoSo.Enabled = true;
                cbbLoaiTK.Items.Add("Truong");
            }

            cbbLoaiTK.SelectedIndex = 0;
            dem++;

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            //Check trường rỗng
            if (edtTenDN.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "", MessageBoxButtons.OK);
                edtTenDN.Focus();
                return;
            }
            if (edtPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "", MessageBoxButtons.OK);
                edtPass.Focus();
                return;
            }
            SqlCommand sqlcmd;
            //neu dăng nhập với quyền co so
            if (Program.mGroup.Equals("Coso"))
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                sqlcmd = Program.conn.CreateCommand();
            }
            else//trường
            {
                if (cbbCoSo.SelectedIndex != Program.mCoso)
                {
                    Program.servername1 = cbbCoSo.SelectedValue.ToString();

                    if (Program.KetNoiCosoKhac() == 0) return;
                    else
                    {
                        this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Fill(this.ds1.SP_MA_GV_CHUA_TAO_TK);
                        sqlcmd = Program.conn1.CreateCommand();
                    }
                }
                else
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    sqlcmd = Program.conn.CreateCommand();
                }
            }



            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_TaoTaiKhoan";
            sqlcmd.Parameters.Add(new SqlParameter("@LGNAME", edtTenDN.Text.Trim()));
            sqlcmd.Parameters.Add(new SqlParameter("@PASS", edtPass.Text.Trim()));
            sqlcmd.Parameters.Add(new SqlParameter("@USERNAME", cbbMaGV.SelectedValue.ToString().Trim()));
            sqlcmd.Parameters.Add(new SqlParameter("@ROLE", cbbLoaiTK.SelectedItem.ToString().Trim()));
            SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlcmd.Parameters.Add(sqlParameter);


            int result = -1;
            try
            {
                DNTK_SA_TAOTK("sa","123");
                sqlcmd.ExecuteNonQuery();
                result = (int)sqlcmd.Parameters["@return"].Value;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Lỗi tạo tài khoản " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (result != -1)
            {
                if (result == 1)
                {
                    Program.conn.Close();
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    edtTenDN.Focus();
                    DNTK_SA_TAOTK(loginCu,passwordCu);
                    return;
                }
                if (result == 2)
                {
                    Program.conn.Close();
                    MessageBox.Show("Mã giảng viên đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    cbbMaGV.Focus();
                    DNTK_SA_TAOTK(loginCu, passwordCu);
                    return;
                }
                //tao tk thành công
                if (result == 0)
                {
                    Program.conn.Close();
                    MessageBox.Show("Tạo tài khoản thành công", "Thành công", MessageBoxButtons.OK);
                    edtPass.Text = "";
                    edtTenDN.Text = "";
                    this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Fill(this.ds1.SP_MA_GV_CHUA_TAO_TK);
                    DNTK_SA_TAOTK(loginCu, passwordCu);
                    return;
                }
                else
                {
                    Program.conn.Close();
                    MessageBox.Show("Tạo tài khoản thất bại", "Lỗi", MessageBoxButtons.OK);
                    DNTK_SA_TAOTK(loginCu, passwordCu);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại", "Lỗi", MessageBoxButtons.OK);
                DNTK_SA_TAOTK(loginCu, passwordCu);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo tài khoản, bạn có muốn lưu thông tin này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnDangKy_Click(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            else
            {
                checkSave = true;
                this.Close();
            }
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbCoSo.SelectedValue != null && Program.mGroup.Equals("Truong") && dem > 0)
                {
                    if (cbbCoSo.SelectedIndex != Program.mCoso)
                    {
                        Program.servername1 = cbbCoSo.SelectedValue.ToString();
                        if (Program.KetNoiCosoKhac() == 0) return;
                        else
                        {
                            this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Connection.ConnectionString = Program.connstr1;
                            this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Fill(this.ds1.SP_MA_GV_CHUA_TAO_TK);
                        }
                    }
                    else
                    {
                        this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_MA_GV_CHUA_TAO_TKTableAdapter.Fill(this.ds1.SP_MA_GV_CHUA_TAO_TK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn cơ sở " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            };
        }
    }
}
