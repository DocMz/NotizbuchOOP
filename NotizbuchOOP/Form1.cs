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
        private List<Notizbuch.Notizbuch> notizenListe = new List<Notizbuch.Notizbuch>();
        private int currentNotizbuch;

        //0 = Notizen, 1 = Einkaufsliste, 2 = Hausaufgaben 3 = Suche
        private int notizArt = 0;

        public Form1()
        {
            InitializeComponent();

            //Deklaration des ersten Notizbuches
            Notizbuch.Notizbuch notizen = new Notizbuch.Notizbuch(DateTime.Now, "Notizbuch");
            this.notizenListe.Add(notizen);

            BindingUpdate();
        }
        public void BindingUpdate()
        {
            //Data-Bindings
            cb_ListenAuswahl.DataSource = this.notizenListe;
            cb_ListenAuswahl.DisplayMember = "name";

            if(this.notizArt == 0) //Einfache Notiz
            {
                lb_notizen.DataSource = notizenListe[currentNotizbuch].einfacheNotizen;
                if(lb_notizen.SelectedIndex != -1)
                {
                    tb_titel.Text = this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].titel;
                    rtb_inhalt.Lines = this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].inhalt;
                    tbar_prio.Value = this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].prio;
                }
                b_Suchen.Enabled = true; //Suchknopf ausschalten
            }
            else if(this.notizArt == 1) { //Einkaufszettel
                lb_notizen.DataSource = notizenListe[currentNotizbuch].einkaufzettel;
                if (lb_notizen.SelectedIndex != -1)
                {
                    tb_titel.Text = this.notizenListe[currentNotizbuch].einkaufzettel[lb_notizen.SelectedIndex].titel;
                    //rtb_inhalt.Lines = this.notizenListe[currentNotizbuch].einkaufzettel[lb_notizen.SelectedIndex].inhalt;
                }
                b_Suchen.Enabled = false; //Suchknopf ausschalten
            }
            else if(this.notizArt == 2) { //Hausaufgaben
                lb_notizen.DataSource = notizenListe[currentNotizbuch].hausaufgaben;
                if (lb_notizen.SelectedIndex != -1)
                {
                    tb_titel.Text = this.notizenListe[currentNotizbuch].hausaufgaben[lb_notizen.SelectedIndex].titel;
                    //rtb_inhalt.Lines = this.notizenListe[currentNotizbuch].hausaufgaben[lb_notizen.SelectedIndex].inhalt;
                }
                b_Suchen.Enabled = false; //Suchknopf ausschalten
            }
            else if(this.notizArt == 3) //Priosuche
            {
                if (lb_notizen.SelectedIndex != -1)
                {
                    IEnumerable<EinfacheNotiz> result = this.notizenListe[currentNotizbuch].einfacheNotizFilter((int)nud_Prio.Value);
                    lb_notizen.DataSource = new BindingSource() { DataSource = result == null ? this.notizenListe[currentNotizbuch].einfacheNotizen : result};
                }
                b_Suchen.Enabled = true; //Suchknopf ausschalten
            }

            lb_notizen.DisplayMember = "titel";

            lb_notizen.ContextMenuStrip = cm_notizen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cb_ListenAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentNotizbuch = cb_ListenAuswahl.SelectedIndex;
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
            int count = 0;
            if(notizenListe[currentNotizbuch] != null && notizenListe[currentNotizbuch].einfacheNotizen != null)
            {
                count = notizenListe[currentNotizbuch].einfacheNotizen.Count();
            }
            notizenListe[currentNotizbuch].einfacheNotizAdd("Notiz" + count);
        }

        private void lb_notizen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_notizen.SelectedIndex < 0)
            {
                return;
            }

            var selectedItem = notizenListe[currentNotizbuch].einfacheNotizen.Select(p => (EinfacheNotiz)lb_notizen.SelectedItem).FirstOrDefault();
            tb_titel.Text = selectedItem.titel;
            rtb_inhalt.Lines = selectedItem.inhalt;
            if (this.notizArt == 0 || this.notizArt == 3)
            {
                nud_Prio.Value = selectedItem.prio;
            }
        }

        private void b_speichern_click(object sender, EventArgs e) //Speicherung
        {

            if (this.notizArt == 0 || this.notizArt == 3)
            {
                var selectedItem = this.notizenListe[currentNotizbuch].einfacheNotizen.Select(p => (EinfacheNotiz)lb_notizen.SelectedItem).FirstOrDefault();
                int index = this.notizenListe[currentNotizbuch].einfacheNotizen.IndexOf(selectedItem);

                this.notizenListe[currentNotizbuch].einfacheNotizen[index].titel = tb_titel.Text;
                this.notizenListe[currentNotizbuch].einfacheNotizen[index].inhalt = rtb_inhalt.Lines;
                this.notizenListe[currentNotizbuch].einfacheNotizen[index].prio = tbar_prio.Value;
            } else if(this.notizArt == 1)
            {
                this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].titel = tb_titel.Text;
                this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].inhalt = rtb_inhalt.Lines;
            } else if (this.notizArt == 2)
            {
                this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].titel = tb_titel.Text;
                this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].inhalt = rtb_inhalt.Lines;
            }
            this.notizenListe[currentNotizbuch].updateListings();
            BindingUpdate();
        }

        private void notizLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notizenListe[currentNotizbuch] != null && notizenListe[currentNotizbuch].einfacheNotizen != null)
            {
                notizenListe[currentNotizbuch].einfacheNotizRemove(lb_notizen.SelectedIndex);
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
            }
            BindingUpdate();
                
        }
    }
}
