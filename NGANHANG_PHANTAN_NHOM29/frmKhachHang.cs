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
    public partial class frmKhachHang : Form
    {
        int vitri = 0;
        String macn = "";
        bool buttonAdd_Clicked = false;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                dS.EnforceConstraints = false;
                Console.WriteLine(Program.connstr);
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                macn = Program.mTenChiNhanh;
                KH_comboboxChiNhanh.DataSource = Program.bds_dspm;
                KH_comboboxChiNhanh.DisplayMember = "TENCN";
                KH_comboboxChiNhanh.ValueMember = "TENSERVER";
                KH_comboboxChiNhanh.SelectedIndex = Program.mChiNhanh;
                panelControl2.Enabled = KH_barPhucHoi.Enabled = KH_barLuu.Enabled = false;
                if (Program.mGroup == "NGANHANG")
                {
                    KH_comboboxChiNhanh.Enabled = true;
                    KH_barThem.Enabled = KH_barHieuChinh.Enabled = KH_barXoa.Enabled = false;
                }
                else
                {
                    KH_barThem.Enabled = KH_barHieuChinh.Enabled = KH_barXoa.Enabled = true;
                    KH_comboboxChiNhanh.Enabled = false;
                }
                KH_comboboxChiNhanh.SelectedIndex = 0;
            }
            catch( Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu khách hàng", "Xác nhận", MessageBoxButtons.OK);
                return;
            }
        }

        private void KH_comboboxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            if (KH_comboboxChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = KH_comboboxChiNhanh.SelectedValue.ToString();
            if( KH_comboboxChiNhanh.SelectedIndex != Program.mChiNhanh)
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
                MessageBox.Show("Lỗi kết nối về nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            }
        }

        private void KH_barThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void KH_barTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            }catch( Exception ex)
            {
                MessageBox.Show("Lỗi reload lại dữ liệu : " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void KH_barThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = khachHangBindingSource.Position;
            panelControl2.Enabled = true;
            KH_textboxCMND.Focus();
            khachHangBindingSource.AddNew();
            KH_textboxChiNhanh.Text = macn;
            KH_barThem.Enabled = KH_barHieuChinh.Enabled = KH_barXoa.Enabled = KH_barTaiLai.Enabled = KH_barThoat.Enabled = false;
            KH_barLuu.Enabled = KH_barPhucHoi.Enabled = true;
            gridControl1.Enabled = KH_textboxChiNhanh.Enabled = false;
            buttonAdd_Clicked = true;
            KH_comboboxPhai.SelectedIndex = 1;
        }
        private bool kiemTraSDT()
        {
            if (!KH_textboxSoDienThoai.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "", MessageBoxButtons.OK);
                KH_textboxSoDienThoai.Focus();
                return false;
            }
            if (KH_textboxSoDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại nhân viên không đúng 10 chữ số", "", MessageBoxButtons.OK);
                KH_textboxSoDienThoai.Focus();
                return false;
            }
            if (KH_textboxSoDienThoai.Text[0] != '0')
            {
                MessageBox.Show("Số điện thoại nhân viên chưa đúng định dạng", "", MessageBoxButtons.OK);
                KH_textboxSoDienThoai.Focus();
                return false;
            }
            return true;
        }
        private void KH_barLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String CMND = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["CMND"].ToString();
            if( KH_textboxCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND Không được để trống!!!","Xác Nhận", MessageBoxButtons.OK);
                KH_textboxCMND.Focus();
                return;
            }
            if(!KH_textboxCMND.Text.All(char.IsDigit))
            {
                MessageBox.Show("CMND không chứa kí tự", "Thông Báo", MessageBoxButtons.OK);
                KH_textboxCMND.Focus();
                return;
            }
            if( KH_dateNgayCap.DateTime > DateTime.Now || KH_dateNgayCap.Text.Trim() == "")
            {
                MessageBox.Show("Ngày cấp không hợp lệ!!!", "Xác Nhận", MessageBoxButtons.OK);
                KH_dateNgayCap.Focus();
                return;
            }
            if( KH_textboxHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ khách hàng không được để trống!!!", "Xác Nhận", MessageBoxButtons.OK);
                KH_textboxHo.Focus();
                return;
            }
            if( KH_textboxTen.Text.Trim() == "" )
            {
                MessageBox.Show("Tên khách hàng không được để trống!!!", "Xác Nhận", MessageBoxButtons.OK);
                KH_textboxTen.Focus();
                return;
            }
            if (KH_textboxDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được để trống!!!", "Xác Nhận", MessageBoxButtons.OK);
                KH_textboxDiaChi.Focus();
                return;
            }
            if ( !kiemTraSDT()) return;
            if ( buttonAdd_Clicked == true || KH_textboxCMND.Text != CMND) 
            {
                buttonAdd_Clicked = false;
                try
                {
                    Program.myReader.Close();
                    string cmd = "EXEC [dbo].[frmKhachHang_DuplicateCMND] '" + KH_textboxCMND.Text + "'";
                    Program.myReader = Program.ExecSqlDataReader(cmd);
                    if (Program.myReader.HasRows)
                    {
                        MessageBox.Show("CMND khách hàng đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                    else
                    {
                        Program.myReader.Close();
                    }
                }
                catch( Exception ex)
                {
                    MessageBox.Show("Không thể kiểm tra CMND trùng!!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            try
            {
                khachHangBindingSource.EndEdit();
                khachHangBindingSource.ResetCurrentItem();
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Update(this.dS.KhachHang);
                MessageBox.Show("Đã lưu thành công!!!", "Thông Báo", MessageBoxButtons.OK);
            }catch( Exception ex)
            {
                MessageBox.Show("Lỗi ghi khách hàng !!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
            gridControl1.Enabled = true;
            KH_barThem.Enabled = KH_barHieuChinh.Enabled = KH_barXoa.Enabled = KH_barTaiLai.Enabled = KH_barThoat.Enabled = true;
            KH_barLuu.Enabled = KH_barPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void KH_barHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = khachHangBindingSource.Position;
            panelControl2.Enabled = true;
            KH_barThem.Enabled = KH_barHieuChinh.Enabled = KH_barXoa.Enabled = KH_barTaiLai.Enabled = KH_barThoat.Enabled = false;
            KH_barLuu.Enabled = KH_barPhucHoi.Enabled = true;
            gridControl1.Enabled = false;
            KH_textboxChiNhanh.Enabled = false;
        }
        private bool kiemTraTaiKhoan()
        {
            try
            {
                Program.myReader.Close();
                string cmd = "EXEC frmKhachHang_ExistsAccount'" + KH_textboxCMND.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(cmd);

                if (Program.myReader.HasRows)
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
            catch( Exception ex)
            {
                MessageBox.Show("Lỗi xóa tài khoản", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

        }
        private void KH_barXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Double cmnd = 0;
            cmnd = Double.Parse(((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["CMND"].ToString());
            if ( kiemTraTaiKhoan())
            {
                MessageBox.Show("Khách hàng không thể xóa!\nLý do : Vì đã mở tài khoản", "Thông báo", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            if( MessageBox.Show("Bạn có thật sự muốn xóa khách hàng " + cmnd + " ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    khachHangBindingSource.RemoveCurrent();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.dS.KhachHang);
                    MessageBox.Show("Đã xóa khách hàng thành công !!", "Thông báo", MessageBoxButtons.OK);
                }
                catch( Exception ex)
                {
                    MessageBox.Show("Rất tiếc!\nĐã xảy ra lỗi!\nLý do : " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                    khachHangBindingSource.Position = khachHangBindingSource.Find("CMND", cmnd);
                    return;
                }
            }
            if (khachHangBindingSource.Count == 0) KH_barXoa.Enabled = true;

        }

        private void KH_barPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khachHangBindingSource.CancelEdit();
            khachHangBindingSource.Position = vitri;
            gridControl1.Enabled = true;
            panelControl2.Enabled = false;
            KH_barThem.Enabled = KH_barHieuChinh.Enabled = KH_barXoa.Enabled = KH_barTaiLai.Enabled = KH_barThoat.Enabled = true;
            KH_barLuu.Enabled = KH_barPhucHoi.Enabled = false;
        }
    }
}
