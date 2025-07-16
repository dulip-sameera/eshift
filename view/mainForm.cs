using eshift.utils.enums;
using eshift.utils.enums.extensions;

namespace eshift
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TransportUnitStatus status = TransportUnitStatus.TRANSPORTING;
            label1.Text = status.GetName();
        }
    }
}
