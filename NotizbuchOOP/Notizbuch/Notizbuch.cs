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
        public DateTime datum { get; set;}
        public List<Einkaufszettel> einkaufzettel { get; set; }
        public List<EinfacheNotiz> einfacheNotizen { get; set; }
        public List<Hausaufgabe> hausaufgaben { get; set; }
        public string name { get; set; }
        public Notizbuch(DateTime datum, string name)
        {
            this.datum = datum;
            this.name = name;

            this.einfacheNotizen = new List<EinfacheNotiz>();
        }
        public void einfacheNotizAdd(string title)
        {
            this.einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, title));
        }
    }
}
