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
        private ITransport _Transport = new Transport();
        public VerbindungenControl()
        {
            InitializeComponent();
            lbConnections.Visible = false;
        }

        private void CbVon_TextChanged(object sender, EventArgs e)
        {
            /*cbVon.DroppedDown = true;
            cbVon.SelectedIndex = -1;
            cbVon.SelectionStart = cbVon.Text.Length;*/
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SearchHelper(cbVon);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchHelper(cbNach);
        }
        /// <summary>
        /// Hilft bei der vervollständigung der Eingabe.
        /// </summary>
        /// <param name="cb"></param>
        public void SearchHelper(ComboBox cb)
        {
            Stations Stations = _Transport.GetStations(cb.Text + ",");
            cb.Items.Clear();
            foreach (Station Station in Stations.StationList)
            {
                cb.Items.Add(Station);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connections Connections = _Transport.GetConnections(cbVon.Text, cbNach.Text);
            lbConnections.Items.Clear();
            foreach(Connection c in Connections.ConnectionList)
            {
                lbConnections.Items.Add(c);
            }
            lbConnections.Visible = true;
        }
    }
}
