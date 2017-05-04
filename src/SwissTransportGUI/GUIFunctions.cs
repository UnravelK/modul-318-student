using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// <param name="displayMap">Gibt an ob die Karte angezeigt werden soll.</param>
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
        /// Zeigt eine Stationsanzeige in einer ListBox an und zeigt eine Karte des Standpunktes der Dation in der PictureBox an.
        /// </summary>
        /// <param name="lbTarget">Die ListBox welche die Stationen anzeigen soll.</param>
        /// <param name="lblLocation">Das Label welches den Standort der Resultate anzeigt.</param>
        /// <param name="objStation">Die Station von welcher die momentane Anzeige angezeigt werden soll. Muss als Station gecastet werden können.</param>
        /// <param name="displayMap">Gibt an ob die Karte angezeigt werden soll.</param>
        /// <param name="pbMap">Die PictureBox in welcher gegebenenfalls die Karte angezeigt wird.</param>
        public void DisplayStationBoard(ListBox lbTarget, Label lblLocation, object objStation, PictureBox pbMap)
        {
            Station Station = (Station)objStation;
            DisplayMap(pbMap, Station.Coordinate);
            StationBoardRoot StationBoardRoot = _Transport.GetStationBoard(Station.Name, Station.Id);
            lbTarget.Items.Clear();
            lbTarget.Items.AddRange(StationBoardRoot.Entries.ToArray());
            lblLocation.Text = StationBoardRoot.Station.Name;
            lblLocation.Visible = true;
            lbTarget.Visible = true;
        }

        /// <summary>
        /// Zeigt den ConnectionPoint auf der PictureBox an.
        /// </summary>
        /// <param name="pbMap">ie PictureBox auf der die Karte erscheint.</param>
        /// <param name="Coordinates">Die Coordinaten welche angezeigt werden.</param>
        private void DisplayMap(PictureBox pbMap, Coordinate Coordinates)
        {

        }

        /// <summary>
        /// Zeigt die erhaltenen Verbindungen in einer ListBox an.
        /// </summary>
        /// <param name="lbTarget">Die ListBox in welcher die Verbindungen angezeigt werden.</param>
        /// <param name="startStation">Name der Station von welcher gestartet werden soll.</param>
        /// <param name="targetStation">Name der Station zu welcher gefahren werden möchte.</param>
        public void DisplayConnections(ListBox lbTarget, string startStation, string targetStaion, DateTime dtDate)
        {
            Connections Connections = _Transport.GetConnections(startStation, targetStaion, dtDate);
            lbTarget.Items.Clear();
            lbTarget.Items.AddRange(Connections.ConnectionList.ToArray());
            lbTarget.Visible = true;
        }
    }
}
