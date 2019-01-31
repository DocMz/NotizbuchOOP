using NotizbuchOOP.Notizbuch.Notizen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotizbuchOOP
{
    public partial class Form1 : Form
    {
        private BindingList<Notizbuch.Notizbuch> notizenListe = new BindingList<Notizbuch.Notizbuch>();
        private ArtikelContainer artikelContainer = new ArtikelContainer();
        private Serializer serializer = new Serializer();
        private int currentNotizbuch;

        //0 = Notizen, 1 = Einkaufsliste, 2 = Hausaufgaben 3 = Suche
        private int notizArt = 0;

        public Form1()
        {
            InitializeComponent();

            //Deklaration des ersten Notizbuches
            this.notizenListe = serializer.load();
            if(notizenListe == null)
            {
                this.notizenListe = new BindingList<Notizbuch.Notizbuch>();
                Notizbuch.Notizbuch notizen = new Notizbuch.Notizbuch(DateTime.Now, "Notizbuch");
                this.notizenListe.Add(notizen);
            }
            this.artikelContainer = serializer.loadArtikel();
            if(artikelContainer == null)
            {
                this.artikelContainer = new ArtikelContainer();
            }
            BindingUpdate();
        }
        public void BindingUpdate()
        {
            //Data-Bindings
            cb_ListenAuswahl.DataSource = this.notizenListe;
            cb_ListenAuswahl.DisplayMember = "name";
            if (currentNotizbuch == -1)
                return;

            if(this.notizArt == 0) //Einfache Notiz
            {
                lb_notizen.DataSource = notizenListe[currentNotizbuch].einfacheNotizen;
                if(lb_notizen.SelectedIndex != -1)
                {
                    var selectedItem = this.notizenListe[currentNotizbuch].einfacheNotizen.Select(p => (EinfacheNotiz)lb_notizen.SelectedItem).FirstOrDefault();
                    tb_titel.Text = selectedItem.titel;
                    rtb_inhalt.Lines = selectedItem.inhalt;
                    tbar_prio.Value = selectedItem.prio;
                    dtp_ablauf.Value = selectedItem.datum;
                }
                notizenRender();
            }
            else if(this.notizArt == 1) { //Einkaufszettel
                lb_notizen.DataSource = notizenListe[currentNotizbuch].einkaufzettel;
                if (lb_notizen.SelectedIndex >= 0)
                {
                    var selectedItem = this.notizenListe[currentNotizbuch].einkaufzettel.Select(p => (Einkaufszettel)lb_notizen.SelectedItem).FirstOrDefault();
                    tb_titel.Text = selectedItem.titel;
                    dtp_ablauf.Value = selectedItem.datum;
                    lb_artikel.DataSource = selectedItem.positions;
                }   
                einkaufslisteRender();
            }
            else if(this.notizArt == 2) { //Hausaufgaben
                lb_notizen.DataSource = notizenListe[currentNotizbuch].hausaufgaben;
                if (lb_notizen.SelectedIndex != -1)
                {
                    var selectedItem = this.notizenListe[currentNotizbuch].hausaufgaben.Select(p => (Hausaufgabe)lb_notizen.SelectedItem).FirstOrDefault();
                    tb_titel.Text = selectedItem.titel;
                    rtb_inhalt.Lines = selectedItem.inhalt;
                    dtp_ablauf.Value = selectedItem.datum;
                    tb_fach.Text = selectedItem.fach;
                }
                hausaufgabenRender();
            }
            else if(this.notizArt == 3) //Priosuche
            {
                lb_notizen.DataSource = this.notizenListe[currentNotizbuch].searchResults;
                if (lb_notizen.SelectedIndex != -1)
                {
                    var selectedItem = this.notizenListe[currentNotizbuch].searchResults.Select(p => (EinfacheNotiz)lb_notizen.SelectedItem).FirstOrDefault();
                    tb_titel.Text = selectedItem.titel;
                    rtb_inhalt.Lines = selectedItem.inhalt;
                    tbar_prio.Value = selectedItem.prio;
                    dtp_ablauf.Value = selectedItem.datum;
                }
                notizenRender();
            }

            lb_notizen.DisplayMember = "titel";
            lb_notizen.ContextMenuStrip = cm_notizen;
            lb_artikel.DisplayMember = "name";
            lb_artikel.ContextMenuStrip = cm_position;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cb_ListenAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentNotizbuch = cb_ListenAuswahl.SelectedIndex;
            this.notizArt = 0;
            BindingUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.notizArt = 0;
            BindingUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.notizArt = 1;
            BindingUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.notizArt = 2;
            BindingUpdate();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void notizHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(currentNotizbuch == -1)
            {
                MessageBox.Show(null, "Erstellen sie erst ein Notizbuch, bevor sie etwas hinzufügen!", "Hinzufügen fehlgeschlagen.");
                return;
            }
            if (notizenListe[currentNotizbuch] != null)
            {
                if(notizArt == 0 ||notizArt == 3)
                {
                    int count = 0;
                    if(notizenListe[currentNotizbuch].einfacheNotizen != null)
                    {
                        count = notizenListe[currentNotizbuch].einfacheNotizen.Count();
                    }
                    notizenListe[currentNotizbuch].einfacheNotizAdd("Notiz" + count);
                } else if (notizArt == 2)
                {
                    int count = 0;
                    if(notizenListe[currentNotizbuch].hausaufgaben != null)
                    {
                        count = notizenListe[currentNotizbuch].hausaufgaben.Count();
                    }
                    notizenListe[currentNotizbuch].hausaufgabeAdd("Hausaufgabe" + count, DateTime.Today);
                } else if (notizArt == 1)
                {
                    int count = 0;
                    if(notizenListe[currentNotizbuch].einkaufzettel != null)
                    {
                        count = notizenListe[currentNotizbuch].einkaufzettel.Count();
                    }
                    notizenListe[currentNotizbuch].einkaufslisteAdd(DateTime.Today, "Einkaufsliste" + count);
                }
            }
        }

        private void lb_notizen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_notizen.SelectedIndex < 0)
            {
                return;
            }
            BindingUpdate();
        }

        private void b_speichern_click(object sender, EventArgs e) //Speicherung
        {
            if (this.notizArt == 0 || this.notizArt == 3) //Einfache Notiz
            {
                var selectedItem = this.notizenListe[currentNotizbuch].einfacheNotizen.Select(p => (EinfacheNotiz)lb_notizen.SelectedItem).FirstOrDefault();
                int index = this.notizenListe[currentNotizbuch].einfacheNotizen.IndexOf(selectedItem);

                if(index >= 0)
                {
                this.notizenListe[currentNotizbuch].einfacheNotizen[index] = new EinfacheNotiz(dtp_ablauf.Value, tb_titel.Text, tbar_prio.Value, rtb_inhalt.Lines);
                }
                this.notizenListe[currentNotizbuch].einfacheNotizFilter((int)nud_Prio.Value); //Nach dem Speicher die Ergebnisse aktualisieren

            } else if(this.notizArt == 1) //Einkaufsliste
            {
                var selectedItem = this.notizenListe[currentNotizbuch].einkaufzettel.Select(p => (Einkaufszettel)lb_notizen.SelectedItem).FirstOrDefault();
                int index = this.notizenListe[currentNotizbuch].einkaufzettel.IndexOf(selectedItem);

                if (index >= 0)
                {
                    this.notizenListe[currentNotizbuch].einkaufzettel[index] = new Einkaufszettel(dtp_ablauf.Value, tb_titel.Text, this.notizenListe[currentNotizbuch].einkaufzettel[index].positions);
                }


            } else if (this.notizArt == 2) // Hausaufgaben
            {
                var selectedItem = this.notizenListe[currentNotizbuch].hausaufgaben.Select(p => (Hausaufgabe)lb_notizen.SelectedItem).FirstOrDefault();
                int index = this.notizenListe[currentNotizbuch].hausaufgaben.IndexOf(selectedItem);

                if(index >= 0)
                {
                    this.notizenListe[currentNotizbuch].hausaufgaben[index] = new Hausaufgabe(dtp_ablauf.Value, tb_titel.Text, tb_fach.Text, rtb_inhalt.Lines);
                }
            }
            this.notizenListe[currentNotizbuch].updateListings();
            BindingUpdate();
        }

        private void notizLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notizenListe[currentNotizbuch] != null)
            {
                if (notizenListe[currentNotizbuch].einfacheNotizen != null && (notizArt == 0 || notizArt == 3) )
                {   
                    var selectedItem = this.notizenListe[currentNotizbuch].einfacheNotizen.Select(p => (EinfacheNotiz)lb_notizen.SelectedItem).FirstOrDefault();
                    notizenListe[currentNotizbuch].einfacheNotizRemove(selectedItem);
                    this.notizenListe[currentNotizbuch].einfacheNotizFilter((int)nud_Prio.Value);
                }
                else if (notizenListe[currentNotizbuch].hausaufgaben != null && notizArt == 2)
                {
                    var selectedItem = this.notizenListe[currentNotizbuch].hausaufgaben.Select(p => (Hausaufgabe)lb_notizen.SelectedItem).FirstOrDefault();
                    notizenListe[currentNotizbuch].hausaufgabenRemove(selectedItem);
                } else if (notizenListe[currentNotizbuch].einkaufzettel != null && notizArt == 1)
                {
                    var selectedItem = this.notizenListe[currentNotizbuch].einkaufzettel.Select(p => (Einkaufszettel)lb_notizen.SelectedItem).FirstOrDefault();
                    notizenListe[currentNotizbuch].einkaufslisteRemove(selectedItem);
                }
                    BindingUpdate();
            }

        }

        private void b_Suchen_Click(object sender, EventArgs e)
        {
            if(nud_Prio.Value == 0)
            {
                this.notizArt = 0; //Anzeige auf einfache Notiz setzen
            }
            else
            {
                this.notizArt = 3; //Anzeige auf Suchen stellen
                this.notizenListe[currentNotizbuch].einfacheNotizFilter((int)nud_Prio.Value);
            }
            BindingUpdate();
        }

        private void notizenRender()
        {
            b_Suchen.Enabled = true; 
            l_datum.Text = "Datum";
            tb_fach.Enabled = false;
            nud_Prio.Enabled = true;
            tbar_prio.Enabled = true;
            b_artAdd.Enabled = false;
            dtp_ablauf.CustomFormat = "'Erstellt:' dd.MM.yy";
            rtb_inhalt.Show();
            lb_artikel.Hide();
        }
        private void hausaufgabenRender()
        {
            b_Suchen.Enabled = false; 
            l_datum.Text = "Fälligkeit";
            tb_fach.Enabled = true;
            nud_Prio.Enabled = false;
            tbar_prio.Enabled = false;
            b_artAdd.Enabled = false;
            dtp_ablauf.CustomFormat = "'Fällig:' dd.MM.yy";
            rtb_inhalt.Show();
            lb_artikel.Hide();
        }
        private void einkaufslisteRender()
        {
            b_Suchen.Enabled = false; 
            l_datum.Text = "Datum";
            tb_fach.Enabled = false;
            nud_Prio.Enabled = false;
            tbar_prio.Enabled = false;
            b_artAdd.Enabled = true;
            rtb_inhalt.Hide();
            lb_artikel.Show();
        }

        private void titelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notizenListe[currentNotizbuch].sortAllTitle();
            BindingUpdate();
        }

        private void datumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notizenListe[currentNotizbuch].sortAllDate();
            BindingUpdate();
        }

        private void fachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notizenListe[currentNotizbuch].sortAllSubject();
            BindingUpdate();
        }

        private void prioritätToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notizenListe[currentNotizbuch].sortAllPrio();
            BindingUpdate();
        }

        private void b_artAdd_Click(object sender, EventArgs e)
        {
            ArtikelManager artikelManager = new ArtikelManager(artikelContainer);
            artikelManager.Show();
            this.artikelContainer = new ArtikelContainer(artikelManager.artikelContainer.artikel);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void positionHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtikelAdd artikelAdd = new ArtikelAdd(artikelContainer);
            var result = artikelAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if(this.notizenListe[currentNotizbuch].einkaufzettel.Count > 0)
                {
                    var selectedItem = this.notizenListe[currentNotizbuch].einkaufzettel.Select(p => (Einkaufszettel)lb_notizen.SelectedItem).FirstOrDefault();
                    int index = this.notizenListe[currentNotizbuch].einkaufzettel.IndexOf(selectedItem);

                    this.notizenListe[currentNotizbuch].einkaufzettel[index].positionAdd(artikelAdd.position);
                    BindingUpdate();
                } else
                {
                    MessageBox.Show(null, "Erstellen sie zuerst eine Einkaufslist und wählen sie diese aus.", "Keine Einkaufliste erstellt");
                }
            }
        }

        private void positonEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.notizenListe[currentNotizbuch].einkaufzettel.Count() != 0)
            {
                var selectedItem = this.notizenListe[currentNotizbuch].einkaufzettel.Select(p => (Einkaufszettel)lb_notizen.SelectedItem).FirstOrDefault();
                int index = this.notizenListe[currentNotizbuch].einkaufzettel.IndexOf(selectedItem);
                
                if(index >= 0)
                {
                    var selectedPosition = this.notizenListe[currentNotizbuch].einkaufzettel[index].positions.Select(p => (Position)lb_artikel.SelectedItem).FirstOrDefault();
                    this.notizenListe[currentNotizbuch].einkaufzettel[index].positionRemove(selectedPosition);
                }
            }
            BindingUpdate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serializer.save(this.notizenListe);
            serializer.saveArtikel(this.artikelContainer);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.notizenListe.Add(new Notizbuch.Notizbuch(DateTime.Today, "Notizbuch" + (this.notizenListe.Count() + (int)1)));
            BindingUpdate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(this.notizenListe.Count() > 0)
            {
                var selectedItem = this.notizenListe.Select(p => (Notizbuch.Notizbuch)cb_ListenAuswahl.SelectedItem).FirstOrDefault();
                this.notizenListe.Remove(selectedItem);
            }

        }
    }
}
