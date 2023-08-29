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
    public partial class BANKCARD_ADDCARD : Form
    {
        public BANKCARD_ADDCARD()
        {
            InitializeComponent();
        }

        //Button Add Click Event
        //Go to Add BankCard Page
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_CardNumber.Text != "" && Txt_CardHolder.Text != "" && Txt_ExpireDate.Text != "" && Txt_Cvv.Text != "" && Txt_PinNumber.Text != "" && Txt_CardNumber.Text != "" && Txt_Comment.Text != "")
                {
                    //Create ConnectionString
                    string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                    //Create SqlConnection with Connection class
                    SqlConnection Con = new SqlConnection(ConnectionString);

                    //Open the Connection
                    Con.Open();

                    //SQL Steatement
                    string sql = "INSERT INTO BANKCARDS(CARD_NUMBER,CARD_HOLDER,EXPIRE_DATE,CVV,PIN_NUMBER,CARD_ISSUER,COMMENT)" +
                    "VALUES('" + Txt_CardNumber.Text + "','" + Txt_CardHolder.Text + "','" + Txt_ExpireDate.Text + "','" + Txt_Cvv.Text + "','" + Txt_PinNumber.Text + "','" + Txt_CardIssuer.Text + "','" + Txt_Comment.Text + "')";

                    //create Command class Object
                    SqlCommand command = new SqlCommand(sql, Con);

                    //Execute the Sql Steatement
                    command.ExecuteNonQuery();

                    //Output
                    MessageBox.Show("Succesfully Added Your BankCard Details");

                    //Clear the Buttons
                    Txt_CardNumber.Text = "";
                    Txt_CardHolder.Text = "";
                    Txt_ExpireDate.Text = "";
                    Txt_Cvv.Text = "";
                    Txt_PinNumber.Text = "";
                    Txt_CardIssuer.Text = "";
                    Txt_Comment.Text = "";

                    //Close the Connection
                    Con.Close();

                }
                else
                {
                    MessageBox.Show("Please Fill the Blanks");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Clear Button Click Event
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_CardNumber.Text = "";
                Txt_CardHolder.Text = "";
                Txt_ExpireDate.Text = "";
                Txt_Cvv.Text = "";
                Txt_PinNumber.Text = "";
                Txt_CardIssuer.Text = "";
                Txt_Comment.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Back to BankCard Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                BankCards Bankcards = new BankCards();
                Bankcards.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        //Button Update Click Event
        //Update the BANK CARDS Details
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_CardNumber.Text != "" && Txt_CardHolder.Text != "" && Txt_ExpireDate.Text != "" && Txt_Cvv.Text != "" && Txt_PinNumber.Text != "" && Txt_CardNumber.Text != "" && Txt_Comment.Text != "")
                {
                    //Create ConnectionString
                    string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                    //Create SqlConnection with Connection class
                    SqlConnection Con = new SqlConnection(ConnectionString);

                    //Open the Connection
                    Con.Open();

                    //SQL Steatement
                    string sql = "UPDATE BANKCARDS SET CARD_HOLDER='" + Txt_CardHolder.Text + "',EXPIRE_DATE='" + Txt_ExpireDate.Text + "',CVV='" + Txt_Cvv.Text + "',PIN_NUMBER='" + Txt_PinNumber.Text + "',CARD_ISSUER='" + Txt_CardIssuer.Text + "',COMMENT='" + Txt_Comment.Text + "' " +
                        "WHERE CARD_NUMBER ='" + Txt_CardNumber.Text + "' ";

                    //create Command class Object
                    SqlCommand command = new SqlCommand(sql, Con);

                    //Execute the Sql Steatement
                    command.ExecuteNonQuery();

                    //Output
                    MessageBox.Show("Succesfully Updated Your BankCard Details");

                    //Clear the Buttons
                    Txt_CardNumber.Text = "";
                    Txt_CardHolder.Text = "";
                    Txt_ExpireDate.Text = "";
                    Txt_Cvv.Text = "";
                    Txt_PinNumber.Text = "";
                    Txt_CardIssuer.Text = "";
                    Txt_Comment.Text = "";

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

        private void Txt_ExpireDate_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_ExpireDate.Text == "Ex:MM/YYYY")
                {
                    Txt_ExpireDate.Text = "";
                    Txt_ExpireDate.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_ExpireDate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_ExpireDate.Text == "")
                {
                    Txt_ExpireDate.Text = "Ex:MM/YYYY";
                    Txt_ExpireDate.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Cvv_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Cvv.Text == "Ex:CVV")
                {
                    Txt_Cvv.Text = "";
                    Txt_Cvv.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Cvv_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Cvv.Text == "")
                {
                    Txt_Cvv.Text = "Ex:CVV";
                    Txt_Cvv.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_PinNumber_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_PinNumber.Text == "Ex:Pin Number")
                {
                    Txt_PinNumber.Text = "";
                    Txt_PinNumber.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_PinNumber_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_PinNumber.Text == "")
                {
                    Txt_PinNumber.Text = "Ex:Pin Number";
                    Txt_PinNumber.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_CardIssuer_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_CardIssuer.Text == "Ex:Card Issuer")
                {
                    Txt_CardIssuer.Text = "";
                    Txt_CardIssuer.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_CardIssuer_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_CardIssuer.Text == "")
                {
                    Txt_CardIssuer.Text = "Ex:Card Issuer";
                    Txt_CardIssuer.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Comment_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Comment.Text == "Ex:Comment")
                {
                    Txt_Comment.Text = "";
                    Txt_Comment.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Comment_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Comment.Text == "")
                {
                    Txt_Comment.Text = "Ex:Comment";
                    Txt_Comment.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
