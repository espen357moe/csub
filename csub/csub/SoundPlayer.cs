using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace csub
{
    public class SoundPlayer
    {
        public void playExplosionSound()
        {
            System.Media.SoundPlayer explosion = new System.Media.SoundPlayer("../../sounds/explosion.wav");
            explosion.Play();
        }

        static void playTorpedoFire()
        {
            System.Media.SoundPlayer fire = new System.Media.SoundPlayer("Espen skriker!");
            fire.Play();
        }

        static void playReloading() 
        {
            System.Media.SoundPlayer reloading = new System.Media.SoundPlayer("Espen skriker!");
            reloading.Play();
        }

    }
}
