using System;
using System.Windows.Forms;

namespace EMSV.UI
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        public string Password => txtPasswordOriginal.Text;
        private void button1_Click(object sender, EventArgs e) {
            if ( txtPasswordOriginal.Text != txtPasswordRetype.Text )
                MessageBox.Show( "Error", "Passwords don't match", MessageBoxButtons.OK, MessageBoxIcon.Error );
            else
                DialogResult = DialogResult.OK;
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
