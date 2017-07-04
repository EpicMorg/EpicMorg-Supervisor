using System.Linq;
using System.Windows.Forms;
using PD.Api.DataTypes;

namespace PD.CL.UI.UI {

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
            AddBindingInternal( this, nameof( Process.Name ) );
            AddBindingInternal( lblId, nameof( Process.Id ) );
            AddBindingInternal( lblName, nameof( Process.Name ) );
            AddBindingInternal( lblFile, nameof( Process.Path ) );
            AddBindingInternal( lblArguments, nameof( Process.Arguments ) );
            AddBindingInternal( lblStatus, nameof( Process.Status ) );
            AddBindingInternal( lblDefaultPriority, nameof( Process.Priority ) );
            AddBindingInternal( lblCurrentPriority, nameof( Process.CurrentPriority ) );
            AddBindingInternal( lblRestarts, nameof( Process.Restarts ) );
            AddBindingInternal( lblAutoRestart, nameof( Process.Autorestart ) );
            AddBindingInternal( lblHide, nameof( Process.HideOnStart ) );
        }

        private Binding AddBindingInternal( Control ct, string prop ) => ct.DataBindings.Add( nameof( Text ), Process, prop );

        private void ClearBindings() {
            this.DataBindings.Clear();
            foreach ( var label in this.Controls.OfType<Label>() )
                label.DataBindings.Clear();
        }

        public frmProcessInfo() { InitializeComponent(); }

    }

}