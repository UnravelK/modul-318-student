using System;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class VerbindungenControl : UserControl
    {
        private GUIFunctions _GUIFunctions = GUIFunctions.GetInstance();
        public Button AcceptButton { get { return btnSearch; } }
        public VerbindungenControl()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            lvConnections.Columns.Add("Von:", 150);
            lvConnections.Columns.Add("Gleis:", 70);
            lvConnections.Columns.Add("Abfahrt:", 60);
            lvConnections.Columns.Add("Nach:", 150);
            lvConnections.Columns.Add("Ankunft:", 60);
            lvConnections.Columns.Add("Dauer:", 70);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //DateTime aus den 2 DateTimePicker zu einem DateTime zusammenfügen.
            DateTime dtDate = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour, timePicker.Value.Minute, 0);
            _GUIFunctions.DisplayConnections(lvConnections, cbVon.Text, cbNach.Text, dtDate);
        }

        private async void CbVon_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunctions.SearchStationsHelper(cbVon);
        }

        private async void CbNach_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunctions.SearchStationsHelper(cbNach);
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            _GUIFunctions.SwapConnectionPoints(cbVon, cbNach);
        }
    }
}
