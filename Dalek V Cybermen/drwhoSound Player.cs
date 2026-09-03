using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen
{
    public class drwhoSound_Player
    {
        SoundPlayer drWhoSound;
        //Methods to play sounds
        public void playintroSound()
        {
            drWhoSound = new SoundPlayer("Doctor Who Intro.wav");
            drWhoSound.PlayLooping();
        }

        public void stopintroSound()
        {
            drWhoSound.Stop();
        }

        public void playIamTheDoctorSound()
        {
            drWhoSound = new SoundPlayer("I am the Doctor.wav");
            drWhoSound.PlayLooping();
        }

        public void playVictorySound()
        {
            drWhoSound = new SoundPlayer("WIN.wav");
            drWhoSound.PlayLooping();
        }

        public void playDefeatSound()
        {
            drWhoSound = new SoundPlayer("Victory Sound.wav");
            drWhoSound.PlayLooping();
        }

    }
}
