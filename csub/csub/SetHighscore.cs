using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csub
{
    public partial class SetHighscore : Form
    {
        private readonly int _points;
        public SetHighscore(int points)
        {
            _points = points;
            InitializeComponent();
            label1.Text = string.Format(label1.Text, points);
        }

        //henter inn inntastet spillernavn
        public string PlayerName { get { return textBox1.Text; } }

        private void button1_Click(object sender, EventArgs e)
        {
            //skriver highscore til XML-fil og sorterer 
            var score = Highscore.FromFile("highscore.xml");

            score.Entries =
                score.Entries.Concat(new []
                {new Highscore.HighscoreEntry {HighScore = _points, Name = textBox1.Text}})
                .OrderByDescending(x => x.HighScore)
                .ToArray();

            score.Save("highscore.xml");

            Close();
        }

        private void SetHighscore_Load(object sender, EventArgs e)
        {

        }
    }
}
