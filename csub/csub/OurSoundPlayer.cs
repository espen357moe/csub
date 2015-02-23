using System;
using System.Collections.Generic;
using System.IO;
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
            explosion.Dispose();
        }

        public void playTorpedoFire()
        {
            System.Media.SoundPlayer torpedo = new System.Media.SoundPlayer("../../sounds/torpedoKort.wav");
            torpedo.Play();
            torpedo.Dispose();
        }

        public void playReloading() 
        {
            System.Media.SoundPlayer reloading = new System.Media.SoundPlayer("../../sounds/reloading.wav");
            reloading.Play();
            reloading.Dispose();
        }

        public void playNewSkiff()
        {
            System.Media.SoundPlayer newSkiff = new System.Media.SoundPlayer("../../sounds/cartmanrespect.wav");
            newSkiff.Play();
            newSkiff.Dispose();
        }

    }
}
