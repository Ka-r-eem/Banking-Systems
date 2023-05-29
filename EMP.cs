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
    public partial class EMP : Form
    {
        public EMP()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SIGN form = new SIGN();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true; ";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " INSERT INTO EMPLOYEE VALUES ( '" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("SIGNED UP");
            EMP_OPTIONS eMP_OPTIONS = new EMP_OPTIONS();
            eMP_OPTIONS.Show();
            this.Hide();
        }

        private void EMP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANKINGDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.bANKINGDataSet.EMPLOYEE);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.eMPLOYEETableAdapter.Fill(this.bANKINGDataSet.EMPLOYEE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true; ";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " UPDATE EMPLOYEE SET NO_OF_LOANS = '" + textBox3.Text + "' ,EMP_USERNAME = '" + textBox4.Text + "',EMP_PASS = '" + textBox5.Text + "',BRANCH_NUMBER = '" + textBox6.Text + "',BANK_CODE = '" + textBox7.Text + "'WHERE EMP_FNAME = '" + textBox1.Text + "'AND EMP_LNAME ='" + textBox2.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("UPDATE DONE :)");
        }
    }
}
