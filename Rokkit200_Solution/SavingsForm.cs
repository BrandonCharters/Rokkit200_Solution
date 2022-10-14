using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rokkit200_Solution.Classes;

namespace Rokkit200_Solution
{
    public partial class SavingsForm : Form
    {
        //Variables created for the users balance as well as the new balance after calculations
        public static int userBalance;
        public static int newBalance;


        public SavingsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button for withdrawing money from the users balance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savingsWithdrawBtn_Click(object sender, EventArgs e)
        {
            int withdrawAmount;

            //Try and catch for error handling
            //Inside the try is an if statement checking if the text being inputted is not an int and throwing and exception.
            try
            {
                withdrawErrorsLbl.Visible = false;

                if (!Int32.TryParse(withdrawTxt.Text, out withdrawAmount))
                {
                    throw new CustomException("Please enter a valid number");
                }

                //Calculation for the withdraw of money
                withdrawAmount = Convert.ToInt32(withdrawTxt.Text);
                newBalance = userBalance - withdrawAmount;

                //Checking if the newBalance is greater than R1000 as the balance cannot be less than R1000
                if (newBalance >= 1000)
                {
                    currentBalancelbl.Text = $"R{newBalance}";
                }
                else
                {
                    throw new CustomException("Balance amount can't be less than R1000");
                }
            }
            catch (Exception ex)
            {
                withdrawErrorsLbl.Visible = true;
                withdrawErrorsLbl.Text = ex.Message;
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Button that allows the user to deposit money to their balance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savingsDepositBtn_Click(object sender, EventArgs e)
        {
            int depositAmount;

            //Try and catch for error handling
            //The button is the same as the withdraw but it is adding funds instead of withdrawing them.
            try
            {
                depositErrorLbl.Visible = false;

                if (!Int32.TryParse(depositTxt.Text, out depositAmount))
                {
                    throw new CustomException("Please enter a valid number");
                }

                depositAmount = Convert.ToInt32(depositTxt.Text);
                newBalance = userBalance + depositAmount;
                currentBalancelbl.Text = $"R{newBalance}";
            }
            catch (Exception ex)
            {
                depositErrorLbl.Visible = true;
                depositErrorLbl.Text = ex.Message;
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Button to go back to the user select page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 backForm1 = new Form1();
            this.Hide();
            backForm1.Show();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Button to exit the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// On page load event
        /// When the page loads then the app will retrieve the user that the was chosen on the previous page and will change the balance accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                depositApprovedLbl.Visible = false;

                currentBalancelbl.Visible = false;

                if (Form1.SetUserChoice.Equals(1))
                {
                    userBalance = 2000;
                    currentBalancelbl.Visible = true;
                    currentBalancelbl.Text = $"R{userBalance}";
                }
                else if (Form1.SetUserChoice.Equals(2))
                {
                    userBalance = 5000;
                    currentBalancelbl.Visible = true;
                    currentBalancelbl.Text = $"R{userBalance}";
                }

                if (userBalance > 1000)
                {
                    depositApprovedLbl.Visible = true;
                    depositApprovedLbl.Text = "Your current balance is able to deposit funds.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//