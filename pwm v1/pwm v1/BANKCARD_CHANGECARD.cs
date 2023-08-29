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
    public partial class BANKCARD_CHANGECARD : Form
    {
        public BANKCARD_CHANGECARD()
        {
            InitializeComponent();
        }

        //Delete Button Click Event
        //Go to BankCard Delete Page
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(Txt_CardNumber.Text !="" && Txt_CardHolder.Text !="")
                {
                    //Create ConnectionString
                    string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                    //Create SqlConnection with Connection class
                    SqlConnection Con = new SqlConnection(ConnectionString);

                    //Open the Connection
                    Con.Open();

                    //SQL Steatement
                    string sql = "DELETE FROM BANKCARDS WHERE CARD_NUMBER = '" + Txt_CardNumber.Text + "' AND CARD_HOLDER='" + Txt_CardHolder.Text + "' ";

                    //create Command class Object
                    SqlCommand command = new SqlCommand(sql, Con);

                    //Execute the Sql Steatement
                    command.ExecuteNonQuery();

                    //Output
                    MessageBox.Show("Succesfully Deleted Your Email Account Details");

                    //Clear Textboxes
                    Txt_CardNumber.Text = "";
                    Txt_CardHolder.Text = "";

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

        //Go Back To Bank Card Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                BankCards BankCard = new BankCards();
                BankCard.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_CardNumber_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_CardNumber.Text == "Ex:1234 1234 1234 1234")
                {
                    Txt_CardNumber.Text = "";
                    Txt_CardNumber.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_CardNumber_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_CardNumber.Text == "")
                {
                    Txt_CardNumber.Text = "Ex:1234 1234 1234 1234";
                    Txt_CardNumber.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_CardHolder_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_CardHolder.Text == "Ex:Card Holder")
                {
                    Txt_CardHolder.Text = "";
                    Txt_CardHolder.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_CardHolder_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_CardHolder.Text == "")
                {
                    Txt_CardHolder.Text = "Ex:Card Holder";
                    Txt_CardHolder.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
