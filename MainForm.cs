using System;
using System.Windows.Forms;

namespace ScootSim {
    public partial class MainForm : Form {
        Session session = new Session();

        public MainForm() {
            InitializeComponent();

            nMetal.ValueChanged += OnPlanetResourcesChanged;
            nMetal.TextChanged += OnPlanetResourcesChanged;
            nCrystal.ValueChanged += OnPlanetResourcesChanged;
            nCrystal.TextChanged += OnPlanetResourcesChanged;
            nDeut.ValueChanged += OnPlanetResourcesChanged;
            nDeut.TextChanged += OnPlanetResourcesChanged;
        }


        void OnPlanetResourcesChanged( object sender, EventArgs e ) {
            session.Resources.Metal = (long)nMetal.Value;
            session.Resources.Crystal = (long)nCrystal.Value;
            session.Resources.Deut = (long)nDeut.Value;

            Res plunder = session.Resources.GetMultiple( session.Universe.PlunderRate );
            tMetal.Text = FormatUtil.FormatRes( plunder.Metal );
            tCrystal.Text = FormatUtil.FormatRes( plunder.Crystal );
            tDeut.Text = FormatUtil.FormatRes( plunder.Deut );
        }
    }
}