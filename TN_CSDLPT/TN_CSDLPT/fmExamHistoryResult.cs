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
    public partial class fmExamHistoryResult : Form
    {
        public fmExamHistoryResult()
        {
            InitializeComponent();
        }
        //define varible
        string MAMH = "";
        string MALOP = "";
        string LAN = "";

        //=======================Function==================================//
        private void loadThongTinSInhVien()
        {

            txtB_FullName.Text = Program.mHoten;
            if (!Program.mSV.Equals(""))
            {
                String layttsv = "SELECT l.MALOP, sv.MASV, l.TENLOP FROM dbo.LOP as l JOIN dbo.SINHVIEN as sv " +
                                  "ON sv.MALOP = l.MALOP WHERE MASV = '" + Program.mSV + "'";
                Program.myReader = Program.ExecSqlDataReader(layttsv);
                if (Program.myReader == null)
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                    return;
                }
                else
                {
                    Program.myReader.Read();
                    txtB_IDClass.Text = Program.myReader.GetString(0).Trim();
                    txtB_IDStudent.Text = Program.myReader.GetString(1).Trim();
                    txtB_NameClass.Text = Program.myReader.GetString(2).Trim();
                    Program.myReader.Close();
                    Program.conn.Close();
                }
            }
        }

        //===========================Event======================================//
        private void fmExamHistoryResult_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            tRINHDOComboBox.SelectedIndex = 0;
            loadThongTinSInhVien();

        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string mamh = mAMHComboBox1.SelectedValue.ToString().Trim();
            int lan = int.Parse(lANSpinEdit.Value.ToString().Trim());
            string ngay = nGAYTHIDateTimePicker.Value.ToString("yyyy-MM-dd");

            string malop = txtB_IDClass.Text.Trim();
            string masv = txtB_IDStudent.Text.Trim();

            string query = "select MAGV, MAMH, MALOP, NGAYTHI, LAN, SOCAUTHI, THOIGIAN from GIAOVIEN_DANGKY where MAMH = '" + mamh +"' and MALOP = '"+malop+ "' and cast(NGAYTHI as date) = '" + ngay + "' and LAN = '" + lan + "'";
            dataGridView_Result.DataSource = Program.ExecSqlDataTable(query);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            fmExamHistoryResult_Load(sender, e);
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            string query = "select CAU_HOI_BAI_THI as 'Số thứ tự' ,CAU_HOI_BO_DE as N'Câu số trong bộ đề',NOIDUNG as N'Nội dung', 'A.'+A+'		B.'+B+'		C.'+C+'		D.'+D as N'Câu chọn lựa',DAP_AN as N'Đáp Án',DAP_AN_CHON as N'Đáp án chọn' from BODE as bd ,(select CAU_HOI_BAI_THI,CAU_HOI_BO_DE, DAP_AN_CHON from CHITIETBAITHISV " +
                "where MASV = '"+Program.mSV+"' and MAMH = '"+MAMH.Trim()+"' and LAN_THI = "+LAN+") as ctbt " +
                "where bd.CAUHOI = ctbt.CAU_HOI_BO_DE order by CAU_HOI_BAI_THI";
            try
            {
                dataGridView_DetailExam.DataSource = Program.ExecSqlDataTable(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView_Result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Result.Rows[e.RowIndex];
                MALOP = row.Cells[2].Value.ToString().Trim();
                MAMH = row.Cells[1].Value.ToString().Trim();
                LAN = row.Cells[4].Value.ToString().Trim();
                //soCauThi = int.Parse(row.Cells[6].Value.ToString());
                //thoigianThi = int.Parse(row.Cells[7].Value.ToString());
                //trinhdo = row.Cells[3].Value.ToString().Trim();
                //ngayThi = Convert.ToDateTime(row.Cells[4].Value.ToString());
                MessageBox.Show(MALOP + " " + MAMH + " " + LAN);
            }
        }
    }
}
