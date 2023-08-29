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
    public partial class WEB_CHANGEACCOUNT : Form
    {
        public WEB_CHANGEACCOUNT()
        {
            InitializeComponent();
        }

      
        //Button Back Click Event
        //Go Back To Web Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Web web = new Web();
                web.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //Button Update Click Event
        //Update the WebSites Details
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtWebsite_Address.Text !="" && TxtLogIn.Text !="" && TxtPassword.Text !="")
                {
                    //Create ConnectionString
                    string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                    //Create SqlConnection with Connection class
                    SqlConnection Con = new SqlConnection(ConnectionString);

                    //Open the Connection
                    Con.Open();

                    //SQL Steatement
                    string sql = "UPDATE WEBSITES SET WEBSITE_LOGIN='" + TxtLogIn.Text + "',WEBSITE_PASSWORD='" + TxtPassword.Text + "' " +
                        "WHERE WEBSITE_ADDRESS ='" + TxtWebsite_Address.Text + "' ";

                    //create Command class Object
                    SqlCommand command = new SqlCommand(sql, Con);

                    //Execute the Sql Steatement
                    command.ExecuteNonQuery();

                    //Output
                    MessageBox.Show("Succesfully Updated Your Web Sites Details");

                    //Clear the Buttons
                    TxtWebsite_Address.Text = "";
                    TxtLogIn.Text = "";
                    TxtPassword.Text = "";

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

        private void TxtLogIn_Enter(object sender, EventArgs e)
        {
            try
            {
                if (TxtLogIn.Text == "Ex:LogIn")
                {
                    TxtLogIn.Text = "";
                    TxtLogIn.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtLogIn_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxtLogIn.Text == "")
                {
                    TxtLogIn.Text = "Ex:LogIn";
                    TxtLogIn.ForeColor = Color.Silver;
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
