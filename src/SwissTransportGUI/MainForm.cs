using System;
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
        private ITransport Transport;
        private VerbindungenControl VerbindungenControl = new VerbindungenControl();
        private StationsfahrplanControl StationsfahrplanControl = new StationsfahrplanControl();
        public MainForm()
        {
            InitializeComponent();
            Controls.OfType<Panel>().First().Controls.Add(VerbindungenControl);
        }

        private void verbindungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.OfType<Panel>().First().Controls.Clear();
            Controls.OfType<Panel>().First().Controls.Add(VerbindungenControl);
        }

        private void stationsfahrplanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.OfType<Panel>().First().Controls.Clear();
            Controls.OfType<Panel>().First().Controls.Add(StationsfahrplanControl);
        }
    }
}
