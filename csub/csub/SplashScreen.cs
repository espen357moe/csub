using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace csub
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
              
            SoundPlayer player = new SoundPlayer("../../sounds/SOUNDSCRATE-DarkTexture.wav");  
            player.Play();  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainGameForm = new MainGameForm();
            mainGameForm.Show(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
