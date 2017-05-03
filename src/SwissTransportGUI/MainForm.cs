﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportGUI
{ 

    public partial class MainForm : Form
    {
        private VerbindungenControl _VerbindungenControl = new VerbindungenControl();
        private StationsfahrplanControl _StationsfahrplanControl = new StationsfahrplanControl();
        public MainForm()
        {
            InitializeComponent();
            Controls.OfType<Panel>().First().Controls.Add(_VerbindungenControl);
        }

        private void VerbindungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.OfType<Panel>().First().Controls.Clear();
            Controls.OfType<Panel>().First().Controls.Add(_VerbindungenControl);
        }

        private void StationsfahrplanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.OfType<Panel>().First().Controls.Clear();
            Controls.OfType<Panel>().First().Controls.Add(_StationsfahrplanControl);
        }
    }
}
