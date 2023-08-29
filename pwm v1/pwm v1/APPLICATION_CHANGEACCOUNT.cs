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
    public partial class APPLICATION_CHANGEACCOUNT : Form
    {
        public APPLICATION_CHANGEACCOUNT()
        {
            InitializeComponent();
        }

        //Button Update Click Event
        //Update the Application Details
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtApplication_Name.Text!="" && TxtUserName.Text!="" && TxtPassword.Text!="")
                {
                    //Create ConnectionString
                    string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                    //Create SqlConnection with Connection class
                    SqlConnection Con = new SqlConnection(ConnectionString);

                    //Open the Connection
                    Con.Open();

                    //SQL Steatement
                    string sql = "UPDATE APPLICATIONS SET APPLICATION_USERNAME='" + TxtUserName.Text + "',APPLICATION_PASSWORD='" + TxtPassword.Text + "'" +
                        "WHERE APPLICATION_NAME ='" + TxtApplication_Name.Text + "' ";

                    //create Command class Object
                    SqlCommand command = new SqlCommand(sql, Con);

                    //Execute the Sql Steatement
                    command.ExecuteNonQuery();

                    //Output
                    MessageBox.Show("Succesfully Updated Your BankCard Details");

                    //Clear the TextBoxes
                    TxtApplication_Name.Text = "";
                    TxtUserName.Text = "";
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

        //Button Back Click Event
        //Clear the TextBoxes 
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Applications applications = new Applications();
                applications.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //Button Clear Click Event
        //Clear the TextBoxes
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                TxtApplication_Name.Text = "";
                TxtUserName.Text = "";
                TxtPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtApplication_Name_Enter(object sender, EventArgs e)
        {
            try
            {
                if (TxtApplication_Name.Text == "Ex:Application Name")
                {
                    TxtApplication_Name.Text = "";
                    TxtApplication_Name.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtApplication_Name_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxtApplication_Name.Text == "")
                {
                    TxtApplication_Name.Text = "Ex:Application Name";
                    TxtApplication_Name.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            try
            {
                if (TxtUserName.Text == "Ex:User Name")
                {
                    TxtUserName.Text = "";
                    TxtUserName.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxtUserName.Text == "")
                {
                    TxtUserName.Text = "Ex:User Name";
                    TxtUserName.ForeColor = Color.Silver;
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
