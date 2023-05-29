using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BANKING_FINAL
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_BANK aDD_BANK = new ADD_BANK();
            aDD_BANK.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADD_BRANCH aDD_BRANCH = new ADD_BRANCH();
            aDD_BRANCH.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CUSTOMER aDD_CUSTOMER = new CUSTOMER();
            aDD_CUSTOMER.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CUS_LIST aDD_CUS_LIST = new CUS_LIST();
            aDD_CUS_LIST.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOAN_LIST aDD_LOAN_LIST = new LOAN_LIST();
            aDD_LOAN_LIST.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SIGN form = new SIGN();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DET dET = new DET();
            dET.Show();
            this.Hide();

        }
    }
}
