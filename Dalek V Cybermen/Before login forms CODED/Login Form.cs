using Dalek_V_Cybermen.Help_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalek_V_Cybermen.Before_Game_forms
{
    public partial class Login_Form : Form
    {
        public static Player_Class playerClass;
        drwhoSound_Player SoundPlayer = new drwhoSound_Player();

        public Login_Form(drwhoSound_Player soundPlayer_)
        {
            InitializeComponent();
            helpBTN.TabStop = false;
            loginBTN.TabStop = false;
            registorBTN.TabStop = false;
            showPassBTN.TabStop = false;

            SoundPlayer = soundPlayer_;
        }

        string[] playerLoginDetails;
        string[] parts;
        bool validLogin = false;
        

        public Boolean notEmpty(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Text boxes cannot be left empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }

        private void registorBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            registor_form registor_Form = new registor_form(SoundPlayer);
            registor_Form.Show();
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help_Login helpLogin = new Help_Login();
            helpLogin.Show();
            SoundPlayer.stopintroSound();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if (notEmpty(usernameTB.Text, passwordTB.Text))
            {

            }
            else if (usernameTB.Text.Any(char.IsUpper))
            {
                MessageBox.Show("The username textbox Contains one or more capitals,\n capitals are not required in the username","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            else if (usernameTB.Text.Contains(" ") || passwordTB.Text.Contains(" "))
            {
                MessageBox.Show("No spaces can be left in text boxes or drop down boxes","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!usernameTB.Text.Any(char.IsDigit))
            {
                MessageBox.Show("There are no numbers within the username please add in 3 numbers to continue");
            }
            else if (usernameTB.Text.Count(char.IsDigit) < 3 ||
                int.Parse(string.Concat(usernameTB.Text.Where(char.IsDigit).Take(3))) < 100)
            {
                MessageBox.Show("Username must contain at least 3 numbers ranging from 100-999 to continue");
            }
            else
            {
                if (usernameTB.Text.Length > 6 && usernameTB.Text.Length < 31)
                {
                    if (passwordTB.Text.Any(char.IsDigit) && passwordTB.Text.Any(char.IsUpper))
                    {
                        try
                        {
                            playerLoginDetails = File.ReadAllLines("playerLoginDetails.txt");

                            foreach (string line in playerLoginDetails)
                            {
                                parts = line.Split('~');

                                //checks to see if the username and password saved matches up with the entered password and username
                                if (parts[0] == usernameTB.Text && parts[1] == passwordTB.Text)
                                {
                                    validLogin = true;
                                    DialogResult result = MessageBox.Show("You are currently logging in as: " + usernameTB.Text
                                                + "\nIs this correct?"
                                                , "Correct information?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.Yes)
                                    {
                                        //creates a new object of type playerclass
                                        playerClass = new Player_Class();

                                        //the data from the correct line in the textfile is put into the variables in the player class
                                        playerClass.Username = parts[0];
                                        playerClass.FavSubject = parts[3];
                                        playerClass.YearGroup = parts[2];
                                        MessageBox.Show("Login Successful\nWelcome " + usernameTB.Text, "Sucessful!");



                                        this.Hide();
                                        Main_Menu_Form mmF = new Main_Menu_Form(playerClass, SoundPlayer);
                                        mmF.ShowDialog();


                                    }
                                }
                            }
                        }
                        catch(IOException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                if (validLogin == false)
                {
                    MessageBox.Show("Inncorrect details have been entered, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showPassBTN_Click(object sender, EventArgs e)
        {
            if (passwordTB.UseSystemPasswordChar == true)
            {
                passwordTB.UseSystemPasswordChar = false;
                showPassBTN.Text = "hide Password";
            }
            else
            {
                passwordTB.UseSystemPasswordChar = true;
                showPassBTN.Text = "show Password";
            }

            
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            usernameTB.Text = "Enter your username";
            usernameTB.ForeColor = Color.Gray;

            passwordTB.Text = "Enter your password";
            passwordTB.ForeColor = Color.Gray;
            passwordTB.UseSystemPasswordChar = false;
        }

        private void usernameTBEnterEvent(object sender, EventArgs e)
        {
            if (usernameTB.Text == "Enter your username")
            {
                usernameTB.Text = "";
                usernameTB.ForeColor = Color.Black;
                
            }
        }

        private void usernameTBLeaveEvent(object sender, EventArgs e)
        {
            if(usernameTB.Text == "")
            {
                usernameTB.Text = "Enter your username";
                usernameTB.ForeColor = Color.Gray;
                
            }
        }

        private void passwordTBEnterEvent(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Enter your password")
            {
                passwordTB.Text = "";
                passwordTB.ForeColor = Color.Black;
                passwordTB.UseSystemPasswordChar = true;
            }
        }

        private void passwordTBLeaveEvent(object sender, EventArgs e)
        {
            if (passwordTB.Text == "")
            {
                passwordTB.Text = "Enter your password";
                passwordTB.ForeColor = Color.Gray;
                passwordTB.UseSystemPasswordChar = false;
            }
        }
    }
}
