using System;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class StationsfahrplanControl : UserControl
    {
        private GUIFunctions _GUIFunctions = new GUIFunctions();

        public StationsfahrplanControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _GUIFunctions.DisplayStationBoard(lbBoard, lblStation, cbStation.SelectedItem);
        }

        private async void CbStation_TextUpdate(object sender, EventArgs e)
        {
            await _GUIFunctions.SearchStationsHelper(cbStation);
        }
    }
}
