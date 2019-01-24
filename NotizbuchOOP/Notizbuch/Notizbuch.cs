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
        public string name { get; set; } //Notizbuchname
        public Notizbuch(DateTime datum, string name)
        {
            this.datum = datum;
            this.name = name;

            this.einfacheNotizen = new BindingList<EinfacheNotiz>();
            this.einkaufzettel = new BindingList<Einkaufszettel>();
            this.hausaufgaben = new BindingList<Hausaufgabe>();
        }
        public void einfacheNotizAdd(string title) //Fügt eine einfache Notiz hinzu
        {
            this.einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, title));
        }
        public void einfacheNotizRemove(int index) //Löscht Notiz aus der List an dem bestimmten Index
        {
            if(index >= 0)
            {
                this.einfacheNotizen.RemoveAt(index);

            }
        }
        public void updateListings() //Aktualisiert die Bindings Manuell
        {
            this.einfacheNotizen.ResetBindings();
            this.hausaufgaben.ResetBindings();
            this.einkaufzettel.ResetBindings();
        }
        public IEnumerable<EinfacheNotiz> einfacheNotizFilter(int prio)
        {
            if (prio != 0)
            {
                IEnumerable<EinfacheNotiz> liste = new BindingList<EinfacheNotiz>();
                return liste = einfacheNotizen.Where(x => x.prio == prio);
            } else
            {
                return null;
            }
        }
    }
}
