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
    public partial class EMAIL_CHANGEACCOUNT : Form
    {
        public EMAIL_CHANGEACCOUNT()
        {
            InitializeComponent();
        }

        //Go back to Email Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Email email = new Email();
                email.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Update Email Details
        private void BtnUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtAccountName.Text !="" &&TxtPassword.Text !="")
                {
                    //Create ConnectionString
                    string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                    //Create SqlConnection with Connection class
                    SqlConnection Con = new SqlConnection(ConnectionString);

                    //Open the Connection
                    Con.Open();

                    //SQL Steatement
                    string sql = "UPDATE EMAILS SET EMAIL_ACCOUNTNAME = '" + TxtAccountName.Text + "' ,EMAIL_Password = '" + TxtPassword.Text + "' WHERE EMAIL_ACCOUNTNAME = '" + TxtAccountName.Text + "'";

                    //create Command class Object
                    SqlCommand command = new SqlCommand(sql, Con);

                    //Execute the Sql Steatement
                    command.ExecuteNonQuery();

                    //Output
                    MessageBox.Show("Succesfully Updated Your Email Account Details");

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

        //Clear Button Click Event
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                TxtAccountName.Text = "";
                TxtPassword.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Delete Email Details
        private void BtnDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtAccountName.Text != "" && TxtPassword.Text != "")
                {
                    //Create ConnectionString
                    string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                    //Create SqlConnection with Connection class
                    SqlConnection Con = new SqlConnection(ConnectionString);

                    //Open the Connection
                    Con.Open();

                    //SQL Steatement
                    string sql = "DELETE FROM EMAILS WHERE  EMAIL_ACCOUNTNAME='" + TxtAccountName.Text + "' ";

                    //create Command class Object
                    SqlCommand command = new SqlCommand(sql, Con);

                    //Execute the Sql Steatement
                    command.ExecuteNonQuery();

                    //Output
                    MessageBox.Show("Succesfully Deleted Your Email Account Details");

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

        private void TxtAccountName_Enter(object sender, EventArgs e)
        {
            try
            {
                if (TxtAccountName.Text == "EX.AccountName")
                {
                    TxtAccountName.Text = "";
                    TxtAccountName.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtAccountName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxtAccountName.Text == "")
                {
                    TxtAccountName.Text = "EX.AccountName";
                    TxtAccountName.ForeColor = Color.Silver;
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
                if (TxtPassword.Text == "EX.Password")
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
                    TxtPassword.Text = "EX.Password";
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
