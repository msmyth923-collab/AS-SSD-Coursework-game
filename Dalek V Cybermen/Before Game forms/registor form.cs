using Dalek_V_Cybermen.Help_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dalek_V_Cybermen.Before_Game_forms
{
    public partial class registor_form : Form
    {
        int teachID;
        public registor_form()
        {
            InitializeComponent();
        }

        //Creates 2 lists to store usernames and passwords
        List<string> users = new List<string>();
        List<string> passwords = new List<string>();

        public Boolean notEmpty(string username, string password, string yearGroup, string favSubject)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(yearGroup) || string.IsNullOrEmpty(favSubject))
            {
                MessageBox.Show("Text boxes, or Drop Down boxes cannot be left empty");
                return true;
            }
            else
                return false;
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login = new Login_Form();
            login.Show();
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help_Registor help_Registor = new Help_Registor();
            help_Registor.Show();
        }

        private void registor_form_Load(object sender, EventArgs e)
        {
            //checks to see if loginDetails is not empty
            if (new FileInfo("playerLoginDetails.txt").Length != 0)
            {
                //if loginDetails text file is not empty take all usernames and store them in 'users' list
                using (StreamReader sr = new StreamReader("playerLoginDetails.txt"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] components = line.Split("~".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        users.Add(components[0]);
                        passwords.Add(components[1]);
                    }
                    sr.Close();
                }
            }
        }

        private void registorBTN_Click(object sender, EventArgs e)
        {
            //check if a username already exists
            if (users.Contains(usernameTB.Text))
            {
                MessageBox.Show("Username has already been used. Try Again");
            }

            //checks if the username textbox contains capitals
            else if (usernameTB.Text.Any(char.IsUpper))
            {
                MessageBox.Show("The username Contains one or more capitals,\n please change it to not contain capitals");
            }

            //checks the list if the entered username and password are present in both the users and passwords
            else if (users.Contains(usernameTB.Text) && passwords.Contains(passwordTB.Text))
            {
                MessageBox.Show("A user has already been registored under the entered username and password");
            }

            //Checking if the text boxes and combo boxes are empty
            else if (notEmpty(usernameTB.Text, passwordTB.Text, yrGroupCB.Text, favSubjectCB.Text))
            {

            }

            //checks if there are digits in the username
            else if (usernameTB.Text.Any(char.IsDigit))
            {
                MessageBox.Show("There are numbers within the username please remove the numbers to continue");
            }

            //checks to see if there is spaces in textboxes and the favSubject combo box
            else if (usernameTB.Text.Contains(" ") || passwordTB.Text.Contains(" ") || reEnterPasswordTB.Text.Contains(" "))
            {
                MessageBox.Show("No spaces can be left in text boxes or drop down boxes");
            }

            else if(favSubjectCB.SelectedIndex == -1 || yrGroupCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid year group and or favourite subject");
            }
            else
            {
                //Length check
                if (usernameTB.Text.Length > 6 && usernameTB.Text.Length < 31)
                {
                    if (passwordTB.Text.Any(char.IsDigit) && passwordTB.Text.Any(char.IsUpper) &&
                        reEnterPasswordTB.Text.Any(char.IsDigit) && reEnterPasswordTB.Text.Any(char.IsUpper) && //Checks if there is digits in the password and reenter password text boxes

                        passwordTB.Text.Length > 9 && passwordTB.Text.Length < 31 && //Checks if the length of the password and reEnterpassword are more than 9 and less than 31
                        reEnterPasswordTB.Text.Length > 9 && reEnterPasswordTB.Text.Length < 31)
                    {
                        //password verification
                        if (passwordTB.Text == reEnterPasswordTB.Text)
                        {
                            using (StreamWriter sw = new StreamWriter("playerLoginDetails.txt", true))
                            {
                                string loginDetails = usernameTB.Text + "~" + passwordTB.Text + "~" +
                                                      yrGroupCB.Text + "~" + favSubjectCB.Text;
                                sw.WriteLine(loginDetails);
                                sw.Close();
                            }
                            DialogResult result = MessageBox.Show("the Data you have entered is:\n" +
                                            "Username: " + usernameTB.Text +
                                            "\nYear Group: " + yrGroupCB.Text +
                                            "\nFavourite Subject: " + favSubjectCB.Text +
                                            "\nIs all of this information correct?"
                                            , "Correct information?", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {

                                MessageBox.Show("New user has been added", "New User added");

                                //clears anything stored in the text boxes and check boxes
                                usernameTB.Clear();
                                passwordTB.Clear();
                                reEnterPasswordTB.Clear();

                                this.Hide();
                                Login_Form LogInForm = new Login_Form();
                                LogInForm.Show();
                            }

                        }
                        else //NOT MATCHING PASSWORDS
                        {
                            MessageBox.Show("Passwords do not match, please Try again");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The password and/or reEnter password boxes must contain atleast: \n 1 capital \n 1 number \n and have a length of atleast 10 characters");
                    }

                }
                else //LENGTH CHECK
                {
                    MessageBox.Show("The username must be 7 or more characters long \n and 30 or less characters long");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordTB.UseSystemPasswordChar == true && reEnterPasswordTB.UseSystemPasswordChar == true)
            {
                passwordTB.UseSystemPasswordChar = false;
                reEnterPasswordTB.UseSystemPasswordChar = false;
                button1.Text = "hide Password";
            }
            else
            {
                passwordTB.UseSystemPasswordChar = true;
                reEnterPasswordTB.UseSystemPasswordChar = true;
                button1.Text = "show Password";
            }
        }
    }
}
