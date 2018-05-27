namespace CordesProject
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDatabaseToGrid = new System.Windows.Forms.Button();
            this.dgvArtikel = new System.Windows.Forms.DataGridView();
            this.lbArbeitsverzeichnis = new System.Windows.Forms.Label();
            this.tvArtikelbaum = new System.Windows.Forms.TreeView();
            this.tbWarengruppe = new System.Windows.Forms.TextBox();
            this.tbBezeichnung = new System.Windows.Forms.TextBox();
            this.tbArtikelnummer = new System.Windows.Forms.TextBox();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.tbGewicht = new System.Windows.Forms.TextBox();
            this.tbLieferzeit = new System.Windows.Forms.TextBox();
            this.lbWarengruppe = new System.Windows.Forms.Label();
            this.lbBezeichnung = new System.Windows.Forms.Label();
            this.lbArtikelnummer = new System.Windows.Forms.Label();
            this.lbPreis = new System.Windows.Forms.Label();
            this.lbGewicht = new System.Windows.Forms.Label();
            this.lbLieferzeit = new System.Windows.Forms.Label();
            this.lbLieferant = new System.Windows.Forms.Label();
            this.tbArbeitsverzeichnis = new System.Windows.Forms.TextBox();
            this.tbLieferant = new System.Windows.Forms.TextBox();
            this.btTxtToDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).BeginInit();
            this.SuspendLayout();
            // 
            // btDatabaseToGrid
            // 
            this.btDatabaseToGrid.Location = new System.Drawing.Point(161, 12);
            this.btDatabaseToGrid.Name = "btDatabaseToGrid";
            this.btDatabaseToGrid.Size = new System.Drawing.Size(119, 23);
            this.btDatabaseToGrid.TabIndex = 1;
            this.btDatabaseToGrid.Text = "Database --> Grid";
            this.btDatabaseToGrid.UseVisualStyleBackColor = true;
            this.btDatabaseToGrid.Click += new System.EventHandler(this.btDatabaseToGrid_Click);
            // 
            // dgvArtikel
            // 
            this.dgvArtikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikel.Location = new System.Drawing.Point(232, 64);
            this.dgvArtikel.Name = "dgvArtikel";
            this.dgvArtikel.ReadOnly = true;
            this.dgvArtikel.Size = new System.Drawing.Size(641, 408);
            this.dgvArtikel.TabIndex = 2;
            // 
            // lbArbeitsverzeichnis
            // 
            this.lbArbeitsverzeichnis.AutoSize = true;
            this.lbArbeitsverzeichnis.Location = new System.Drawing.Point(383, 12);
            this.lbArbeitsverzeichnis.Name = "lbArbeitsverzeichnis";
            this.lbArbeitsverzeichnis.Size = new System.Drawing.Size(95, 13);
            this.lbArbeitsverzeichnis.TabIndex = 3;
            this.lbArbeitsverzeichnis.Text = "Arbeitsverzeichnis:";
            // 
            // tvArtikelbaum
            // 
            this.tvArtikelbaum.Location = new System.Drawing.Point(13, 64);
            this.tvArtikelbaum.Name = "tvArtikelbaum";
            this.tvArtikelbaum.Size = new System.Drawing.Size(213, 214);
            this.tvArtikelbaum.TabIndex = 4;
            this.tvArtikelbaum.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvArtikelbaum_NodeMouseClick);
            // 
            // tbWarengruppe
            // 
            this.tbWarengruppe.Location = new System.Drawing.Point(91, 302);
            this.tbWarengruppe.Name = "tbWarengruppe";
            this.tbWarengruppe.ReadOnly = true;
            this.tbWarengruppe.Size = new System.Drawing.Size(135, 20);
            this.tbWarengruppe.TabIndex = 5;
            // 
            // tbBezeichnung
            // 
            this.tbBezeichnung.Location = new System.Drawing.Point(91, 328);
            this.tbBezeichnung.Name = "tbBezeichnung";
            this.tbBezeichnung.ReadOnly = true;
            this.tbBezeichnung.Size = new System.Drawing.Size(135, 20);
            this.tbBezeichnung.TabIndex = 6;
            // 
            // tbArtikelnummer
            // 
            this.tbArtikelnummer.Location = new System.Drawing.Point(91, 354);
            this.tbArtikelnummer.Name = "tbArtikelnummer";
            this.tbArtikelnummer.ReadOnly = true;
            this.tbArtikelnummer.Size = new System.Drawing.Size(135, 20);
            this.tbArtikelnummer.TabIndex = 7;
            // 
            // tbPreis
            // 
            this.tbPreis.Location = new System.Drawing.Point(91, 380);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.ReadOnly = true;
            this.tbPreis.Size = new System.Drawing.Size(135, 20);
            this.tbPreis.TabIndex = 8;
            // 
            // tbGewicht
            // 
            this.tbGewicht.Location = new System.Drawing.Point(91, 406);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.ReadOnly = true;
            this.tbGewicht.Size = new System.Drawing.Size(135, 20);
            this.tbGewicht.TabIndex = 9;
            // 
            // tbLieferzeit
            // 
            this.tbLieferzeit.Location = new System.Drawing.Point(91, 432);
            this.tbLieferzeit.Name = "tbLieferzeit";
            this.tbLieferzeit.ReadOnly = true;
            this.tbLieferzeit.Size = new System.Drawing.Size(135, 20);
            this.tbLieferzeit.TabIndex = 10;
            // 
            // lbWarengruppe
            // 
            this.lbWarengruppe.AutoSize = true;
            this.lbWarengruppe.Location = new System.Drawing.Point(10, 302);
            this.lbWarengruppe.Name = "lbWarengruppe";
            this.lbWarengruppe.Size = new System.Drawing.Size(75, 13);
            this.lbWarengruppe.TabIndex = 11;
            this.lbWarengruppe.Text = "Warengruppe:";
            // 
            // lbBezeichnung
            // 
            this.lbBezeichnung.AutoSize = true;
            this.lbBezeichnung.Location = new System.Drawing.Point(10, 328);
            this.lbBezeichnung.Name = "lbBezeichnung";
            this.lbBezeichnung.Size = new System.Drawing.Size(72, 13);
            this.lbBezeichnung.TabIndex = 12;
            this.lbBezeichnung.Text = "Bezeichnung:";
            // 
            // lbArtikelnummer
            // 
            this.lbArtikelnummer.AutoSize = true;
            this.lbArtikelnummer.Location = new System.Drawing.Point(10, 354);
            this.lbArtikelnummer.Name = "lbArtikelnummer";
            this.lbArtikelnummer.Size = new System.Drawing.Size(76, 13);
            this.lbArtikelnummer.TabIndex = 13;
            this.lbArtikelnummer.Text = "Artikelnummer:";
            // 
            // lbPreis
            // 
            this.lbPreis.AutoSize = true;
            this.lbPreis.Location = new System.Drawing.Point(10, 380);
            this.lbPreis.Name = "lbPreis";
            this.lbPreis.Size = new System.Drawing.Size(33, 13);
            this.lbPreis.TabIndex = 14;
            this.lbPreis.Text = "Preis:";
            // 
            // lbGewicht
            // 
            this.lbGewicht.AutoSize = true;
            this.lbGewicht.Location = new System.Drawing.Point(10, 406);
            this.lbGewicht.Name = "lbGewicht";
            this.lbGewicht.Size = new System.Drawing.Size(49, 13);
            this.lbGewicht.TabIndex = 15;
            this.lbGewicht.Text = "Gewicht:";
            // 
            // lbLieferzeit
            // 
            this.lbLieferzeit.AutoSize = true;
            this.lbLieferzeit.Location = new System.Drawing.Point(10, 432);
            this.lbLieferzeit.Name = "lbLieferzeit";
            this.lbLieferzeit.Size = new System.Drawing.Size(52, 13);
            this.lbLieferzeit.TabIndex = 16;
            this.lbLieferzeit.Text = "Lieferzeit:";
            // 
            // lbLieferant
            // 
            this.lbLieferant.AutoSize = true;
            this.lbLieferant.Location = new System.Drawing.Point(430, 41);
            this.lbLieferant.Name = "lbLieferant";
            this.lbLieferant.Size = new System.Drawing.Size(51, 13);
            this.lbLieferant.TabIndex = 17;
            this.lbLieferant.Text = "Lieferant:";
            // 
            // tbArbeitsverzeichnis
            // 
            this.tbArbeitsverzeichnis.Location = new System.Drawing.Point(484, 5);
            this.tbArbeitsverzeichnis.Name = "tbArbeitsverzeichnis";
            this.tbArbeitsverzeichnis.Size = new System.Drawing.Size(389, 20);
            this.tbArbeitsverzeichnis.TabIndex = 18;
            // 
            // tbLieferant
            // 
            this.tbLieferant.Location = new System.Drawing.Point(484, 38);
            this.tbLieferant.Name = "tbLieferant";
            this.tbLieferant.ReadOnly = true;
            this.tbLieferant.Size = new System.Drawing.Size(389, 20);
            this.tbLieferant.TabIndex = 19;
            // 
            // btTxtToDatabase
            // 
            this.btTxtToDatabase.Location = new System.Drawing.Point(13, 12);
            this.btTxtToDatabase.Name = "btTxtToDatabase";
            this.btTxtToDatabase.Size = new System.Drawing.Size(121, 23);
            this.btTxtToDatabase.TabIndex = 20;
            this.btTxtToDatabase.Text = "Txt --> Database";
            this.btTxtToDatabase.UseVisualStyleBackColor = true;
            this.btTxtToDatabase.Click += new System.EventHandler(this.btTxtToDatabase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 484);
            this.Controls.Add(this.btTxtToDatabase);
            this.Controls.Add(this.tbLieferant);
            this.Controls.Add(this.tbArbeitsverzeichnis);
            this.Controls.Add(this.lbLieferant);
            this.Controls.Add(this.lbLieferzeit);
            this.Controls.Add(this.lbGewicht);
            this.Controls.Add(this.lbPreis);
            this.Controls.Add(this.lbArtikelnummer);
            this.Controls.Add(this.lbBezeichnung);
            this.Controls.Add(this.lbWarengruppe);
            this.Controls.Add(this.tbLieferzeit);
            this.Controls.Add(this.tbGewicht);
            this.Controls.Add(this.tbPreis);
            this.Controls.Add(this.tbArtikelnummer);
            this.Controls.Add(this.tbBezeichnung);
            this.Controls.Add(this.tbWarengruppe);
            this.Controls.Add(this.tvArtikelbaum);
            this.Controls.Add(this.lbArbeitsverzeichnis);
            this.Controls.Add(this.dgvArtikel);
            this.Controls.Add(this.btDatabaseToGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDatabaseToGrid;
        private System.Windows.Forms.DataGridView dgvArtikel;
        private System.Windows.Forms.Label lbArbeitsverzeichnis;
        private System.Windows.Forms.TreeView tvArtikelbaum;
        private System.Windows.Forms.TextBox tbWarengruppe;
        private System.Windows.Forms.TextBox tbBezeichnung;
        private System.Windows.Forms.TextBox tbArtikelnummer;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.TextBox tbGewicht;
        private System.Windows.Forms.TextBox tbLieferzeit;
        private System.Windows.Forms.Label lbWarengruppe;
        private System.Windows.Forms.Label lbBezeichnung;
        private System.Windows.Forms.Label lbArtikelnummer;
        private System.Windows.Forms.Label lbPreis;
        private System.Windows.Forms.Label lbGewicht;
        private System.Windows.Forms.Label lbLieferzeit;
        private System.Windows.Forms.Label lbLieferant;
        private System.Windows.Forms.TextBox tbArbeitsverzeichnis;
        private System.Windows.Forms.TextBox tbLieferant;
        private System.Windows.Forms.Button btTxtToDatabase;
    }
}

