namespace QL_BanHangThuanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnhacungcap = new System.Windows.Forms.Label();
            this.lbhanghoa = new System.Windows.Forms.Label();
            this.lbkhachhang = new System.Windows.Forms.Label();
            this.lbnhanvien = new System.Windows.Forms.Label();
            this.lbhoadon = new System.Windows.Forms.Label();
            this.lbbaocao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1151, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tậpTinToolStripMenuItem
            // 
            this.tậpTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuLogout,
            this.mnuThoat});
            this.tậpTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tậpTinToolStripMenuItem.Name = "tậpTinToolStripMenuItem";
            this.tậpTinToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.tậpTinToolStripMenuItem.Text = "Hệ thống";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(180, 26);
            this.mnuLogout.Text = "Đăng xuất";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(180, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(389, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BÁN HÀNG";
            // 
            // lbnhacungcap
            // 
            this.lbnhacungcap.Image = ((System.Drawing.Image)(resources.GetObject("lbnhacungcap.Image")));
            this.lbnhacungcap.Location = new System.Drawing.Point(311, 153);
            this.lbnhacungcap.Name = "lbnhacungcap";
            this.lbnhacungcap.Size = new System.Drawing.Size(153, 153);
            this.lbnhacungcap.TabIndex = 2;
            this.lbnhacungcap.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbhanghoa
            // 
            this.lbhanghoa.Image = ((System.Drawing.Image)(resources.GetObject("lbhanghoa.Image")));
            this.lbhanghoa.Location = new System.Drawing.Point(311, 335);
            this.lbhanghoa.Name = "lbhanghoa";
            this.lbhanghoa.Size = new System.Drawing.Size(153, 153);
            this.lbhanghoa.TabIndex = 3;
            this.lbhanghoa.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbkhachhang
            // 
            this.lbkhachhang.Image = ((System.Drawing.Image)(resources.GetObject("lbkhachhang.Image")));
            this.lbkhachhang.Location = new System.Drawing.Point(528, 153);
            this.lbkhachhang.Name = "lbkhachhang";
            this.lbkhachhang.Size = new System.Drawing.Size(153, 153);
            this.lbkhachhang.TabIndex = 4;
            this.lbkhachhang.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbnhanvien
            // 
            this.lbnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("lbnhanvien.Image")));
            this.lbnhanvien.Location = new System.Drawing.Point(528, 335);
            this.lbnhanvien.Name = "lbnhanvien";
            this.lbnhanvien.Size = new System.Drawing.Size(153, 153);
            this.lbnhanvien.TabIndex = 5;
            this.lbnhanvien.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbhoadon
            // 
            this.lbhoadon.Image = ((System.Drawing.Image)(resources.GetObject("lbhoadon.Image")));
            this.lbhoadon.Location = new System.Drawing.Point(733, 153);
            this.lbhoadon.Name = "lbhoadon";
            this.lbhoadon.Size = new System.Drawing.Size(153, 153);
            this.lbhoadon.TabIndex = 6;
            this.lbhoadon.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbbaocao
            // 
            this.lbbaocao.Image = ((System.Drawing.Image)(resources.GetObject("lbbaocao.Image")));
            this.lbbaocao.Location = new System.Drawing.Point(733, 335);
            this.lbbaocao.Name = "lbbaocao";
            this.lbbaocao.Size = new System.Drawing.Size(153, 153);
            this.lbbaocao.TabIndex = 7;
            this.lbbaocao.Click += new System.EventHandler(this.lbbaocao_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 613);
            this.Controls.Add(this.lbbaocao);
            this.Controls.Add(this.lbhoadon);
            this.Controls.Add(this.lbnhanvien);
            this.Controls.Add(this.lbkhachhang);
            this.Controls.Add(this.lbhanghoa);
            this.Controls.Add(this.lbnhacungcap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng bán laptop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Label lbnhacungcap;
        private System.Windows.Forms.Label lbhanghoa;
        private System.Windows.Forms.Label lbkhachhang;
        private System.Windows.Forms.Label lbnhanvien;
        private System.Windows.Forms.Label lbhoadon;
        private System.Windows.Forms.Label lbbaocao;
    }
}

