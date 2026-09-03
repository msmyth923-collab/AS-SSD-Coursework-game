using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen
{
    //=================================================
    //BASE CLASS   BASE CLASS   BASE CLASS   BASE CLASS
    //=================================================
    public class Normal
    {

        private int _lives;
        private int _enemies;
        private int _enemySpeed;

        //default construction

        public Normal()
        {
            Enemies = 0;
            Lives = 0;
            EnemySpeed = 0;
        }


        //getters and setters for the difficulties
        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        public int Enemies
        {
            get { return _enemies; }
            set { _enemies = value; }
        }

        public int EnemySpeed
        {
            get { return _enemySpeed; }
            set { _enemySpeed = value; }
        }


        //methods to be the base of the over riders

        public virtual int setLives()
        {
            Lives = 3;
            return Lives;
        }

        public virtual int setEnemies()
        {
            Enemies = 5;
            return Enemies;
        }


        public virtual int setEnemySpeed()
        {
            EnemySpeed = 5;
            return EnemySpeed;
        }
    }
}
