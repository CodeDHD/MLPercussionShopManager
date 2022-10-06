using System;
using System.Windows.Forms;

namespace MLPercussion
{

    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }
        // GENERATING THE SKU 
        private void button1_Click(object sender, EventArgs e)
        {
            sku_gen Form1 = new sku_gen();
            //this.Hide();
            Form1.ShowDialog();
            //this.WindowState = FormWindowState.Minimized;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //System.Diagnostics.Process.Start("http://www.mlpercussions.com");
        }

        private void inv_Manager_Click(object sender, EventArgs e)
        {
            inventorymanager Form2 = new inventorymanager();
            //this.Hide();
            try
            {
                Form2.ShowDialog();
                //this.WindowState = FormWindowState.Minimized;
            }
            catch (System.AccessViolationException)
            {

                MessageBox.Show("A window is currently open", "Inventor Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void sale_logbttn_Click(object sender, EventArgs e)
        {
            Sales_Log Form3 = new Sales_Log();
            //this.Hide();
            Form3.ShowDialog();
            //this.WindowState = FormWindowState.Minimized;
        }
    }
}
