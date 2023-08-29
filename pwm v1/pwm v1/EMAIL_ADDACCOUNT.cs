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
    public partial class EMAIL_ADDACCOUNT : Form
    {
        public EMAIL_ADDACCOUNT()
        {
            InitializeComponent();
        }

        //Button Add Click Event
        //Add Emails Details
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtAccountName.Text!="" && TxtPassword.Text!="" && RtxtComment.Text!="")
                {
                    //Create ConnectionString
                    string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                    //Create SqlConnection with Connection class
                    SqlConnection Con = new SqlConnection(ConnectionString);

                    //Open the Connection
                    Con.Open();

                    //SQL Steatement
                    string sql = "INSERT INTO EMAILS(EMAIL_ACCOUNTNAME,EMAIL_PASSWORD,COMMENT)" +
                    "VALUES('" + TxtAccountName.Text + "','" + TxtPassword.Text + "','" + RtxtComment.Text + "')";

                    //create Command class Object
                    SqlCommand command = new SqlCommand(sql, Con);

                    //Execute the Sql Steatement
                    command.ExecuteNonQuery();

                    //Output
                    MessageBox.Show("Succesfully Add Email Details");

                    //Clear the TextBoxes
                    TxtAccountName.Text = "";
                    TxtPassword.Text = "";
                    RtxtComment.Text = "";

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

        //IconButton Back Click Event
        //Go to Email Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Email email = new Email();
                email.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Clear the Textboxes
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                TxtAccountName.Text = "";
                TxtPassword.Text = "";
                RtxtComment.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //RichTextbox Enter Event
        private void RtxtComment_Enter(object sender, EventArgs e)
        {
            try
            {
                if (RtxtComment.Text == "Add Your Comment Here")
                {
                    RtxtComment.Text = "";
                    RtxtComment.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //RichTextbox Leave Event
        private void RtxtComment_Leave(object sender, EventArgs e)
        {
            try
            {
                if (RtxtComment.Text == "")
                {
                    RtxtComment.Text = "Add Your Comment Here";
                    RtxtComment.ForeColor = Color.Silver;
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
                if (TxtAccountName.Text == "EX.Account Name")
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
                    TxtAccountName.Text = "EX.Account Name";
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
