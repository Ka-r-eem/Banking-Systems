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
    public partial class DET : Form
    {
        public DET()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true;");
            con.Open();
            SqlCommand Mycommand = new SqlCommand("SELECT CUSTOMER.FNAME ,EMPLOYEE.EMP_FNAME ,LOAN.LOAN_NUMBER FROM CUSTOMER , EMPLOYEE , LOAN, ADDING, TAKE WHERE CUSTOMER.CUSTOMER_SSN = TAKE.CUSTOMER_SSN AND EMPLOYEE.EMP_ID = ADDING.EMP_ID AND ADDING.LOAN_NUMBER =TAKE.LOAN_NUMBER;", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Mycommand);
            DataTable mydatabase = new DataTable();
            myAdapter.Fill(mydatabase);
            dataGridView1.DataSource = mydatabase;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMIN aDMIN = new ADMIN();
            aDMIN.Show();
            this.Hide();
        }
    }
}
