using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace PortScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public delegate void delege();
        public void ListeDoldur()
        {
            #region Port Tarama , progress bar ve butonların enable falseleri
            int baslangic = Convert.ToInt32(txtBaslangic.Text);
            int bitis = Convert.ToInt32(txtBitis.Text);
            progressBar1.Minimum = baslangic;
            progressBar1.Maximum = bitis;

            for (int currPort = baslangic; currPort <= bitis; currPort++)
            {
                TcpClient tcpportScan = new TcpClient();
                tcpportScan.SendTimeout = 10;
                progressBar1.Value = currPort;
                try
                {
                    tcpportScan.Connect(txtIPAdres.Text, currPort);
                    lstPortListAcik.Items.Add("Port " + currPort);
                    if (btnIndex.Checked == true)
                    {
                        for (int i = 0; i < lstPortListAcik.Items.Count; i++)
                        {
                            lstPortListAcik.SelectedIndex = i;
                        }
                    }
                    lblAcik.Text = lstPortListAcik.Items.Count.ToString();
                }
                catch //(Exception hata)
                {
                    lstPortListKapali.Items.Add("Port " + currPort);
                    if (btnIndex.Checked == true)
                    {
                        for (int i = 0; i < lstPortListKapali.Items.Count; i++)
                        {
                            lstPortListKapali.SelectedIndex = i;
                        }
                    }
                    lblKapali.Text = lstPortListKapali.Items.Count.ToString();
                }
            }
            int acik = Convert.ToInt32(lblAcik.Text);
            int kapali = Convert.ToInt32(lblKapali.Text);
            if ((acik + kapali) == ((bitis - baslangic) + 1)) lblDurum.Text = "Bitti!";
            if (lblDurum.Text == "Bitti!")
            {
                btnTemizle.Enabled = true;
                btnKaydet.Enabled = true;

            }
            #endregion
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            #region Temizlemeler
            progressBar1.Minimum = 0;
            txtIPAdres.Text = "";
            txtBaslangic.Text = "";
            txtBitis.Text = "";
            lstPortListAcik.Items.Clear();
            lstPortListKapali.Items.Clear();
            progressBar1.Value = 0;
            txtIPAdres.Focus();
            btnTara.Enabled = true;
            txtBaslangic.Enabled = true;
            txtBitis.Enabled = true;
            txtIPAdres.Enabled = true;
            lblAcik.Text = "0";
            lblKapali.Text = "0";
            lblDurum.Text = "Bekliyor";
            #endregion
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                #region Save Dialog açtır ve kaydet
                saveFileDialog1.FileName = "*";
                saveFileDialog1.Filter = "Metin Dosyası (.txt) | *.txt";
                saveFileDialog1.DefaultExt = "txt";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

                #endregion

                #region streamWriter ile bilgi ve taramaları yazdır
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                string sonuc = "";
                sw.WriteLine("Taranan Adres :  " + txtIPAdres.Text);
                sw.WriteLine("");
                sw.WriteLine("Taranan Port Başlangıcı :  " + txtBaslangic.Text);
                sw.WriteLine("");
                sw.WriteLine("Taranan Port Bitişi :  " + txtBitis.Text);
                sw.WriteLine("");
                sw.WriteLine("Düşen(Açık) Portlar");
                sw.WriteLine("-----------------------------------------------------------");
                sw.WriteLine("");
                if (lstPortListAcik.Items.Count != 0)
                {
                    for (int i = 0; i < lstPortListAcik.Items.Count; i++)
                    {
                        sonuc = lstPortListAcik.Items[i].ToString();
                        sw.WriteLine(sonuc);
                        sw.WriteLine("");
                    }
                }
                else
                    sw.WriteLine("Açık Port Bulunamadı!");

                sw.Close();
                #endregion
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnTara_Click(object sender, EventArgs e)
        {
            if (txtIPAdres.Text == "")
            {
                MessageBox.Show("Bir IP Adres girmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                lblDurum.Text = "Taranıyor...";
                delege ch1 = new delege(ListeDoldur);
                ch1.BeginInvoke(null, null);

                btnTara.Enabled = false;
                txtBaslangic.Enabled = false;
                txtBitis.Enabled = false;
                txtIPAdres.Enabled = false;
                btnTemizle.Enabled = false;
                btnKaydet.Enabled = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        Form2 frm2;
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            frm2.FormuKapat();
        }
        private void btnIPMac_Click_1(object sender, EventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
                frm2 = new Form2();
            frm2.Show();
        }
        private void TusEngelle(object sender, KeyPressEventArgs e)
        { 
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
                e.Handled = false;//eğer 47 -58 arasındaysa tuşu yazdır.
            else if ((int)e.KeyChar == 8 || e.KeyChar.ToString() == ".")
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            else
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bekir Kökkuş\nwww.bekirkokkkus.com","Hakkında",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }
}
