namespace PortScanner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTara = new System.Windows.Forms.Button();
            this.lstPortListAcik = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.lstPortListKapali = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAcik = new System.Windows.Forms.Label();
            this.lblKapali = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIPMac = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKaydetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTemizleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Adres ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ile";
            // 
            // txtIPAdres
            // 
            this.txtIPAdres.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtIPAdres.ForeColor = System.Drawing.Color.Lime;
            this.txtIPAdres.Location = new System.Drawing.Point(62, 31);
            this.txtIPAdres.Name = "txtIPAdres";
            this.txtIPAdres.Size = new System.Drawing.Size(149, 20);
            this.txtIPAdres.TabIndex = 0;
            this.txtIPAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TusEngelle);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // btnTara
            // 
            this.btnTara.Location = new System.Drawing.Point(12, 94);
            this.btnTara.Name = "btnTara";
            this.btnTara.Size = new System.Drawing.Size(61, 22);
            this.btnTara.TabIndex = 3;
            this.btnTara.Text = "Tara";
            this.btnTara.UseVisualStyleBackColor = true;
            this.btnTara.Click += new System.EventHandler(this.btnTara_Click);
            // 
            // lstPortListAcik
            // 
            this.lstPortListAcik.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstPortListAcik.ForeColor = System.Drawing.Color.Lime;
            this.lstPortListAcik.FormattingEnabled = true;
            this.lstPortListAcik.Location = new System.Drawing.Point(12, 141);
            this.lstPortListAcik.Name = "lstPortListAcik";
            this.lstPortListAcik.Size = new System.Drawing.Size(83, 134);
            this.lstPortListAcik.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(150, 94);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(61, 22);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(81, 94);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(61, 22);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 280);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(135, 12);
            this.progressBar1.TabIndex = 12;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Port Scanner Listeni Kaydet";
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtBaslangic.ForeColor = System.Drawing.Color.Lime;
            this.txtBaslangic.Location = new System.Drawing.Point(62, 63);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(60, 20);
            this.txtBaslangic.TabIndex = 1;
            this.txtBaslangic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBaslangic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TusEngelle);
            // 
            // txtBitis
            // 
            this.txtBitis.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtBitis.ForeColor = System.Drawing.Color.Lime;
            this.txtBitis.Location = new System.Drawing.Point(151, 63);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(60, 20);
            this.txtBitis.TabIndex = 2;
            this.txtBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBitis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TusEngelle);
            // 
            // lstPortListKapali
            // 
            this.lstPortListKapali.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstPortListKapali.ForeColor = System.Drawing.Color.Lime;
            this.lstPortListKapali.FormattingEnabled = true;
            this.lstPortListKapali.Location = new System.Drawing.Point(128, 141);
            this.lstPortListKapali.Name = "lstPortListKapali";
            this.lstPortListKapali.Size = new System.Drawing.Size(83, 134);
            this.lstPortListKapali.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Açık : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kapalı : ";
            // 
            // lblAcik
            // 
            this.lblAcik.AutoSize = true;
            this.lblAcik.Location = new System.Drawing.Point(46, 123);
            this.lblAcik.Name = "lblAcik";
            this.lblAcik.Size = new System.Drawing.Size(13, 13);
            this.lblAcik.TabIndex = 17;
            this.lblAcik.Text = "0";
            // 
            // lblKapali
            // 
            this.lblKapali.AutoSize = true;
            this.lblKapali.Location = new System.Drawing.Point(167, 123);
            this.lblKapali.Name = "lblKapali";
            this.lblKapali.Size = new System.Drawing.Size(13, 13);
            this.lblKapali.TabIndex = 18;
            this.lblKapali.Text = "0";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(149, 279);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 13);
            this.lblDurum.TabIndex = 19;
            this.lblDurum.Text = "Bekliyor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu,
            this.görünümToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(221, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenu
            // 
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIPMac,
            this.btnIndex,
            this.btnKaydetMenu});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 20);
            this.btnMenu.Text = "Menü";
            // 
            // btnIPMac
            // 
            this.btnIPMac.Name = "btnIPMac";
            this.btnIPMac.Size = new System.Drawing.Size(179, 22);
            this.btnIPMac.Text = "Local IP Mac";
            this.btnIPMac.Click += new System.EventHandler(this.btnIPMac_Click_1);
            // 
            // btnIndex
            // 
            this.btnIndex.CheckOnClick = true;
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(179, 22);
            this.btnIndex.Text = "Listeleri Indexle Dön";
            // 
            // btnKaydetMenu
            // 
            this.btnKaydetMenu.Name = "btnKaydetMenu";
            this.btnKaydetMenu.Size = new System.Drawing.Size(179, 22);
            this.btnKaydetMenu.Text = "Kaydet";
            this.btnKaydetMenu.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTemizleMenu});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // btnTemizleMenu
            // 
            this.btnTemizleMenu.Name = "btnTemizleMenu";
            this.btnTemizleMenu.Size = new System.Drawing.Size(152, 22);
            this.btnTemizleMenu.Text = "Temizle";
            this.btnTemizleMenu.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 300);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKapali);
            this.Controls.Add(this.lblAcik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstPortListKapali);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.txtBaslangic);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstPortListAcik);
            this.Controls.Add(this.btnTara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIPAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Scanner v1.0.0 ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTara;
        private System.Windows.Forms.ListBox lstPortListAcik;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.ListBox lstPortListKapali;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAcik;
        private System.Windows.Forms.Label lblKapali;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnIndex;
        private System.Windows.Forms.ToolStripMenuItem btnIPMac;
        private System.Windows.Forms.ToolStripMenuItem btnKaydetMenu;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTemizleMenu;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}

