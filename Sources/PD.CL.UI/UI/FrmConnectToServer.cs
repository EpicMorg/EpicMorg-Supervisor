using System.Windows.Forms;
using PD.UI.Shared;

namespace process_demonizator.UI {

    public sealed partial class frmConnect : Form {
        
        public frmConnect() {
            InitializeComponent();
            Text = $@"Connect to server :: {InfoHelper.NameVersion}";
        }

        public string Server => txtServer.Text;

    }

}