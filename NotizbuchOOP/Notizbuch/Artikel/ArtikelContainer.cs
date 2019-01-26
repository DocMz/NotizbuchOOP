using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    public class ArtikelContainer
    {
        public BindingList<Artikel> artikel { get; set; }
        public ArtikelContainer(BindingList<Artikel> artikel = null)
        {
            if(artikel != null) {
                this.artikel = artikel;
            } else
            {
                this.artikel = new BindingList<Artikel>();
            }
        }
        public void artikelAdd(string bezeichnung,float preis)
        {
            this.artikel.Add(new Artikel(bezeichnung, preis));
        }
    }
}
