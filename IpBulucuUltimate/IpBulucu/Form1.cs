using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace IpBulucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public delegate void delege();

        public void IPScanner()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = lstAdres.Items.Count;
            for (int i = 0; i < lstAdres.Items.Count; i++)
            {
                IPHostEntry siteadi = Dns.GetHostEntry(lstAdres.Items[i].ToString());
                IPAddress[] ip = siteadi.AddressList;
                lstIp.Items.Add(ip[0]);
                lstIp.SelectedIndex = i;
                lblIPSatirSayisi.Text = lstIp.Items.Count.ToString();
                progressBar1.Value = lstIp.Items.Count;
            }
            if (lstAdres.Items.Count == lstIp.Items.Count) lblDurum.Text = "Bitti!";
            if (lblDurum.Text == "Bitti!")
            {
                btnTemizle.Enabled = true;
                btnKaydet.Enabled = true;
            }
        }

        public void Ekle()
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            string Adres;
            while ((Adres = sr.ReadLine()) != null)
            {
               if(ceAyniAdresleriSil.Checked == true)
               { 
                   if (!lstAdres.Items.Contains(Adres))
                   lstAdres.Items.Add(Adres.ToString());
               }
               else
                   lstAdres.Items.Add(Adres.ToString());
                lblAdresSatirSayisi.Text = lstAdres.Items.Count.ToString();
            }
            if (lstAdres.Items.Count.ToString() == lblAdresSatirSayisi.Text)
                btnSorgula.Enabled = true;
        }
       
        private void btnListeEkle_Click(object sender, EventArgs e)
        {
           try
                {
                    openFileDialog1.FileName = "Liste Seçiniz";
                    openFileDialog1.Filter = "Yazı Dosyası (.txt) | *.txt";
                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;


                    lstAdres.Items.Clear();

                    delege ch2 = new delege(Ekle);
                    ch2.BeginInvoke(null, null);

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (lstAdres.Items.Count == 0)
            {
                MessageBox.Show("Liste seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                lblDurum.Text = "Taranıyor...";
                delege ch1 = new delege(IPScanner);
                ch1.BeginInvoke(null, null);
                
               
                btnSorgula.Enabled = false;
                btnListeEkle.Enabled = false;
                btnTemizle.Enabled = false;
                btnKaydet.Enabled = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstAdres.Items.Clear();
            lstIp.Items.Clear();
            lblAdresSatirSayisi.Text = "0";
            lblIPSatirSayisi.Text = "0";
            btnListeEkle.Focus();
            btnListeEkle.Enabled = true;
            btnSorgula.Enabled = false;
            progressBar1.Value = 0;
            lblDurum.Text = "Bekliyor";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "*";
                saveFileDialog1.Filter = "Yazı Dosyası (*txt) |*.txt";
                saveFileDialog1.DefaultExt = "txt";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                string adres = "", ip = "";
                for (int i = 0; i < lstAdres.Items.Count; i++)
                {
                    adres = lstAdres.Items[i].ToString();
                    ip = lstIp.Items[i].ToString();
                    sw.WriteLine(adres);
                    sw.WriteLine(ip);
                    sw.WriteLine("");
                }
                sw.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstAdres_DoubleClick(object sender, EventArgs e)
        {
            if(lstAdres.Items != null)
                System.Diagnostics.Process.Start(lstAdres.SelectedItem.ToString());
        }

        private void lstAdres_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void DropEkle()
        {
            try
            {
                int i;
                for (i = 0; i < s1.Length; i++)
                {
                    StreamReader sr = new StreamReader(s1[i]);
                    string Adres;
                    while ((Adres = sr.ReadLine()) != null)
                    {
                        if (ceAyniAdresleriSil.Checked == true)
                        {
                            if (!lstAdres.Items.Contains(Adres))
                                lstAdres.Items.Add(Adres.ToString());
                        }
                        else
                            lstAdres.Items.Add(Adres.ToString());
                        lblAdresSatirSayisi.Text = lstAdres.Items.Count.ToString();
                    }
                }

                if (lstAdres.Items.Count.ToString() == lblAdresSatirSayisi.Text)
                    btnSorgula.Enabled = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        string[] s1;
        private void lstAdres_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                lstAdres.Items.Clear();
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                s1 = s;
                delege ch3 = new delege(DropEkle);
                ch3.BeginInvoke(null, null);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


        }
        hakkinda hkkda;
        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            hkkda = new hakkinda();
            hkkda.Show();
            
        }
    }
}
