using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    /// <summary>
    /// Artikelobjekt
    /// </summary>
    public class Artikel
    {
        public string bezeichung { get; set; }
        public float preis { get; set; }
        public Artikel(string bezeichnung, float preis)
        {
            this.bezeichung = bezeichnung;
            this.preis = preis;
        }
    }
}
