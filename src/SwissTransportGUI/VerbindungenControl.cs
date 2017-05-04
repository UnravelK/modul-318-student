﻿using System;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class VerbindungenControl : UserControl
    {
        private GUIFunctions _GUIFunctions = GUIFunctions.GetInstance();

        public VerbindungenControl()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DateTime dtDate = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour, timePicker.Value.Minute, 0);
            _GUIFunctions.DisplayConnections(lbConnections, cbVon.Text, cbNach.Text, dtDate);
        }

        private async void CbVon_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunctions.SearchStationsHelper(cbVon);
        }

        private async void CbNach_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunctions.SearchStationsHelper(cbNach);
        }
    }
}
