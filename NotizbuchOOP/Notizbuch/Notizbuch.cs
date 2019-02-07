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
        public DateTime datum { get; set;} //Datum des Notizbuches
        public BindingList<Einkaufszettel> einkaufzettel { get; set; } //Liste der Beinhalteten Einkaufszettel
        public BindingList<EinfacheNotiz> einfacheNotizen { get; set; } //Liste der Einfachen Notizen
        public BindingList<Hausaufgabe> hausaufgaben { get; set; } //Liste der Hausaufgaben
        public BindingList<EinfacheNotiz> searchResults { get; set; } //Liste der Suchergebnisse
        public string name { get; set; } //Notizbuchname

        /// <summary>
        /// Konstruktor erstellt die einzelnen Listen bei erstellen eines Notizbuches.
        /// </summary>
        /// <param name="datum"></param>
        /// <param name="name"></param>
        public Notizbuch(DateTime datum, string name)
        {
            this.datum = datum;
            this.name = name;

            this.einfacheNotizen = new BindingList<EinfacheNotiz>();
            this.einkaufzettel = new BindingList<Einkaufszettel>();
            this.hausaufgaben = new BindingList<Hausaufgabe>();
            this.searchResults = new BindingList<EinfacheNotiz>();
        }
        /// <summary>
        /// Fügt der EinfachenNotizliste eine neue Notiz hinzu.
        /// </summary>
        /// <param name="title">Der Funktion wird nur der Titel übergeben</param>
        public void einfacheNotizAdd(string title) //Fügt eine einfache Notiz hinzu
        {
            this.einfacheNotizen.Add(new EinfacheNotiz(DateTime.Now, title));
        }

        /// <summary>
        /// Löscht eine EinfacheNotiz aus der Liste.
        /// </summary>
        /// <param name="item">Übergibt das zu löschende Item an die Funktion.</param>
        public void einfacheNotizRemove(EinfacheNotiz item) //Löscht Notiz aus der List an dem bestimmten Index
        {
            this.einfacheNotizen.Remove(item);
            this.searchResults.Remove(item);
        }

        /// <summary>
        /// Filtert die liste und gibt die Wert in eine neue Liste aus.
        /// </summary>
        /// <param name="prio"></param>
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
        /// <summary>
        /// Hausaufgabe hinzufügen
        /// </summary>
        /// <param name="titel"></param>
        /// <param name="ablauf"></param>
        public void hausaufgabeAdd(string titel, DateTime ablauf)
        {
            this.hausaufgaben.Add(new Hausaufgabe(ablauf, titel));
        }

        /// <summary>
        /// Hausaufgabe entfernen.
        /// </summary>
        /// <param name="item"></param>
        public void hausaufgabenRemove(Hausaufgabe item)
        {
            this.hausaufgaben.Remove(item);
        }

        /// <summary>
        /// Einkaufsliste hinzufügen.
        /// </summary>
        /// <param name="datum"></param>
        /// <param name="titel"></param>
        public void einkaufslisteAdd(DateTime datum, string titel)
        {
            this.einkaufzettel.Add(new Einkaufszettel(datum, titel));
        }

        /// <summary>
        /// Einkaufsliste entfernen.
        /// </summary>
        /// <param name="item"></param>
        public void einkaufslisteRemove(Einkaufszettel item)
        {
            this.einkaufzettel.Remove(item);
        }

        /// <summary>
        /// Bindings Aktualisieren.
        /// </summary>
        public void updateListings() //Aktualisiert die Bindings Manuell
        {
            this.einfacheNotizen.ResetBindings();
            this.hausaufgaben.ResetBindings();
            this.einkaufzettel.ResetBindings();
        }

        /// <summary>
        /// Alle Liste des Notizbuches nach Titel sortieren
        /// </summary>
        public void sortAllTitle()
        {
            this.einfacheNotizen = new BindingList<EinfacheNotiz>(this.einfacheNotizen.OrderBy(p => p.titel).ToList());
            this.hausaufgaben = new BindingList<Hausaufgabe>(this.hausaufgaben.OrderBy(p => p.titel).ToList());
            this.einkaufzettel = new BindingList<Einkaufszettel>(this.einkaufzettel.OrderBy(p => p.titel).ToList());
            this.searchResults = new BindingList<EinfacheNotiz>(this.searchResults.OrderBy(p => p.titel).ToList());
            updateListings();
        }

        /// <summary>
        /// Alle Listen des Notizbuches nach Datum sortieren
        /// </summary>
        public void sortAllDate()
        {
            this.einfacheNotizen = new BindingList<EinfacheNotiz>(this.einfacheNotizen.OrderBy(p => p.datum).ToList());
            this.hausaufgaben = new BindingList<Hausaufgabe>(this.hausaufgaben.OrderBy(p => p.datum).ToList());
            this.einkaufzettel = new BindingList<Einkaufszettel>(this.einkaufzettel.OrderBy(p => p.datum).ToList());
            this.searchResults = new BindingList<EinfacheNotiz>(this.searchResults.OrderBy(p => p.datum).ToList());
            updateListings();
        }

        /// <summary>
        /// Alle Listen nach Fach sortieren
        /// </summary>
        public void sortAllSubject()
        {
            this.hausaufgaben = new BindingList<Hausaufgabe>(this.hausaufgaben.OrderBy(p => p.fach).ToList());
            updateListings();
        }

        /// <summary>
        /// Alle Listen nach Prio sortieren.
        /// </summary>
        public void sortAllPrio()
        {
            this.einfacheNotizen = new BindingList<EinfacheNotiz>(this.einfacheNotizen.OrderByDescending(p => p.prio).ToList());
            this.hausaufgaben = new BindingList<Hausaufgabe>(this.hausaufgaben.OrderBy(p => p.datum).ToList());
            this.searchResults = new BindingList<EinfacheNotiz>(this.searchResults.OrderByDescending(p => p.prio).ToList());
        }
    }
}
