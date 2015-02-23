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
using System.Xml;

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


            // Leser Scores fra XML

            String s = "";
            richTextBox1.Text = "";
            try
            {
                XmlTextReader leser = new XmlTextReader("../../scores/scores.xml");
                while (leser.Read())  // leser neste
                {
                    switch (leser.NodeType)
                    {
                        case (XmlNodeType.Element):
                            {
                                //   s = s + leser.Name;
                                if (leser.HasAttributes)
                                {
                                    for (int i = 0; i < leser.AttributeCount; i++)
                                    {
                                        s = s + "Name: " + leser.GetAttribute(i) + " ";
                                    }
                                }
                                break;
                            }
                        case (XmlNodeType.Text):
                            {
                                s = s + "Poeng: " + leser.Value + "\n";
                                break;
                            }
                    }
                    richTextBox1.Text = s;
                }
                leser.Close();
            }
            catch (Exception f)
            {
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

           
        }
    }
}
