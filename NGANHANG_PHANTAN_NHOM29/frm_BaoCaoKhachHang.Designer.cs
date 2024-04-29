namespace NGANHANG_PHANTAN_NHOM29
{
    partial class frm_BaoCaoKhachHang
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.BCKB_buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BCKH_comboboxChiNhanh = new System.Windows.Forms.ComboBox();
            this.KH_panelControlChiNhanh = new System.Windows.Forms.Label();
            this.BC_buttonXemToanBo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.BC_buttonXemToanBo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.BCKB_buttonClose);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.BCKH_comboboxChiNhanh);
            this.panelControl1.Controls.Add(this.KH_panelControlChiNhanh);
            this.panelControl1.Location = new System.Drawing.Point(-1, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1093, 349);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "XEM BÁO CÁO KHÁCH HÀNG";
            // 
            // BCKB_buttonClose
            // 
            this.BCKB_buttonClose.BackColor = System.Drawing.Color.Red;
            this.BCKB_buttonClose.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.BCKB_buttonClose.ForeColor = System.Drawing.Color.White;
            this.BCKB_buttonClose.Location = new System.Drawing.Point(667, 266);
            this.BCKB_buttonClose.Name = "BCKB_buttonClose";
            this.BCKB_buttonClose.Size = new System.Drawing.Size(155, 44);
            this.BCKB_buttonClose.TabIndex = 7;
            this.BCKB_buttonClose.Text = "Thoát";
            this.BCKB_buttonClose.UseVisualStyleBackColor = false;
            this.BCKB_buttonClose.Click += new System.EventHandler(this.BCKB_buttonClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(330, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BCKH_comboboxChiNhanh
            // 
            this.BCKH_comboboxChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BCKH_comboboxChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCKH_comboboxChiNhanh.FormattingEnabled = true;
            this.BCKH_comboboxChiNhanh.Location = new System.Drawing.Point(379, 175);
            this.BCKH_comboboxChiNhanh.Name = "BCKH_comboboxChiNhanh";
            this.BCKH_comboboxChiNhanh.Size = new System.Drawing.Size(369, 31);
            this.BCKH_comboboxChiNhanh.TabIndex = 3;
            this.BCKH_comboboxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.BCKH_comboboxChiNhanh_SelectedIndexChanged);
            // 
            // KH_panelControlChiNhanh
            // 
            this.KH_panelControlChiNhanh.AutoSize = true;
            this.KH_panelControlChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KH_panelControlChiNhanh.Location = new System.Drawing.Point(172, 178);
            this.KH_panelControlChiNhanh.Name = "KH_panelControlChiNhanh";
            this.KH_panelControlChiNhanh.Size = new System.Drawing.Size(136, 23);
            this.KH_panelControlChiNhanh.TabIndex = 2;
            this.KH_panelControlChiNhanh.Text = "CHẾ ĐỘ XEM";
            this.KH_panelControlChiNhanh.Click += new System.EventHandler(this.KH_panelControlChiNhanh_Click);
            // 
            // BC_buttonXemToanBo
            // 
            this.BC_buttonXemToanBo.BackColor = System.Drawing.Color.Cyan;
            this.BC_buttonXemToanBo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC_buttonXemToanBo.ForeColor = System.Drawing.Color.White;
            this.BC_buttonXemToanBo.Location = new System.Drawing.Point(819, 167);
            this.BC_buttonXemToanBo.Name = "BC_buttonXemToanBo";
            this.BC_buttonXemToanBo.Size = new System.Drawing.Size(131, 43);
            this.BC_buttonXemToanBo.TabIndex = 10;
            this.BC_buttonXemToanBo.Text = "Toàn bộ";
            this.BC_buttonXemToanBo.UseVisualStyleBackColor = false;
            this.BC_buttonXemToanBo.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_BaoCaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 349);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_BaoCaoKhachHang";
            this.Text = "frm_BaoCaoKhachHang";
            this.Load += new System.EventHandler(this.frm_BaoCaoKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label KH_panelControlChiNhanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BCKB_buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BCKH_comboboxChiNhanh;
        private System.Windows.Forms.Button BC_buttonXemToanBo;
    }
}