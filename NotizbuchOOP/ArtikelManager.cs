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
    /// <summary>
    /// Artikelmanager, indem die Artikel angelegt werden können.
    /// </summary>
    public partial class ArtikelManager : Form
    {
        public ArtikelContainer artikelContainer = new ArtikelContainer();

        /// <summary>
        /// Konstruktorfunktion
        /// </summary>
        /// <param name="artikelContainer">Der Hauptartikelcontainer wird der Funktion übergeben</param>
        public ArtikelManager(ArtikelContainer artikelContainer)
        {
            InitializeComponent();
            this.artikelContainer = artikelContainer;
        }

        /// <summary>
        /// Aktualisiert die Darstellung der Form
        /// </summary>
        private void BindingUpdate()
        {
            lb_artikel.ContextMenuStrip = cm_artikel;

            artikelContainer.artikel.ResetBindings();

            lb_artikel.DataSource = artikelContainer.artikel;
            lb_artikel.DisplayMember = "bezeichung";
        }
        
        /// <summary>
        /// Wird ausgeführt wenn die Form das erste mal geladen wurden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArtikelManager_Load(object sender, EventArgs e)
        {
            BindingUpdate();
        }

        /// <summary>
        /// Event welches bei Klick auf Speichern ausgelöst wird.
        /// Speicher Änderungen am aktuellen Artikel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Event welches ausgelöst wird wenn der Index der Listbox sich verändert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_artikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTextboxes();
        }

        /// <summary>
        /// Funktion welche den Inhalt der Textboxen aktualisiert.
        /// </summary>
        private void updateTextboxes()
        {
            if(artikelContainer.artikel.Count > 0)
            {
                var selectedItem = artikelContainer.artikel.Select(p => (Artikel)lb_artikel.SelectedItem).FirstOrDefault();
                tb_Bezeichnung.Text = selectedItem.bezeichung;
                nud_Preis.Value = Convert.ToDecimal(selectedItem.preis);
            }
        }

        /// <summary>
        /// Funktion welche ausgeführt wird wenn man im Kontextmenü auf Artikelhinzufügen klickt.
        /// Fügt dem Artikelcontainer eine neuen Artikel hinzu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Funktion welche ausgelöst wird, wenn man im Kontextmenü auf Artikellöschen klickt.
        /// Löscht den aktuell ausgewählten Artikel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
