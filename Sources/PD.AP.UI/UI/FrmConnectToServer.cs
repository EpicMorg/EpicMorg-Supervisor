using System.Windows.Forms;
using EMSV.UI.Shared;

namespace EMSV.UI {

    public sealed partial class FrmStartHm : Form {

        public FrmStartHm() {
            InitializeComponent();
            Text = $@"Connect to server :: {InfoHelper.NameVersion}";
        }

        public string Server => txtServer.Text;
        public string Key => txtKey.Text;

        private void FrmStartHm_Load(object sender, System.EventArgs e)
        {

        }
    }

}