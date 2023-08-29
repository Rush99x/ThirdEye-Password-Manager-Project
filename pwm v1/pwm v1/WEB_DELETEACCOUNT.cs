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
    public partial class WEB_DELETEACCOUNT : Form
    {
        public WEB_DELETEACCOUNT()
        {
            InitializeComponent();
        }

        //Delete Button Click Event
        //Delete Web Sites Details
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtWebsite_Address.Text !="" && TxtPassword.Text !="")
                {
                    //Create ConnectionString
                    string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                    //Create SqlConnection with Connection class
                    SqlConnection Con = new SqlConnection(ConnectionString);

                    //Open the Connection
                    Con.Open();

                    //SQL Steatement
                    string sql = "DELETE FROM WEBSITES WHERE WEBSITE_ADDRESS = '" + TxtWebsite_Address.Text + "' AND WEBSITE_PASSWORD ='" + TxtPassword.Text + "' ";

                    //create Command class Object
                    SqlCommand command = new SqlCommand(sql, Con);

                    //Execute the Sql Steatement
                    command.ExecuteNonQuery();

                    //Output
                    MessageBox.Show("Succesfully Deleted Your Web Sites Details");

                    //Close the Connection
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Please Fill the Blanks");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Back Click Event
        //Go Back to Web page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Web WEB = new Web();
                WEB.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
        }

        private void TxtWebsite_Address_Enter(object sender, EventArgs e)
        {
            try
            {
                if (TxtWebsite_Address.Text == "Ex:Website Address")
                {
                    TxtWebsite_Address.Text = "";
                    TxtWebsite_Address.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtWebsite_Address_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxtWebsite_Address.Text == "")
                {
                    TxtWebsite_Address.Text = "Ex:Website Address";
                    TxtWebsite_Address.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            try
            {
                if (TxtPassword.Text == "Ex:Password")
                {
                    TxtPassword.Text = "";
                    TxtPassword.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxtPassword.Text == "")
                {
                    TxtPassword.Text = "Ex:Password";
                    TxtPassword.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
