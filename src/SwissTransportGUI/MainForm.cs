using System;
using System.Linq;
using System.Windows.Forms;

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
            AcceptButton = _VerbindungenControl.AcceptButton;
        }

        private void StationsfahrplanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.OfType<Panel>().First().Controls.Clear();
            Controls.OfType<Panel>().First().Controls.Add(_StationsfahrplanControl);
            AcceptButton = _StationsfahrplanControl.AcceptButton;
        }
    }
}
