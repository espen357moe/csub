using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace csub
{
    class Sounds
    {

        static void playExplosionSound ()
        {
            SoundPlayer explosion = new SoundPlayer("../../sounds/explosion.wav");
            explosion.Play();
        }

        static void playTorpedoFire()
        {
            SoundPlayer fire = new SoundPlayer("Espen skriker!");
            fire.Play();
        }

        static void playReloading () 
        {
            SoundPlayer reloading = new SoundPlayer("Espen skriker!");
            reloading.Play();
        }

    }
}
