using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    class GUIFunctions
    {
        private ITransport _Transport = new Transport();

        public GUIFunctions() { }

        /// <summary>
        /// Hilft bei der vervollständigung der Eingabe von Stationen in einer ComboBox.
        /// </summary>
        /// <param name="cbTarget">Die ComboBox welche die Suchhilfe erhalten soll.</param>
        public async Task SearchStationsHelper(ComboBox cbTarget)
        {
            string oldText = cbTarget.Text;
            await Task.Delay(500);
            if (oldText == cbTarget.Text)
            {
                Stations Stations = _Transport.GetStations(cbTarget.Text + ",");
                cbTarget.Items.Clear();
                cbTarget.DroppedDown = true;
                cbTarget.MaxDropDownItems = 12;
                cbTarget.Items.AddRange(Stations.StationList.ToArray());
                cbTarget.SelectionStart = cbTarget.Text.Length;
            }
        }

        /// <summary>
        /// Zeigt eine Stationsanzeige in einer ListBox an.
        /// </summary>
        /// <param name="lbTarget">Die ListBox welche die Stationen anzeigen soll.</param>
        /// <param name="lblLocation">Das Label welches den Standort der Resultate anzeigt.</param>
        /// <param name="objStation">Die Station von welcher die momentane Anzeige angezeigt werden soll. Muss als Station gecastet werden können.</param>
        public void DisplayStationBoard(ListBox lbTarget, Label lblLocation, object objStation)
        {
            Station Station = (Station)objStation;
            StationBoardRoot StationBoardRoot = _Transport.GetStationBoard(Station.Name, Station.Id);
            lbTarget.Items.Clear();
            lbTarget.Items.AddRange(StationBoardRoot.Entries.ToArray());
            lblLocation.Text = StationBoardRoot.Station.Name;
            lblLocation.Visible = true;
            lbTarget.Visible = true;
        }

        /// <summary>
        /// Zeigt die erhaltenen Verbindungen in einer ListBox an.
        /// </summary>
        /// <param name="lbTarget">Die ListBox in welcher die Verbindungen angezeigt werden.</param>
        /// <param name="startStation">Name der Station von welcher gestartet werden soll.</param>
        /// <param name="targetStation">Name der Station zu welcher gefahren werden möchte.</param>
        public void DisplayConnections(ListBox lbTarget, string startStation, string targetStaion)
        {
            Connections Connections = _Transport.GetConnections(startStation, targetStaion);
            lbTarget.Items.Clear();
            lbTarget.Items.AddRange(Connections.ConnectionList.ToArray());
            lbTarget.Visible = true;
        }
    }
}
