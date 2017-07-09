using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EMSV.UI;
using EMSV.UI.Shared;
using System.Threading.Tasks;
using EMSV.Api.Client;
using EMSV.Api.DataTypes;

namespace EMSV.CL.UI.UI {

    public partial class FrmMain : Form {

        private ClientApi _api;
        private Dictionary<int, string> _keys;

        public FrmMain() {
            InitializeComponent();
            Text = InfoHelper.NameVersion;
            _notifyIcon.Text = InfoHelper.NameVersion;
            dgvProcessList.AutoGenerateColumns = false;
        }

        private FormWindowState _oldFormState;

        private void FormForTray_Resize( object sender, EventArgs e ) {
            if ( FormWindowState.Minimized == WindowState )
                Hide();
        }

        private void _notifyIcon_MouseClick( object sender, MouseEventArgs e ) {
            if ( e.Button != MouseButtons.Left ) return;
            if ( WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized ) {
                _oldFormState = WindowState;
                WindowState = FormWindowState.Minimized;
            }
            else {
                Show();
                WindowState = _oldFormState;
            }
        }

        private void smenuLicense_Click( object sender, EventArgs e ) => InfoHelper.ShowLicense();

        private void smenuAbout_Click( object sender, EventArgs e ) => new FrmAbout().ShowDialog();

        private async void smenuStartMonitorServer_Click( object sender, EventArgs e ) {
            using ( var cf = new frmConnect() ) if ( cf.ShowDialog() == DialogResult.OK ) await Connect( cf.Server ).ConfigureAwait( true );
        }

        private async Task Connect( string server ) {
            _api = new ClientApi( server );
            _keys = new Dictionary<int, string>();
            await UpdateServers().ConfigureAwait( true );
        }

        private async Task UpdateServers() => dgvProcessList.DataSource = await _api.Process.List().ConfigureAwait( true );

        private void dgvProcessList_DataSourceChanged_1( object sender, EventArgs e ) {
            foreach ( DataGridViewRow row in dgvProcessList.Rows )
                UpdateRowMenu( row );
        }

        private void UpdateRowMenu( DataGridViewRow row ) { row.ContextMenuStrip = _keys.ContainsKey( ( (DemonizedProcessBase) row.DataBoundItem ).Id ) ? cmProcess : cmUnlock; }

        private async void unlockToolStripMenuItem_Click( object sender, EventArgs e ) {
            var o = sender;
            var row = GetMenuRow( o );
            var source = row?.DataBoundItem as DemonizedProcessBase;

            if ( source == null ) return;
            using ( var form = new frmUnlock() ) {
                form.Process = source;
                if ( form.ShowDialog() != DialogResult.OK )
                    return;
                if ( await _api.Process.CheckPassword( source.Id, form.Password ).ConfigureAwait( true ) ) {
                    _keys.Add( source.Id, form.Password );
                    UpdateRowMenu( row );
                }
                else {
                    MessageBox.Show( "Wrong key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        private static DataGridViewRow GetMenuRow( object o )
            => ( ( ( o as ToolStripItem )?.Owner as ContextMenuStrip )?.SourceControl as DataGridView )?.SelectedRows?.OfType<DataGridViewRow>()?.FirstOrDefault();

        private async void FrmMain_Load( object sender, EventArgs e ) {
//#if DEBUG
//            await Connect( "http://localhost:31337" ).ConfigureAwait( true );
//#endif
        }

        private async void startToolStripMenuItem_Click( object sender, EventArgs e ) {
            var row = GetMenuRow( sender );
            var source = row?.DataBoundItem as DemonizedProcessBase;
            if ( source == null ) return;
            await _api.Process.Start( source.Id, _keys[ source.Id ] ).ConfigureAwait( true );
        }

        private async void restartToolStripMenuItem_Click( object sender, EventArgs e ) {
            var row = GetMenuRow( sender );
            var source = row?.DataBoundItem as DemonizedProcessBase;
            if ( source == null ) return;
            await _api.Process.Restart( source.Id, _keys[ source.Id ] ).ConfigureAwait( true );
        }

        private async void stopToolStripMenuItem_Click( object sender, EventArgs e ) {
            var row = GetMenuRow( sender );
            var source = row?.DataBoundItem as DemonizedProcessBase;
            if ( source == null ) return;
            await _api.Process.Stop( source.Id, _keys[ source.Id ] ).ConfigureAwait( true );
        }

        private async void infoToolStripMenuItem_Click(object sender, EventArgs e) {
            var row = GetMenuRow(sender);
            var source = row?.DataBoundItem as DemonizedProcessBase;
            if (source == null) return;
            var pi = await _api.Process.Get( source.Id, _keys[ source.Id ] ).ConfigureAwait( true );
            using ( var frm = new frmProcessInfo() ) {
                frm.Process = pi;
                frm.ShowDialog();
            }
        }

        private void английскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageManager.Set("en");
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageManager.Set("ru");
        }
    }

}