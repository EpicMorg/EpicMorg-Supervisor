using System;
using System.Diagnostics;
using System.Windows.Forms;
using PD.Api.DataTypes;
using PD.UI.Shared;


namespace process_demonizator.UI {
    public sealed partial class FrmAdd : Form {

        private readonly EventHandler _cmPriorityOnSelectedValueChanged;
        private PasswordedDemonizedProcess _model;

        public PasswordedDemonizedProcess Model
        {
            get
            {
                Console.WriteLine("Editor model requested:");
                return _model;
                
            }
            set
            {
                _model = value;
                Console.WriteLine( "Editor model updated:" );
                if ( value != null ) UpdateBindings();
            }
        }

        public FrmAdd() {
            InitializeComponent();
            Text = @"Add new item :: " + InfoHelper.NameVersion;
            _cmPriorityOnSelectedValueChanged = ( sender, value ) => {
                if ( _model != null )
                    _model.Priority = (ProcessPriorityClass) cmPriority.SelectedItem;
            };
            Model = new PasswordedDemonizedProcess();
        }

        private void UpdateBindings() {
            Console.WriteLine("Updating bindings");
            var controls = new Control[] { txtItemName, txtPassword, txtArgs, txtPath, chckHideOnStart, chckReanimateProcess };
            foreach ( var control1 in controls )
                control1.DataBindings.Clear();

            cmPriority.SelectedValueChanged -= _cmPriorityOnSelectedValueChanged;
            if ( _model == null ) return;

            AddBinding( txtItemName, nameof( _model.Name ) );
            AddBinding(txtPassword, nameof(_model.Key));
            AddBinding(txtArgs, nameof(_model.Arguments));
            AddBinding(txtPath, nameof(_model.Path));
            
            chckHideOnStart.DataBindings.Add( nameof( chckHideOnStart.Checked ), _model, nameof(_model.HideOnStart ), false, DataSourceUpdateMode.OnPropertyChanged, false);
            chckReanimateProcess.DataBindings.Add( nameof( chckReanimateProcess.Checked ), _model, nameof(_model.Autorestart ), false, DataSourceUpdateMode.OnPropertyChanged, false );
            cmPriority.Items.Clear();
            var items = (ProcessPriorityClass[]) Enum.GetValues( typeof( ProcessPriorityClass ) );
            foreach ( var item in items ) cmPriority.Items.Add( item );
            if (_model != null )
                cmPriority.SelectedItem = _model.Priority;
            cmPriority.SelectedValueChanged += _cmPriorityOnSelectedValueChanged;
        }

        private void AddBinding( Control control, string property ) => control.DataBindings.Add( nameof( control.Text ), _model, property, false, DataSourceUpdateMode.OnPropertyChanged, "");

        private void btnBrowse_Click( object sender, EventArgs e ) {
            if ( ofdPath.ShowDialog() != DialogResult.OK ) return;
            txtPath.Text = ofdPath.FileName;
        }

        private void btnOK_Click( object sender, EventArgs e ) {
        }

    }

}