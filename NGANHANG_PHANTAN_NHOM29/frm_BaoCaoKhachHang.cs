using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace NGANHANG_PHANTAN_NHOM29
{
    public partial class frm_BaoCaoKhachHang : Form
    {
        public frm_BaoCaoKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if( BCKH_comboboxChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    MessageBox.Show("Lỗi giá trị chọn của combobox chi nhánh", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
                else { 
                    xtrp_BaoCaoKhachHang baocao = new xtrp_BaoCaoKhachHang('C', BCKH_comboboxChiNhanh.Text);
                    ReportPrintTool print = new ReportPrintTool(baocao);
                    print.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu.\nVui lòng thử lại!!\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_BaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                BCKH_comboboxChiNhanh.DataSource = Program.bds_dspm;
                BCKH_comboboxChiNhanh.DisplayMember = "TENCN";
                BCKH_comboboxChiNhanh.ValueMember = "TENSERVER";
                BCKH_comboboxChiNhanh.SelectedIndex = Program.mChiNhanh;

                if ( Program.mGroup == "NGANHANG")
                {
                    BCKH_comboboxChiNhanh.Enabled = true;
                }
                else
                {
                    BCKH_comboboxChiNhanh.Enabled = false;
                    BC_buttonXemToanBo.Visible = false;
                }
            }catch( Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu trang.\nVui lòng thử lại!!\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void BCKB_buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KH_panelControlChiNhanh_Click(object sender, EventArgs e)
        {

        }

        private void BCKH_comboboxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xtrp_BaoCaoKhachHang baocao = new xtrp_BaoCaoKhachHang('T', BCKH_comboboxChiNhanh.Text);
            ReportPrintTool print = new ReportPrintTool(baocao);
            print.ShowPreviewDialog();
        }
    }
}
