using System;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class StationsfahrplanControl : UserControl
    {
        private GUIFunctions _GUIFunctions = GUIFunctions.GetInstance();
        public Button AcceptButton { get { return btnSearch; } }

        public StationsfahrplanControl()
        {
            InitializeComponent();
            lvBoard.Columns.Add("Typ:", 70);
            lvBoard.Columns.Add("Ab:", 70);
            lvBoard.Columns.Add("Nach:", 250);
        }

        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            _GUIFunctions.DisplayStationBoard(lvBoard, lblStationName, cbStation.SelectedItem);
        }

        private async void CbStation_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunctions.SearchStationsHelper(cbStation);
        }
    }
}
