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
    public partial class StationsfahrplanControl : UserControl
    {
        private ITransport _Transport = new Transport();
        public StationsfahrplanControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchHelper(cbStation);
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

        private void button2_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
            Station Station = (Station)cbStation.SelectedItem;
            StationBoardRoot StationBoardRoot = _Transport.GetStationBoard(Station.Name, Station.Id);
            foreach(StationBoard StationBoard in StationBoardRoot.Entries)
            {
                lb.Items.Add(StationBoard);
            }
            lblStationName.Text = StationBoardRoot.Station.Name;
        }
    }
}
