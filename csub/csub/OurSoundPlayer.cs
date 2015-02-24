using System.Media;

namespace csub
{
    public class OurSoundPlayer
    {     

        public void playExplosionSound()
        {
            SoundPlayer explosion = new System.Media.SoundPlayer("../../sounds/explosion.wav");
            explosion.Play();
            explosion.Dispose();
        }

        public void playTorpedoFire()
        {
            SoundPlayer torpedo = new System.Media.SoundPlayer("../../sounds/torpedoKort.wav");
            torpedo.Play();
            torpedo.Dispose();
        }

        public void playReloading() 
        {
            SoundPlayer reloading = new System.Media.SoundPlayer("../../sounds/reloading.wav");
            reloading.Play();
            reloading.Dispose();
        }

        public void playNewSkiff()
        {
            SoundPlayer newSkiff = new System.Media.SoundPlayer("../../sounds/cartmanrespect.wav");
            newSkiff.Play();
            newSkiff.Dispose();
        }

        public void playNewFerry()
        {
            SoundPlayer newFerry = new System.Media.SoundPlayer("../../sounds/ferry.wav");
            newFerry.Play();
            newFerry.Dispose();
        }

        public void playNewTitanic()
        {
            SoundPlayer newTitanic = new System.Media.SoundPlayer("../../sounds/titanic.wav");
            newTitanic.Play();
            newTitanic.Dispose();
        }
    }
}
