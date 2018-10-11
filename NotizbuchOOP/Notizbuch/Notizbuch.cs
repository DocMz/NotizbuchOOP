using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotizbuchOOP.Notizbuch.Notizen;

namespace NotizbuchOOP.Notizbuch
{
    class Notizbuch
    {
        public DateTime jahr { get; set; }
        public Einkaufszettel[] einkaufzettel { get; set; }
        public EinfacheNotiz[] einfacheNotizen { get; set; }
        public Hausaufgabe[] hausaufgaben { get; set; }
    }
}
