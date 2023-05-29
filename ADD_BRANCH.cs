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
    public partial class ADD_BRANCH : Form
    {
        public ADD_BRANCH()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMIN aDMIN = new ADMIN();
            aDMIN.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true; ";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " INSERT INTO BRANCH VALUES ( '" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("INSERTION Successfully DONE");
        }

        private void ADD_BRANCH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANKINGDataSet.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.bANKINGDataSet.BRANCH);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bRANCHTableAdapter.Fill(this.bANKINGDataSet.BRANCH);
        }
    }
}
