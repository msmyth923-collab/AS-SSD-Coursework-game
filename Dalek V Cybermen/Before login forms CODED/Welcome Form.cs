using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using AxWMPLib;
using WMPLib;

namespace Dalek_V_Cybermen.Before_Game_forms
{
    public partial class Welcome_Form : Form
    {
        Color originalBackColour;
        bool wasClicked = false;

        drwhoSound_Player SoundPlayer = new drwhoSound_Player();


        public Welcome_Form()
        {
            InitializeComponent();
            beginBTN.TabStop = false;
            enemyImagePB.BackColor = Color.Transparent;
            playerImagePB.BackColor = Color.Transparent;
        }

        private void Welcome_Form_Load(object sender, EventArgs e)
        {
            //plays a sound once the form has successfully loaded
            SoundPlayer.playintroSound();
        }


        private void beginBTN_Click(object sender, EventArgs e)
        {
            //sets a boolean to true
            wasClicked = true;
        }

        private void loadingBarTimer_Tick(object sender, EventArgs e)
        {
            
            if (wasClicked == true)
            {
                //if the boolean is true hide the button and show the loading bar
                loadingBarProBar.Visible = true;
                beginBTN.Visible = false;
                loadingLBL.Visible = true;

                loadingBarTimer.Enabled = true;
                loadingBarProBar.Increment(5);

                if (loadingBarProBar.Value == 20)
                {
                    loadingLBL.Text = "Loading player data...";
                }
                else if (loadingBarProBar.Value == 40)
                {
                    loadingLBL.Text = "Loading enemy data...";
                }
                else if (loadingBarProBar.Value == 60)
                {
                    loadingLBL.Text = "Loading game assets...";
                }
                else if (loadingBarProBar.Value == 80)
                {
                    loadingLBL.Text = "Finalising...";
                }

                if (loadingBarProBar.Value == 100)
                {
                    loadingBarTimer.Enabled = false;

                    //brings up a new form
                    this.Hide();
                    Login_Form lf = new Login_Form(SoundPlayer); //passes in a class to the new form
                    lf.Show(); //shows a form

                   
                }
            }
        }

        private void beginBTN_MouseEnter(object sender, EventArgs e)
        {
            //once the mouse hovers over the button the size incease and changes the colour
            beginBTN.Size = new Size(beginBTN.Width + 10, beginBTN.Height + 10);

            beginBTN.Location = new Point(beginBTN.Location.X - 5 , beginBTN.Location.Y - 15);

            beginBTN.BackColor = Color.Lime;
        }

        private void beginBTN_MouseL(object sender, EventArgs e)
        {
            //once the mouse is off the button changes the size back to normal
            beginBTN.Size = new Size(beginBTN.Width - 10, beginBTN.Height - 10);

            beginBTN.Location = new Point(beginBTN.Location.X + 5, beginBTN.Location.Y + 15);

            beginBTN.BackColor = originalBackColour;
        }

    }
}
