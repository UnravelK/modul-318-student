using System;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class VerbindungenControl : UserControl
    {
        private GUIFunctions _GUIFunction = GUIFunctions.GetInstance();

        public VerbindungenControl()
        {
            InitializeComponent();
        }

        private async void CbVon_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunction.SearchStationsHelper(cbVon);
        }

        private async void CbNach_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunction.SearchStationsHelper(cbNach);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _GUIFunction.DisplayConnections(lbConnections, cbVon.Text, cbNach.Text);
        }
    }
}
