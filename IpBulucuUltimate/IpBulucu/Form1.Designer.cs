namespace IpBulucu
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
            this.lstAdres = new System.Windows.Forms.ListBox();
            this.lstIp = new System.Windows.Forms.ListBox();
            this.btnListeEkle = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdresSatirSayisi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIPSatirSayisi = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDurum = new System.Windows.Forms.Label();
            this.ceAyniAdresleriSil = new System.Windows.Forms.CheckBox();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAdres
            // 
            this.lstAdres.AllowDrop = true;
            this.lstAdres.BackColor = System.Drawing.SystemColors.WindowText;
            this.lstAdres.ForeColor = System.Drawing.Color.Chartreuse;
            this.lstAdres.FormattingEnabled = true;
            this.lstAdres.Location = new System.Drawing.Point(8, 23);
            this.lstAdres.Name = "lstAdres";
            this.lstAdres.Size = new System.Drawing.Size(217, 121);
            this.lstAdres.TabIndex = 6;
            this.lstAdres.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAdres_DragDrop);
            this.lstAdres.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAdres_DragEnter);
            this.lstAdres.DoubleClick += new System.EventHandler(this.lstAdres_DoubleClick);
            // 
            // lstIp
            // 
            this.lstIp.BackColor = System.Drawing.SystemColors.WindowText;
            this.lstIp.ForeColor = System.Drawing.Color.Chartreuse;
            this.lstIp.FormattingEnabled = true;
            this.lstIp.Location = new System.Drawing.Point(234, 23);
            this.lstIp.Name = "lstIp";
            this.lstIp.Size = new System.Drawing.Size(138, 121);
            this.lstIp.TabIndex = 7;
            // 
            // btnListeEkle
            // 
            this.btnListeEkle.Location = new System.Drawing.Point(8, 168);
            this.btnListeEkle.Name = "btnListeEkle";
            this.btnListeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnListeEkle.TabIndex = 8;
            this.btnListeEkle.Text = "Liste Ekle";
            this.btnListeEkle.UseVisualStyleBackColor = true;
            this.btnListeEkle.Click += new System.EventHandler(this.btnListeEkle_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Enabled = false;
            this.btnSorgula.Location = new System.Drawing.Point(86, 168);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(75, 23);
            this.btnSorgula.TabIndex = 9;
            this.btnSorgula.Text = "IP Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(165, 168);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(243, 168);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Liste Seç";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "IP Scanner Listeni Kaydet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adresler :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "IP Adresler :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adres Satır Sayısı : ";
            // 
            // lblAdresSatirSayisi
            // 
            this.lblAdresSatirSayisi.AutoSize = true;
            this.lblAdresSatirSayisi.Location = new System.Drawing.Point(102, 147);
            this.lblAdresSatirSayisi.Name = "lblAdresSatirSayisi";
            this.lblAdresSatirSayisi.Size = new System.Drawing.Size(13, 13);
            this.lblAdresSatirSayisi.TabIndex = 15;
            this.lblAdresSatirSayisi.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "IP Satır Sayısı : ";
            // 
            // lblIPSatirSayisi
            // 
            this.lblIPSatirSayisi.AutoSize = true;
            this.lblIPSatirSayisi.Location = new System.Drawing.Point(310, 147);
            this.lblIPSatirSayisi.Name = "lblIPSatirSayisi";
            this.lblIPSatirSayisi.Size = new System.Drawing.Size(13, 13);
            this.lblIPSatirSayisi.TabIndex = 17;
            this.lblIPSatirSayisi.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 197);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 10);
            this.progressBar1.TabIndex = 18;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblDurum.Location = new System.Drawing.Point(318, 194);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(43, 13);
            this.lblDurum.TabIndex = 19;
            this.lblDurum.Text = "Bekliyor";
            // 
            // ceAyniAdresleriSil
            // 
            this.ceAyniAdresleriSil.AutoSize = true;
            this.ceAyniAdresleriSil.Checked = true;
            this.ceAyniAdresleriSil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ceAyniAdresleriSil.Location = new System.Drawing.Point(62, 6);
            this.ceAyniAdresleriSil.Name = "ceAyniAdresleriSil";
            this.ceAyniAdresleriSil.Size = new System.Drawing.Size(103, 17);
            this.ceAyniAdresleriSil.TabIndex = 20;
            this.ceAyniAdresleriSil.Text = "Aynı Adresleri Sil";
            this.ceAyniAdresleriSil.UseVisualStyleBackColor = true;
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHakkinda.Location = new System.Drawing.Point(324, 168);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(29, 23);
            this.btnHakkinda.TabIndex = 21;
            this.btnHakkinda.Text = "?";
            this.btnHakkinda.UseVisualStyleBackColor = true;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 214);
            this.Controls.Add(this.btnHakkinda);
            this.Controls.Add(this.ceAyniAdresleriSil);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblIPSatirSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAdresSatirSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.btnListeEkle);
            this.Controls.Add(this.lstIp);
            this.Controls.Add(this.lstAdres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Scanner v1.0.1 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAdres;
        private System.Windows.Forms.ListBox lstIp;
        private System.Windows.Forms.Button btnListeEkle;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdresSatirSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIPSatirSayisi;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.CheckBox ceAyniAdresleriSil;
        private System.Windows.Forms.Button btnHakkinda;
    }
}

