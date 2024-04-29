using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NGANHANG_PHANTAN_NHOM29
{
    public partial class xtrp_BaoCaoKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public xtrp_BaoCaoKhachHang()
        {
        }
        public xtrp_BaoCaoKhachHang( Char loai, String macn)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = loai;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = macn;
            this.sqlDataSource1.Fill();
        }

    }
}
