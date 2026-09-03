using Dalek_V_Cybermen.After_Game_Forms;
using Dalek_V_Cybermen.diff_questions_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Dalek_V_Cybermen
{
    public partial class Form1 : Form
    {
        public static Hard hardMode;
        public static Normal normalMode;
        public static Easy easyMode;

        public HardQues hardModeQues;
        public NormalQues normalModeQues;
        public EasyQues easyModeQues;

        drwhoSound_Player SoundPlayer = new drwhoSound_Player();

        public static Player_Class currentPlayer;

        private object[] difficulty; //game difficulty
        private object[] difficultyBasedQuestions;  //quiz difficulty

        //boolean variables
        bool goLeft, goRight, goUp, goDown;
        bool gameOver;
        bool healSpawned = false;
        bool isPaused = false;
        

        //string variables
        string facing = "up";


        //integer variables
        int playerHealth = 100;
        int maxHealth = 100;
        int speed = 10;
        int ammo = 10;    
        int dalekSpeed = 3;
        int gameScore;
        int escPressCount = 0;
        int lives = 0;
        int amountOfEnemies;
        int damageCoolDown = 0;

        //a random number generator
        Random randNum = new Random();

        List<PictureBox> daleksList = new List<PictureBox>();


        //form constructor now contains a reference type 'normal' parameter
        public Form1(drwhoSound_Player playMySound,object[] difficultySelected, object[] selectedQuestionsDifficulty, Player_Class player_, int remainingLives = -1)
        {
            InitializeComponent();

            // Enable double buffering for the form
            this.DoubleBuffered = true; 
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            this.UpdateStyles();

            RestartGame();
            Cursor.Hide();

            SoundPlayer = playMySound;

            SoundPlayer.playIamTheDoctorSound();

            difficulty = difficultySelected;
            difficultyBasedQuestions = selectedQuestionsDifficulty;

            currentPlayer = player_;
            foreach (var difficulty in difficultySelected)
            {
                if (difficulty is Easy)
                {
                    easyMode = (Easy)difficulty;
                    lives = (remainingLives != -1) ? remainingLives : easyMode.setLives();
                    dalekSpeed = easyMode.setEnemySpeed();
                    amountOfEnemies = easyMode.setEnemies();
                }
                else if (difficulty is Normal)
                {
                    normalMode = (Normal)difficulty;
                    lives = (remainingLives != -1) ? remainingLives : normalMode.setLives();
                    dalekSpeed = normalMode.setEnemySpeed();
                    amountOfEnemies = normalMode.setEnemies();
                }
                else if (difficulty is Hard)
                {
                    hardMode = (Hard)difficulty;
                    lives = (remainingLives != -1) ? remainingLives : hardMode.setLives();
                    dalekSpeed = hardMode.setEnemySpeed();
                    amountOfEnemies = hardMode.setEnemies();
                }
            }

            foreach (var difficultyBasedQuestions in selectedQuestionsDifficulty)
            {
                if(difficultyBasedQuestions is EasyQues)
                {
                    this.easyModeQues = (EasyQues)difficultyBasedQuestions;
                }
                else if (difficultyBasedQuestions is NormalQues)
                {
                    this.normalModeQues = (NormalQues)difficultyBasedQuestions;
                }
                else if (difficultyBasedQuestions is HardQues)
                {
                    this.hardModeQues = (HardQues)difficultyBasedQuestions;
                }
            }

            mainMbtn.TabStop = false;

        }

        private void CheckScore()
        {
            foreach(var diff in difficulty)
            {
                if (diff.GetType() == typeof(Hard) && gameScore == 40)
                {
                    gameTimer.Stop();
                    this.Hide();
                    TheGameQuiz qForm = new TheGameQuiz(SoundPlayer,difficulty, currentPlayer, difficultyBasedQuestions, lives);
                    qForm.Show();
                    
                }
                else if (diff.GetType() == typeof(Normal) && gameScore == 25)
                {
                    gameTimer.Stop();
                    this.Hide();
                    TheGameQuiz qForm = new TheGameQuiz(SoundPlayer,difficulty, currentPlayer, difficultyBasedQuestions, lives);
                    qForm.Show();
                    
                }
                else if (diff.GetType() == typeof(Easy) && gameScore == 15)
                {
                    gameTimer.Stop();
                    this.Hide();
                    TheGameQuiz qForm = new TheGameQuiz(SoundPlayer,difficulty, currentPlayer, difficultyBasedQuestions, lives);
                    qForm.Show();
                    
                }
            }
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            CheckScore();

            // if there is less than the amount of daleks make more daleks till i (daleks) is equal to the amount of enemies
            while (daleksList.Count < amountOfEnemies)
            {
                MakeDaleks();
            }

            if (damageCoolDown > 0)
            {
                damageCoolDown--;
            }
            // if the player health exceeds 100 because of the medkit, it will automatically change the player health variable to 100
            if (playerHealth > maxHealth)
            {
                playerHealth = maxHealth;
            }    

            //the players health is actively being updated to ensure that it is correct and doesnt show the incorrect value
            if (playerHealth > 0)
            {
                healthProBar.Value = playerHealth;
                healthnumLBL.Text = playerHealth.ToString() + "%";
            }
            

            //if the players health goes below 1 the else statement will be execuded
            else
            {
                if (playerHealth <= 0)
                {
                    lives--;

                    this.Hide();
                    TheGameQuiz qForm = new TheGameQuiz(SoundPlayer, difficulty, currentPlayer, difficultyBasedQuestions, lives);
                    qForm.Show();

                    gameTimer.Stop();

                    if (lives > 0)
                    {

                        //isRespawning = true;
                        RespawnPlayer();
                    }
                }
            }

            if (playerHealth <= 50 && playerHealth > 1 && !healSpawned) // the if statement will be executed if the players health is less than 50 and the
            {                                       // healSpawned boolean is set to false
                DropHeal();
                healSpawned = true; 
            }
            

            ammolbl.Text = "Ammo: " + ammo; // actively updating the labels 
            killScorelbl.Text = "Kills: " + gameScore;
            liveLBLB.Text = "Lives: " + lives;

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
                    if (playerPB.Bounds.IntersectsWith(x.Bounds) && damageCoolDown == 0)
                    {
                        playerHealth -= 1;
                        damageCoolDown = 5;
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
                            gameScore++; // adds one to the score

                            currentPlayer.GameScore = gameScore; //adds the total game score to the player class

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

        private void RespawnPlayer()
        {
            playerHealth = maxHealth;
            playerPB.Location = new Point(699, 596);
            healthProBar.Value = playerHealth;


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
                playerPB.Size = new Size(150, 107);
                goLeft = true;
                facing = "left";
                playerPB.Image = Properties.Resources.Cleft;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) //Right
            {
                playerPB.Size = new Size(150, 107);
                goRight = true;
                facing = "right";
                playerPB.Image = Properties.Resources.Cright;
            }

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) //up
            {
                playerPB.Size = new Size(107, 150);
                goUp = true;
                facing = "up";
                playerPB.Image = Properties.Resources.Cup;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) //Down
            {
                playerPB.Size = new Size(107, 150);
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
                    pauselbl.Visible = true;

                    mainMbtn.BringToFront();
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
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) 
            {
                playerPB.Size = new Size(150, 107);
                goLeft = false;               
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                playerPB.Size = new Size(150, 107);
                goRight = false;       
            }

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                playerPB.Size = new Size(107, 150);
                goUp = false;                
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                playerPB.Size = new Size(107, 150);
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
            dalek.Left = randNum.Next(0, 1458); // positions for the dalek to spawn 1458, 986
            dalek.Top = randNum.Next(0, 986);
            dalek.SizeMode = PictureBoxSizeMode.AutoSize;// fits the picture box to the size of the dalek
            daleksList.Add(dalek); // generates a new picture box
            this.Controls.Add(dalek); // adds in the dalek into the designer when the code is run
            dalek.BackColor = Color.Transparent;
            playerPB.BringToFront(); // brings the ammo to the front of the designer when the game is run
        }

        private void mainMbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer.stopintroSound();
            this.Hide();
            Main_Menu_Form mmf = new Main_Menu_Form(currentPlayer,SoundPlayer);
            mmf.Show();
            SoundPlayer.stopintroSound();
        }


        //a method for the ammo to be droped
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.Size = new Size(80, 80);
            ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";  
            this.Controls.Add(ammo);
            ammo.BackColor = Color.Transparent;
            ammo.BringToFront(); 
            playerPB.BringToFront();
        }

        private void DropHeal()
        {
            PictureBox heal = new PictureBox();
            heal.Size = new Size(80, 80); // setting a set size for the heals
            heal.Image = Properties.Resources.Medkit_font_awesome_red_svg; 
            heal.SizeMode = PictureBoxSizeMode.StretchImage; 
            heal.Left = randNum.Next(10, this.ClientSize.Width - heal.Width);
            heal.Top = randNum.Next(60, this.ClientSize.Height -  heal.Height);
            heal.Tag = "heal";
            this.Controls.Add(heal);
            heal.BackColor = Color.Transparent;
            heal.BringToFront();
            playerPB.BringToFront();
        }

        //a method for the game to be restarted
        private void RestartGame()
        {
            //setting the players sprite image to the start image, in this case its facing up
            playerPB.Image = Properties.Resources.Cup;
            playerPB.Location = new Point(699, 596);

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


            

            //sets all the movement varaibles to false and setting the game over variable to false as the game as restarted
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            // sets the "you are dead" label and the main menu button to not be visible
            udeadlbl.Visible = false;

            //resets the heal spawned boolean to false
            healSpawned = false;

            //resets the stats
            playerHealth = 100;
            gameScore = 0;
            ammo = 10;
            lives = 0;

            //begins the timer after the rest of the code has been execuded
            gameTimer.Start();

        }


    }
}
