using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CordesProject
{
    class ArtikelFileReader
    {
        public ArtikelFileReader()
        {
        }

        public ArtikelFileReader(String path)
        {
            this._filePath = path;
        }

        private String _filePath;

        public String FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public String ReadLieferant()
        {
            FileStream fs = File.OpenRead(_filePath);
            StreamReader sr = new StreamReader(fs);
            String lieferant = sr.ReadLine();
            sr.Close();
            return lieferant;
        }

        /// <summary>
        /// Liest die Artikel aus Datei
        /// </summary>
        /// <returns>Gibt Artikel zurück</returns>
        public List<Artikel> ReadArtikel()
        {
            List<Artikel> artikel = new List<Artikel>();
            FileStream fs = File.OpenRead(_filePath);
            StreamReader sr = new StreamReader(fs);

            String line;
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                String[] propertys = line.Split('\t');
                                      //warengruppe //bezeichnung //artikelnummer //preis     //gewicht     //lieferzeit
                artikel.Add(new Artikel(propertys[0], propertys[1], propertys[2], propertys[3], propertys[4], propertys[5]));
            }
            sr.Close();
            return artikel;
        }
    }
}
