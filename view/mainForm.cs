using eshift.database;
using eshift.model;
using eshift.utils.enums;
using eshift.utils.enums.extensions;
using System.Data;
using System.Data.Common;
using ZstdSharp.Unsafe;

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

        private void mainForm_Load(object sender, EventArgs e)
        {
            //IDBConnectionManager connectionManager = MySqlConnectionManager.Instance;
            //Console.WriteLine(connectionManager.GetConnection().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get DB manager via interface
            IDBConnectionManager dbManager = new MySqlConnectionManager();
            try
            {
                dbManager.GetConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error");
            }
            
        }
    }
}
