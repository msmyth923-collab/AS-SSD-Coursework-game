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
using System.Media;

namespace Dalek_V_Cybermen.Before_Game_forms
{
    public partial class registor_form : Form
    {
        drwhoSound_Player sound_Player = new drwhoSound_Player();

        public static Player_Class playerReg;

        
        public registor_form(drwhoSound_Player playmySound)
        {
            InitializeComponent();
            helpBTN.TabStop = false;
            registorBTN.TabStop = false;
            returnBTN.TabStop = false;
            button1.TabStop = false;

            sound_Player = playmySound;

            
        }

        //Creates 2 lists to store usernames and passwords
        List<string> users = new List<string>();
        List<string> passwords = new List<string>();

        

        //method to check if the text boxes and combo are empty
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
            Login_Form login = new Login_Form(sound_Player);
            login.Show();
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            sound_Player.stopintroSound();
            this.Hide();
            Help_Registor help_Registor = new Help_Registor(sound_Player);
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

            usernameTB.Text = "Enter your username";
            usernameTB.ForeColor = Color.Gray;

            passwordTB.Text = "Enter your password";
            passwordTB.ForeColor = Color.Gray;
            passwordTB.UseSystemPasswordChar = false;

            reEnterPasswordTB.Text = "Re-Enter your password";
            reEnterPasswordTB.ForeColor = Color.Gray;
            reEnterPasswordTB.UseSystemPasswordChar = false;

            yrGroupCB.Text = "Select a year group";
            yrGroupCB.ForeColor = Color.Gray;

            favSubjectCB.Text = "Select a subject";
            favSubjectCB.ForeColor = Color.Gray;

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

            else if (usernameTB.Text.Contains("gay") || usernameTB.Text.Contains("shit") || usernameTB.Text.Contains("bitch"))
            {
                MessageBox.Show("No inappropriate word can be used for the username");
                usernameTB.Clear();
            }
            //checks if there are digits in the username
            else if (!usernameTB.Text.Any(char.IsDigit))
            {
                MessageBox.Show("There are no numbers within the username please add in 3 numbers to continue");
            }
            else if(usernameTB.Text.Count(char.IsDigit) < 3 ||
                int.Parse(string.Concat(usernameTB.Text.Where(char.IsDigit).Take(3))) < 100)
            {
                MessageBox.Show("Username must contain at least 3 numbers ranging from 100-999 to continue");
            }





            //checks to see if there is spaces in textboxes and the favSubject combo box
            else if (usernameTB.Text.Contains(" ") || passwordTB.Text.Contains(" ") || reEnterPasswordTB.Text.Contains(" "))
            {
                MessageBox.Show("No spaces can be left in text boxes or drop down boxes");
            }

            else if (favSubjectCB.SelectedIndex == -1 || yrGroupCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid year group and or favourite subject");
            }
            else if (usernameTB.Text.Contains('.') && passwordTB.Text.Contains('.') && reEnterPasswordTB.Text.Contains('.'))
            {
                MessageBox.Show("Characters must be used, '.' cant be used");
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

                                playerReg = new Player_Class();


                                //asigns the data entered in the text bxoes and combo boxes to the player class
                                playerReg.Username = usernameTB.Text;
                                playerReg.YearGroup = yrGroupCB.Text;
                                playerReg.FavSubject = favSubjectCB.Text;

                                //clears anything stored in the text boxes and check boxes
                                usernameTB.Clear();
                                passwordTB.Clear();
                                reEnterPasswordTB.Clear();

                                this.Hide();
                                Main_Menu_Form mm = new Main_Menu_Form(playerReg,sound_Player);
                                mm.Show();
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
            //shows the password
            if (passwordTB.UseSystemPasswordChar == true && reEnterPasswordTB.UseSystemPasswordChar == true)
            {
                passwordTB.UseSystemPasswordChar = false;
                reEnterPasswordTB.UseSystemPasswordChar = false;
                button1.Text = "hide Password";
            }
            else//hides the password
            {
                passwordTB.UseSystemPasswordChar = true;
                reEnterPasswordTB.UseSystemPasswordChar = true;
                button1.Text = "show Password";
            }
        }



        private void usernameTB_Enter(object sender, EventArgs e)
        {
            if (usernameTB.Text == "Enter your username")
            {
                usernameTB.Text = "";
                usernameTB.ForeColor = Color.Black;

            }
        }

        private void usernameTB_Leave(object sender, EventArgs e)
        {
            if (usernameTB.Text == "")
            {
                usernameTB.Text = "Enter your username";
                usernameTB.ForeColor = Color.Gray;

            }
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Enter your password")
            {
                passwordTB.Text = "";
                passwordTB.ForeColor = Color.Black;
                passwordTB.UseSystemPasswordChar = true;
            }
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text == "")
            {
                passwordTB.Text = "Enter your password";
                passwordTB.ForeColor = Color.Gray;
                passwordTB.UseSystemPasswordChar = false;
            }
        }

        private void ReEnterPassword_Enter(object sender, EventArgs e)
        {
            if (reEnterPasswordTB.Text == "Re-Enter your password")
            {
                reEnterPasswordTB.Text = "";
                reEnterPasswordTB.ForeColor = Color.Black;
                reEnterPasswordTB.UseSystemPasswordChar = true;
            }
        }

        private void ReEnterPassword_Leave(object sender, EventArgs e)
        {
            if (reEnterPasswordTB.Text == "")
            {
                reEnterPasswordTB.Text = "Re-Enter your password";
                reEnterPasswordTB.ForeColor = Color.Gray;
                reEnterPasswordTB.UseSystemPasswordChar = false;
            }
        }


    }
}
