using Dalek_V_Cybermen.Help_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalek_V_Cybermen.Before_Game_forms
{
    public partial class Login_Form : Form
    {
        public static Player_Class playerClass;
        
        public Login_Form()
        {
            InitializeComponent();
        }

        string[] playerLoginDetails;
        string[] parts;
        bool validLogin = false;
        

        public Boolean notEmpty(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Text boxes cannot be left empty");
                return true;
            }
            else
                return false;
        }

        private void registorBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            registor_form registor_Form = new registor_form();
            registor_Form.Show();
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help_Login helpLogin = new Help_Login();
            helpLogin.Show();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if (notEmpty(usernameTB.Text, passwordTB.Text))
            {

            }
            else if (usernameTB.Text.Any(char.IsUpper))
            {
                MessageBox.Show("The username textbox Contains one or more capitals,\n capitals are not required in the username");
            }
            else if (usernameTB.Text.Any(char.IsDigit))
            {
                MessageBox.Show("The username textbox Contains one or more numbers \n numbers are not needed in the username");
            }
            else if (usernameTB.Text.Contains(" ") || passwordTB.Text.Contains(" "))
            {
                MessageBox.Show("No spaces can be left in text boxes or drop down boxes");
            }
            else
            {
                if (usernameTB.Text.Length > 6 && usernameTB.Text.Length < 31)
                {
                    if (passwordTB.Text.Any(char.IsDigit) && passwordTB.Text.Any(char.IsUpper))
                    {
                        playerLoginDetails = File.ReadAllLines("playerLoginDetails.txt");

                        foreach (string line in playerLoginDetails)
                        {
                            parts = line.Split('~');

                            if (parts[0] == usernameTB.Text && parts[1] == passwordTB.Text)
                            {
                                validLogin = true;

                                //creates a new object of type playerclass
                                playerClass = new Player_Class();

                                //the data from the correct line in the textfile is put into the variables in the player class
                                playerClass.Username = parts[0];
                                playerClass.FavSubject = parts[3];
                                MessageBox.Show("Login Successful\nWelcome " + usernameTB.Text);

                                this.Hide();
                                Main_Menu_Form mmF = new Main_Menu_Form();
                                mmF.ShowDialog();
                            }
                        }
                    }
                }

                if (validLogin == false)
                {
                    MessageBox.Show("Inncorrect details have been entered, please try again");
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
    }
}
