using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    /// <summary>
    /// Einfache Notiz Objekt
    /// </summary>
    public class EinfacheNotiz
    {
        public DateTime datum { get; set; }
        public string titel { get; set; }
        public string[] inhalt { get; set; }
        public int prio { get; set; }
        public EinfacheNotiz(DateTime datum, string titel, int prio = 0, string[] inhalt = null)
        {
            this.datum = datum;
            this.titel = titel;
            this.prio = prio;

            if (inhalt != null)
            {
                this.inhalt = inhalt;
            }
        }
    }
}
