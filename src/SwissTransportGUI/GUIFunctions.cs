using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Net;

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
            try
            {
                string oldText = cbTarget.Text;
                await Task.Delay(350);
                //Prüft ob sich der Text in den letzten 350 Millisekunden verändert hat, kein Item ausgewählt ist und ob der Text mindestens 3 Zeichen lang ist.
                if (oldText == cbTarget.Text && cbTarget.SelectedIndex == -1 && cbTarget.Text.Length > 3)
                {
                    Stations Stations = _Transport.GetStations(cbTarget.Text + ",");
                    if (cbTarget.Focused)
                    {
                        cbTarget.Items.Clear();
                        cbTarget.DroppedDown = true;
                        cbTarget.Items.AddRange(Stations.StationList.ToArray());
                        cbTarget.SelectionStart = cbTarget.Text.Length;
                    }
                    else return;
                }
            }
            catch (WebException Ex)
            {
                MessageBox.Show("Verbindung zum Webserver fehlgeschlagen. " + Ex.Message, "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Unbekannter Fehler: " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Zeigt die Stationsanzeige in einer ListView an.
        /// </summary>
        /// <param name="lvTarget">Die ListBox welche die Stationen anzeigen soll.</param>
        /// <param name="lblLocation">Das Label welches den Standort der Resultate anzeigt.</param>
        /// <param name="objStation">Das Station's Objekt von welchem das Station-Board angezeigt wird.</param>
        public void DisplayStationBoard(ListView lvTarget, Label lblLocation, object objStation)
        {
            Station Station = null;
            if (objStation != null) Station = (Station)objStation;
            else
            {
                MessageBox.Show("Bitte eine vorgeschlagene Station auswählen.", "Ungültige Station", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StationBoardInfo StationBoardInfo;
            lvTarget.Items.Clear();
            try
            {
                StationBoardRoot StationBoardRoot = _Transport.GetStationBoard(Station.Name, Station.Id);
                foreach (StationBoard StationBoard in StationBoardRoot.Entries)
                {
                    StationBoardInfo = new StationBoardInfo(StationBoard);
                    lvTarget.Items.Add(new ListViewItem(StationBoardInfo.GetInfos()));
                }
                lblLocation.Text = StationBoardRoot.Station.Name;
            }
            catch (WebException Ex)
            {
                MessageBox.Show("Verbindung zum Webserver fehlgeschlagen. " + Ex.Message, "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Unbekannter Fehler: " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblLocation.Visible = true;
            lvTarget.Visible = true;
        }

        /// <summary>
        /// Tauscht den Text der beiden ComboBoxen.
        /// </summary>
        /// <param name="cbFrom">Die erste ComboBox.</param>
        /// <param name="cbTo">Die zweite ComboBox.</param>
        public void SwapConnectionPoints(ComboBox cbFrom, ComboBox cbTo)
        {
            string textFrom = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = textFrom;
        }

        /// <summary>
        /// Zeigt die erhaltenen Verbindungen in einer ListView an.
        /// </summary>
        /// <param name="lvTarget">Die ListView in welcher die Verbindungen angezeigt werden.</param>
        /// <param name="startStation">Name der Station von welcher gestartet werden soll.</param>
        /// <param name="targetStation">Name der Station zu welcher gefahren werden möchte.</param>
        /// <param name="dtDate">Das Datum ab welchem gesucht werden soll.</param>
        public void DisplayConnections(ListView lvTarget, string startStation, string targetStaion, DateTime dtDate)
        {
            lvTarget.Items.Clear();
            try
            {
                Connections Connections = _Transport.GetConnections(startStation, targetStaion, dtDate);
                ConnectionInfo ConnectionInfo;
                foreach (Connection Connection in Connections.ConnectionList)
                {
                    ConnectionInfo = new ConnectionInfo(Connection);
                    lvTarget.Items.Add(new ListViewItem(ConnectionInfo.GetInfos()));
                }
            }
            catch (WebException Ex)
            {
                MessageBox.Show("Verbindung zum Webserver fehlgeschlagen. " + Ex.Message, "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Unbekannter Fehler: " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lvTarget.Visible = true;
        }
    }
}
