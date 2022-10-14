using Rokkit200_Solution.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rokkit200_Solution
{
    /*
     * I have created a working application to the best of my ability.
     * Points to make about my application are as follows:
     * I am aware that when the user withdraws or deposits funds for the second time that the balance being used in the calculation would be the original balance and not the new balance.
     * I did not manage to use the interface which was given as a requirement as I was getting a version error, has something to do with the version of my c#.
     * I had not included a built in DB but rather tried my best to put in place a replacement.
     *
     * I did not manage to incorporate all of the required features as I have had an extremely busy week with assignments and group work. I still wanted to give something that shows my working structure.
     */
    public partial class Form1 : Form
    {
        //Creating a variable for the users choice.
        public static int SetUserChoice;

        public Form1()
        {
            InitializeComponent();
        }

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
        /// Button to take the user to the current account page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentAccountPage_Click(object sender, EventArgs e)
        {
            //Try and catch for error handling
            //Within the try is an if statement where the a check for whether a user has been selected.
            try
            {
                userErrorLbls.Visible = false;

                if (!user1Radio.Checked && !user2Radio.Checked)
                    throw new CustomException("Please select a user");

                if (user1Radio.Checked)
                {
                    SetUserChoice = 1;
                    currentPageNavigation();
                }
                else if (user2Radio.Checked)
                {
                    SetUserChoice = 2;
                    currentPageNavigation();
                }
            }
            //Displaying an error if no user has been selected
            catch (Exception ex)
            {
                userErrorLbls.Visible = true;
                userErrorLbls.Text = ex.Message;
            }

        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Button to take the user to the savings page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavingsAccountPage_Click(object sender, EventArgs e)
        {
            //Try and catch for error handling
            //Inside the try is the same as the code above, could be made into a single method for simplicity and ease
            try
            {
                userErrorLbls.Visible = false;

                if (!user1Radio.Checked && !user2Radio.Checked)
                    throw new CustomException("Please select a user");

                else if (user1Radio.Checked)
                {
                    SetUserChoice = 1;
                    savingPageNavigation();
                }
                else if (user2Radio.Checked)
                {
                    SetUserChoice = 2;
                    savingPageNavigation();
                }
            }
            catch (Exception ex)
            {
                userErrorLbls.Visible = true;
                userErrorLbls.Text = ex.Message;
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Method for navigating to to the current account page
        /// </summary>
        private void currentPageNavigation()
        {
            CurrentForm toCurrentForm = new CurrentForm();
            this.Hide();
            toCurrentForm.Show();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Method for navigating to the savings account page
        /// </summary>
        private void savingPageNavigation()
        {
            SavingsForm toSavingsForm = new SavingsForm();
            this.Hide();
            toSavingsForm.Show();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//
