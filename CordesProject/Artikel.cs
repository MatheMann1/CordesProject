using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordesProject
{
    class Artikel
    {
        public Artikel()
        {

        }

        public Artikel(String warengruppe, String bezeichnung, String artikelnummer, String preis, String gewicht, String lieferzeit)
        {
            this._warengruppe = warengruppe;
            this._bezeichnung = bezeichnung;
            this._artikelnummer = artikelnummer;
            this._preis = preis;
            this._gewicht = gewicht;
            this._lieferzeit = lieferzeit;
        }

        private String _warengruppe;

        public String Warengruppe
        {
            get { return _warengruppe; }
            set { _warengruppe = value; }
        }
        private String _bezeichnung;

        public String Bezeichnung
        {
            get { return _bezeichnung; }
            set { _bezeichnung = value; }
        }
        private String _artikelnummer;

        public String Artikelnummer
        {
            get { return _artikelnummer; }
            set { _artikelnummer = value; }
        }
        private String _preis;

        public String Preis
        {
            get { return _preis; }
            set { _preis = value; }
        }
        private String _gewicht;

        public String Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }
        private String _lieferzeit;

        public String Lieferzeit
        {
            get { return _lieferzeit; }
            set { _lieferzeit = value; }
        }
    }
}
