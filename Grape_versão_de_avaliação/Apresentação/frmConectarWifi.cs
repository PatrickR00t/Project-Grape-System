using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grape_versão_de_avaliação
{
    public partial class frmConectarWifi : Form
    {
        public frmConectarWifi()
        {
            InitializeComponent();
        }

        bool mouseDown;
        Point lastLocaction;

        private void frmConectarWifi_Load(object sender, EventArgs e)
        {
            WlanClient client = new WlanClient();

            foreach (WlanClient.WlanInterface wlaninterface in client.Interfaces)
            {
                Wlan.WlanAvailableNetwork[] networks = wlaninterface.GetAvailableNetworkList(0);

                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    Wlan.Dot11Ssid ssid = network.dot11Ssid;
                    string networkname = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
                    ListViewItem item = new ListViewItem(networkname);
                    item.SubItems.Add(network.dot11DefaultCipherAlgorithm.ToString());
                    item.SubItems.Add(network.wlanSignalQuality + "%");
                    lvWifi.Items.Add(item);
                }
            }
        }

        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbBotãoFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConectarWifi_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void frmConectarWifi_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void frmConectarWifi_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
