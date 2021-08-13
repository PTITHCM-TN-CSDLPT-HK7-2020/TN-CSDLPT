using System;
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
    public partial class fmDoExam : Form
    {
        public fmDoExam()
        {
            InitializeComponent();
        }

        private int dem = 0;
        public static Boolean checkThi = false;
        private Boolean checkThiTiep = false;// Biến lưu nếu sv này thi tiếp
        private Boolean isSinhVien = false;
        private int thoigianThi = 0;
        private int soCauThi = 0;
        private string trinhdo = "";
        public static QuestionItem[] listCauHoi;
        public static ListViewItem baiThi;
        private float diem = -1;
        private DateTime ngayThi;
        private string ngayHienTai=DateTime.Now.ToString("yyyy-MM-dd");
        private int s = 1;//second of timer

        private object SENDER;
        private EventArgs Event;


        string MAMH = "";
        string MALOP = "";
        string LAN = "";

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        //==========================================Function============================================//
        private DataTable SetUpCurrentData(DataRowView[] dataRow)
        {
            DataTable table = new DataTable();

            DataColumn[] dcs = new DataColumn[] { new DataColumn("Mã GV"), new DataColumn("Mã môn học")
                                                ,new DataColumn("Mã lớp"), new DataColumn("Trình độ")
                                                ,new DataColumn("Ngày thi"), new DataColumn("Lần thi")
                                                ,new DataColumn("Số câu"), new DataColumn("Thời gian")};

            table.Columns.AddRange(dcs);

            foreach (DataRowView item in dataRow)
            {
                DataRow dr = table.NewRow();
                dr.ItemArray = item.Row.ItemArray;
                table.Rows.Add(dr);
            }

            return table;
        }

        public void capNhapDaChon(int cauSo, String daChon)
        {
            //String[] arr = new string[2];
            //arr[0] = (cauSo).ToString();
            //arr[1] = daChon;
            //ListViewItem baiThi = new ListViewItem(arr);
            //listV_ChosenAnswer.Items[cauSo - 1] = baiThi;
        }

        private void loadThongTinSInhVien()
        {
            
            txtB_FullName.Text = Program.mHoten;
            if (!Program.mSV.Equals(""))
            {
                String layttsv = "SELECT l.MALOP, sv.MASV, l.TENLOP FROM dbo.LOP as l JOIN dbo.SINHVIEN as sv " +
                                  "ON sv.MALOP = l.MALOP WHERE MASV = '"+Program.mSV+"'";
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
        private void HienCHGiaoDien()
        {
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                listCauHoi[i] = new QuestionItem();
                listCauHoi[i].Width = flowLayoutPanel_Question.Width;

                listCauHoi[i].CauBaiThi = i + 1;
                listCauHoi[i].CauBoDe = (int)((DataRowView)bAITHIBindingSource[i])["CauHoi"];
                listCauHoi[i].NDCauHoi = ((DataRowView)bAITHIBindingSource[i])["NOIDUNG"].ToString();
                listCauHoi[i].CauA = ((DataRowView)bAITHIBindingSource[i])["A"].ToString();
                listCauHoi[i].CauB = ((DataRowView)bAITHIBindingSource[i])["B"].ToString();
                listCauHoi[i].CauC = ((DataRowView)bAITHIBindingSource[i])["C"].ToString();
                listCauHoi[i].CauD = ((DataRowView)bAITHIBindingSource[i])["D"].ToString();
                listCauHoi[i].CauDapAn = ((DataRowView)bAITHIBindingSource[i])["DAP_AN"].ToString();
                if (checkThiTiep == true)
                {                  
                    listCauHoi[i].CauDaChon = ((DataRowView)bAITHIBindingSource[i])["DAP_AN_CHON"].ToString();
                    if (listCauHoi[i].CauDaChon == "A")
                    {
                        //listCauHoi[i].rBtn_AnswerA_CheckedChanged(SENDER,Event);

                        listCauHoi[i].rBtn_AnswerA.Checked = true;
                    }
                    else if (listCauHoi[i].CauDaChon == "B")
                    {
                        //listCauHoi[i].rBtn_AnswerB_CheckedChanged(SENDER, Event);
                        listCauHoi[i].rBtn_AnswerB.Checked = true;
                    }
                    else if (listCauHoi[i].CauDaChon == "C")
                    {
                        //listCauHoi[i].rBtn_AnswerC_CheckedChanged(SENDER, Event);
                        listCauHoi[i].rBtn_AnswerC.Checked = true;
                    }
                    else if (listCauHoi[i].CauDaChon == "D")
                    {
                        //listCauHoi[i].rBtn_AnswerD_CheckedChanged(SENDER, Event);
                        listCauHoi[i].rBtn_AnswerD.Checked = true;
                    }
                }
                else
                {
                    listCauHoi[i].CauDaChon = "";
                }
                String[] arr = new string[2];
                arr[0] = (i + 1).ToString();
                arr[1] = listCauHoi[i].CauDaChon;

                baiThi = new ListViewItem(arr);
                Console.WriteLine("cau: " + (i + 1) + ":" + listCauHoi[i].CauDapAn);
                //this.listV_ChosenAnswer.Items.Add(baiThi);


                if (flowLayoutPanel_Question.Controls.Count < 0)
                {
                    flowLayoutPanel_Question.Controls.Clear();
                }
                else
                    flowLayoutPanel_Question.Controls.Add(listCauHoi[i]);
            }
        }

        public void loadCauHoi()
        {
            String query = "";
            if (Program.mGroup=="Sinhvien")
            {
                if (checkThiTiep == true)
                {
                    query = "exec SP_LAYBAITHISV_THITIEP '"+Program.mSV+"','"+MAMH.Trim()+"',"+LAN;
                }
                else if(checkThi == false){
                    query = "exec SP_THITHU '"
                        + MALOP.Trim() + "','"
                        + MAMH.Trim() + "',"
                        + LAN;
                }
            }
            else
            {
                query = "exec SP_ThiThu '"
                     + MALOP.Trim() + "','"
                    + MAMH + "', "
                    + LAN;
            }
            DataTable dt = Program.ExecSqlDataTable(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không thể lấy được đề thi, thiếu đề", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            // bắt đầu thi khi đã có dữ liệu
            lb_Time.Visible = lb_TImer.Visible = true;
            btn_StartTesting.Visible = false;
            btn_Submit.Visible = true;
            timer1.Start();
            bAITHIBindingSource.DataSource = dt;
            grpB_txtExam.Enabled = grpB_txtStudent.Enabled = false;
            listCauHoi = new QuestionItem[soCauThi];
            //checkThi = true;

            HienCHGiaoDien();

        }

        public void ghiDapAn()
        {
            string sqlUpdate = "";
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                sqlUpdate += " UPDATE dbo.BAITHI SET DaChon = '"
                   + listCauHoi[i].CauDaChon
                   + "' WHERE CauHoi = " + listCauHoi[i].IDBaiThi + "  ";
                Console.WriteLine("id cau hoi ghi:  " + listCauHoi[i].IDBaiThi + " da chon:" + listCauHoi[i].CauDaChon);
            }

            Console.WriteLine("câu lệnh: " + sqlUpdate);

            try
            {
                int kq = Program.ExecSqlNonQuery(sqlUpdate);
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đáp án thi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        public void tinhdiem()
        {
            int caudung = 0;
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                if (listCauHoi[i].CauDaChon.Trim().CompareTo(listCauHoi[i].CauDapAn.Trim()) == 0)
                    caudung++;

            }

            if (caudung == 0) diem = 0;

            else diem = (float)Math.Round((double)(10 * caudung) / soCauThi, 2);
            MessageBox.Show("Số câu đúng: " + caudung + "/" + soCauThi + "\nĐiểm: " + diem, "Kết Quả", MessageBoxButtons.OK);
            btn_Submit.Visible = false;
            btn_Submit.Visible = true;
        }

        public void luuBaithi()
        {
            string query = "";

            for (int i = 0; i < listCauHoi.Length; i++)
            {
                query +=" exec SP_LUUBAITHI '" + Program.mSV + "','" + MAMH.Trim() + "'," + LAN + ","
                    + listCauHoi[i].CauBaiThi + "," + listCauHoi[i].CauBoDe + ",'" + listCauHoi[i].CauDaChon + "','"+txtB_IDClass.Text.Trim()+"',"+
                    +thoigianThi;
            }

            Console.WriteLine("câu lệnh: " + query);

            try
            {
                int kq = Program.ExecSqlNonQuery(query);
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đáp án thi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }

        public void themDiemsv()
        {
            String sql = "";
            if (checkThiTiep == true)
            {
                sql = "UPDATE dbo.BANGDIEM SET DIEM = " + diem +
                    "WHERE MASV = '" + Program.mSV
                    + "' AND MAMH = '" + MAMH.Trim()
                    + "' AND LAN = " + LAN
                    ;
            }
            else
            {
                sql = "insert into BANGDIEM (MASV,MAMH,LAN,NGAYTHI,DIEM)" +
                "values('" + Program.mSV + "', '" + MAMH + "'," + LAN + ",'"+ngayHienTai+"',"+ diem + ")";
            }
            try
            {
                int kq = Program.ExecSqlNonQuery(sql);
                Program.conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi điểm thi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        
        //===========================================Event Button===============================================//
        private void fmDoExam_Load(object sender, EventArgs e)
            {
            
            this.dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.BAITHI' table. You can move, or remove it, as needed.
            this.bAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHITableAdapter.Fill(this.dS.BAITHI);
            if (grpB_txtExam.Enabled == true)
            {
                pnl_S.Enabled = false;
            }

            tRINHDOComboBox.SelectedIndex = 0;

            string queryLoadBangGVDK = "select MAGV, MAMH, MALOP, TRINHDO, NGAYTHI, LAN, SOCAUTHI, THOIGIAN from GIAOVIEN_DANGKY where MAGV = '" + Program.username.Trim() + "'";
            
            if (Program.mGroup == "Sinhvien")
            {
                loadThongTinSInhVien();
                tRINHDOComboBox.Enabled =
                sOCAUTHISpinEdit.Enabled =
                tHOIGIANSpinEdit.Enabled = false;
                btn_Search.Enabled = true;
                lb_Time.Visible = lb_TImer.Visible = false;
                btn_Submit.Enabled =
                    btn_Submit.Visible= false;
                btn_Refresh.Visible = btn_Refresh.Enabled = false;
            }
            else
            {
                grpB_txtStudent.Visible = false;
                tRINHDOComboBox.Enabled =
                sOCAUTHISpinEdit.Enabled =
                tHOIGIANSpinEdit.Enabled = true;
                btn_Search.Enabled = true;
                lb_Time.Visible = lb_TImer.Visible = false;
                btn_Submit.Enabled = btn_Submit.Visible = false;

                pnl_S.Enabled=
                btn_StartTesting.Enabled = true;

                btn_Refresh.Visible = btn_Refresh.Enabled = true;

                dataGridView_Result.DataSource = Program.ExecSqlDataTable(queryLoadBangGVDK);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Console.Write("Ngày hiện tại: " + ngayHienTai);
            string mamh = mAMHComboBox1.SelectedValue.ToString().Trim();
            int lan = int.Parse(lANSpinEdit.Value.ToString().Trim());
            string ngay = nGAYTHIDateTimePicker.Value.ToString("yyyy-MM-dd");

            string malop = txtB_IDClass.Text.Trim();
            string masv = txtB_IDStudent.Text.Trim();
            string query = "";
            if (Program.mGroup != "Sinhvien")
            {
                query = "select MAGV, MAMH, MALOP, TRINHDO, NGAYTHI, LAN, SOCAUTHI, THOIGIAN from GIAOVIEN_DANGKY where MAMH = '" + mamh+ "' and cast(NGAYTHI as date) = '" + ngay +"' and LAN = '"+lan+"'";
                dataGridView_Result.DataSource = Program.ExecSqlDataTable(query);

                //cho nhấn nút bắt đầu thi
                if (dataGridView_Result.Rows.Count > 0)
                {
                    pnl_S.Enabled=
                    btn_StartTesting.Enabled = true;
                }
            }
            else
            {
                query = "exec SP_LISTBANGSVTHI '" + mamh + "', " + lan + ",'" + ngay + "','" + malop + "','" + masv + "'";
                dataGridView_Result.DataSource = Program.ExecSqlDataTable(query);

                //cho nhấn nút bắt đầu thi
                if (dataGridView_Result.Rows.Count > 0)
                {
                    pnl_S.Enabled =
                    btn_StartTesting.Enabled = true;
                }
            }
        }

        private void btn_StartTesting_Click(object sender, EventArgs e)
        {
            string query = ""; int kq = -1;
            pnl_S.Enabled =
               btn_Submit.Enabled = true;
            dataGridView_Result.Enabled =dataGridView_Result.Visible = false;
            //reset timer          
            s = 1;
            lb_TImer.Text = thoigianThi + ":00";

            
           
            if (Program.mGroup == "Sinhvien")
            {
                //Kt sv đã thi chưa
                query= "exec SP_KTSVDATHI '"+Program.mSV+"','"+MAMH.Trim()+"',"+LAN;
                try
                {
                    kq = Program.ExecSqlNonQuery(query);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (kq == 1)
                {
                    checkThi = true;
                    dataGridView_Result.Visible = dataGridView_Result.Enabled = true;                  
                    return;
                }
                //kt sv co phai thi tiep
                query = "exec SP_KTSVTHITIEP '" + Program.mSV + "','" + MAMH.Trim() + "'," + LAN;
                try
                {
                    kq = Program.ExecSqlNonQuery(query);
                    if (kq == 1)
                    {
                        checkThiTiep = true;
                        query = "Select THOIGIAN from CHITIETBAITHISV where MASV='" + Program.mSV + "' and MAMH='" + MAMH.Trim() + "' and LAN_THI=" + LAN;
                        DataTable table = Program.ExecSqlDataTable(query);
                        thoigianThi = int.Parse(table.Rows[0]["THOIGIAN"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Kiem tra đã đến ngày thi
                query = "exec SP_KTDENNGAYTHI '"+MAMH.Trim()+"','"+MALOP.Trim()+"',"+LAN+",'"+ngayHienTai+"'";
                try
                {
                    kq = Program.ExecSqlNonQuery(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (kq == 1)
                {
                    dataGridView_Result.Visible = dataGridView_Result.Enabled = true;
                    return;
                }

                //Không có môn để thi
                if (dataGridView_Result.RowCount == 0)
                {
                    MessageBox.Show("Môn học này không được đăng ký thi. Vui lòng thông báo đến giáo viên để biết thêm chi tiết"
                    , "Không tìm thấy bài thi."
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                }
                if (MALOP == "" || (dataGridView_Result.Rows.Count > 0 && dataGridView_Result.Rows.Count < 2))
                {
                    dataGridView_Result.Rows[0].Selected = true;
                }
                               
            }
            else//Giang vien
            {
                if (mAMHComboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK);
                    mAMHComboBox1.Focus();
                    return;
                }              
                if (tRINHDOComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Trình độ không được để trống!", "", MessageBoxButtons.OK);
                    tRINHDOComboBox.Focus();
                    return;
                }
                if (lANSpinEdit.Value.ToString() == "")
                {
                    MessageBox.Show("Lần thi không được để trống!", "", MessageBoxButtons.OK);
                    lANSpinEdit.Focus();
                    return;
                }
                if (sOCAUTHISpinEdit.Value.ToString() == "")
                {
                    MessageBox.Show("Số câu thi không được để trống!", "", MessageBoxButtons.OK);
                    sOCAUTHISpinEdit.Focus();
                    return;
                }
                if (nGAYTHIDateTimePicker.Value.ToString() == "")
                {
                    MessageBox.Show("Thời gian không được để trống!", "", MessageBoxButtons.OK);
                    nGAYTHIDateTimePicker.Focus();
                    return;
                }
                if (tHOIGIANSpinEdit.Value.ToString() == "")
                {
                    MessageBox.Show("Thời gian không được để trống!", "", MessageBoxButtons.OK);
                    tHOIGIANSpinEdit.Focus();
                    return;
                }
                if ( MALOP=="" || (dataGridView_Result.Rows.Count > 0 && dataGridView_Result.Rows.Count < 2))
                {
                    dataGridView_Result.Rows[0].Selected = true;
                }
            }

            loadCauHoi();
        }

        private void dataGridView_Result_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Result.Rows[e.RowIndex];
                MALOP= row.Cells[2].Value.ToString().Trim();
                MAMH = row.Cells[1].Value.ToString().Trim();
                LAN = row.Cells[5].Value.ToString().Trim();
                soCauThi = int.Parse(row.Cells[6].Value.ToString());
                thoigianThi = int.Parse(row.Cells[7].Value.ToString());
                trinhdo = row.Cells[3].Value.ToString().Trim();
                ngayThi = Convert.ToDateTime(row.Cells[4].Value.ToString());
                MessageBox.Show(MALOP + " " + MAMH + " " + LAN + " " + soCauThi + " " + thoigianThi);
            }
        }

        private void dataGridView_Result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Result.Rows[e.RowIndex];
                MALOP = row.Cells[2].Value.ToString().Trim();
                MAMH = row.Cells[1].Value.ToString().Trim();
                LAN = row.Cells[5].Value.ToString().Trim();
                soCauThi = int.Parse(row.Cells[6].Value.ToString());
                thoigianThi = int.Parse(row.Cells[7].Value.ToString());
                trinhdo = row.Cells[3].Value.ToString().Trim();
                MessageBox.Show(MALOP + " " + MAMH + " " + LAN + " " + soCauThi + " " + thoigianThi+ " |" +e.RowIndex+"|");
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == 0)
            {
                if (thoigianThi != 0)
                {
                    thoigianThi=thoigianThi-1;
                    s = 59;
                }
            }
            lb_TImer.Text = thoigianThi.ToString() + " : " + s.ToString();
            if (thoigianThi == 0 && s == 0)
            {
                timer1.Stop();
                checkThi = false;
                MessageBox.Show("Đã hết thời gian thi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tinhdiem();
                if (Program.mGroup.Equals("Sinhvien"))
                {
                    themDiemsv();
                }
                btn_Submit.Enabled = false;
                dataGridView_Result.Visible = dataGridView_Result.Enabled = true;
                fmDoExam_Load(SENDER,Event);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn nộp bài", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                timer1.Stop();
                checkThi = false;
                tinhdiem();

                if (Program.mGroup.Equals("Sinhvien"))
                {
                    if (checkThiTiep == true)
                    {
                        luuBaithi();
                        themDiemsv();
                    }
                    else
                    {
                        themDiemsv();
                        luuBaithi();
                    }
                }
                dataGridView_Result.Visible = dataGridView_Result.Enabled = true;
                btn_Submit.Visible = false;
                btn_StartTesting.Visible = btn_StartTesting.Enabled = true;
                //listV_ChosenAnswer.Items.Clear();
                flowLayoutPanel_Question.Controls.Clear();
                grpB_txtExam.Enabled = true;
                lb_Time.Visible = lb_TImer.Visible = false;

            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            fmDoExam_Load(sender, e);
        }

        private void fmDoExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.mGroup == "Sinhvien")
            {
                //luuBaithi();
            }
        }
    }
}
