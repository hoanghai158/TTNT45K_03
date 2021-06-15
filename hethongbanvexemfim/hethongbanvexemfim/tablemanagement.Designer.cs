namespace hethongbanvexemfim
{
    partial class tablemanagement
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpChair = new System.Windows.Forms.FlowLayoutPanel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbFilm = new System.Windows.Forms.ComboBox();
            this.btnAddSticket = new System.Windows.Forms.Button();
            this.nmAddSticket = new System.Windows.Forms.NumericUpDown();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnDisscount = new System.Windows.Forms.Button();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSwitchChair = new System.Windows.Forms.Button();
            this.cbSwitchChair = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddSticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.cbSwitchChair);
            this.panel2.Controls.Add(this.btnSwitchChair);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.btnDisscount);
            this.panel2.Controls.Add(this.btnBill);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(464, 539);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 79);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Location = new System.Drawing.Point(464, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 411);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.Controls.Add(this.nmAddSticket);
            this.panel4.Controls.Add(this.btnAddSticket);
            this.panel4.Controls.Add(this.cbFilm);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.ForeColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(464, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 81);
            this.panel4.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // flpChair
            // 
            this.flpChair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flpChair.Location = new System.Drawing.Point(0, 31);
            this.flpChair.Name = "flpChair";
            this.flpChair.Size = new System.Drawing.Size(458, 587);
            this.flpChair.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(223, 24);
            this.cbCategory.TabIndex = 0;
            // 
            // cbFilm
            // 
            this.cbFilm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(3, 43);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(223, 24);
            this.cbFilm.TabIndex = 1;
            // 
            // btnAddSticket
            // 
            this.btnAddSticket.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddSticket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddSticket.Location = new System.Drawing.Point(293, 4);
            this.btnAddSticket.Name = "btnAddSticket";
            this.btnAddSticket.Size = new System.Drawing.Size(75, 63);
            this.btnAddSticket.TabIndex = 2;
            this.btnAddSticket.Text = "Thêm vé";
            this.btnAddSticket.UseVisualStyleBackColor = false;
            this.btnAddSticket.Click += new System.EventHandler(this.btnAddSticket_Click);
            // 
            // nmAddSticket
            // 
            this.nmAddSticket.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nmAddSticket.ForeColor = System.Drawing.Color.Blue;
            this.nmAddSticket.Location = new System.Drawing.Point(402, 25);
            this.nmAddSticket.Name = "nmAddSticket";
            this.nmAddSticket.Size = new System.Drawing.Size(62, 22);
            this.nmAddSticket.TabIndex = 3;
            this.nmAddSticket.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAddSticket.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(283, 5);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 63);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Thanh toán";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisscount
            // 
            this.btnDisscount.Location = new System.Drawing.Point(151, 3);
            this.btnDisscount.Name = "btnDisscount";
            this.btnDisscount.Size = new System.Drawing.Size(75, 30);
            this.btnDisscount.TabIndex = 4;
            this.btnDisscount.Text = "Giảm giá";
            this.btnDisscount.UseVisualStyleBackColor = true;
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lsvBill.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lsvBill.Location = new System.Drawing.Point(3, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(483, 405);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numericUpDown1.ForeColor = System.Drawing.Color.Blue;
            this.numericUpDown1.Location = new System.Drawing.Point(151, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSwitchChair
            // 
            this.btnSwitchChair.Location = new System.Drawing.Point(3, 3);
            this.btnSwitchChair.Name = "btnSwitchChair";
            this.btnSwitchChair.Size = new System.Drawing.Size(96, 41);
            this.btnSwitchChair.TabIndex = 6;
            this.btnSwitchChair.Text = "Chọn ghế";
            this.btnSwitchChair.UseVisualStyleBackColor = true;
            // 
            // cbSwitchChair
            // 
            this.cbSwitchChair.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbSwitchChair.FormattingEnabled = true;
            this.cbSwitchChair.Location = new System.Drawing.Point(3, 44);
            this.cbSwitchChair.Name = "cbSwitchChair";
            this.cbSwitchChair.Size = new System.Drawing.Size(96, 24);
            this.cbSwitchChair.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(402, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 63);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // tablemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 630);
            this.Controls.Add(this.flpChair);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "tablemanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống bán vé xem fim";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddSticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmAddSticket;
        private System.Windows.Forms.Button btnAddSticket;
        private System.Windows.Forms.ComboBox cbFilm;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpChair;
        private System.Windows.Forms.Button btnDisscount;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cbSwitchChair;
        private System.Windows.Forms.Button btnSwitchChair;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}