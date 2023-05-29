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
    public partial class LOAN_APPROVAL : Form
    {
        public LOAN_APPROVAL()
        {
            InitializeComponent();
        }

        private void LOAN_APPROVAL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANKINGDataSet.LOAN' table. You can move, or remove it, as needed.
            this.lOANTableAdapter.Fill(this.bANKINGDataSet.LOAN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true; ";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " UPDATE LOAN SET STATUS ='" + textBox2.Text + "' WHERE LOAN_NUMBER = '" + textBox1.Text +"'" ; //ELMAFROD YD5L BYANAT ELLOAN W YKTB FE ELSTATUS ACCEPTED AW REJECTED 
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("ACCEPTED");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMP_OPTIONS eMP_OPTIONS = new EMP_OPTIONS();
            eMP_OPTIONS.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true; ";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " UPDATE LOAN SET STATUS ='" + textBox3.Text + "' WHERE LOAN_NUMBER = '" + textBox1.Text + "'"; //ELMAFROD YD5L BYANAT ELLOAN W YKTB FE ELSTATUS ACCEPTED AW REJECTED 
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("REJECTED");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lOANTableAdapter.Fill(this.bANKINGDataSet.LOAN);
        }
    }
}
