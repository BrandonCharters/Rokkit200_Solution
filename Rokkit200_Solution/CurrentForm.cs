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
    public partial class CurrentForm : Form
    {
        //Variables are being made
        public static string balance;
        public static int userBalance;
        public static int newBalance;
        public static int overdraftAmount;

        public CurrentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to withdraw money from the balance of the user
        /// The user cannot withdraw the sum of their overdraft amount and balance amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentWithdrawBtn_Click(object sender, EventArgs e)
        {
            int withdrawAmount;

            try
            {
                withdrawErrorLbl.Visible = false;

                if (!Int32.TryParse(withdrawTxt.Text, out withdrawAmount))
                {
                    throw new CustomException("Please enter a valid number");
                }

                withdrawAmount = Convert.ToInt32(withdrawTxt.Text);
                newBalance = userBalance - withdrawAmount;

                if (withdrawAmount >= (overdraftAmount + userBalance))
                {
                    throw new CustomException("You are trying to withdraw more than you are allowed.");
                }

                currentBalance.Text = $"User balance amount: R{newBalance} Overdraft amount: R{overdraftAmount}";
            }
            catch (Exception ex)
            {
                withdrawErrorLbl.Visible = true;
                withdrawErrorLbl.Text = ex.Message;
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Button to deposit money into the balance of the user
        /// The user can deposit as much as they want
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentDepositBtn_Click(object sender, EventArgs e)
        {
            int depositAmount;

            try
            {
                depositErrorLbl.Visible = false;

                if (!Int32.TryParse(depositTxt.Text, out depositAmount))
                {
                    throw new CustomException("Please enter a valid number");
                }

                depositAmount = Convert.ToInt32(depositTxt.Text);
                newBalance = userBalance + depositAmount;
                currentBalance.Text = $"User balance amount: R{newBalance} Overdraft amount: R{overdraftAmount}";
            }
            catch (Exception ex)
            {
                depositErrorLbl.Visible = true;
                depositErrorLbl.Text = ex.Message;
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Button to go back to the home page
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
        /// Form load event
        /// When the form is loaded the app will check which of the users have been chosen and will display the appropriate values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentForm_Load(object sender, EventArgs e)
        {
            try
            {
                currentBalance.Visible = false;

                if (Form1.SetUserChoice.Equals(1))
                {
                    userBalance = 1000;
                    overdraftAmount = 10000;

                    balance = $"User balance amount: R{userBalance} Overdraft amount: R{overdraftAmount}";
                    currentBalance.Visible = true;
                    currentBalance.Text = balance;
                }
                else if (Form1.SetUserChoice.Equals(2))
                {
                    userBalance = -5000;
                    overdraftAmount = 20000;

                    balance = $"User balance amount: R{userBalance} Overdraft amount: R{overdraftAmount}";
                    currentBalance.Visible = true;
                    currentBalance.Text = balance;
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