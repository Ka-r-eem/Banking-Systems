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
    public partial class LOAN_LIST : Form
    {
        public LOAN_LIST()
        {
            InitializeComponent();
        }

        private void LOAN_LIST_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANKINGDataSet.LOAN' table. You can move, or remove it, as needed.
            this.lOANTableAdapter.Fill(this.bANKINGDataSet.LOAN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN aDMIN = new ADMIN();
            aDMIN.Show();
            this.Hide();
        }
    }
}
