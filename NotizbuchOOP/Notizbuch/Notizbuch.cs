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
        public BindingList<EinfacheNotiz> searchResults { get; set; }
        public string name { get; set; } //Notizbuchname

        public Notizbuch(DateTime datum, string name)
        {
            this.datum = datum;
            this.name = name;

            this.einfacheNotizen = new BindingList<EinfacheNotiz>();
            this.einkaufzettel = new BindingList<Einkaufszettel>();
            this.hausaufgaben = new BindingList<Hausaufgabe>();
            this.searchResults = new BindingList<EinfacheNotiz>();
        }
        public void einfacheNotizAdd(string title) //Fügt eine einfache Notiz hinzu
        {
            this.einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, title));
        }
        public void einfacheNotizRemove(EinfacheNotiz item) //Löscht Notiz aus der List an dem bestimmten Index
        {
            this.einfacheNotizen.Remove(item);
            this.searchResults.Remove(item);
        }
        public void einfacheNotizFilter(int prio)
        {   
            if (prio != 0)
            {
                IEnumerable<EinfacheNotiz> liste = new BindingList<EinfacheNotiz>();
                liste = einfacheNotizen.Where(x => x.prio == prio);
                searchResults.Clear();
                foreach (EinfacheNotiz x in liste)
                {
                    this.searchResults.Add(x);
                }
            }
        }
        public void hausaufgabeAdd(string titel, DateTime ablauf)
        {
            this.hausaufgaben.Add(new Hausaufgabe(ablauf, titel));
        }
        public void hausaufgabenRemove(Hausaufgabe item)
        {
            this.hausaufgaben.Remove(item);
        }
        public void einkaufslisteAdd(DateTime datum, string titel)
        {
            this.einkaufzettel.Add(new Einkaufszettel(datum, titel));
        }
        public void einkaufslisteRemove(Einkaufszettel item)
        {
            this.einkaufzettel.Remove(item);
        }
        public void updateListings() //Aktualisiert die Bindings Manuell
        {
            this.einfacheNotizen.ResetBindings();
            this.hausaufgaben.ResetBindings();
            this.einkaufzettel.ResetBindings();
        }
        public void sortAllTitle()
        {
            this.einfacheNotizen = new BindingList<EinfacheNotiz>(this.einfacheNotizen.OrderBy(p => p.titel).ToList());
            this.hausaufgaben = new BindingList<Hausaufgabe>(this.hausaufgaben.OrderBy(p => p.titel).ToList());
            this.einkaufzettel = new BindingList<Einkaufszettel>(this.einkaufzettel.OrderBy(p => p.titel).ToList());
            this.searchResults = new BindingList<EinfacheNotiz>(this.searchResults.OrderBy(p => p.titel).ToList());
            updateListings();
        }
        public void sortAllDate()
        {
            this.einfacheNotizen = new BindingList<EinfacheNotiz>(this.einfacheNotizen.OrderBy(p => p.datum).ToList());
            this.hausaufgaben = new BindingList<Hausaufgabe>(this.hausaufgaben.OrderBy(p => p.datum).ToList());
            this.einkaufzettel = new BindingList<Einkaufszettel>(this.einkaufzettel.OrderBy(p => p.datum).ToList());
            this.searchResults = new BindingList<EinfacheNotiz>(this.searchResults.OrderBy(p => p.datum).ToList());
            updateListings();
        }
        public void sortAllSubject()
        {
            this.hausaufgaben = new BindingList<Hausaufgabe>(this.hausaufgaben.OrderBy(p => p.fach).ToList());
            updateListings();
        }
        public void sortAllPrio()
        {
            this.einfacheNotizen = new BindingList<EinfacheNotiz>(this.einfacheNotizen.OrderByDescending(p => p.prio).ToList());
            this.hausaufgaben = new BindingList<Hausaufgabe>(this.hausaufgaben.OrderBy(p => p.datum).ToList());
            this.searchResults = new BindingList<EinfacheNotiz>(this.searchResults.OrderByDescending(p => p.prio).ToList());
        }
    }
}
