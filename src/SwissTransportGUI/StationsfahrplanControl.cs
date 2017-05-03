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
            //SearchHelper(cbStation);
        }

        /// <summary>
        /// Hilft bei der vervollständigung der Eingabe.
        /// </summary>
        /// <param name="cb"></param>
        public async Task SearchHelper(ComboBox cb)
        {
            string text = cbStation.Text;
            await Task.Delay(500);
            if (text == cb.Text)
            {
                Stations Stations = _Transport.GetStations(cb.Text + ",");
                cb.Items.Clear();
                //cb.DropDownHeight = Stations.StationList.Count * cb.ItemHeight;
                cb.DroppedDown = true;
                cb.Items.AddRange(Stations.StationList.ToArray());
                /*foreach (Station Station in Stations.StationList)
                {
                    cb.Items.Add(Station);
                }*/
                cb.SelectionStart = cb.Text.Length;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
            Station Station = (Station)cbStation.SelectedItem;
            StationBoardRoot StationBoardRoot = _Transport.GetStationBoard(Station.Name, Station.Id);
            foreach (StationBoard StationBoard in StationBoardRoot.Entries)
            {
                lb.Items.Add(StationBoard);
            }
            lblStationName.Text = StationBoardRoot.Station.Name;
        }

        private async void cbStation_TextUpdate(object sender, EventArgs e)
        {
            await SearchHelper(cbStation);
           
        }
    }
}
