using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotizbuchOOP.Notizbuch.Notizen;

namespace NotizbuchOOP
{
    public partial class ArtikelAdd : Form
    {
        private ArtikelContainer artikelContainer = new ArtikelContainer();
        public Position position { get; set; }
        public ArtikelAdd(ArtikelContainer artikelContainer)
        {
            InitializeComponent();
            this.artikelContainer = artikelContainer;
            cb_artikel.DataSource = artikelContainer.artikel;
            cb_artikel.DisplayMember = "bezeichung";
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            var selectedItem = artikelContainer.artikel.Select(p => (Artikel)cb_artikel.SelectedItem).FirstOrDefault();
            int n;
            bool isNumber = int.TryParse(tb_anzahl.Text, out n);
            if(isNumber)
            {
                this.position = new Position(selectedItem, Convert.ToInt32(tb_anzahl.Text));
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void cb_artikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_anzahl.Text = "0";
            UpdateBindings();
        }

        private void UpdateBindings()
        {
            if(artikelContainer.artikel.Count > 0)
            {
                b_add.Enabled = true;
                var selectedItem = artikelContainer.artikel.Select(p => (Artikel)cb_artikel.SelectedItem).FirstOrDefault();
                int n;
                bool isNumber = int.TryParse(tb_anzahl.Text, out n);
                if (isNumber)
                {
                    tb_preis.Text = (selectedItem.preis * n).ToString();
                }
            } else
            {
                b_add.Enabled = false;
            }
        }

        private void tb_anzahl_TextChanged(object sender, EventArgs e)
        {
            UpdateBindings();
        }
    }
}
