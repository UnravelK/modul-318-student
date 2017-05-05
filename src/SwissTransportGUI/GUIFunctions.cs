using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportGUI
{
    /// <summary>
    /// Stellt funktionen für das GUI zur verfügung.
    /// </summary>
    class GUIFunctions
    {
        private ITransport _Transport = new Transport();
        private static GUIFunctions _Instance = null;

        private GUIFunctions() { }

        /// <summary>
        /// Prüft ob bereits eine Instanz vorhanden ist, erstellt sie gegebenenfalls und gibt sie zurück.
        /// </summary>
        /// <returns>Die GUIFunctions Instanz.</returns>
        internal static GUIFunctions GetInstance()
        {
            if (_Instance == null) _Instance = new GUIFunctions();
            return _Instance;
        }

        /// <summary>
        /// Bietet eine Vervollständigungsauswahl von Stationen in einer ComboBox an.
        /// </summary>
        /// <param name="cbTarget">Die ComboBox welche die Suchhilfe erhalten soll.</param>
        public async Task SearchStationsHelper(ComboBox cbTarget)
        {
            string oldText = cbTarget.Text;
            await Task.Delay(500);
            if (oldText == cbTarget.Text && cbTarget.SelectedIndex == -1)
            {
                Stations Stations = _Transport.GetStations(cbTarget.Text + ",");
                cbTarget.Items.Clear();
                cbTarget.DroppedDown = true;
                cbTarget.Items.AddRange(Stations.StationList.ToArray());
                cbTarget.SelectionStart = cbTarget.Text.Length;
            }
        }

        /// <summary>
        /// Zeigt die Stationsanzeige in einer ListBox an.
        /// </summary>
        /// <param name="lbTarget">Die ListBox welche die Stationen anzeigen soll.</param>
        /// <param name="lblLocation">Das Label welches den Standort der Resultate anzeigt.</param>
        /// <param name="objStation">Die Station von welcher die momentane Anzeige angezeigt werden soll. Muss als Station gecastet werden können.</param>
        /// <param name="displayMap">Gibt an ob die Karte angezeigt werden soll.</param>
        public void DisplayStationBoard(ListView lvTarget, Label lblLocation, object objStation)
        {
            Station Station = (Station)objStation;
            StationBoardInfo StationBoardInfo;
            StationBoardRoot StationBoardRoot = _Transport.GetStationBoard(Station.Name, Station.Id);
            lvTarget.Items.Clear();
            foreach (StationBoard StationBoard in StationBoardRoot.Entries)
            {
                StationBoardInfo = new StationBoardInfo(StationBoard);
                lvTarget.Items.Add(new ListViewItem(StationBoardInfo.GetInfos()));
            }
            lblLocation.Text = StationBoardRoot.Station.Name;
            lblLocation.Visible = true;
            lvTarget.Visible = true;
        }

        /// <summary>
        /// Zeigt die erhaltenen Verbindungen in einer ListBox an.
        /// </summary>
        /// <param name="lvTarget">Die ListView in welcher die Verbindungen angezeigt werden.</param>
        /// <param name="startStation">Name der Station von welcher gestartet werden soll.</param>
        /// <param name="targetStation">Name der Station zu welcher gefahren werden möchte.</param>
        public void DisplayConnections(ListView lvTarget, string startStation, string targetStaion, DateTime dtDate)
        {
            Connections Connections = _Transport.GetConnections(startStation, targetStaion, dtDate);
            ConnectionInfo ConnectionInfo;
            lvTarget.Items.Clear();
            foreach (Connection Connection in Connections.ConnectionList)
            {
                ConnectionInfo = new ConnectionInfo(Connection);
                lvTarget.Items.Add(new ListViewItem(ConnectionInfo.GetInfos()));
            }
            lvTarget.Visible = true;
        }
    }
}
