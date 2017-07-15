using System.Windows.Forms;
using EMSV.Api.DataTypes;
using EMSV.UI.Shared;

namespace EMSV.UI {

    public sealed partial class FrmSettings : Form {

        private Settings _model;

        public Settings Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
                if (Model!=null)
                    UpdateBidnings();
            }
        }

        public FrmSettings() {
            InitializeComponent();
            Text = $@"Settings :: {InfoHelper.NameVersion}";
        }

        private void UpdateBidnings() {
            numMaxRestarts.DataBindings.Clear();
            textBox1.DataBindings.Clear();
            numMaxRestarts.DataBindings.Add( nameof( numMaxRestarts.Value ), Model, nameof( Model.RestartLimit ) );
            textBox1.DataBindings.Add( nameof( textBox1.Text ), Model, nameof( Model.LogPath ) );
        }

        private void FrmSettings_Load(object sender, System.EventArgs e)
        {

        }
    }

}