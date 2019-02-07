using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    /// <summary>
    /// Der Artikelcontainer beinhaltet die Liste der Artikel, die es gibt.
    /// </summary>
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

        /// <summary>
        /// Funtion um Artikel hinzuzufügen.
        /// </summary>
        /// <param name="bezeichnung"></param>
        /// <param name="preis"></param>
        public void artikelAdd(string bezeichnung,float preis)
        {
            this.artikel.Add(new Artikel(bezeichnung, preis));
        }
    }
}
