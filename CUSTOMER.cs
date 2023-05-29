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
    public partial class CUSTOMER : Form
    {
        public CUSTOMER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true; ";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " INSERT INTO CUSTOMER VALUES ( '" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("INSERTION Successfully DONE");
            CUS_OPTIONS cUS_OPTIONS = new CUS_OPTIONS();
            cUS_OPTIONS.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SIGN form = new SIGN();
            form.Show();
            this.Hide();
        }

        private void CUSTOMER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANKINGDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.bANKINGDataSet.CUSTOMER);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.bANKINGDataSet.CUSTOMER);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true; ";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " UPDATE CUSTOMER SET FNAME =  '" + textBox2.Text + "' , LNAME = '" + textBox3.Text + "',CUSTOMER_PHONE = '" + textBox4.Text + "',CUSTOMER_ADDRESS = '" + textBox5.Text + "',CUS_USERNAME = '" + textBox6.Text + "',CUS_PASS = '" + textBox7.Text + "',NO_OF_LOANS = '" + textBox8.Text + "',BRANCH_NUMBER = '" + textBox9.Text + "',BANK_CODE = '" + textBox10.Text + "'WHERE CUSTOMER_SSN = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("UPDATE DONE");
        }
    }
}
