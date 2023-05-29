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
    public partial class LOAN_REQ : Form
    {
        public LOAN_REQ()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUS_OPTIONS cUS_OPTIONS = new CUS_OPTIONS();
            cUS_OPTIONS.Show();
            this.Hide();
        }

        private void LOAN_REQ_Load(object sender, EventArgs e)
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
            sqlCommand.CommandText = " INSERT INTO LOAN VALUES ( LOAN_TYPE = '" + textBox1.Text + "' ,LOAN_AMOUNT = '" + textBox2.Text + "' , STATUS = '" +textBox3.Text +"'"; 
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("REQUEST DONE");
        }
    }
}
