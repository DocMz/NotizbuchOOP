using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    class Einkaufszettel
    {
        public DateTime datum { get; set; }
        public string titel { get; set; }
        public BindingList<Position> positions { get; set; }
        public Einkaufszettel(DateTime datum, string titel)
        {
            this.datum = datum;
            this.titel = titel;
        }
    }
}
