using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NGANHANG_PHANTAN_NHOM29
{
    public partial class frmNhanVien : Form
    {
        int vitri;
        String macn = "";
        bool buttonAdd_Clicked = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                dS.EnforceConstraints = false;
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

                macn = Program.mTenChiNhanh;
                NV_ChiNhanhHienTai.DataSource = Program.bds_dspm;
                NV_ChiNhanhHienTai.DisplayMember = "TENCN";
                NV_ChiNhanhHienTai.ValueMember = "TENSERVER";
                NV_ChiNhanhHienTai.SelectedIndex = Program.mChiNhanh;
                NV_panelInput.Enabled = NV_PHUCHOI.Enabled = NV_LUU.Enabled = NV_panelInput.Enabled = NV_comboboxChiNhanhChuyen.Enabled = NV_textboxMaNVMoi.Enabled = false;
                if (Program.mGroup == "NGANHANG")
                {
                    NV_ChiNhanhHienTai.Enabled = true;
                    NV_THEM.Enabled = NV_XOA.Enabled = NV_HIEUCHINH.Enabled = NV_ChuyenNV.Enabled = false;
                }
                else
                {
                    NV_ChiNhanhHienTai.Enabled = false;
                    NV_THEM.Enabled = NV_XOA.Enabled = NV_HIEUCHINH.Enabled = NV_ChuyenNV.Enabled = true;
                }
                BindingSource chiNhanhMoi = new BindingSource();
                foreach (DataRowView d in Program.bds_dspm)
                {
                    if (d[0].ToString() != Program.mTenChiNhanh)
                    {
                        chiNhanhMoi.Add(d);
                    }
                }
                NV_comboboxChiNhanhChuyen.DataSource = chiNhanhMoi;
                NV_comboboxChiNhanhChuyen.DisplayMember = "TENCN";
                NV_comboboxChiNhanhChuyen.ValueMember = "TENSERVER";
                NV_comboboxChiNhanhChuyen.SelectedIndex = 0;
                NV_buttonXacNhanChuyen.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi load trang nhân viên", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void NV_THOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private string taoMaNV()
        {
            // Đóng DataReader trước nếu nó đã mở
            if (Program.myReader != null && !Program.myReader.IsClosed)
            {
                Program.myReader.Close();
            }

            string cmd = "exec [dbo].[timMaNV]";
            Program.myReader = Program.ExecSqlDataReader(cmd);

            if (Program.myReader == null) return null;

            Program.myReader.Read();
            int stt = Program.myReader.GetInt32(0);
            Program.myReader.Close(); // Đóng DataReader sau khi sử dụng

            if (Convert.IsDBNull(Program.username))
            {
                return null;
            }

            return "NV" + stt.ToString("D4");
        }


        private void NV_THEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (taoMaNV() == null)
            {
                MessageBox.Show("Lỗi tạo mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            vitri = nhanVienBindingSource.Position;
            NV_HO.Focus();
            NV_panelInput.Enabled = true;
            nhanVienBindingSource.AddNew();
            NV_ChiNhanh.Text = macn;
            NV_THEM.Enabled = NV_XOA.Enabled = NV_HIEUCHINH.Enabled = NV_TAILAI.Enabled = NV_ChuyenNV.Enabled = NV_THOAT.Enabled = false;
            NV_LUU.Enabled = NV_PHUCHOI.Enabled = true;
            nhanVienGridControl.Enabled = false;
            NV_ChiNhanh.Enabled = false;
            NV_PHAI.SelectedIndex = 1;
            buttonAdd_Clicked = true;
            NV_MANV.Text = taoMaNV();
            NV_MANV.Enabled = false;
        }
        private bool kiemTraMaNV(string manv)
        {
            String chuoi = manv.Trim();
            if (chuoi.Length > 10) return false;
            Regex regex = new Regex(@"^NV\d+$");
            return regex.IsMatch(chuoi);
        }
        private void kiemTraSDT( )
        {
            if (!NV_SDT.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "", MessageBoxButtons.OK);
                NV_SDT.Focus();
                return;
            }
            if (NV_SDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại nhân viên không đúng 10 chữ số", "", MessageBoxButtons.OK);
                NV_SDT.Focus();
                return;
            }
            if( NV_SDT.Text[0] != '0')
            {
                MessageBox.Show("Số điện thoại nhân viên chưa đúng định dạng", "", MessageBoxButtons.OK);
                NV_SDT.Focus();
                return;
            }
        }
        private bool kiemTraSdt()
        {
            if( NV_SDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại bắt buộc 10 số", "", MessageBoxButtons.OK);
                NV_SDT.Focus();
                return false;
            }
            if(!NV_SDT.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không bao gồm chữ", "", MessageBoxButtons.OK);
                NV_SDT.Focus();
                return false;
            }
            if ( (NV_SDT.Text)[0] != '0')
            {
                MessageBox.Show("Số điện thoại bắt đầu bằng số 0", "", MessageBoxButtons.OK);
                NV_SDT.Focus();
                return false;
            }
            return true;
        }
        private bool KiemTraCMNDTrungNV()
        {
            try
            {
                Program.myReader.Close();
                String cmd = "exec KiemTraCMNDTrungNhanVien '" + NV_CMND.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                if(Program.myReader.HasRows)
                {
                    MessageBox.Show("CMND không thể trùng!!!", "Thông Báo", MessageBoxButtons.OK);
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
                MessageBox.Show("Không thể kiểm tra trùng CMND!!!", "Thông Báo", MessageBoxButtons.OK);
                return true;
            }
        }
        private void NV_LUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String manv = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString();
            if( NV_MANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được trống", "", MessageBoxButtons.OK);
                NV_MANV.Focus();
                return;
            }
            if( !kiemTraMaNV(NV_MANV.Text))
            {
                MessageBox.Show("Mã nhân viên sai cấu trúc : NV + STT", "", MessageBoxButtons.OK);
                NV_MANV.Focus();
                return;
            }
            if( NV_HO.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được trống", "", MessageBoxButtons.OK);
                NV_HO.Focus();
                return;
            }
            if( NV_TEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được trống", "", MessageBoxButtons.OK);
                NV_TEN.Focus();
                return;
            }
            if( NV_DIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được trống", "", MessageBoxButtons.OK);
                NV_DIACHI.Focus();
                return;
            }
            if (!kiemTraSdt()) return;
            if( buttonAdd_Clicked == true || manv != NV_MANV.Text)
            {
                buttonAdd_Clicked = false;
                try
                {
                    if (KiemTraCMNDTrungNV()) return;
                    Program.myReader.Close();
                    string cmd = "exec [dbo].[frmNhanVien_duplicateMANV] '" + NV_MANV + "'";
                    Program.myReader = Program.ExecSqlDataReader(cmd);
                    if (Program.myReader.HasRows)
                    {
                        MessageBox.Show("Rất tiếc!!\nMã nhân viên đã bị trùng.", "", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                    else
                    {
                        Program.myReader.Close();
                    }
                }catch( Exception ex)
                {
                    MessageBox.Show("Không thể kiểm tra MANV trùng!!!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
            }
            try
            {
                nhanVienBindingSource.EndEdit();
                nhanVienBindingSource.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                MessageBox.Show("Lưu thành công!!\n", "", MessageBoxButtons.OK);

            }catch( Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            NV_THEM.Enabled = NV_XOA.Enabled = NV_HIEUCHINH.Enabled = NV_TAILAI.Enabled = NV_ChuyenNV.Enabled = NV_THOAT.Enabled = true;
            NV_LUU.Enabled = NV_PHUCHOI.Enabled = false;
            nhanVienGridControl.Enabled = true;
            NV_panelInput.Enabled = false;
        }

        private void NV_PHUCHOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
            nhanVienBindingSource.Position = vitri;
            nhanVienGridControl.Enabled = true;
            NV_panelInput.Enabled = false;
            NV_THEM.Enabled = NV_XOA.Enabled = NV_HIEUCHINH.Enabled = NV_TAILAI.Enabled = NV_ChuyenNV.Enabled = NV_THOAT.Enabled = true;
            NV_LUU.Enabled = NV_PHUCHOI.Enabled = false;
            NV_buttonXacNhanChuyen.Enabled = false;
            NV_comboboxChiNhanhChuyen.Enabled = false;
            NV_textboxMaNVMoi.Text = "";
        }

        private void NV_HIEUCHINH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhanVienBindingSource.Position;
            nhanVienGridControl.Enabled = false;
            NV_panelInput.Enabled = true;
            NV_THEM.Enabled = NV_XOA.Enabled = NV_HIEUCHINH.Enabled = NV_TAILAI.Enabled = NV_ChuyenNV.Enabled = NV_THOAT.Enabled = false;
            NV_LUU.Enabled = NV_PHUCHOI.Enabled = true;
            NV_MANV.Enabled = false;
            NV_ChiNhanh.Enabled = false;
        }

        private void NV_ChiNhanhHienTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NV_ChiNhanhHienTai.SelectedIndex.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            //Program.servername = NV_ChiNhanhHienTai.SelectedValue.ToString();
            if (NV_ChiNhanhHienTai.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu mới!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            }
        }
        private bool kiemTraCoTaiKhoan()
        {
            Program.myReader.Close();
            string cmd = "EXEC frmNhanVien_ExistsAccount '" + NV_MANV.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            Program.myReader.Read();
            if( Program.myReader.HasRows)
            {
                Program.myReader.Close();
                return true;
            }
            Program.myReader.Close();
            return false;
            
        }
        private void NV_XOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string manv = ((DataRowView)nhanVienBindingSource[vitri])["MANV"].ToString();
                if( gD_GOIRUTBindingSource.Count > 0)
                {
                    MessageBox.Show("Không thể xóa nhân viên vì đã thực hiện giao dịch", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (gD_CHUYENTIENBindingSource.Count > 0)
                {
                    MessageBox.Show("Không thể xóa nhân viên vì đã thực hiện giao", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (kiemTraCoTaiKhoan())
                {
                    MessageBox.Show("Nhân viên không thể xoá vì đã mở tài khoản login!!", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xoá nhân viên " + manv + " ??", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        nhanVienBindingSource.RemoveCurrent();
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                        MessageBox.Show("Xoá thành công nhân viên " + manv, "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xoá nhân viên. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                        nhanVienBindingSource.Position = vitri;
                        return;
                    }
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Lỗi xóa!!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void NV_TAILAI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }catch( Exception ex)
            {
                MessageBox.Show("Lỗi reload lại dữ liệu!!!", "Thông bóa", MessageBoxButtons.OK);
                return;
            }
        }

        private void NV_ChuyenNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhanVienBindingSource.Position;
            string manv = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString();
            NV_comboboxChiNhanhChuyen.Enabled = true;
            NV_textboxMaNVMoi.Text = taoMaNV();
            NV_THEM.Enabled = NV_HIEUCHINH.Enabled = NV_LUU.Enabled = NV_XOA.Enabled = NV_TAILAI.Enabled = NV_ChuyenNV.Enabled = NV_THOAT.Enabled = false;
            NV_PHUCHOI.Enabled = NV_buttonXacNhanChuyen.Enabled = true;
            nhanVienGridControl.Enabled = false;
            NV_buttonXacNhanChuyen.Enabled = true;
        }
    }
}
