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
    public partial class Applications : Form
    {
        public Applications()
        {
            InitializeComponent();
        }

        //Go to Application Adding Page
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                APPLICATION_ADDACCOUNT APPLICATION = new APPLICATION_ADDACCOUNT();
                APPLICATION.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        //Go to Application Change Page
        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                APPLICATION_CHANGEACCOUNT APPLICATION = new APPLICATION_CHANGEACCOUNT();
                APPLICATION.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Back To Home Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Home Home = new Home();
                Home.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Delete Saved Application Details
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                APPLICATION_DELETEACCOUNT APPLICATION = new APPLICATION_DELETEACCOUNT();
                APPLICATION.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //View the Application Details
        private void Applications_Load(object sender, EventArgs e)
        {
            try
            {
                //Create ConnectionString
                string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                //Create SqlConnection with Connection class
                SqlConnection Con = new SqlConnection(ConnectionString);

                //Open the Connection
                Con.Open();

                //SQL Statement
                string sql = "SELECT * FROM APPLICATIONS";

                //Create Sqlcommand class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Create SqlDataAdapter class Object
                SqlDataAdapter adaobj = new SqlDataAdapter(command);

                //creating a datatble Object
                DataTable dataTable = new DataTable();

                //filling the data table with data
                adaobj.Fill(dataTable);

                //set the data in grid view
                GRID_APPLICATION.DataSource = dataTable;

                //Close the Connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
