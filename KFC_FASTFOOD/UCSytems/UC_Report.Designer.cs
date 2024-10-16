namespace KFC_FASTFOOD.UCSytems
{
    partial class UC_Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpThongKeBaoCao = new System.Windows.Forms.GroupBox();
            this.grpRpDoanhThu = new System.Windows.Forms.GroupBox();
            this.btnRpDoanhThu = new Bunifu.Framework.UI.BunifuImageButton();
            this.grpRpHoaDon = new System.Windows.Forms.GroupBox();
            this.btnRpHoaDon = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.grpThongKeBaoCao.SuspendLayout();
            this.grpRpDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRpDoanhThu)).BeginInit();
            this.grpRpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRpHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongKeBaoCao
            // 
            this.grpThongKeBaoCao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpThongKeBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.grpThongKeBaoCao.Controls.Add(this.grpRpDoanhThu);
            this.grpThongKeBaoCao.Controls.Add(this.grpRpHoaDon);
            this.grpThongKeBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongKeBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpThongKeBaoCao.Location = new System.Drawing.Point(32, 4);
            this.grpThongKeBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongKeBaoCao.Name = "grpThongKeBaoCao";
            this.grpThongKeBaoCao.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongKeBaoCao.Size = new System.Drawing.Size(1137, 742);
            this.grpThongKeBaoCao.TabIndex = 7;
            this.grpThongKeBaoCao.TabStop = false;
            this.grpThongKeBaoCao.Text = "Thống kê - báo cáo";
            // 
            // grpRpDoanhThu
            // 
            this.grpRpDoanhThu.Controls.Add(this.btnRpDoanhThu);
            this.grpRpDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRpDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpRpDoanhThu.Location = new System.Drawing.Point(697, 74);
            this.grpRpDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.grpRpDoanhThu.Name = "grpRpDoanhThu";
            this.grpRpDoanhThu.Padding = new System.Windows.Forms.Padding(4);
            this.grpRpDoanhThu.Size = new System.Drawing.Size(256, 225);
            this.grpRpDoanhThu.TabIndex = 10;
            this.grpRpDoanhThu.TabStop = false;
            this.grpRpDoanhThu.Text = "Doanh thu";
            // 
            // btnRpDoanhThu
            // 
            this.btnRpDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.btnRpDoanhThu.Image = global::KFC_FASTFOOD.Properties.Resources.statistics_120px;
            this.btnRpDoanhThu.ImageActive = null;
            this.btnRpDoanhThu.Location = new System.Drawing.Point(45, 34);
            this.btnRpDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.btnRpDoanhThu.Name = "btnRpDoanhThu";
            this.btnRpDoanhThu.Size = new System.Drawing.Size(171, 167);
            this.btnRpDoanhThu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRpDoanhThu.TabIndex = 0;
            this.btnRpDoanhThu.TabStop = false;
            this.btnRpDoanhThu.Zoom = 10;
            this.btnRpDoanhThu.Click += new System.EventHandler(this.btnRpDoanhThu_Click);
            // 
            // grpRpHoaDon
            // 
            this.grpRpHoaDon.Controls.Add(this.btnRpHoaDon);
            this.grpRpHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRpHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpRpHoaDon.Location = new System.Drawing.Point(123, 74);
            this.grpRpHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.grpRpHoaDon.Name = "grpRpHoaDon";
            this.grpRpHoaDon.Padding = new System.Windows.Forms.Padding(4);
            this.grpRpHoaDon.Size = new System.Drawing.Size(256, 225);
            this.grpRpHoaDon.TabIndex = 2;
            this.grpRpHoaDon.TabStop = false;
            this.grpRpHoaDon.Text = "Hóa đơn";
            // 
            // btnRpHoaDon
            // 
            this.btnRpHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnRpHoaDon.Image = global::KFC_FASTFOOD.Properties.Resources.bill_120px;
            this.btnRpHoaDon.ImageActive = null;
            this.btnRpHoaDon.Location = new System.Drawing.Point(45, 34);
            this.btnRpHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnRpHoaDon.Name = "btnRpHoaDon";
            this.btnRpHoaDon.Size = new System.Drawing.Size(171, 167);
            this.btnRpHoaDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRpHoaDon.TabIndex = 0;
            this.btnRpHoaDon.TabStop = false;
            this.btnRpHoaDon.Zoom = 10;
            this.btnRpHoaDon.Click += new System.EventHandler(this.btnRpHoaDon_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpThongKeBaoCao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(1191, 762);
            this.grpThongKeBaoCao.ResumeLayout(false);
            this.grpRpDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRpDoanhThu)).EndInit();
            this.grpRpHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRpHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpThongKeBaoCao;
        private System.Windows.Forms.GroupBox grpRpHoaDon;
        private Bunifu.Framework.UI.BunifuImageButton btnRpHoaDon;
        private System.Windows.Forms.GroupBox grpRpDoanhThu;
        private Bunifu.Framework.UI.BunifuImageButton btnRpDoanhThu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
