using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizbuchOOP.Notizbuch.Notizen
{
    public class EinfacheNotiz
    {
        public DateTime Datum { get; set; }
        public string Titel { get; set; }
        public EinfacheNotiz(DateTime date, string title)
        {
            this.Datum = date;
            this.Titel = title;
        }
    }
}
