using System.Linq;
using System.Windows.Forms;
using EMSV.Api.DataTypes;

namespace EMSV.CL.UI.UI {

    public partial class frmProcessInfo : Form {

        private IRunningDemonizedProcess _process;

        public IRunningDemonizedProcess Process
        {
            get { return _process; }
            set
            {
                _process = value;
                UpdateBindings();
            }
        }

        private void UpdateBindings() {
            ClearBindings();
            if (Process!=null)
                SetBindings();
        }

        private void SetBindings() {
            AddBindingInternal( this, nameof(Process.Name ) );
            AddBindingInternal( txtId, nameof( Process.Id ) );
            AddBindingInternal( txtName, nameof( Process.Name ) );
            AddBindingInternal( txtFile, nameof( Process.Path ) );
            AddBindingInternal( txtArguments, nameof( Process.Arguments ) );
            AddBindingInternal( txtStatus, nameof( Process.Status ) );
            AddBindingInternal( txtDefaultPriority, nameof( Process.Priority ) );
            AddBindingInternal( txtCurrentPriority, nameof( Process.CurrentPriority ) );
            AddBindingInternal( txtRestarts, nameof( Process.Restarts ) );
            AddBindingInternal(checkAutoRestart, nameof( Process.Autorestart ) );
            AddBindingInternal(checkHide, nameof( Process.HideOnStart ) );
        }

        private Binding AddBindingInternal( Control ct, string prop ) => ct.DataBindings.Add( nameof( Text ), Process, prop );

        private void ClearBindings() {
            this.DataBindings.Clear();
            foreach ( var label in this.Controls.OfType<Label>() )
                label.DataBindings.Clear();
        }

        public frmProcessInfo() { InitializeComponent(); }

        private void FrmProcessInfo_Load(object sender, System.EventArgs e)
        {

        }

     

        private void CheckHide_TextChanged(object sender, System.EventArgs e)
        {
            if (checkHide.Text == "True")
            {
                checkHide.Checked = true;
            }
            else
            {
                checkHide.Checked = false;
            }
        }

        private void checkAutoRestart_TextChanged(object sender, System.EventArgs e)
        {
            if (checkAutoRestart.Text == "True")
            {
                checkAutoRestart.Checked = true;
            }
            else
            {
                checkAutoRestart.Checked = false;
            }
        }
    }

}