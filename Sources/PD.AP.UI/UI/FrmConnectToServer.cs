using System.Windows.Forms;
using PD.UI.Shared;

namespace process_demonizator.UI {

    public sealed partial class FrmStartHm : Form {

        public FrmStartHm() {
            InitializeComponent();
            Text = $@"Connect to server :: {InfoHelper.NameVersion}";
        }

        public string Server => txtServer.Text;
        public string Key => txtKey.Text;

    }

}