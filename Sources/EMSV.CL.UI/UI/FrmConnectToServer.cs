﻿using System.Windows.Forms;
using EMSV.UI.Shared;

namespace EMSV.UI {

    public sealed partial class frmConnect : Form {
        
        public frmConnect() {
            InitializeComponent();
            Text = $@"Connect to server :: {InfoHelper.NameVersion}";
        }

        public string Server => txtServer.Text;

        private void frmConnect_Load(object sender, System.EventArgs e)
        {

        }
    }

}