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
    public partial class SQL : Form
    {
        public SQL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true;");
            con.Open();
            SqlCommand Mycommand = new SqlCommand("SELECT BRANCH.BRANCH_NUMBER FROM BRANCH WHERE BRANCH.NO_OF_CUSTOMERS = 0", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Mycommand);
            DataTable mydatabase = new DataTable();
            myAdapter.Fill(mydatabase);
            dataGridView1.DataSource = mydatabase;
            con.Close();


        }

        private void SQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANKINGDataSet.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.bANKINGDataSet.BRANCH);
            // TODO: This line of code loads data into the 'bANKINGDataSet.LOAN' table. You can move, or remove it, as needed.
            this.lOANTableAdapter.Fill(this.bANKINGDataSet.LOAN);
            // TODO: This line of code loads data into the 'bANKINGDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.bANKINGDataSet.EMPLOYEE);
            // TODO: This line of code loads data into the 'bANKINGDataSet.ADDING' table. You can move, or remove it, as needed.
            this.aDDINGTableAdapter.Fill(this.bANKINGDataSet.ADDING);
            // TODO: This line of code loads data into the 'bANKINGDataSet.TAKE' table. You can move, or remove it, as needed.
            this.tAKETableAdapter.Fill(this.bANKINGDataSet.TAKE);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true;");
            con.Open();
            SqlCommand Mycommand = new SqlCommand("SELECT BRANCH.BRANCH_NUMBER FROM BRANCH WHERE BRANCH.NO_OF_EMPLOYEES = 0", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Mycommand);
            DataTable mydatabase = new DataTable();
            myAdapter.Fill(mydatabase);
            dataGridView1.DataSource = mydatabase;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true;");
            con.Open();
            SqlCommand Mycommand = new SqlCommand("SELECT EMPLOYEE.EMP_FNAME , EMPLOYEE.EMP_LNAME FROM EMPLOYEE where NO_OF_LOANS = (select  MAX(EMPLOYEE.NO_OF_LOANS) from EMPLOYEE ) GROUP BY EMP_FNAME , EMP_LNAME", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Mycommand);
            DataTable mydatabase = new DataTable();
            myAdapter.Fill(mydatabase);
            dataGridView1.DataSource = mydatabase;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true;");
            con.Open();
            SqlCommand Mycommand = new SqlCommand("SELECT CUSTOMER.FNAME , CUSTOMER.LNAME FROM CUSTOMER where NO_OF_LOANS = (select  MAX(CUSTOMER.NO_OF_LOANS) from CUSTOMER ) GROUP BY FNAME , LNAME; ", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Mycommand);
            DataTable mydatabase = new DataTable();
            myAdapter.Fill(mydatabase);
            dataGridView1.DataSource = mydatabase;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(" server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true;");
            con.Open();
            SqlCommand Mycommand = new SqlCommand("SELECT CUSTOMER.FNAME , CUSTOMER.LNAME FROM CUSTOMER WHERE NO_OF_LOANS = 0; ", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Mycommand);
            DataTable mydatabase = new DataTable();
            myAdapter.Fill(mydatabase);
            dataGridView1.DataSource = mydatabase;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" server= DESKTOP-TEUK540 ; database = BANKING ;integrated security = true;");
            con.Open();
            SqlCommand Mycommand = new SqlCommand(" SELECT * FROM CUSTOMER ", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Mycommand);
            DataTable mydatabase = new DataTable();
            myAdapter.Fill(mydatabase);
            dataGridView1.DataSource = mydatabase;
            con.Close();
        }
    }
}
