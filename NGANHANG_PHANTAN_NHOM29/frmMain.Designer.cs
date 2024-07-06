namespace NGANHANG_PHANTAN_NHOM29
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.HT_buttonDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.HT_buttonDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.HT_buttonTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.DM_buttonKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.DM_buttonNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.NV_buttonMoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.NV_butotnGuiVaRut = new DevExpress.XtraBars.BarButtonItem();
            this.NV_buttonChuyenKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.BC_buttonSaoKeTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.BC_buttonDSMTK = new DevExpress.XtraBars.BarButtonItem();
            this.BC_buttonTKTTKH = new DevExpress.XtraBars.BarButtonItem();
            this.HT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DM = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.NV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BC = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STS_MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.STS_HOVATEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.STS_NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.HT_buttonDangNhap,
            this.HT_buttonDangKy,
            this.HT_buttonTaoTaiKhoan,
            this.DM_buttonKhachHang,
            this.DM_buttonNhanVien,
            this.NV_buttonMoTaiKhoan,
            this.NV_butotnGuiVaRut,
            this.NV_buttonChuyenKhoan,
            this.BC_buttonSaoKeTaiKhoan,
            this.BC_buttonDSMTK,
            this.BC_buttonTKTTKH});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HT,
            this.DM,
            this.NV,
            this.BC});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(884, 179);
            // 
            // HT_buttonDangNhap
            // 
            this.HT_buttonDangNhap.Caption = "Đăng Nhập";
            this.HT_buttonDangNhap.Id = 1;
            this.HT_buttonDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HT_buttonDangNhap.ImageOptions.Image")));
            this.HT_buttonDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HT_buttonDangNhap.ImageOptions.LargeImage")));
            this.HT_buttonDangNhap.LargeWidth = 140;
            this.HT_buttonDangNhap.Name = "HT_buttonDangNhap";
            this.HT_buttonDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HT_buttonDangNhap_ItemClick);
            // 
            // HT_buttonDangKy
            // 
            this.HT_buttonDangKy.Caption = "Đăng Xuất";
            this.HT_buttonDangKy.Id = 2;
            this.HT_buttonDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HT_buttonDangKy.ImageOptions.Image")));
            this.HT_buttonDangKy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HT_buttonDangKy.ImageOptions.LargeImage")));
            this.HT_buttonDangKy.LargeWidth = 140;
            this.HT_buttonDangKy.Name = "HT_buttonDangKy";
            this.HT_buttonDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HT_buttonDangKy_ItemClick);
            // 
            // HT_buttonTaoTaiKhoan
            // 
            this.HT_buttonTaoTaiKhoan.Caption = "Tạo Tài Khoản";
            this.HT_buttonTaoTaiKhoan.Id = 3;
            this.HT_buttonTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HT_buttonTaoTaiKhoan.ImageOptions.Image")));
            this.HT_buttonTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HT_buttonTaoTaiKhoan.ImageOptions.LargeImage")));
            this.HT_buttonTaoTaiKhoan.LargeWidth = 140;
            this.HT_buttonTaoTaiKhoan.Name = "HT_buttonTaoTaiKhoan";
            this.HT_buttonTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HT_buttonTaoTaiKhoan_ItemClick);
            // 
            // DM_buttonKhachHang
            // 
            this.DM_buttonKhachHang.Caption = "Khách Hàng";
            this.DM_buttonKhachHang.Id = 4;
            this.DM_buttonKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DM_buttonKhachHang.ImageOptions.Image")));
            this.DM_buttonKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DM_buttonKhachHang.ImageOptions.LargeImage")));
            this.DM_buttonKhachHang.LargeWidth = 140;
            this.DM_buttonKhachHang.Name = "DM_buttonKhachHang";
            this.DM_buttonKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DM_buttonKhachHang_ItemClick);
            // 
            // DM_buttonNhanVien
            // 
            this.DM_buttonNhanVien.Caption = "Nhân Viên";
            this.DM_buttonNhanVien.Id = 5;
            this.DM_buttonNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DM_buttonNhanVien.ImageOptions.Image")));
            this.DM_buttonNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DM_buttonNhanVien.ImageOptions.LargeImage")));
            this.DM_buttonNhanVien.LargeWidth = 140;
            this.DM_buttonNhanVien.Name = "DM_buttonNhanVien";
            this.DM_buttonNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DM_buttonNhanVien_ItemClick);
            // 
            // NV_buttonMoTaiKhoan
            // 
            this.NV_buttonMoTaiKhoan.Caption = "Mở Tài Khoản";
            this.NV_buttonMoTaiKhoan.Id = 6;
            this.NV_buttonMoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NV_buttonMoTaiKhoan.ImageOptions.Image")));
            this.NV_buttonMoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NV_buttonMoTaiKhoan.ImageOptions.LargeImage")));
            this.NV_buttonMoTaiKhoan.LargeWidth = 140;
            this.NV_buttonMoTaiKhoan.Name = "NV_buttonMoTaiKhoan";
            // 
            // NV_butotnGuiVaRut
            // 
            this.NV_butotnGuiVaRut.Caption = "Gửi Và Rút";
            this.NV_butotnGuiVaRut.Id = 7;
            this.NV_butotnGuiVaRut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NV_butotnGuiVaRut.ImageOptions.Image")));
            this.NV_butotnGuiVaRut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NV_butotnGuiVaRut.ImageOptions.LargeImage")));
            this.NV_butotnGuiVaRut.LargeWidth = 140;
            this.NV_butotnGuiVaRut.Name = "NV_butotnGuiVaRut";
            // 
            // NV_buttonChuyenKhoan
            // 
            this.NV_buttonChuyenKhoan.Caption = "Chuyển Khoản";
            this.NV_buttonChuyenKhoan.Id = 8;
            this.NV_buttonChuyenKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NV_buttonChuyenKhoan.ImageOptions.Image")));
            this.NV_buttonChuyenKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NV_buttonChuyenKhoan.ImageOptions.LargeImage")));
            this.NV_buttonChuyenKhoan.LargeWidth = 140;
            this.NV_buttonChuyenKhoan.Name = "NV_buttonChuyenKhoan";
            // 
            // BC_buttonSaoKeTaiKhoan
            // 
            this.BC_buttonSaoKeTaiKhoan.Caption = "Sao Kê Tài Khoản";
            this.BC_buttonSaoKeTaiKhoan.Id = 9;
            this.BC_buttonSaoKeTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BC_buttonSaoKeTaiKhoan.ImageOptions.Image")));
            this.BC_buttonSaoKeTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BC_buttonSaoKeTaiKhoan.ImageOptions.LargeImage")));
            this.BC_buttonSaoKeTaiKhoan.LargeWidth = 140;
            this.BC_buttonSaoKeTaiKhoan.Name = "BC_buttonSaoKeTaiKhoan";
            // 
            // BC_buttonDSMTK
            // 
            this.BC_buttonDSMTK.Caption = "Danh Sách Mở Tài Khoản";
            this.BC_buttonDSMTK.Id = 10;
            this.BC_buttonDSMTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BC_buttonDSMTK.ImageOptions.Image")));
            this.BC_buttonDSMTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BC_buttonDSMTK.ImageOptions.LargeImage")));
            this.BC_buttonDSMTK.LargeWidth = 140;
            this.BC_buttonDSMTK.Name = "BC_buttonDSMTK";
            // 
            // BC_buttonTKTTKH
            // 
            this.BC_buttonTKTTKH.Caption = "Thống Kê Thông Tin Khách Hàng";
            this.BC_buttonTKTTKH.Id = 11;
            this.BC_buttonTKTTKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BC_buttonTKTTKH.ImageOptions.Image")));
            this.BC_buttonTKTTKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BC_buttonTKTTKH.ImageOptions.LargeImage")));
            this.BC_buttonTKTTKH.LargeWidth = 140;
            this.BC_buttonTKTTKH.Name = "BC_buttonTKTTKH";
            this.BC_buttonTKTTKH.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing;
            this.BC_buttonTKTTKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BC_buttonTKTTKH_ItemClick);
            // 
            // HT
            // 
            this.HT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HT.Name = "HT";
            this.HT.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.HT_buttonDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.HT_buttonDangKy);
            this.ribbonPageGroup1.ItemLinks.Add(this.HT_buttonTaoTaiKhoan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ Thống";
            // 
            // DM
            // 
            this.DM.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.DM.Name = "DM";
            this.DM.Text = "Danh Mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.DM_buttonKhachHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.DM_buttonNhanVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh Mục";
            // 
            // NV
            // 
            this.NV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.NV.Name = "NV";
            this.NV.Text = "Nghiệp Vụ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.NV_buttonMoTaiKhoan);
            this.ribbonPageGroup3.ItemLinks.Add(this.NV_butotnGuiVaRut);
            this.ribbonPageGroup3.ItemLinks.Add(this.NV_buttonChuyenKhoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Nghiệp Vụ";
            // 
            // BC
            // 
            this.BC.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.BC.Name = "BC";
            this.BC.Text = "Báo Cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.BC_buttonSaoKeTaiKhoan);
            this.ribbonPageGroup4.ItemLinks.Add(this.BC_buttonDSMTK);
            this.ribbonPageGroup4.ItemLinks.Add(this.BC_buttonTKTTKH);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STS_MANV,
            this.STS_HOVATEN,
            this.STS_NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // STS_MANV
            // 
            this.STS_MANV.Name = "STS_MANV";
            this.STS_MANV.Size = new System.Drawing.Size(52, 20);
            this.STS_MANV.Text = "MANV";
            // 
            // STS_HOVATEN
            // 
            this.STS_HOVATEN.Name = "STS_HOVATEN";
            this.STS_HOVATEN.Size = new System.Drawing.Size(75, 20);
            this.STS_HOVATEN.Text = "HOVATEN";
            // 
            // STS_NHOM
            // 
            this.STS_NHOM.Name = "STS_NHOM";
            this.STS_NHOM.Size = new System.Drawing.Size(55, 20);
            this.STS_NHOM.Text = "NHOM";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Ngân Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage HT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem HT_buttonDangNhap;
        private DevExpress.XtraBars.BarButtonItem HT_buttonDangKy;
        private DevExpress.XtraBars.BarButtonItem HT_buttonTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem DM_buttonKhachHang;
        private DevExpress.XtraBars.BarButtonItem DM_buttonNhanVien;
        private DevExpress.XtraBars.BarButtonItem NV_buttonMoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem NV_butotnGuiVaRut;
        private DevExpress.XtraBars.BarButtonItem NV_buttonChuyenKhoan;
        private DevExpress.XtraBars.BarButtonItem BC_buttonSaoKeTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem BC_buttonDSMTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage DM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage NV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage BC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem BC_buttonTKTTKH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel STS_MANV;
        private System.Windows.Forms.ToolStripStatusLabel STS_HOVATEN;
        private System.Windows.Forms.ToolStripStatusLabel STS_NHOM;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

