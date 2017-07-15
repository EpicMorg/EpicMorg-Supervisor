using System; 
using System.Windows.Forms;

namespace EMSV.UI.Shared
{
    public partial class FrmLicense : Form
    {
        public FrmLicense()
        {
            InitializeComponent();
        }

        private void FrmLicense_Load(object sender, EventArgs e)
        {
            textBoxLicense.Text = InfoHelper.License;


        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
