using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen
{
    public class Easy : Normal
    {
        //=============================================================
        //DERIVED CLASS   DERIVED CLASS   DERIVED CLASS   DERIVED CLASS
        //=============================================================



        //Links the form comstructor from the base class
        public Easy() : base()
        {

        }

        //methods to be overriden

        public override int setLives()
        {
            Lives = 5;
            return Lives;
        }

        public override int setEnemies()
        {
            Enemies = 3;
            return Enemies;
        }

        public override int setEnemySpeed()
        {
            EnemySpeed = 3;
            return EnemySpeed;
        }
    }
}
