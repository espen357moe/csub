using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace csub
{
    public class OurSoundPlayer
    {
        public void playExplosionSound()
        {
            System.Media.SoundPlayer explosion = new System.Media.SoundPlayer("../../sounds/explosion.wav");
            explosion.Play();
        }

        public void playTorpedoFire()
        {
            System.Media.SoundPlayer fire = new System.Media.SoundPlayer("../../sounds/torpedoKort.wav");
            fire.Play();
        }

        public void playReloading() 
        {
            System.Media.SoundPlayer reloading = new System.Media.SoundPlayer("../../sounds/reloading.wav");
            reloading.Play();
        }

    }
}
