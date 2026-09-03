using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Dalek_V_Cybermen
{
    //
    //This class has been created and used to generate a bullet everytime the space bar is pressed
    //
    class bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 20; // the speed at which the bullet will be heading at
        private PictureBox Bullet = new PictureBox();
        private Timer bulletTimer = new Timer();


        //Method to generate the bullet
        public void MakeBullet(Form form)
        {
            Bullet.BackColor = Color.Blue;
            Bullet.Size = new Size(10, 10);
            Bullet.Tag = "bullet";
            Bullet.Left = bulletLeft;
            Bullet.Top = bulletTop;
            Bullet.BringToFront();

            form.Controls.Add(Bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        //setting the speed of the bullet
        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                Bullet.Left -= speed;
            }
            if (direction == "right")
            {
                Bullet.Left += speed;
            }
            if (direction == "up")
            {
                Bullet.Top -= speed;
            }
            if (direction == "down")
            {
                Bullet.Top += speed;
            }

            //If the bullet hits one of the edges the it will be destroyed 1458, 986
            if (Bullet.Left < 10 
                || Bullet.Left > 1458 
                || Bullet.Top < 10 
                || Bullet.Top > 986)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                Bullet.Dispose();
                bulletTimer = null;
                Bullet = null;
            } 
        }

    }
}
