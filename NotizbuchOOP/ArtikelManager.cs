using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotizbuchOOP.Notizbuch.Notizen;
using System.Windows.Forms;

namespace NotizbuchOOP
{
    public partial class ArtikelManager : Form
    {
        public ArtikelContainer artikelContainer = new ArtikelContainer();

        public ArtikelManager(ArtikelContainer artikelContainer)
        {
            InitializeComponent();
            this.artikelContainer = artikelContainer;
        }

        private void BindingUpdate()
        {
            lb_artikel.ContextMenuStrip = cm_artikel;

            artikelContainer.artikel.ResetBindings();

            lb_artikel.DataSource = artikelContainer.artikel;
            lb_artikel.DisplayMember = "bezeichung";
        }

        private void ArtikelManager_Load(object sender, EventArgs e)
        {
            BindingUpdate();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if(lb_artikel.SelectedIndex >= 0)
            {
                var selectedItem = artikelContainer.artikel.Select(p => (Artikel)lb_artikel.SelectedItem).FirstOrDefault();
                selectedItem.bezeichung = tb_Bezeichnung.Text;
                selectedItem.preis = (float)(nud_Preis.Value);
            }
            BindingUpdate();
        }

        private void lb_artikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTextboxes();
        }

        private void updateTextboxes()
        {
            if(artikelContainer.artikel.Count > 0)
            {
                var selectedItem = artikelContainer.artikel.Select(p => (Artikel)lb_artikel.SelectedItem).FirstOrDefault();
                tb_Bezeichnung.Text = selectedItem.bezeichung;
                nud_Preis.Value = Convert.ToDecimal(selectedItem.preis);
            }
        }

        private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            if(artikelContainer.artikel != null) {
                if (artikelContainer.artikel.Count() >= 0)
                {
                    count = artikelContainer.artikel.Count();
                }
            }
            artikelContainer.artikelAdd("Artikel" + count, 0);
            BindingUpdate();
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lb_artikel.SelectedIndex >= 0)
            {
                var selectedItem = artikelContainer.artikel.Select(p => (Artikel)lb_artikel.SelectedItem).FirstOrDefault();
                artikelContainer.artikel.Remove(selectedItem);
            }
            BindingUpdate();
        }
    }
}
