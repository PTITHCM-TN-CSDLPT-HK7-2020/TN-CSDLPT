using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace TN_CSDLPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername="";//chon sever ket noi toi
        public static String username = "";//manv
        public static String mlogin = "";//login name
        public static String password = "";

        public static String database = "TN_CSDLPT";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = "";//luu dang nhap
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mCoso = 0;//luu vi tri co so trên combox box branch

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static fmMain fmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                //Data Source=DESKTOP-4KQ12ML\MSSQLSERVER1;Initial Catalog = TN_CSDLPT; Integrated Security = True
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                MessageBox.Show(Program.conn.DataSource+"\n"+Program.mlogin+"\n"+Program.password);
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)//reader tai du lieu nhanh, chi doc khong sua, con tro nam dau bang va chi di xuong, ko len 
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)//trả về một bảng data table từ csdl
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// dữ liệu lớn trăm ngàn mẩu tin,mặc định chạy một câu lệnh 3p, nên chạy lâu tự ngắt, server tê liệt
                                        //Là thời gian cho 10 phut thời gian chạy, phòng trường hợp sql chạy lâu hơn thời gian mặc định
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int data=Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        public static int ExecuteNonQuery1(String query, object[] parameter = null)
        {
            int data = 0;//số dòng thêm thành công

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            { //using: sau khi khối lệnh phía trong chạy xong biến connection tự giải phóng

                //mở kết nối để lấy dữ liệu
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);//lệnh thực thi câu truy vấn tại kết nối "connection"

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();//số lần thêm thành công
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra! Kiểm tra lại! \n"+ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
                // đóng kết nối sql để tránh việc quá nhiều dữ liệu cùng một lúc đổ vê
                connection.Close();
            }

            return data;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //BonusSkins.Register();
            fmChinh = new fmMain();
            //Application.Run(new fmLogin());
            Application.Run(fmChinh);

        }
    }
}
