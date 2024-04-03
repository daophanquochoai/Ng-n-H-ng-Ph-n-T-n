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
            dS.EnforceConstraints = false;
            this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Connection.ConnectionString = Program.connstr;
            this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.dS.frmCreateLogin_GetEmployeeNotHaveLogin);
            this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Connection.ConnectionString = Program.connstr;
            this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.dS.frmCreateLogin_GetLoginsOfBranch,Program.mGroup);
            macn = Program.mTenChiNhanh;
            TK_comboChiNhanh.DataSource = Program.bds_dspm;
            TK_comboChiNhanh.DisplayMember = "TENCN";
            TK_comboChiNhanh.ValueMember = "TENSERVER";
            TK_comboChiNhanh.SelectedIndex = Program.mChiNhanh;
            groupBox1.Enabled = false;
            TK_barPhucHoi.Enabled = false;
            if ( Program.mGroup == "NGANHANG")
            {
                TK_barTaoTaiKhoan.Enabled = TK_barThoat.Enabled= false;
            }
            else if( Program.mGroup == "CHINHANH")
            {
                TK_barTaoTaiKhoan.Enabled = TK_barThoat.Enabled = true;
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
                memo.Text = "Thông tin nhân viên tạo login :\n Mã nhân viên : " + manv + "\n Tên là : " + hovaten;
                panelControl1.Enabled = frmCreateLogin_GetLoginsOfBranchGridControl.Enabled = false;
            }
            catch( Exception ex)
            {
                MessageBox.Show("Lỗi xử lý khi setup thêm \n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                return;
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
        }
    }
}
