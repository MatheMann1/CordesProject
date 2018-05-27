using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CordesProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbArbeitsverzeichnis.Text = Directory.GetCurrentDirectory();
        }

        ArtikelDatabaseHandler dbh;
        ArtikelFileReader afr;
        private List<Artikel> artikel = new List<Artikel>();
        private String lieferant = "";

        private String ReadArbeitsverzeichnis()
        {
            MessageBox.Show(this.tbArbeitsverzeichnis.Text);
            return this.tbArbeitsverzeichnis.Text;
        }

        private void showArtikelGridView()
        {
            dgvArtikel.Columns.Clear();
            dgvArtikel.Columns.Add("artikelnummer", "Artikelnummer");
            dgvArtikel.Columns.Add("bezeichnung", "Bezeichnung");
            dgvArtikel.Columns.Add("preis", "Preis");
            dgvArtikel.Columns.Add("warengruppe", "Warengruppe");
            dgvArtikel.Columns.Add("gewicht", "Gewicht");
            dgvArtikel.Columns.Add("lieferzeit", "Lieferzeit");
            for (int i = 0; i < artikel.Count; i++)
            {
                dgvArtikel.Rows.Add(artikel[i].Artikelnummer, artikel[i].Bezeichnung, artikel[i].Preis, artikel[i].Warengruppe, artikel[i].Gewicht, artikel[i].Lieferzeit);
            }
        }

        private void showArtikelTreeView()
        {
            tvArtikelbaum.Nodes.Clear();
            TreeNode lief = tvArtikelbaum.Nodes.Add(lieferant);
            for(int i = 0; i < artikel.Count; i++)
            {
                TreeNode warengruppe;
                if (!lief.Nodes.ContainsKey(artikel[i].Warengruppe))
                {
                    warengruppe = lief.Nodes.Add(artikel[i].Warengruppe, artikel[i].Warengruppe);
                }
                else
                {
                    warengruppe = lief.Nodes[artikel[i].Warengruppe];
                }

                if (!warengruppe.Nodes.ContainsKey(artikel[i].Bezeichnung))
                {
                    warengruppe.Nodes.Add(artikel[i].Bezeichnung);
                }
            }
        }

        private void tvArtikelbaum_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                for (int i = 0; i < artikel.Count; i++)
                {
                    if (e.Node.Parent.Text == artikel[i].Warengruppe && e.Node.Text == artikel[i].Bezeichnung)
                    {
                        showSelectedArtikel(artikel[i]);
                        break;
                    }
                }
            }
        }

        private void showSelectedArtikel(Artikel artikel)
        {
            tbWarengruppe.Text = artikel.Warengruppe;
            tbBezeichnung.Text = artikel.Bezeichnung;
            tbArtikelnummer.Text = artikel.Artikelnummer;
            tbPreis.Text = artikel.Preis;
            tbGewicht.Text = artikel.Gewicht;
            tbLieferzeit.Text = artikel.Lieferzeit;
        }

        private void btTxtToDatabase_Click(object sender, EventArgs e)
        {
            DialogOpener opn = new DialogOpener();
            String txtFilepath = opn.ShowOpenFileDialog("Textdokument|*.txt|Alle Dateien|*.*", "Artikel Datei auswählen", ReadArbeitsverzeichnis());
            if (String.IsNullOrEmpty(txtFilepath))
            {
                MessageBox.Show("Die Datei konnte nicht erfolgreich ausgewählt werden");
            }
            else
            {
                afr = new ArtikelFileReader(txtFilepath);
                this.lieferant = afr.ReadLieferant();
                this.artikel = afr.ReadArtikel();
                String dbFilepath = opn.ShowOpenFileDialog("Access Datenbank|*.accdb|Alle Dateien|*.*", "Datenbank auswählen", ReadArbeitsverzeichnis());
                if (String.IsNullOrEmpty(dbFilepath))
                {
                    MessageBox.Show("Beim auswählen der Datei ist ein Fehler aufgetreten");
                }
                else
                {
                    dbh = new ArtikelDatabaseHandler(dbFilepath);
                    try
                    {
                        dbh.OpenDatabase();
                        dbh.InsertArtikel(this.artikel);
                        MessageBox.Show("Die Artikel wurden erfolgreich in die Datenbank geschrieben");
                    }
                    catch (OleDbException oex)
                    {
                        MessageBox.Show(oex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        dbh.CloseDatabase();
                    }
                }
            }
        }

        private void btDatabaseToGrid_Click(object sender, EventArgs e)
        {
            DialogOpener opn = new DialogOpener();
            String dbFilepath = opn.ShowOpenFileDialog("Access Datenbank|*.accdb|Alle Dateien|*.*", "Datenbank auswählen", ReadArbeitsverzeichnis());
            if (String.IsNullOrEmpty(dbFilepath))
            {
                MessageBox.Show("Bei der Auswahl der Datenbank ist ein Fehler aufgetreten");
            }
            else
            {
                dbh = new ArtikelDatabaseHandler(dbFilepath);
                try
                {
                    dbh.OpenDatabase();
                    this.artikel = dbh.ReadArtikelWarengruppe();
                    showArtikelGridView();
                    showArtikelTreeView();
                }
                catch(OleDbException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dbh.CloseDatabase();
                }
            }
        }
    }
}