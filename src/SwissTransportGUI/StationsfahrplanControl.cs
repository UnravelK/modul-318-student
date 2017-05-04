using System;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class StationsfahrplanControl : UserControl
    {
        private GUIFunctions _GUIFunctions = GUIFunctions.GetInstance();

        public StationsfahrplanControl()
        {
            InitializeComponent();
        }

        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            _GUIFunctions.DisplayStationBoard(lbBoard, lblStation, cbStation.SelectedItem);
        }

        private async void CbStation_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunctions.SearchStationsHelper(cbStation);
        }
    }
}
