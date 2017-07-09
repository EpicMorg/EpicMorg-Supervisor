using System;
using System.Diagnostics;
using System.Windows.Forms;
using EMSV.UI.Shared;

namespace EMSV.UI {

    public sealed partial class FrmAbout : Form {

        public FrmAbout() {
            InitializeComponent();
            Text = "About";
            txtProgName.Text = InfoHelper.Product;
            txtVer.Text = InfoHelper.Version;
            txtProgCopy.Text = $"Copyright {(char) 0169} {InfoHelper.Company}";
        }

        private void FrmAbout_Load( object sender, EventArgs e ) { }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e ) => Process.Start( "https://ww.epicm.org/" );

        private void linkLabel2_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e ) => Process.Start("https://github.com/EpicMorg/EpicMorg-Supervisor");

        private void linkLabel3_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e ) => Process.Start( "https://github.com/m66n/ipaddresscontrollib" );

        private void button1_Click( object sender, EventArgs e ) => Close();

    }

}