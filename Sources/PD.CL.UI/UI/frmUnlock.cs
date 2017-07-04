using System.Windows.Forms;
using PD.Api.DataTypes;

namespace PD.CL.UI.UI
{
    public partial class frmUnlock : Form
    {

        private DemonizedProcessBase _process;

        public DemonizedProcessBase Process
        {
            get
            {
                return _process;
            }
            set
            {
                _process = value;
                if (value!=null)
                    lblProcess.DataBindings.Add(new Binding(nameof(lblProcess.Text), Process, nameof(Process.Name)));
            }
        }

        public string Password => textBox1.Text;
        public frmUnlock() {
            InitializeComponent();
        }
    }
}
