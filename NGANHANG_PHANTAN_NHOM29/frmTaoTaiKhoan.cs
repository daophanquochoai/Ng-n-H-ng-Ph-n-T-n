using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG_PHANTAN_NHOM29
{
    public partial class frmTaoTaiKhoan : Form
    {
        String macn = "";
        int vitri = 0;
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            try{
                dS.EnforceConstraints = false;
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.dS.frmCreateLogin_GetEmployeeNotHaveLogin);
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.dS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
                macn = Program.mTenChiNhanh;
                TK_comboChiNhanh.DataSource = Program.bds_dspm;
                TK_comboChiNhanh.DisplayMember = "TENCN";
                TK_comboChiNhanh.ValueMember = "TENSERVER";
                TK_comboChiNhanh.SelectedIndex = Program.mChiNhanh;
                groupBox1.Enabled = false;
                TK_barPhucHoi.Enabled = false;
                TK_barTaoTaiKhoan.Enabled = TK_barThoat.Enabled = true;

                if (Program.mGroup == "NGANHANG")
                {
                    TK_comboChiNhanh.Enabled = true;
                }
                else if (Program.mGroup == "CHINHANH")
                {
                    TK_comboChiNhanh.Enabled = false;
                }
                if( frmCreateLogin_GetEmployeeNotHaveLoginBindingSource.Count == 0)
                {
                    TK_barTaoTaiKhoan.Enabled = false;
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu tạo tài khoản\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TK_comboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( TK_comboChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.servername = TK_comboChiNhanh.SelectedValue.ToString();
            if ( TK_comboChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if( Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối với chi nhánh mới!!!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                dS.EnforceConstraints = false;
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.dS.frmCreateLogin_GetEmployeeNotHaveLogin);
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.dS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);

                if (frmCreateLogin_GetEmployeeNotHaveLoginBindingSource.Count == 0)
                {
                    TK_barTaoTaiKhoan.Enabled = true;
                }
            }
        }

        private void TK_barTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                vitri = frmCreateLogin_GetEmployeeNotHaveLoginBindingSource.Position;
                String manv = ((DataRowView)frmCreateLogin_GetEmployeeNotHaveLoginBindingSource[frmCreateLogin_GetEmployeeNotHaveLoginBindingSource.Position])["MANV"].ToString();
                String hovaten = ((DataRowView)frmCreateLogin_GetEmployeeNotHaveLoginBindingSource[frmCreateLogin_GetEmployeeNotHaveLoginBindingSource.Position])["HO"].ToString() +
                    ((DataRowView)frmCreateLogin_GetEmployeeNotHaveLoginBindingSource[frmCreateLogin_GetEmployeeNotHaveLoginBindingSource.Position])["TEN"].ToString();
                memo.Text = "Thông tin nhân viên tạo login : "+
                    "\n Mã nhân viên : " + manv 
                    + "\n Tên là : " + hovaten;
                panelControl1.Enabled = frmCreateLogin_GetLoginsOfBranchGridControl.Enabled = false;
                frmCreateLogin_GetEmployeeNotHaveLoginGridControl.Enabled = false;
                groupBox1.Enabled = true;
                TK_barPhucHoi.Enabled = true;
                TK_barTaoTaiKhoan.Enabled = TK_barTaiLaiTrang.Enabled = false;
            }
            catch( Exception ex)
            {
                MessageBox.Show("Lỗi xử lý khi setup thêm \n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }
        private bool KiemTraLoginBiTrung( string textlogin)
        {
            Program.myReader.Close();
            string cmd = "EXEC frmCreateLogin_DuplicateLOGIN '" + textlogin + "','" + Program.mGroup + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if(Program.myReader.HasRows)
            {
                Program.myReader.Close();
                return true;
            }
            else
            {
                Program.myReader.Close();
                return false;
            }
        }
        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TK_buttonTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            String manv = ((DataRowView)frmCreateLogin_GetEmployeeNotHaveLoginBindingSource[frmCreateLogin_GetEmployeeNotHaveLoginBindingSource.Position])["MANV"].ToString();
            if( TK_textboxTaiKhoan.ToString().Trim() == "" || TK_textboxMatKhau.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu đang để trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if( KiemTraLoginBiTrung(TK_textboxTaiKhoan.Text) )
            {
                MessageBox.Show("Tên Login đã tồn tại \nVui lòng nhập tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            string cmd = "EXEC frmCreateLogin_CreateLoginForEmployee '" + TK_textboxTaiKhoan.Text + "','" + TK_textboxMatKhau.Text + "','" + manv + "','" + Program.mGroup + "'";
            Program.ExecSqlNonQuery(cmd);

            frmCreateLogin_GetEmployeeNotHaveLoginGridControl.Enabled = frmCreateLogin_GetLoginsOfBranchGridControl.Enabled = true;
            this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.dS.frmCreateLogin_GetEmployeeNotHaveLogin);
            this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.dS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
            groupBox1.Enabled = false;
            TK_barPhucHoi.Enabled = false;
            TK_barTaoTaiKhoan.Enabled = true;
            TK_barTaiLaiTrang.Enabled = true;
            TK_textboxTaiKhoan.Text = "";
            TK_textboxMatKhau.Text = "";
            if ( frmCreateLogin_GetEmployeeNotHaveLoginBindingSource.Count == 0)
            {
                TK_barTaoTaiKhoan.Enabled = false;
                memo.Text = "Tất cả nhân viên đã có tài khoản";
            }
            else
            {
                memo.Text = "Chọn nhân viên để tạo tài khoản";
            }
        }

        private void frmCreateLogin_GetLoginsOfBranchGridControl_Click(object sender, EventArgs e)
        {
        }

        private void frmCreateLogin_GetLoginsOfBranchGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if( e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String username = ((DataRowView)frmCreateLogin_GetLoginsOfBranchBindingSource[frmCreateLogin_GetLoginsOfBranchBindingSource.Position])["MANV"].ToString();
                String login = ((DataRowView)frmCreateLogin_GetLoginsOfBranchBindingSource[frmCreateLogin_GetLoginsOfBranchBindingSource.Position])["TENLOGIN"].ToString();
                if (username == Program.username)
                {
                    MessageBox.Show("Tài khoản này bạn đang đăng nhập\nKhông thể xóa!!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Thông Báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    string cmd = "EXEC frmCreateLogin_DeleteLoginForEmployee '" + login + "','" + username + "'";
                    MessageBox.Show(cmd);

                    Program.ExecSqlNonQuery(cmd);
                }
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.dS.frmCreateLogin_GetEmployeeNotHaveLogin);
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.dS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
                TK_barTaoTaiKhoan.Enabled = true;
            }
            catch( Exception ex)
            {
                MessageBox.Show("Lỗi quá trình thực hiện xóa!!!\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void TK_barTaiLaiTrang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.dS.frmCreateLogin_GetEmployeeNotHaveLogin);
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.dS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
            }
            catch( Exception ex)
            {
                MessageBox.Show("Lỗi làm mới trang!!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void TK_barTaiLaiTrang_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void TK_barPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.frmCreateLogin_GetEmployeeNotHaveLoginBindingSource.CancelEdit();
                this.frmCreateLogin_GetLoginsOfBranchBindingSource.CancelEdit();
                frmCreateLogin_GetEmployeeNotHaveLoginGridControl.Enabled = frmCreateLogin_GetLoginsOfBranchGridControl.Enabled = true;
                groupBox1.Enabled = false;
                TK_textboxTaiKhoan.Text = "";
                TK_textboxMatKhau.Text = "";
                TK_barTaoTaiKhoan.Enabled = TK_barTaiLaiTrang.Enabled = true;
                TK_barPhucHoi.Enabled = false;
                memo.Text = "Chọn nhân viên để tạo tài khoản";
            }
            catch( Exception ex)
            {
                MessageBox.Show("Lỗi phục hồi!!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
