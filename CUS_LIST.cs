using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKING_FINAL
{
    public partial class CUS_LIST : Form
    {
        public CUS_LIST()
        {
            InitializeComponent();
        }

        private void CUS_LIST_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANKINGDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.bANKINGDataSet.CUSTOMER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN aDMIN = new ADMIN();
            aDMIN.Show();
            this.Hide();
        }
    }
}
// OZBOT SKAKL ELTABLE 5LEH YAKHOD MN ELDATASOURCE 3LATOL