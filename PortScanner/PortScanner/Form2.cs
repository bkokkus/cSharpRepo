using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScanner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                var macAddress = networkInterface.GetPhysicalAddress().ToString();
                if (macAddress != string.Empty)
                {
                    lstListe.Items.Add("Mac Adres : " + macAddress);
                }
            }

            IPAddress[] ipHostAdress = Dns.GetHostAddresses(Dns.GetHostName());

            for (int i = 0; i < ipHostAdress.Length; i++)
            {
                lstListe.Items.Add("Local IP Adres : " + ipHostAdress[i].ToString());
            }
        }

        public void FormuKapat()
        {
            this.Close();
            this.Dispose();
        }
    }
}
