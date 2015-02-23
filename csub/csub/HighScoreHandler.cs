using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;


namespace csub
{
    class HighScoreHandler
    {/*

        private void button2_Click(object sender, EventArgs e)
        {

            // XmlTextWriter skriver XML-kode til fil, og har metoder for
            // å skrive innhold til filen.  Brukes spesielt ved store XML-
            // filer, siden vi ikke bygger opp en hierarkisk struktur i
            // hukommelsen
            try
            {
                XmlTextWriter skriver = new XmlTextWriter("scores.xml", System.Text.Encoding.ASCII);
                skriver.WriteStartDocument(); // Skriver XML-deklarasjonen
                // De to neste linjer sørger for formattering
                skriver.Formatting = Formatting.Indented;
                skriver.Indentation = 2;
                // Nå skriver vi selve innholdet
                skriver.WriteStartElement("scores");
                skriver.WriteStartElement("entry");
                skriver.WriteAttributeString("Name", "TEXTBOX MED KNAPP");
                skriver.WriteElementString("Score", scoreLbl1 XmlDocumentFragment MainGameForm);
                skriver.WriteEndElement();
                skriver.Flush();
                skriver.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show("Noe gikk galt: " + f.Message);
            }

            private void button3_Click(object sender, EventArgs e)
        {
            // Her brukes LINQ for å lage dokumentet
            // NB XDoument er en hierarkisk struktur
            XDocument NewDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("scores",
                    new XElement("entry",
                        new XElement("Name","INNHOLD FRA TEXTBOX"),
                        new XElement("Score","scoreLbl1 XmlDocumentFragment MainGameForm")),
                        
            // Vis resultatet
            textBox1.Text = NewDoc.Declaration + "\r\n" + NewDoc.ToString();
            // Lagrer på skrivebordet - smart triks for
            NewDoc.Save("XmlLinq.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XDocument NewDoc = XDocument.Load("test.xml");
            textBox1.Text = NewDoc.Declaration + "\r\n" + NewDoc.ToString();
        }


        }

    */












        //metode for å lese high score fra XML
        //metode for å skrive high score til XML

        //   // Skifter text score til string og registrerer treff
           

        //    for (int i =0; i < torpedo.Position.X; i++)
        //    {
        //        if (torpedo.Position[i].IntersectsWith()) //position av båt mellom parantes 
        //        {
        //            score += 10;
        //        }
        //   }

        ////Restrating av spill + melding om score
        //public void restart()
        //{
        //    timer1.Enabled = false;
        //    MessageBox.Show("Game over. You got: " +score + "points");
        //    scoreLbl.Text = "0";
        //    score = 0;

        //}

        public void xmlSheet () 
        {

        }


    
    }
}
