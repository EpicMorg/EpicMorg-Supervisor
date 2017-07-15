using System.Windows.Forms;
using EMSV.UI.Shared;

namespace EMSV.UI {

    public sealed partial class FrmStartHm : Form {

        public FrmStartHm() {
            InitializeComponent();
            Text = $@"Connect to server :: {InfoHelper.NameVersion}";
        }

        public string Server => "http://" + ipAddressText.Text + ":" +txtServer.Text;
        public string Key => txtKey.Text;

        private void FrmStartHm_Load(object sender, System.EventArgs e)
        {

        }

        private void ipAddressText_TextChanged(object sender, System.EventArgs e)
        {

        }
    }

}