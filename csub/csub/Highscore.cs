using System;
using System.IO;
using System.Xml.Serialization;

namespace csub
{
    [Serializable]
    [XmlRoot("highscores")]
    public class Highscore
    {
        [Serializable]
        public class HighscoreEntry
        {
            [XmlAttribute("name")]
            public string Name { get; set; }

            [XmlAttribute("highscore")]
            public long HighScore { get; set; }
        }

        [XmlArray("entries")]
        public HighscoreEntry[] Entries { get; set; }

        private static readonly XmlSerializer serializer = new XmlSerializer(typeof(Highscore));

        public static Highscore FromFile(string xmlFile)
        {
            if(!File.Exists(xmlFile))
                return new Highscore { Entries = new HighscoreEntry[0] };

            using (var file = File.OpenRead(xmlFile))
            {
                return (Highscore)serializer.Deserialize(file);
            }
        }

        public void Save(string xmlFile)
        {
            using (var file = File.Create(xmlFile))
            {
                serializer.Serialize(file, this);
            }
        }
    }
}
