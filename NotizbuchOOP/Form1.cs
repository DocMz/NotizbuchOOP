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

        //0 = Notizen, 1 = Einkaufsliste, 2 = Hausaufgaben
        private int notizArt = 0;

        public Form1()
        {
            InitializeComponent();

            //Deklaration des ersten Notizbuches
            Notizbuch.Notizbuch notizen = new Notizbuch.Notizbuch(DateTime.Now, "Notizbuch");
            Notizbuch.Notizbuch notizen2 = new Notizbuch.Notizbuch(DateTime.Now, "Notizbuch2");
            this.notizenListe.Add(notizen);
            this.notizenListe.Add(notizen2);

            BindingUpdate();
        }
        public void BindingUpdate()
        {
            //Data-Bindings
            cb_ListenAuswahl.DataSource = notizenListe;
            cb_ListenAuswahl.DisplayMember = "name";

            if(this.notizArt == 0)
            {
                lb_notizen.DataSource = notizenListe[currentNotizbuch].einfacheNotizen;
                if(lb_notizen.SelectedIndex != -1)
                {
                    tb_titel.Text = this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].titel;
                    rtb_inhalt.Lines = this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].inhalt;
                }
            }
            else if(this.notizArt == 1) {
                lb_notizen.DataSource = notizenListe[currentNotizbuch].einkaufzettel;
                if (lb_notizen.SelectedIndex != -1)
                {
                    tb_titel.Text = this.notizenListe[currentNotizbuch].einkaufzettel[lb_notizen.SelectedIndex].titel;
                    //rtb_inhalt.Lines = this.notizenListe[currentNotizbuch].einkaufzettel[lb_notizen.SelectedIndex].inhalt;
                }
            }
            else if(this.notizArt == 2) {
                lb_notizen.DataSource = notizenListe[currentNotizbuch].hausaufgaben;
                if (lb_notizen.SelectedIndex != -1)
                {
                    tb_titel.Text = this.notizenListe[currentNotizbuch].hausaufgaben[lb_notizen.SelectedIndex].titel;
                    //rtb_inhalt.Lines = this.notizenListe[currentNotizbuch].hausaufgaben[lb_notizen.SelectedIndex].inhalt;
                }
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
            BindingUpdate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].titel = tb_titel.Text;
            this.notizenListe[currentNotizbuch].einfacheNotizen[lb_notizen.SelectedIndex].inhalt = rtb_inhalt.Lines;
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
    }
}
