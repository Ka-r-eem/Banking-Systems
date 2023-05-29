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
    public partial class SIGN : Form
    {
        public SIGN()
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
            EMP eMP = new EMP();    
            eMP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADMIN aDMIN = new ADMIN();
            aDMIN.Show();
            this.Hide();
        }

        private void SIGN_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQL sQL = new SQL();    
            sQL.Show();
            this.Hide();
        }
    }
}
