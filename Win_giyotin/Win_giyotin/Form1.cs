using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_giyotin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
        }
        Random rnd = new Random();
        public delegate void delege();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Rastgele()
        {
            try
            {
                SoundPlayer player = new SoundPlayer();
                string path = Application.StartupPath + "\\sound\\tiksesi.wav";
                player.SoundLocation = path;
                int sayac = 1;

                if(txtKacKisi.Text == "")
                {
                    while (true)
                    {
                        int gelenDeger = rnd.Next(0, lstListe1.Items.Count);

                        if (sayac < 6)
                        {
                            lstListe1.SelectedIndex = gelenDeger;
                            player.Play();
                            Thread.Sleep(500);
                            sayac++;
                        }
                        else
                            break;
                    }
                    lstListe2.Items.Add(lstListe1.SelectedItem);
                    lstListe1.Items.Remove(lstListe1.SelectedItem);
                    lblKisiSayisi.Text = lstListe1.Items.Count.ToString();
                    lblSatirSayisi2.Text = lstListe2.Items.Count.ToString();
                }


                else
                {
                    int kacKisi;
                    kacKisi = Convert.ToInt32(txtKacKisi.Text);
                
                    for (int i = 0; i < kacKisi; i++)
                    {
                        while (true)
                        {
                            int gelenDeger = rnd.Next(0, lstListe1.Items.Count);

                            if (sayac < 6)
                            {
                                lstListe1.SelectedIndex = gelenDeger;
                                player.Play();
                                Thread.Sleep(500);
                                sayac++;
                            }
                            else
                                break;
                        }
                        lstListe2.Items.Add(lstListe1.SelectedItem);
                        lstListe1.Items.Remove(lstListe1.SelectedItem);
                        lblKisiSayisi.Text = lstListe1.Items.Count.ToString();
                        lblSatirSayisi2.Text = lstListe2.Items.Count.ToString();
                        sayac = 0;
                    } 
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void btnRastgele_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(Rastgele);
            th1.Start();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            try
            {
                ofdListe.FileName = "Liste Seçiniz";
                ofdListe.Filter = "Yazı Dosyası (.txt) | *.txt";
                if (ofdListe.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

                lstListe1.Items.Clear();

                delege ch1 = new delege(Ekle);
                ch1.BeginInvoke(null, null);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        public void Ekle()
        {
            StreamReader sr = new StreamReader(ofdListe.FileName);
            textBox1.Text = ofdListe.FileName;
            string kisi;
            while ((kisi = sr.ReadLine()) != null)
            {
                if (!lstListe1.Items.Contains(kisi))
                    lstListe1.Items.Add(kisi.ToString());

                lblKisiSayisi.Text = lstListe1.Items.Count.ToString();
            }
        }

    }
}
