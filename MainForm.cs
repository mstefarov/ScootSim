using System;
using System.Globalization;
using System.Windows.Forms;

namespace ScootSim {
    public partial class MainForm : Form {
        Session session = new Session();

        public MainForm() {
            InitializeComponent();

            nMetal.ValueChanged += OnPlanetResourcesChanged;
            nMetal.TextChanged += OnPlanetResourcesChanged;
            nMetal.Enter += OnNumberFieldFocus;
            nCrystal.ValueChanged += OnPlanetResourcesChanged;
            nCrystal.TextChanged += OnPlanetResourcesChanged;
            nCrystal.Enter += OnNumberFieldFocus;
            nDeut.ValueChanged += OnPlanetResourcesChanged;
            nDeut.TextChanged += OnPlanetResourcesChanged;
            nDeut.Enter += OnNumberFieldFocus;
        }


        void OnNumberFieldFocus( object sender, EventArgs e ) {
            ((NumericUpDown)sender).Select();
        }


        void OnPlanetResourcesChanged( object sender, EventArgs e ) {
            session.Resources.Metal = (int)nMetal.Value;
            session.Resources.Crystal = (int)nCrystal.Value;
            session.Resources.Deut = (int)nDeut.Value;

            Res plunder = session.Resources.GetMultiple( Universe.Plunder );
            tMetal.Text = FormatUtil.FormatRes( plunder.Metal );
            tCrystal.Text = FormatUtil.FormatRes( plunder.Crystal );
            tDeut.Text = FormatUtil.FormatRes( plunder.Deut );
        }
    }
}