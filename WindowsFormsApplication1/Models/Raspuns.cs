using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Raspuns
    {
        public int RaspunsId { get; set; }

        public int RezultatId { get; set; }   //FK
        public virtual Rezultat Rezultat { get; set; } // un rezultat are o lista de raspunsuri

        public int NumarIntrebare { get; set; }

        public String RaspunsCorect { get; set; }
        public String RaspunsDat { get; set; }



    }
}
