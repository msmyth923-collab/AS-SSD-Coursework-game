using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen
{
    public class Hard : Normal
    {
        //=============================================================
        //DERIVED CLASS   DERIVED CLASS   DERIVED CLASS   DERIVED CLASS
        //=============================================================


        //Links the form constructor from the base class
        public Hard() : base()
        {

        }

        //methods to be overriden

        public override int setLives()
        {
            Lives = 1;
            return Lives;
        }

        public override int setEnemies()
        {
            Enemies = 7;
            return Enemies;
        }

        public override int setEnemySpeed()
        {
            EnemySpeed = 7;
            return EnemySpeed;
        }

    }
}
