using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;

namespace CordesProject
{
    class ArtikelDatabaseHandler
    {
        /// <summary>
        /// Creates an instance of ArtikelDatabaseHandler and opens a connection to a Database
        /// </summary>
        /// <param name="path">Path to the DatabaseFile</param>
        public ArtikelDatabaseHandler(String path)
        {
            this.path = path;
        }

        struct dbWarengruppe
        {
            public int Id;
            public String Bezeichnung;
        }

        private OleDbConnection connection = new OleDbConnection();
        private String path;

        /// <summary>
        /// Opens the OleDbDatabase
        /// </summary>
        public void OpenDatabase()
        {
            connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path;
            connection.Open();
        }

        /// <summary>
        /// Reads the Artikel from the Database
        /// </summary>
        /// <returns>Returns the currently read Artikel with joined Warengruppe</returns>
        public List<Artikel> ReadArtikelWarengruppe() 
        {
            List<Artikel> artikel = new List<Artikel>();
            OleDbCommand com = new OleDbCommand("SELECT * FROM AllesSchoen", connection);
            OleDbDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                                        // Warengruppe              // Bezeichnung              // Artikelnummer        // Preis                    // Gewicht
                artikel.Add(new Artikel(rd.GetValue(3).ToString(), rd.GetValue(1).ToString(), rd.GetValue(0).ToString(), rd.GetValue(2).ToString(), rd.GetValue(4).ToString(), rd.GetValue(5).ToString())); // Lieferzeit
            }
            return artikel;
        }

        /// <summary>
        /// Liest alle in der Datenbank gespeicherten Warengruppen aus und gibt sie zurück
        /// </summary>
        /// <returns>Alle in der Datenbank gespeicherten Warengruppen</returns>
        private List<dbWarengruppe> ReadWarengruppen() 
        {
            List<dbWarengruppe> warengruppen = new List<dbWarengruppe>();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Warengruppe", this.connection);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read()) 
            {
                warengruppen.Add(new dbWarengruppe { Id = Convert.ToInt32(rd.GetValue(0)), Bezeichnung = rd.GetValue(1).ToString()});
            }
            cmd.Dispose();
            return warengruppen;
        }

        /// <summary>
        /// Closes the OleDbDatabase
        /// </summary>
        public void CloseDatabase() 
        {
            connection.Dispose();
        }

        /// <summary>
        /// Insert Artikel data in the Database
        /// </summary>
        /// <param name="artikel">Artikel to export</param>
        public void InsertArtikel(List<Artikel> artikel) 
        {
            List<dbWarengruppe> dbWarengruppen = new List<dbWarengruppe>();
            List<String> InsWarengruppen = new List<String>();
            int maxId, maxArId = 0;

            dbWarengruppen = ReadWarengruppen();
            maxId = GetMaxWarId(dbWarengruppen);
            InsWarengruppen = GetInsertableWarengruppen(artikel, dbWarengruppen);
            InsertWarengruppen(InsWarengruppen, maxId);
            dbWarengruppen = ReadWarengruppen();
            maxArId = GetMaxArtikelId();

            OleDbCommand cmd = new OleDbCommand("INSERT INTO Artikel (ID, Bezeichnung, Preis, Warengruppe, Gewicht, Lieferzeit) VALUES (?,?,?,?,?,?)", this.connection);
            foreach (Artikel ar in artikel) 
            {
                maxArId++;
                cmd.Parameters.Add("ID", OleDbType.Char).Value = "ART" + maxArId.ToString("D5");
                cmd.Parameters.Add("Bezeichnung", OleDbType.Char).Value = ar.Bezeichnung;
                cmd.Parameters.Add("Preis", OleDbType.Char).Value = ar.Preis;
                cmd.Parameters.Add("Warengruppe", OleDbType.Integer).Value = GetIdOfWarengruppe(ar.Warengruppe, dbWarengruppen);
                cmd.Parameters.Add("Gewicht", OleDbType.Char).Value = ar.Gewicht;
                cmd.Parameters.Add("Lieferzeit", OleDbType.Char).Value = ar.Lieferzeit;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
        }

        private int GetIdOfWarengruppe(String warengruppe, List<dbWarengruppe> warengruppen)
        {
            foreach (dbWarengruppe war in warengruppen)
            {
                if (war.Bezeichnung == warengruppe)
                    return war.Id;
            }
            return -1;
        }

        private int GetMaxArtikelId()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT MAX(ID) FROM Artikel", this.connection);
            String maxId = cmd.ExecuteScalar().ToString();
            if (String.IsNullOrEmpty(maxId))
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(maxId.Split(new String[] { "ART" }, StringSplitOptions.None)[1]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="warengruppen">Die Liste der durchzugehenden Warengruppen</param>
        /// <returns>Die höchste Id in der Liste der Warengruppen</returns>
        private int GetMaxWarId(List<dbWarengruppe> warengruppen)
        {
            int maxId = 0;
            foreach (dbWarengruppe war in warengruppen) 
            {
                if (maxId < war.Id)
                    maxId = war.Id;
            }
            return maxId;
        }

        private List<String> GetInsertableWarengruppen(List<Artikel> artikel, List<dbWarengruppe> dbWarengruppen) 
        {
            List<String> insWarengruppen = new List<String>();
            List<String> databaseWarengruppen = new List<String>();

            foreach (dbWarengruppe war in dbWarengruppen) 
            {
                databaseWarengruppen.Add(war.Bezeichnung);
            }

            foreach (Artikel ar in artikel) 
            {
                if (!databaseWarengruppen.Contains(ar.Warengruppe) && !insWarengruppen.Contains(ar.Warengruppe))
                    insWarengruppen.Add(ar.Warengruppe);
            }
            return insWarengruppen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="warengruppen"></param>
        /// <param name="maxId"></param>
        private void InsertWarengruppen(List<String> warengruppen, int maxId) 
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Warengruppe (Id, Bezeichnung) VALUES (?,?)", this.connection);
            foreach (String war in warengruppen) 
            {
                cmd.Parameters.Add("Id", OleDbType.Integer).Value = ++maxId;
                cmd.Parameters.Add("Bezeichnung", OleDbType.Char).Value = war;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
        }
    }
}