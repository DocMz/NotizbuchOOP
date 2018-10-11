using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    class Hausaufgabe
    {
        public DateTime datum { get ; set ;}
        public string titel { get; set; }
        public Hausaufgabe(DateTime datum, string title)
        {
            this.datum = datum;
            this.titel = title;
        }
    }
}
