using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace NGANHANG_PHANTAN_NHOM29
{
    public partial class frmLogin : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public void getSide( String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            Program.bds_dspm.DataSource = dt;
            LG_comboxChiNhanh.DataSource = Program.bds_dspm;
            LG_comboxChiNhanh.DisplayMember = "TENCN";
            LG_comboxChiNhanh.ValueMember = "TENSERVER";
            conn_publisher.Close();
        }
        public frmLogin()
        {
            InitializeComponent();
        }
        private int ketNoiDuLieuGoc()
        {
            if( conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }catch( Exception e)
            {
                MessageBox.Show("\nLỗi kết nối cơ sở dữ liệu gốc.\nBạn xem lại Tên Server và tên của Publisher, và tên CSDL trong chuỗi kết nối.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = LG_comboxChiNhanh.SelectedValue.ToString();
                Console.WriteLine(Program.servername);
            }catch( Exception ex)
            {
                MessageBox.Show("\nLỗi thay đổi servername bằng combobox\n " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (ketNoiDuLieuGoc() == 0) return;
            getSide("SELECT * FROM [dbo].[V_DS_PHANMANH]");
            LG_comboxChiNhanh.SelectedIndex = 1;
            LG_comboxChiNhanh.SelectedIndex = 0;
        }
        private bool KiemTraNhanVienDaXoa(string manv)
        {
            try
            {
                Program.myReader.Close();
                String cmd = "EXEC KiemTraNhanVienXoaChua '" + manv + "'";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                if(Program.myReader.HasRows)
                {
                    MessageBox.Show("Nhân viên đã bị xóa !!", "Thông Báo", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return true;
                }
                else
                {
                    Program.myReader.Close();
                    return false;
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra nhân viên xóa chưa!!!", "Thông Báo", MessageBoxButtons.OK);
                return true;
            }
        }
        private void LG_buttonDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (LG_textboxTaiKhoan.Text.Trim() == "" || LG_textboxMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = LG_textboxTaiKhoan.Text;
                Program.password = LG_textboxMatKhau.Text;
                if (Program.KetNoi() == 0) return;

                Program.mChiNhanh = LG_comboxChiNhanh.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                // SP đăng nhập
                string strDangNhap = "EXEC [dbo].[SP_LayThongTinNhanVien] '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strDangNhap);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                // myReader đọc trả ra giá trị
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.\nBạn xem lại user name và password.\n ", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.mTenChiNhanh = LG_comboxChiNhanh.Text;
                Program.myReader.Close();
                if (KiemTraNhanVienDaXoa(Program.username)) return;
                MessageBox.Show("Đăng nhập thành công tài khoản \n- Mã NV: " + Program.username + "\n- Tên: " + Program.mHoten + "\n- Nhóm: " + Program.mGroup, "", MessageBoxButtons.OK);
                Program.frmChinh.hienThiTool();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi quá trình đăng nhập!!!", "Thông Baó", MessageBoxButtons.OK);
                return;
            }
        }

        private void LG_buttonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.frmChinh.Close();
            }
        }
    }
}
