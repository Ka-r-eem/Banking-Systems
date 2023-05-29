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
    public partial class CUS_OPTIONS : Form
    {
        public CUS_OPTIONS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUSTOMER cUSTOMER = new CUSTOMER();
            cUSTOMER.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOAN_REQ lOAN_REQ = new LOAN_REQ();
            lOAN_REQ.Show();
            this.Hide();
        }
    }
}
