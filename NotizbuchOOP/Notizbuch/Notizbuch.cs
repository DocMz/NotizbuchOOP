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
        }
        public void einfacheNotizAdd(string title)
        {
            this.einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, title));
        }
        public void einfacheNotizRemove(int index) //Löscht Notiz aus der List an dem bestimmten Index
        {
            this.einfacheNotizen.RemoveAt(index);
        }
        public void updateListings() //Aktualisiert die Bindings Manuell
        {
            this.einfacheNotizen.ResetBindings();
            this.hausaufgaben.ResetBindings();
            this.einkaufzettel.ResetBindings();
        }
        public BindingList<EinfacheNotiz> einfacheNotizFilter(int prio)
        {
            BindingList<EinfacheNotiz> liste = new BindingList<EinfacheNotiz>();
            foreach(EinfacheNotiz x in einfacheNotizen)
            {
                if(x.prio == prio)
                {
                    liste.Add(x);
                }
            }
            return liste;
        }
    }
}
