namespace Win_giyotin
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
            this.lstListe1 = new System.Windows.Forms.ListBox();
            this.lstListe2 = new System.Windows.Forms.ListBox();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAc = new System.Windows.Forms.Button();
            this.ofdListe = new System.Windows.Forms.OpenFileDialog();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKacKisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSatirSayisi2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstListe1
            // 
            this.lstListe1.FormattingEnabled = true;
            this.lstListe1.Location = new System.Drawing.Point(12, 42);
            this.lstListe1.Name = "lstListe1";
            this.lstListe1.Size = new System.Drawing.Size(205, 225);
            this.lstListe1.TabIndex = 0;
            // 
            // lstListe2
            // 
            this.lstListe2.FormattingEnabled = true;
            this.lstListe2.Location = new System.Drawing.Point(227, 42);
            this.lstListe2.Name = "lstListe2";
            this.lstListe2.Size = new System.Drawing.Size(205, 225);
            this.lstListe2.TabIndex = 1;
            // 
            // btnRastgele
            // 
            this.btnRastgele.Location = new System.Drawing.Point(366, 11);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(66, 23);
            this.btnRastgele.TabIndex = 2;
            this.btnRastgele.Text = "Seç";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(140, 12);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 23);
            this.btnAc.TabIndex = 4;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // ofdListe
            // 
            this.ofdListe.FileName = "openFileDialog1";
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(76, 273);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(13, 13);
            this.lblKisiSayisi.TabIndex = 5;
            this.lblKisiSayisi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Satır Sayısı : ";
            // 
            // txtKacKisi
            // 
            this.txtKacKisi.Location = new System.Drawing.Point(287, 14);
            this.txtKacKisi.Name = "txtKacKisi";
            this.txtKacKisi.Size = new System.Drawing.Size(73, 20);
            this.txtKacKisi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kaç Kişi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Satır Sayısı : ";
            // 
            // lblSatirSayisi2
            // 
            this.lblSatirSayisi2.AutoSize = true;
            this.lblSatirSayisi2.Location = new System.Drawing.Point(293, 273);
            this.lblSatirSayisi2.Name = "lblSatirSayisi2";
            this.lblSatirSayisi2.Size = new System.Drawing.Size(13, 13);
            this.lblSatirSayisi2.TabIndex = 10;
            this.lblSatirSayisi2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 295);
            this.Controls.Add(this.lblSatirSayisi2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKacKisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.lstListe2);
            this.Controls.Add(this.lstListe1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giyotin v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListe1;
        private System.Windows.Forms.ListBox lstListe2;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.OpenFileDialog ofdListe;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKacKisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSatirSayisi2;
    }
}

