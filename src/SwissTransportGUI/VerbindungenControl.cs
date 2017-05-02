using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportGUI
{
    public partial class VerbindungenControl : UserControl
    {
        private ITransport Transport = new Transport();
        public VerbindungenControl()
        {
            InitializeComponent();
        }

        private void CbVon_TextChanged(object sender, EventArgs e)
        {
            Stations Stations = Transport.GetStations(cbVon.Text);
            cbVon.Items.Clear();
            foreach (Station s in Stations.StationList)
            {
                cbVon.Items.Add(s);
            }
            cbVon.DroppedDown = true;
            cbVon.SelectionStart = cbVon.Text.Length;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
