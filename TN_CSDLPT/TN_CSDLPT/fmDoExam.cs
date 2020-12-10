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
    public partial class fmDoExam : Form
    {
        public fmDoExam()
        {
            InitializeComponent();
        }

        private int dem = 0;
        public static Boolean checkThi = false;
        private Boolean isSinhVien = false;
        private int thoigianThi = 0;
        private int soCauThi = 0;
        public static QuestionItem[] listCauHoi;
        public static ListViewItem baiThi;
        private float diem = -1;
        private DateTime ngayThi;

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        //==========================================Function============================================//
        private void loadThongTinSInhVien()
        {
            txtB_FullName.Text = Program.mHoten;
            if (!Program.mSV.Equals(""))
            {
                String ktsocau = "SELECT l.MALOP, sv.MASV FROM dbo.LOP as l JOIN dbo.SINHVIEN as sv" +
                                  "ON sv.MALOP = l.MALOP WHERE MASV = '"+Program.mSV+"'";
                Program.myReader = Program.ExecSqlDataReader(ktsocau);
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
                    Program.myReader.Close();
                    Program.conn.Close();
                }
            }
        }

        //===========================================Event===============================================//
        private void fmDoExam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

        }
    }
}
