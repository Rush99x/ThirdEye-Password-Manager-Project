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

namespace pwm_v1
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        //Go to add email account
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EMAIL_ADDACCOUNT ADDACCOUNT = new EMAIL_ADDACCOUNT();
                ADDACCOUNT.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Display Emails Details
        private void Email_Load(object sender, EventArgs e)
        {
            try
            {
                //connection string
                string connectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS; Initial Catalog=THIRDEYE_PASSWORD_MANAGER; user id=yasiru; password=123456789";

                //create sql connection class object
                SqlConnection Con = new SqlConnection(connectionString);

                //Open the connection
                Con.Open();

                //Sql statement
                string sql = "select * from EMAILS";

                //Create Sqlcommand class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Create SqlDataAdapter class Object
                SqlDataAdapter adaobj = new SqlDataAdapter(command);

                //creating a datatble Object
                DataTable dataTable = new DataTable();

                //filling the data table with data
                adaobj.Fill(dataTable);

                //set the data in grid view
                DataGrid_Email.DataSource = dataTable;

                //Close the Connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Back to HOME page
        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Home home = new Home();
                home.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Go to Change email account
        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                EMAIL_CHANGEACCOUNT CHANGEACCOUNT = new EMAIL_CHANGEACCOUNT();
                CHANGEACCOUNT.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
