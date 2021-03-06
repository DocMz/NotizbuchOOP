﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    class Hausaufgabe
    {
        public DateTime datum { get ; set ;}
        public string titel { get; set; }
        public string fach { get; set; }
        public string[] inhalt { get; set; }
        public Hausaufgabe(DateTime datum, string titel, string fach = "-", string[] inhalt = null)
        {
            this.datum = datum;
            this.titel = titel;
            this.fach = fach;
            if(inhalt != null)
            {
                this.inhalt = inhalt;
            }
        }
    }
}
