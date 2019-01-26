using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    public class Position
    {
        public Artikel artikel { get; set; }
        public string name { get; set; }
        public int menge { get; set; }
        public float preis { get; set; }
        public Position(Artikel artikel, int menge)
        {
            this.artikel = artikel;
            this.menge = menge;
            this.name = artikel.bezeichung + " - Anzahl: " + menge.ToString();
            this.preis = artikel.preis * menge;
        }
    }
}
