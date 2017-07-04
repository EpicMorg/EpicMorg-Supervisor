using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PD.Api;
using PD.Api.Client;
using PD.Api.DataTypes;
using PD.UI.Shared;

namespace process_demonizator.UI {

    public sealed partial class FrmMain : Form {

        private FormWindowState _oldFormState;
        private AdminApi _api;
        public string ApiKey { get; set; }

        public FrmMain() {
            InitializeComponent();
            Text = InfoHelper.NameVersion;
            _notifyIcon.Text = InfoHelper.NameVersion;
            dgvProcessList.AutoGenerateColumns = false;
        }

        private RunningDemonizedProcess GetMenuRow( object o ) {
            var dataGridView = dgvProcessList;
            var dataGridViewSelectedRowCollection = dataGridView?.SelectedRows;
            var dataGridViewRows = dataGridViewSelectedRowCollection?.OfType<DataGridViewRow>();
            var dataGridViewRow = dataGridViewRows?.FirstOrDefault();
            var dataBoundItem = dataGridViewRow?.DataBoundItem;
            var runningDemonizedProcess = dataBoundItem as RunningDemonizedProcess;
            return runningDemonizedProcess;
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

        private async Task ApplyApi( AdminApi api, string key ) {
            ApiKey = key;
            _api = api;
            _api.Key = key;
            SetControls( true );
            await UpdateProcesses().ConfigureAwait( true );
        }

        private void SetControls( bool enabled ) {
            tabControl.Enabled = enabled;
            smenuSettions.Enabled = enabled;
            smenuAddNewItem.Enabled = enabled;
            changePasswordToolStripMenuItem.Enabled = enabled;
            refreshToolStripMenuItem.Enabled = enabled;
        }

        private async Task UpdateProcesses() {
            var processes = await _api.Process.ListFull().ConfigureAwait( true );
            dgvProcessList.DataSource = processes;
        }

        //=====================================================================================================================================================

        private void smenuExit_Click( object sender, EventArgs e ) => Application.Exit();

        private async void smenuSettions_Click( object sender, EventArgs e ) {
            using ( var frmSettings = new FrmSettings() ) {
                Settings data = (Settings) await _api.Settings.GetSettings().ConfigureAwait( true );
                frmSettings.Model = data;
                if ( frmSettings.ShowDialog() == DialogResult.OK ) {
                    await _api.Settings.SetSettings( data ).ConfigureAwait( true );
                }
                
            }
        }

        private void smenuAbout_Click( object sender, EventArgs e ) => new FrmAbout().ShowDialog();

        private void smenuLicense_Click( object sender, EventArgs e ) => InfoHelper.ShowLicense();

        private void FrmMain_Resize( object sender, EventArgs e ) {
            if ( FormWindowState.Minimized == WindowState )
                Hide();
        }

        private async void smenuStartMonitorServer_Click( object sender, EventArgs e ) {
            using ( var frmStartHm = new FrmStartHm() ) {
                if ( frmStartHm.ShowDialog() != DialogResult.OK ) return;

                bool checkResult;
                var key = frmStartHm.Key;

                var api = new AdminApi( frmStartHm.Server );
                try {
                    checkResult = await api.Settings.CheckKey( key ).ConfigureAwait( true );
                }
                catch ( Exception ex ) {
                    MessageBox.Show( "Failed to get response from server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    statusServer.Text = "Disconnected";
                    return;
                }

                if ( checkResult) { 
                    await ApplyApi( api, key ).ConfigureAwait( true );
                    statusServer.Text = $"Managing {frmStartHm.Server}";
                }
                else {
                    MessageBox.Show( "Wrong pass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    statusServer.Text = "Disconnected";
                }
            }
        }

        private async void smenuAddNewItem_Click( object sender, EventArgs e ) {
            if ( _api == null ) return;
            using ( var add = new FrmAdd() ) {
                if ( add.ShowDialog() != DialogResult.OK ) return;
                await _api.Process.Create( add.Model ).ConfigureAwait( true );
            }
            await UpdateProcesses().ConfigureAwait( false );
        }

        private async void showToolStripMenuItem_Click( object sender, EventArgs e ) {
            if ( _api == null ) return;
            var o = GetMenuRow( sender );
            if ( o == null ) return;
            await _api.Process.Show( o.Id ).ConfigureAwait( true );
        }

        private async void hideToolStripMenuItem_Click( object sender, EventArgs e ) {
            if ( _api == null ) return;
            var o = GetMenuRow( sender );
            if ( o == null ) return;
            await _api.Process.Hide( o.Id ).ConfigureAwait( true );
        }

        private async void deleteToolStripMenuItem_Click( object sender, EventArgs e ) {
            if ( _api == null ) return;
            var o = GetMenuRow( sender );
            if ( o == null ) return;
            await _api.Process.Delete( o.Id ).ConfigureAwait( true );
            await UpdateProcesses().ConfigureAwait( true );
        }

        private async void startToolStripMenuItem_Click( object sender, EventArgs e ) {
            if ( _api == null ) return;
            var o = GetMenuRow( sender );
            if ( o == null ) return;
            await _api.Process.Start( o.Id ).ConfigureAwait( true );
            await UpdateProcesses().ConfigureAwait( true );
        }

        private async void stopToolStripMenuItem_Click( object sender, EventArgs e ) {
            if ( _api == null ) return;
            var o = GetMenuRow( sender );
            if ( o == null ) return;
            await _api.Process.Stop( o.Id ).ConfigureAwait( true );
            await UpdateProcesses().ConfigureAwait( true );
        }

        private async void restartToolStripMenuItem_Click( object sender, EventArgs e ) {
            if ( _api == null ) return;
            var o = GetMenuRow( sender );
            if ( o == null ) return;
            await _api.Process.Restart( o.Id ).ConfigureAwait( true );
            await UpdateProcesses().ConfigureAwait( true );
        }

        private async void editToolStripMenuItem_Click( object sender, EventArgs e ) {
            if ( _api == null ) return;
            var o = GetMenuRow( sender );
            if ( o == null ) return;
            using ( var add = new FrmAdd() ) {
                var em = new PasswordedDemonizedProcess() {
                    Id = o.Id,
                    Arguments = o.Arguments,
                    Name = o.Name,
                    Key = "",
                    Path = o.Path,
                    Autorestart = o.Autorestart,
                    HideOnStart = o.HideOnStart,
                    Priority = o.Priority
                };
                add.Model = em;
                if ( add.ShowDialog() != DialogResult.OK ) return;
                await _api.Process.Edit( em ).ConfigureAwait( true );
            }
            await UpdateProcesses().ConfigureAwait(true);
        }

        private async void refreshToolStripMenuItem_Click( object sender, EventArgs e ) => await Refresh().ConfigureAwait( true );

        private async Task Refresh() {
            if ( _api == null ) return;
            switch ( tabControl.SelectedIndex ) {
                case 0:
                    await UpdateProcesses().ConfigureAwait( true );
                    break;
                case 1:
                    await UpdateLogs().ConfigureAwait( true );
                    break;
            }
        }

        private async void tabControl_SelectedIndexChanged( object sender, EventArgs e ) { await Refresh().ConfigureAwait( true ); }

        private async Task UpdateLogs() { txtLogs.Lines = ( await _api.Log.Show( (int) ( txtLogs.Height / txtLogs.Font.SizeInPoints ) ).ConfigureAwait( true ) ).ToArray(); }
        

        private async void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.F5:
                    await Refresh().ConfigureAwait( true );
                    break;
            }
            
        }

        private void АнглийскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageManager.Set( "en" );
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageManager.Set("ru");
        }

        private async void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using ( var frm = new FrmPassword() ) {
                if ( frm.ShowDialog() == DialogResult.OK ) {
                    var password = frm.Password;
                    await _api.Settings.SetKey( password ).ConfigureAwait( true );
                    _api.Key = password;
                }
            }
            await UpdateProcesses().ConfigureAwait(true);
        }
    }

}