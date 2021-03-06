﻿using System.Globalization;
using System.Windows.Forms;

namespace csub
{
    public partial class HighscoreList : Form
    {
        public HighscoreList(Highscore highscore)
        {
            InitializeComponent();

            //skriver ny highscore til form
            foreach (var entry in highscore.Entries)
            {
                var item = new ListViewItem(entry.Name);                
                item.SubItems.Add(entry.HighScore.ToString(CultureInfo.CurrentUICulture));
                this.highscore.Items.Add(item);
            }
        }

        private void avslutt_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void highscore_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
