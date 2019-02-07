using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{

    /// <summary>
    /// Einkaufszettel Objekt
    /// </summary>
    class Einkaufszettel
    {
        public DateTime datum { get; set; }
        public string titel { get; set; }
        public BindingList<Position> positions { get; set; }
        public Einkaufszettel(DateTime datum, string titel, BindingList<Position> positions = null)
        {
            this.datum = datum;
            this.titel = titel;
            if(positions != null)
            {
                this.positions = new BindingList<Position>(positions);
            } else
            {
                this.positions = new BindingList<Position>();
            }
        }
        /// <summary>
        /// Funktion um eine Position der Einkaufsliste hinzuzufügen
        /// </summary>
        /// <param name="position"></param>
        public void positionAdd(Position position)
        {
            positions.Add(position);
        }

        /// <summary>
        /// Funktion um eine Position aus der Einkaufsliste zu löschen.
        /// </summary>
        /// <param name="item"></param>
        public void positionRemove(Position item)
        {
            positions.Remove(item);
        }
    }
}
