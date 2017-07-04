using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace process_demonizator.UI
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        public string Password => textBox1.Text;
        private void button1_Click(object sender, EventArgs e) {
            if ( textBox1.Text != textBox2.Text )
                MessageBox.Show( "Error", "Passwords don't match", MessageBoxButtons.OK, MessageBoxIcon.Error );
            else
                DialogResult = DialogResult.OK;
        }
    }
}
