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
    public partial class fmScoreTable : Form
    {
        public fmScoreTable()
        {
            InitializeComponent();
        }

        string MALOP = "", MAMH = "", LAN = "";


        private void ScoreTable_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;         
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            MAMH = mAMHComboBox.SelectedValue.ToString();
            MALOP = mALOPComboBox.SelectedValue.ToString();
            LAN = lANSpinEdit.Value.ToString();
            string query = "select bd.MASV as 'Mã sinh viên', HO as 'Họ', TEN as'Tên', DIEM as 'Điểm', dbo.fnAmountToWords(DIEM) as N'Điểm chữ' from LOP as l, SINHVIEN as sv, BANGDIEM as bd " +
                "where bd.MAMH = '" + MAMH.Trim() + "' and " +
                "l.MALOP = '" + MALOP.Trim() + "' and " +
                "LAN = " + LAN.Trim() +" and " +
                "l.MALOP = sv.MALOP and " +
                "bd.MASV = sv.MASV ";
            Console.WriteLine(query);
            try
            {
                dataGridView_Score.DataSource = Program.ExecSqlDataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
