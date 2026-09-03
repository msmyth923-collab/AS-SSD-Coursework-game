using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalek_V_Cybermen
{
    public partial class Form1 : Form
    {
        //boolean variables
        bool goLeft, goRight, goUp, goDown;
        bool gameOver;
        bool healSpawned = false;
        bool isPaused = false;

        //string variables
        string facing = "up";

        //integer variables
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int dalekSpeed = 3;
        int score;
        int escPressCount = 0;

        //a random number generator
        Random randNum = new Random();

        List<PictureBox> daleksList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            RestartGame(); //restart game is automatically called in order for the game to begin and set the correct variables           
            Cursor.Hide();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {            
            // if the player health exceeds 100 because of the medkit, it will automatically change the player health variable to 100
            if (playerHealth > 100)
            {
                playerHealth = 100;
            }    

            //the players health is actively being updated to ensure that it is correct and doesnt show the incorrect value
            if (playerHealth > 1)
            {
                healthProBar.Value = playerHealth;
                healthnumLBL.Text = playerHealth.ToString() + "%";
            }

            //if the players health goes below 1 the else statement will be execuded
            else
            {
                gameOver = true;
                udeadlbl.Visible = true;
                mmBtn.Visible = true;
                udeadlbl.BringToFront();
                playerPB.Image = Properties.Resources.dead;
                healthnumLBL.Text = "0%";
                healthProBar.Value = 0;
                Cursor.Show();
                gameTimer.Stop();
            }

            if (playerHealth <= 50 && !healSpawned) // the if statement will be executed if the players health is less than 50 and the
            {                                       // healSpawned boolean is set to false
                DropHeal();
                healSpawned = true; 
            }
            

            ammolbl.Text = "Ammo: " + ammo; // actively updating the labels 
            killScorelbl.Text = "Kills: " + score;

            //setting the speed at which the player will move at
            if (goLeft == true && playerPB.Left > 0)
            {
                playerPB.Left -= speed;
            }
            if (goRight == true && playerPB.Left + playerHealth < this.ClientSize.Width)
            {
                playerPB.Left += speed;
            }
            if (goUp == true && playerPB.Top > 40)
            {
                playerPB.Top -= speed;
            }
            if (goDown == true && playerPB.Bottom < this.ClientSize.Height)
            {
                playerPB.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    //every time the ammo is picked up (everytime the playerPB hits the ammoPB) the if statment will be executed giving the player 5 ammo
                    if (playerPB.Bounds.IntersectsWith(x.Bounds)) 
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5; // 5 will be added to the ammo, giving the player 5 more bullets
                    }
                }

                if(x is PictureBox && (string)x.Tag == "heal")
                {
                    if (playerPB.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        playerHealth += 5;   // the players health will have 5 added on to it 
                        healSpawned = false; // this will allow more heals to spawn, this is done to prevent more than one heal spawning at one time
                    }
                }

                if(x is PictureBox && (string)x.Tag == "dalek")
                {
                    // -1 of the players health is taken away from the player when the dalek intersects with (hits) the player
                    if (playerPB.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    //movement images for the dalek to follow the player
                    if(x.Left > playerPB.Left)
                    {
                        x.Left -= dalekSpeed;
                        ((PictureBox)x).Image = Properties.Resources.Dalek_left;
                    }
                    if (x.Left < playerPB.Left)
                    {
                        x.Left += dalekSpeed;
                        ((PictureBox)x).Image = Properties.Resources.Dalek_right;
                    }
                    if (x.Top > playerPB.Top)
                    {
                        x.Top -= dalekSpeed;
                        ((PictureBox)x).Image = Properties.Resources.Dalek_up;
                    }
                    if (x.Top < playerPB.Top)
                    {
                        x.Top += dalekSpeed;
                        ((PictureBox)x).Image = Properties.Resources.Dalek_down;
                    }
                }


                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "dalek")
                    {
                        //the if statement will be executed if the picture box with the tag bullet hits another picturebox with the dalek
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++; // adds one to the score

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            daleksList.Remove(((PictureBox)x));
                            //another dalek is made after one or more of them have been destroyed
                            MakeDaleks();
                        }
                    }
                }
            }
        }

        //movement for the player to move
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) //left
            {
                goLeft = true;
                facing = "left";
                playerPB.Image = Properties.Resources.Cleft;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) //Right
            {
                goRight = true;
                facing = "right";
                playerPB.Image = Properties.Resources.Cright;
            }

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) //up
            {
                goUp = true;
                facing = "up";
                playerPB.Image = Properties.Resources.Cup;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) //Down
            {
                goDown = true;
                facing = "down";
                playerPB.Image = Properties.Resources.Cdown;
            }

            if(e.KeyCode == Keys.Escape)
            {
                if (!isPaused)
                {
                    escPressCount++;
                    gameTimer.Stop();
                    isPaused = true;
                    Cursor.Show();

                    mainMbtn.Visible = true;
                    optionsbtn.Visible = true;
                    pauselbl.Visible = true;

                    mainMbtn.BringToFront();
                    optionsbtn.BringToFront();
                    pauselbl.BringToFront();

                    return;
                }
                else
                {
                    ResumeGame();
                    return;
                }
            }
        }

        
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //  to ensure that the player cant move after they've been killed
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) 
            {
                goLeft = false;               
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goRight = false;       
            }

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                goUp = false;                
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                goDown = false;         
            }


            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                //one bullet will be taken away and what ever way the player is facing it will go that way
                ammo--;
                ShootBullet(facing);

                //The drop ammo method will be called if the variable ammo contains 0
                if (ammo < 1)
                {
                    DropAmmo();
                }                
            }

            // if the enter keyd is pressed the method RestartGame(); will be execuded
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                Cursor.Hide();
                RestartGame();
            }
        }

        private void ResumeGame()
        {
            gameTimer.Start();
            isPaused = false;
            Cursor.Hide();

            mainMbtn.Visible = false;
            optionsbtn.Visible = false;
            pauselbl.Visible = false;
        }

        //a method for a bullet to be shot
        private void ShootBullet(string direction)
        {
            //bullet is a class which is called allowing the code within the class to be used
            bullet shootBullet = new bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = playerPB.Left + (playerPB.Width / 2);
            shootBullet.bulletTop = playerPB.Top + (playerPB.Height / 2);
            shootBullet.MakeBullet(this);
        }

        //a method for the daleks to be made
        private void MakeDaleks()
        {
            PictureBox dalek = new PictureBox(); //creates a picturebox within the code so inputing a picture on the desginer is not needed 
            dalek.Tag = "dalek"; // gives the picture box a tag
            dalek.Image = Properties.Resources.Dalek_down; //uses the picture within resources
            dalek.Left = randNum.Next(0, 900); // positions for the dalek to spawn
            dalek.Top = randNum.Next(0, 800);
            dalek.SizeMode = PictureBoxSizeMode.AutoSize;// fits the picture box to the size of the dalek
            daleksList.Add(dalek); // generates a new picture box
            this.Controls.Add(dalek); // adds in the dalek into the designer when the code is run
            playerPB.BringToFront(); // brings the ammo to the front of the designer when the game is run
        }

        //a method for the ammo to be droped
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";  
            this.Controls.Add(ammo);

            ammo.BringToFront(); 
            playerPB.BringToFront();
        }

        private void DropHeal()
        {
            PictureBox heal = new PictureBox();
            heal.Size = new Size(80, 80); // setting a set size for the heals
            heal.Image = Properties.Resources.Medkit_font_awesome_red_svg; 
            heal.SizeMode = PictureBoxSizeMode.StretchImage; //seting the set size, on 293
            heal.Left = randNum.Next(10, this.ClientSize.Width - heal.Width);
            heal.Top = randNum.Next(60, this.ClientSize.Height -  heal.Height);
            heal.Tag = "heal";
            this.Controls.Add(heal);

            heal.BringToFront();
            playerPB.BringToFront();
        }

        //a method for the game to be restarted
        private void RestartGame()
        {
            //setting the players sprite image to the start image, in this case its facing up
            playerPB.Image = Properties.Resources.Cup;
            playerPB.Location = new Point(300, 400);

            foreach (PictureBox i in daleksList)
            {
                this.Controls.Remove(i);
            }

            //removes any daleks that are present
            daleksList.Clear();

            //removes all dropped ammo and heals
            foreach (Control j in this.Controls.OfType<PictureBox>().ToList())
            {
                if ((string)j.Tag == "ammo" || (string)j.Tag == "heal")
                {
                    this.Controls.Remove(j);
                    ((PictureBox)j).Dispose();
                }
            }

            // if there is less than 3 daleks make more daleks till i (daleks) is equal to 3
            for(int i = 0; i < 3; i++)
            {
                MakeDaleks();
            }

            //sets all the movement varaibles to false and setting the game over variable to false as the game as restarted
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            // sets the "you are dead" label and the main menu button to not be visible
            udeadlbl.Visible = false;
            mmBtn.Visible = false;

            //resets the heal spawned boolean to false
            healSpawned = false;

            //resets the stats
            playerHealth = 100;
            score = 0;
            ammo = 10;

            //begins the timer after the rest of the code has been execuded
            gameTimer.Start();

        }
        
    }
}
