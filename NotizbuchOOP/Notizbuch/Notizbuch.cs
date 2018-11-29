using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotizbuchOOP.Notizbuch.Notizen;

namespace NotizbuchOOP.Notizbuch
{
    class Notizbuch
    {
        public DateTime datum { get; set;}
        public BindingList<Einkaufszettel> einkaufzettel { get; set; }
        public BindingList<EinfacheNotiz> einfacheNotizen { get; set; }
        public BindingList<Hausaufgabe> hausaufgaben { get; set; }
        public string name { get; set; }
        public Notizbuch(DateTime datum, string name)
        {
            this.datum = datum;
            this.name = name;

            this.einfacheNotizen = new BindingList<EinfacheNotiz>();
            this.einkaufzettel = new BindingList<Einkaufszettel>();
            this.hausaufgaben = new BindingList<Hausaufgabe>();

            einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, "test"));
            einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, "test"));
            einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, "test"));
            einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, "test"));

        }
        public void einfacheNotizAdd(string title)
        {
            this.einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, title));
        }
    }
}
