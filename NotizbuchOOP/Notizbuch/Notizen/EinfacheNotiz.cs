using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    public class EinfacheNotiz
    {
        public DateTime datum { get; set; }
        public string titel { get; set; }
        public string[] inhalt { get; set; }
        public int prio { get; set; }
        public EinfacheNotiz(DateTime date, string title)
        {
            this.datum = date;
            this.titel = title;
        }
    }
}
