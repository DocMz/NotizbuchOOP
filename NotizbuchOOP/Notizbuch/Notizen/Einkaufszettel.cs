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
        public void positionAdd(Position position)
        {
            positions.Add(position);
        }
        public void positionRemove(Position item)
        {
            positions.Remove(item);
        }
    }
}
